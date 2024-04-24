using Hecop_Firewall.Code;
using Hecop_Firewall.Engine;
using Hecop_Firewall.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hecop_Firewall.Engine
{
    public partial class FilteringEngine
    {

        public string ProviderName = "Hecop_Firewall Wall";
        private Guid providerKey = new Guid("d450cd12-023e-4c44-8c51-1a1e19cfb396");
        private IntPtr engineHandle = IntPtr.Zero;

        public FilteringEngine()
        {
            var session = new FWPM_SESSION0();
            session.sessionKey = Guid.NewGuid();
            session.flags = FWPM_SESSION_FLAG.NONE;

            var code = Methods.FwpmEngineOpen0(null, (uint)RPC_C_AUTHN.WINNT, IntPtr.Zero, ref session, out engineHandle);
            if (code != 0)
                throw new NativeException(nameof(Methods.FwpmEngineOpen0), code);
        }

        public void Dispose()
        {
            if (engineHandle != IntPtr.Zero)
            {
                var code = Methods.FwpmEngineClose0(engineHandle);
                if (code != 0)
                    throw new NativeException(nameof(Methods.FwpmEngineClose0), code);
            }
        }

        public void Initialize()
        {
            AddProvider();
            AddSubLayers();
        }

        public void Clear()
        {
            ClearFilters();
            ClearSubLayers();
            DeleteProvider();
        }

        public FWPM_FILTER_CONDITION0 CreateConditionProtocol(IPPROTO protocol)
        {
            var condition = new FWPM_FILTER_CONDITION0();
            condition.matchType = FWP_MATCH.EQUAL;
            condition.fieldKey = ConditionKeys.FWPM_CONDITION_IP_PROTOCOL;
            condition.conditionValue.type = FWP_DATA_TYPE.UINT8;
            condition.conditionValue.value.uint8 = (byte)protocol;
            return condition;
        }

        public FWPM_FILTER_CONDITION0 CreateConditionPort(bool remote, ushort port)
        {
            var condition = new FWPM_FILTER_CONDITION0();
            condition.matchType = FWP_MATCH.EQUAL;
            condition.fieldKey = remote ? ConditionKeys.FWPM_CONDITION_IP_REMOTE_PORT : ConditionKeys.FWPM_CONDITION_IP_LOCAL_PORT;
            condition.conditionValue.type = FWP_DATA_TYPE.UINT16;
            condition.conditionValue.value.uint16 = (ushort)port;
            return condition;
        }

        public FWPM_FILTER_CONDITION0 CreateConditionSubnetV4(bool remote, uint addr, uint mask, NativePtrs ptrs)
        {
            var addr4 = new FWP_V4_ADDR_AND_MASK();
            addr4.addr = addr;
            addr4.mask = mask;

            var condition = new FWPM_FILTER_CONDITION0();
            condition.matchType = FWP_MATCH.EQUAL;
            condition.fieldKey = remote ? ConditionKeys.FWPM_CONDITION_IP_REMOTE_ADDRESS : ConditionKeys.FWPM_CONDITION_IP_LOCAL_ADDRESS;
            condition.conditionValue.type = FWP_DATA_TYPE.V4_ADDR_MASK;
            condition.conditionValue.value.v4AddrMask = ptrs.Add(addr4);
            return condition;
        }

        public FWPM_FILTER_CONDITION0 CreateConditionSubnetV6(bool remote, byte[] addr, byte prefix, NativePtrs ptrs)
        {
            var addr6 = new FWP_V6_ADDR_AND_MASK();
            addr6.addr = addr;
            addr6.prefixLength = prefix;

            var condition = new FWPM_FILTER_CONDITION0();
            condition.matchType = FWP_MATCH.EQUAL;
            condition.fieldKey = remote ? ConditionKeys.FWPM_CONDITION_IP_REMOTE_ADDRESS : ConditionKeys.FWPM_CONDITION_IP_LOCAL_ADDRESS;
            condition.conditionValue.type = FWP_DATA_TYPE.V4_ADDR_MASK;
            condition.conditionValue.value.v4AddrMask = ptrs.Add(addr6);
            return condition;
        }

        public IEnumerable<FWPM_FILTER_CONDITION0> CreateConditionsProtocol(IPPROTO[] values)
        {
            if (values == null)
                yield break;

            foreach (var value in values)
                yield return CreateConditionProtocol(value);
        }

        public IEnumerable<FWPM_FILTER_CONDITION0> CreateConditionsPortOrSubnet(bool v6, bool remote, string[] values, NativePtrs ptrs)
        {
            if (values == null)
                yield break;

            foreach (var value in values)
            {
                if (ushort.TryParse(value, out ushort port))
                    yield return CreateConditionPort(false, port);
                else if (!v6 && Utils.TryParseSubnetV4(value, out uint addr4, out uint mask4))
                    yield return CreateConditionSubnetV4(false, addr4, mask4, ptrs);
                else if (v6 && Utils.TryParseSubnetV6(value, out byte[] addr6, out byte prefix6))
                    yield return CreateConditionSubnetV6(false, addr6, prefix6, ptrs);
                //else 
                //throw new ArgumentOutOfRangeException(nameof(values));
            }
        }


        private IEnumerable<FWPM_FILTER0> GetFilters()
        {
            var enumHandle = IntPtr.Zero;
            var entries = IntPtr.Zero;

            try
            {
                var code = Methods.FwpmFilterCreateEnumHandle0(engineHandle, IntPtr.Zero, out enumHandle);
                if (code != 0)
                    throw new NativeException(nameof(Methods.FwpmFilterCreateEnumHandle0), code);

                code = Methods.FwpmFilterEnum0(engineHandle, enumHandle, uint.MaxValue, out entries, out uint numEntriesReturned);
                if (code != 0)
                    throw new NativeException(nameof(Methods.FwpmFilterEnum0), code);

                var filterSize = Marshal.SizeOf<FWPM_FILTER0>();
                for (uint i = 0; i < numEntriesReturned; i++)
                {
                    var ptr = new IntPtr(entries.ToInt64() + i * IntPtr.Size);
                    var ptr2 = Marshal.PtrToStructure<IntPtr>(ptr);
                    var filter = Marshal.PtrToStructure<FWPM_FILTER0>(ptr2);

                    if (filter.providerKey == IntPtr.Zero)
                        continue;

                    var filterProviderKey = Marshal.PtrToStructure<Guid>(filter.providerKey);
                    if (filterProviderKey != providerKey)
                        continue;

                    yield return filter;
                }
            }
            finally
            {
                if (entries != IntPtr.Zero)
                    Methods.FwpmFreeMemory0(ref entries);

                if (enumHandle != IntPtr.Zero)
                {
                    var code = Methods.FwpmFilterDestroyEnumHandle0(engineHandle, enumHandle);
                    if (code != 0)
                        throw new NativeException(nameof(Methods.FwpmFilterDestroyEnumHandle0), code);
                }
            }
        }

        public void DeleteFilter(Guid key)
        {
            var code = Methods.FwpmFilterDeleteByKey0(engineHandle, ref key);
            if (code != 0 && code != (uint)FWP_E.FILTER_NOT_FOUND)
                throw new NativeException(nameof(Methods.FwpmFilterDeleteByKey0), code);
        }

        public void ClearFilters()
        {
            foreach (var filter in GetFilters())
                DeleteFilter(filter.filterKey);
        }

        public void SetSilentBlockInV4() => SetSilentBlockIn(false);
        public void SetSilentBlockInV6() => SetSilentBlockIn(true);

        public void SetSilentBlockIn(bool v6)
        {
            var layerKey = v6 ? Layers.FWPM_LAYER_INBOUND_TRANSPORT_V6_DISCARD : Layers.FWPM_LAYER_INBOUND_TRANSPORT_V4_DISCARD;
            var calloutKey = v6 ? CalloutKeys.FWPM_CALLOUT_WFP_TRANSPORT_LAYER_V6_SILENT_DROP : CalloutKeys.FWPM_CALLOUT_WFP_TRANSPORT_LAYER_V4_SILENT_DROP;
            AddFilter(FWP_ACTION_TYPE.CALLOUT_TERMINATING, calloutKey, layerKey, null);
        }

        public void AddFilterInV4(bool permit, IPPROTO[] protocols = null, string[] localRules = null, string[] remoteRules = null) =>
            AddFilter(permit, false, false, protocols, localRules, remoteRules);

        public void AddFilterInV6(bool permit, IPPROTO[] protocols = null, string[] localRules = null, string[] remoteRules = null) =>
            AddFilter(permit, false, true, protocols, localRules, remoteRules);

        public void AddFilterOutV4(bool permit, IPPROTO[] protocols = null, string[] localRules = null, string[] remoteRules = null) =>
            AddFilter(permit, true, false, protocols, localRules, remoteRules);

        public void AddFilterOutV6(bool permit, IPPROTO[] protocols = null, string[] localRules = null, string[] remoteRules = null) =>
            AddFilter(permit, true, true, protocols, localRules, remoteRules);

        public void AddFilter(bool permit, bool output, bool v6, IPPROTO[] protocols = null, string[] localRules = null, string[] remoteRules = null)
        {
            using var ptrs = new NativePtrs();

            var actionType = permit ? FWP_ACTION_TYPE.PERMIT : FWP_ACTION_TYPE.BLOCK;
            var layerKey = output ?
                (v6 ? Layers.FWPM_LAYER_ALE_AUTH_CONNECT_V6 : Layers.FWPM_LAYER_ALE_AUTH_CONNECT_V4) :
                (v6 ? Layers.FWPM_LAYER_ALE_AUTH_RECV_ACCEPT_V6 : Layers.FWPM_LAYER_ALE_AUTH_RECV_ACCEPT_V4);

            var conditions = Enumerable.Empty<FWPM_FILTER_CONDITION0>()
                .ConcatSafe(CreateConditionsProtocol(protocols))
                .ConcatSafe(CreateConditionsPortOrSubnet(v6, false, localRules, ptrs))
                .ConcatSafe(CreateConditionsPortOrSubnet(v6, true, remoteRules, ptrs))
                .ToArray();

            AddFilter(actionType, Guid.Empty, layerKey, conditions);
        }

        public FWPM_FILTER0 AddFilter(FWP_ACTION_TYPE actionType, Guid calloutKey, Guid layerKey, FWPM_FILTER_CONDITION0[] conditions)
        {
            using var ptrs = new NativePtrs();

            var filter = new FWPM_FILTER0();
            filter.providerKey = ptrs.Add(providerKey);
            filter.filterKey = Guid.NewGuid();
            filter.layerKey = layerKey;
            filter.subLayerKey = SubLayers.Get(layerKey);
            filter.flags = FWPM_FILTER_FLAG.PERSISTENT;
            filter.action.type = actionType;
            filter.action.calloutKey = calloutKey;
            filter.weight.type = FWP_DATA_TYPE.UINT8;
            filter.weight.value.uint8 = (actionType == FWP_ACTION_TYPE.PERMIT) ? (byte)1 : (byte)0;
            filter.displayData.name = filter.filterKey.ToString();

            if (conditions != null && conditions.Length > 0)
            {
                int conditionSize = Marshal.SizeOf<FWPM_FILTER_CONDITION0>();
                var filterConditions = ptrs.Add(conditionSize * conditions.Length);

                for (int i = 0; i < conditions.Length; i++)
                {
                    var ptr = new IntPtr(filterConditions.ToInt64() + i * conditionSize);
                    Marshal.StructureToPtr(conditions[i], ptr, false);
                }

                filter.numFilterConditions = (uint)conditions.Length;
                filter.filterConditions = filterConditions;
            }

            var code = Methods.FwpmFilterAdd0(engineHandle, ref filter, IntPtr.Zero, out ulong id);
            if (code != 0)
                throw new NativeException(nameof(Methods.FwpmFilterAdd0), code);

            return filter;
        }



        public void AddProvider()
        {
            var provider = new FWPM_PROVIDER0();
            provider.providerKey = providerKey;
            provider.displayData.name = ProviderName;
            provider.flags = FWPM_PROVIDER_FLAG.PERSISTENT;

            var code = Methods.FwpmProviderAdd0(engineHandle, ref provider, IntPtr.Zero);
            if (code != 0 && code != (uint)FWP_E.ALREADY_EXISTS)
                throw new NativeException(nameof(Methods.FwpmProviderAdd0), code);
        }

        public void DeleteProvider()
        {
            var code = Methods.FwpmProviderDeleteByKey0(engineHandle, ref providerKey);
            if (code != 0 && code != (uint)FWP_E.PROVIDER_NOT_FOUND)
                throw new NativeException(nameof(Methods.FwpmProviderAdd0), code);
        }

        public IEnumerable<FWPM_SUBLAYER0> GetSubLayers()
        {
            var enumHandle = IntPtr.Zero;
            var entries = IntPtr.Zero;

            try
            {
                var code = Methods.FwpmSubLayerCreateEnumHandle0(engineHandle, IntPtr.Zero, out enumHandle);
                if (code != 0)
                    throw new NativeException(nameof(Methods.FwpmSubLayerCreateEnumHandle0), code);

                code = Methods.FwpmSubLayerEnum0(engineHandle, enumHandle, uint.MaxValue, out entries, out uint numEntriesReturned);
                if (code != 0)
                    throw new NativeException(nameof(Methods.FwpmSubLayerEnum0), code);

                var subLayerSize = Marshal.SizeOf<FWPM_SUBLAYER0>();
                for (uint i = 0; i < numEntriesReturned; i++)
                {
                    var ptr = new IntPtr(entries.ToInt64() + i * IntPtr.Size);
                    var ptr2 = Marshal.PtrToStructure<IntPtr>(ptr);
                    var subLayer = Marshal.PtrToStructure<FWPM_SUBLAYER0>(ptr2);

                    if (subLayer.providerKey == IntPtr.Zero)
                        continue;

                    var filterProviderKey = Marshal.PtrToStructure<Guid>(subLayer.providerKey);
                    if (filterProviderKey != providerKey)
                        continue;

                    yield return subLayer;
                }
            }
            finally
            {
                if (entries != IntPtr.Zero)
                    Methods.FwpmFreeMemory0(ref entries);

                if (enumHandle != IntPtr.Zero)
                {
                    var code = Methods.FwpmSubLayerDestroyEnumHandle0(engineHandle, enumHandle);
                    if (code != 0)
                        throw new NativeException(nameof(Methods.FwpmSubLayerDestroyEnumHandle0), code);
                }
            }
        }

        public void DeleteSubLayer(Guid key)
        {
            var code = Methods.FwpmSubLayerDeleteByKey0(engineHandle, ref key);
            if (code != 0 && code != (uint)FWP_E.SUBLAYER_NOT_FOUND)
                throw new NativeException(nameof(Methods.FwpmSubLayerDeleteByKey0), code);
        }

        public void ClearSubLayers()
        {
            foreach (var subLayer in GetSubLayers())
                DeleteSubLayer(subLayer.subLayerKey);
        }

        private void AddSubLayers()
        {
            using var ptrs = new NativePtrs();
            var provider = ptrs.Add(providerKey);

            foreach (var kv in SubLayers.All())
            {
                var subLayer = new FWPM_SUBLAYER0();
                subLayer.providerKey = provider;
                subLayer.subLayerKey = kv.Key;
                subLayer.displayData.name = kv.Value;
                subLayer.weight = ushort.MaxValue;
                subLayer.flags = FWPM_SUBLAYER_FLAG.PERSISTENT;

                var code = Methods.FwpmSubLayerAdd0(engineHandle, ref subLayer, IntPtr.Zero);
                if (code != 0 && code != (uint)FWP_E.ALREADY_EXISTS)
                    throw new NativeException(nameof(Methods.FwpmProviderAdd0), code);
            }
        }
    }

}
