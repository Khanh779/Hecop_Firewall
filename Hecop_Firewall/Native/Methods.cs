using System;
using System.Runtime.InteropServices;

namespace Hecop_Firewall.Native
{
    public static class Methods
    {
        [DllImport("FWPUCLNT.DLL")]
        public static extern void FwpmFreeMemory0(
            ref IntPtr p);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmEngineOpen0(
            [MarshalAs(UnmanagedType.LPWStr)] string serverName,
            uint authnService,
            IntPtr authIdentity,
            ref FWPM_SESSION0 session,
            out IntPtr engineHandle);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmEngineClose0(
            IntPtr engineHandle);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmProviderAdd0(
            IntPtr engineHandle,
            ref FWPM_PROVIDER0 provider,
            IntPtr sd);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmProviderGetByKey0(
            IntPtr engineHandle,
            ref Guid key,
            out IntPtr provider);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmProviderDeleteByKey0(
            IntPtr engineHandle,
            ref Guid key);

        [DllImport("FWPUCLNT.DLL")]
        internal static extern uint FwpmFilterAdd0(
            IntPtr engineHandle,
            ref FWPM_FILTER0 filter,
            IntPtr sd,
            out ulong id);

        [DllImport("FWPUCLNT.DLL")]
        internal static extern uint FwpmFilterDeleteByKey0(
            IntPtr engineHandle,
            ref Guid key);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmFilterCreateEnumHandle0(
            IntPtr engineHandle,
            IntPtr enumTemplate,
            out IntPtr enumHandle);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmFilterEnum0(
            IntPtr engineHandle,
            IntPtr enumHandle,
            uint numEntriesRequested,
            out IntPtr entries,
            out uint numEntriesReturned);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmFilterDestroyEnumHandle0(
            IntPtr engineHandle,
            IntPtr enumHandle);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmSubLayerAdd0(
            IntPtr engineHandle,
            ref FWPM_SUBLAYER0 subLayer,
            IntPtr sd);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmSubLayerDeleteByKey0(
            IntPtr engineHandle,
            ref Guid key);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmSubLayerCreateEnumHandle0(
            IntPtr engineHandle,
            IntPtr enumTemplate,
            out IntPtr enumHandle);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmSubLayerEnum0(
            IntPtr engineHandle,
            IntPtr enumHandle,
            uint numEntriesRequested,
            out IntPtr entries,
            out uint numEntriesReturned);


        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmSubLayerDestroyEnumHandle0(
            IntPtr engineHandle,
            IntPtr enumHandle);
        
        // Ex

        [DllImport("FWPUClnt.dll", EntryPoint = "FwpmFilterGetByKey0")]
        public static extern uint FwpmFilterGetByKey0(
            [In] IntPtr engineHandle,
            [In] ref Guid key,
            [Out] out IntPtr filter);

        [DllImport("FWPUClnt.dll", EntryPoint = "FwpmFilterGetById0")]
        public static extern uint FwpmFilterGetById0(
            [In] IntPtr engineHandle,
            [In] ulong id,
            [Out] out IntPtr filter);

        [DllImport("FWPUClnt.dll", EntryPoint = "FwpmEngineSetOption0")]
        public static extern uint FwpmEngineSetOption0(
              IntPtr engineHandle,
              FWPM_ENGINE_OPTION option,
              ref FWP_VALUE0 newValue);

        [DllImport("FWPUClnt.dll", EntryPoint = "FwpmEngineGetOption0")]
        public static extern uint FwpmEngineGetOption0(
               IntPtr engineHandle,
               FWPM_ENGINE_OPTION option,
               out IntPtr value);

        // Additional functions from FWPUCLNT.dll

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmCalloutAdd0(
            IntPtr engineHandle,
            ref FWPM_CALLOUT0 callout,
            IntPtr sd,
            out ulong id);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmCalloutDeleteById0(
            IntPtr engineHandle,
            ulong id);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmCalloutGetById0(
            IntPtr engineHandle,
            ulong id,
            out IntPtr callout);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmCalloutDeleteByKey0(
            IntPtr engineHandle,
            ref Guid key);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmCalloutGetByKey0(
            IntPtr engineHandle,
            ref Guid key,
            out IntPtr callout);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmCalloutCreateEnumHandle0(
            IntPtr engineHandle,
            IntPtr enumTemplate,
            out IntPtr enumHandle);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmCalloutEnum0(
            IntPtr engineHandle,
            IntPtr enumHandle,
            uint numEntriesRequested,
            out IntPtr entries,
            out uint numEntriesReturned);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmCalloutDestroyEnumHandle0(
            IntPtr engineHandle,
            IntPtr enumHandle);


        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmTransactionBegin0(
            IntPtr engineHandle,
            uint flags);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmTransactionCommit0(
            IntPtr engineHandle);

        [DllImport("FWPUCLNT.DLL")]
        public static extern uint FwpmTransactionAbort0(
            IntPtr engineHandle);

      
    }
}
