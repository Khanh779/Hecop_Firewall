﻿using System;

namespace Hecop_Firewall.Native
{
    public static class ConditionKeys
    {
        public static readonly Guid FWPM_CONDITION_INTERFACE_MAC_ADDRESS = new Guid("f6e63dce-1f4b-4c6b-b6ef-1165e71f8ee7");
        public static readonly Guid FWPM_CONDITION_MAC_LOCAL_ADDRESS = new Guid("d999e981-7948-4c83-b742-c84e3b678f8f");
        public static readonly Guid FWPM_CONDITION_MAC_REMOTE_ADDRESS = new Guid("408f2ed4-3a70-4b4d-92a6-415ac20e2f12");
        public static readonly Guid FWPM_CONDITION_ETHER_TYPE = new Guid("fd08948d-a219-4d52-bb98-1a5540ee7b4e");
        public static readonly Guid FWPM_CONDITION_VLAN_ID = new Guid("938eab21-3618-4e64-9ca5-2141ebda1ca2");
        public static readonly Guid FWPM_CONDITION_VSWITCH_TENANT_NETWORK_ID = new Guid("dc04843c-79e6-4e44-a025-65b9bb0f9f94");
        public static readonly Guid FWPM_CONDITION_NDIS_PORT = new Guid("db7bb42b-2dac-4cd4-a59a-e0bdce1e6834");
        public static readonly Guid FWPM_CONDITION_NDIS_MEDIA_TYPE = new Guid("cb31cef1-791d-473b-89d1-61c5984304a0");
        public static readonly Guid FWPM_CONDITION_NDIS_PHYSICAL_MEDIA_TYPE = new Guid("34c79823-c229-44f2-b83c-74020882ae77");
        public static readonly Guid FWPM_CONDITION_L2_FLAGS = new Guid("7bc43cbf-37ba-45f1-b74a-82ff518eeb10");
        public static readonly Guid FWPM_CONDITION_MAC_LOCAL_ADDRESS_TYPE = new Guid("cc31355c-3073-4ffb-a14f-79415cb1ead1");
        public static readonly Guid FWPM_CONDITION_MAC_REMOTE_ADDRESS_TYPE = new Guid("027fedb4-f1c1-4030-b564-ee777fd867ea");
        public static readonly Guid FWPM_CONDITION_ALE_PACKAGE_ID = new Guid("71bc78fa-f17c-4997-a602-6abb261f351c");
        public static readonly Guid FWPM_CONDITION_MAC_SOURCE_ADDRESS = new Guid("7b795451-f1f6-4d05-b7cb-21779d802336");
        public static readonly Guid FWPM_CONDITION_MAC_DESTINATION_ADDRESS = new Guid("04ea2a93-858c-4027-b613-b43180c7859e");
        public static readonly Guid FWPM_CONDITION_MAC_SOURCE_ADDRESS_TYPE = new Guid("5c1b72e4-299e-4437-a298-bc3f014b3dc2");
        public static readonly Guid FWPM_CONDITION_MAC_DESTINATION_ADDRESS_TYPE = new Guid("ae052932-ef42-4e99-b129-f3b3139e34f7");
        public static readonly Guid FWPM_CONDITION_IP_SOURCE_PORT = new Guid("a6afef91-3df4-4730-a214-f5426aebf821");
        public static readonly Guid FWPM_CONDITION_IP_DESTINATION_PORT = new Guid("ce6def45-60fb-4a7b-a304-af30a117000e");
        public static readonly Guid FWPM_CONDITION_VSWITCH_ID = new Guid("c4a414ba-437b-4de6-9946-d99c1b95b312");
        public static readonly Guid FWPM_CONDITION_VSWITCH_NETWORK_TYPE = new Guid("11d48b4b-e77a-40b4-9155-392c906c2608");
        public static readonly Guid FWPM_CONDITION_VSWITCH_SOURCE_INTERFACE_ID = new Guid("7f4ef24b-b2c1-4938-ba33-a1ecbed512ba");
        public static readonly Guid FWPM_CONDITION_VSWITCH_DESTINATION_INTERFACE_ID = new Guid("8ed48be4-c926-49f6-a4f6-ef3030e3fc16");
        public static readonly Guid FWPM_CONDITION_VSWITCH_SOURCE_VM_ID = new Guid("9c2a9ec2-9fc6-42bc-bdd8-406d4da0be64");
        public static readonly Guid FWPM_CONDITION_VSWITCH_DESTINATION_VM_ID = new Guid("6106aace-4de1-4c84-9671-3637f8bcf731");
        public static readonly Guid FWPM_CONDITION_VSWITCH_SOURCE_INTERFACE_TYPE = new Guid("e6b040a2-edaf-4c36-908b-f2f58ae43807");
        public static readonly Guid FWPM_CONDITION_VSWITCH_DESTINATION_INTERFACE_TYPE = new Guid("fa9b3f06-2f1a-4c57-9e68-a7098b28dbfe");
        public static readonly Guid FWPM_CONDITION_IP_LOCAL_ADDRESS = new Guid("d9ee00de-c1ef-4617-bfe3-ffd8f5a08957");
        public static readonly Guid FWPM_CONDITION_IP_REMOTE_ADDRESS = new Guid("b235ae9a-1d64-49b8-a44c-5ff3d9095045");
        public static readonly Guid FWPM_CONDITION_IP_SOURCE_ADDRESS = new Guid("ae96897e-2e94-4bc9-b313-b27ee80e574d");
        public static readonly Guid FWPM_CONDITION_IP_DESTINATION_ADDRESS = new Guid("2d79133b-b390-45c6-8699-acaceaafed33");
        public static readonly Guid FWPM_CONDITION_IP_LOCAL_ADDRESS_TYPE = new Guid("6ec7f6c4-376b-45d7-9e9c-d337cedcd237");
        public static readonly Guid FWPM_CONDITION_IP_DESTINATION_ADDRESS_TYPE = new Guid("1ec1b7c9-4eea-4f5e-b9ef-76beaaaf17ee");
        public static readonly Guid FWPM_CONDITION_IP_NEXTHOP_ADDRESS = new Guid("eabe448a-a711-4d64-85b7-3f76b65299c7");
        public static readonly Guid FWPM_CONDITION_IP_LOCAL_INTERFACE = new Guid("4cd62a49-59c3-4969-b7f3-bda5d32890a4");
        public static readonly Guid FWPM_CONDITION_IP_ARRIVAL_INTERFACE = new Guid("618a9b6d-386b-4136-ad6e-b51587cfb1cd");
        public static readonly Guid FWPM_CONDITION_ARRIVAL_INTERFACE_TYPE = new Guid("89f990de-e798-4e6d-ab76-7c9558292e6f");
        public static readonly Guid FWPM_CONDITION_ARRIVAL_TUNNEL_TYPE = new Guid("511166dc-7a8c-4aa7-b533-95ab59fb0340");
        public static readonly Guid FWPM_CONDITION_ARRIVAL_INTERFACE_INDEX = new Guid("cc088db3-1792-4a71-b0f9-037d21cd828b");
        public static readonly Guid FWPM_CONDITION_NEXTHOP_SUB_INTERFACE_INDEX = new Guid("ef8a6122-0577-45a7-9aaf-825fbeb4fb95");
        public static readonly Guid FWPM_CONDITION_IP_NEXTHOP_INTERFACE = new Guid("93ae8f5b-7f6f-4719-98c8-14e97429ef04");
        public static readonly Guid FWPM_CONDITION_NEXTHOP_INTERFACE_TYPE = new Guid("97537c6c-d9a3-4767-a381-e942675cd920");
        public static readonly Guid FWPM_CONDITION_NEXTHOP_TUNNEL_TYPE = new Guid("72b1a111-987b-4720-99dd-c7c576fa2d4c");
        public static readonly Guid FWPM_CONDITION_NEXTHOP_INTERFACE_INDEX = new Guid("138e6888-7ab8-4d65-9ee8-0591bcf6a494");
        public static readonly Guid FWPM_CONDITION_ORIGINAL_PROFILE_ID = new Guid("46ea1551-2255-492b-8019-aabeee349f40");
        public static readonly Guid FWPM_CONDITION_CURRENT_PROFILE_ID = new Guid("ab3033c9-c0e3-4759-937d-5758c65d4ae3");
        public static readonly Guid FWPM_CONDITION_LOCAL_INTERFACE_PROFILE_ID = new Guid("4ebf7562-9f18-4d06-9941-a7a625744d71");
        public static readonly Guid FWPM_CONDITION_ARRIVAL_INTERFACE_PROFILE_ID = new Guid("cdfe6aab-c083-4142-8679-c08f95329c61");
        public static readonly Guid FWPM_CONDITION_NEXTHOP_INTERFACE_PROFILE_ID = new Guid("d7ff9a56-cdaa-472b-84db-d23963c1d1bf");
        public static readonly Guid FWPM_CONDITION_REAUTHORIZE_REASON = new Guid("11205e8c-11ae-457a-8a44-477026dd764a");
        public static readonly Guid FWPM_CONDITION_ORIGINAL_ICMP_TYPE = new Guid("076dfdbe-c56c-4f72-ae8a-2cfe7e5c8286");
        public static readonly Guid FWPM_CONDITION_IP_PHYSICAL_ARRIVAL_INTERFACE = new Guid("da50d5c8-fa0d-4c89-b032-6e62136d1e96");
        public static readonly Guid FWPM_CONDITION_IP_PHYSICAL_NEXTHOP_INTERFACE = new Guid("f09bd5ce-5150-48be-b098-c25152fb1f92");
        public static readonly Guid FWPM_CONDITION_INTERFACE_QUARANTINE_EPOCH = new Guid("cce68d5e-053b-43a8-9a6f-33384c28e4f6");
        public static readonly Guid FWPM_CONDITION_INTERFACE_TYPE = new Guid("daf8cd14-e09e-4c93-a5ae-c5c13b73ffca");
        public static readonly Guid FWPM_CONDITION_TUNNEL_TYPE = new Guid("77a40437-8779-4868-a261-f5a902f1c0cd");
        public static readonly Guid FWPM_CONDITION_IP_FORWARD_INTERFACE = new Guid("1076b8a5-6323-4c5e-9810-e8d3fc9e6136");
        public static readonly Guid FWPM_CONDITION_IP_PROTOCOL = new Guid("3971ef2b-623e-4f9a-8cb1-6e79b806b9a7");
        public static readonly Guid FWPM_CONDITION_IP_LOCAL_PORT = new Guid("0c1ba1af-5765-453f-af22-a8f791ac775b");
        public static readonly Guid FWPM_CONDITION_ICMP_TYPE = new Guid("0c1ba1af-5765-453f-af22-a8f791ac775b");
        public static readonly Guid FWPM_CONDITION_IP_REMOTE_PORT = new Guid("c35a604d-d22b-4e1a-91b4-68f674ee674b");
        public static readonly Guid FWPM_CONDITION_ICMP_CODE = new Guid("c35a604d-d22b-4e1a-91b4-68f674ee674b");
        public static readonly Guid FWPM_CONDITION_EMBEDDED_LOCAL_ADDRESS_TYPE = new Guid("4672a468-8a0a-4202-abb4-849e92e66809");
        public static readonly Guid FWPM_CONDITION_EMBEDDED_REMOTE_ADDRESS = new Guid("77ee4b39-3273-4671-b63b-ab6feb66eeb6");
        public static readonly Guid FWPM_CONDITION_EMBEDDED_PROTOCOL = new Guid("07784107-a29e-4c7b-9ec7-29c44afafdbc");
        public static readonly Guid FWPM_CONDITION_EMBEDDED_LOCAL_PORT = new Guid("bfca394d-acdb-484e-b8e6-2aff79757345");
        public static readonly Guid FWPM_CONDITION_EMBEDDED_REMOTE_PORT = new Guid("cae4d6a1-2968-40ed-a4ce-547160dda88d");
        public static readonly Guid FWPM_CONDITION_FLAGS = new Guid("632ce23b-5167-435c-86d7-e903684aa80c");
        public static readonly Guid FWPM_CONDITION_DIRECTION = new Guid("8784c146-ca97-44d6-9fd1-19fb1840cbf7");
        public static readonly Guid FWPM_CONDITION_INTERFACE_INDEX = new Guid("667fd755-d695-434a-8af5-d3835a1259bc");
        public static readonly Guid FWPM_CONDITION_SUB_INTERFACE_INDEX = new Guid("0cd42473-d621-4be3-ae8c-72a348d283e1");
        public static readonly Guid FWPM_CONDITION_SOURCE_INTERFACE_INDEX = new Guid("2311334d-c92d-45bf-9496-edf447820e2d");
        public static readonly Guid FWPM_CONDITION_SOURCE_SUB_INTERFACE_INDEX = new Guid("055edd9d-acd2-4361-8dab-f9525d97662f");
        public static readonly Guid FWPM_CONDITION_DESTINATION_INTERFACE_INDEX = new Guid("35cf6522-4139-45ee-a0d5-67b80949d879");
        public static readonly Guid FWPM_CONDITION_DESTINATION_SUB_INTERFACE_INDEX = new Guid("2b7d4399-d4c7-4738-a2f5-e994b43da388");
        public static readonly Guid FWPM_CONDITION_ALE_APP_ID = new Guid("d78e1e87-8644-4ea5-9437-d809ecefc971");
        public static readonly Guid FWPM_CONDITION_ALE_ORIGINAL_APP_ID = new Guid("0e6cd086-e1fb-4212-842f-8a9f993fb3f6");
        public static readonly Guid FWPM_CONDITION_ALE_USER_ID = new Guid("af043a0a-b34d-4f86-979c-c90371af6e66");
        public static readonly Guid FWPM_CONDITION_ALE_REMOTE_USER_ID = new Guid("f63073b7-0189-4ab0-95a4-6123cbfab862");
        public static readonly Guid FWPM_CONDITION_ALE_REMOTE_MACHINE_ID = new Guid("1aa47f51-7f93-4508-a271-81abb00c9cab");
        public static readonly Guid FWPM_CONDITION_ALE_PROMISCUOUS_MODE = new Guid("1c974776-7182-46e9-afd3-b02910e30334");
        public static readonly Guid FWPM_CONDITION_ALE_SIO_FIREWALL_SYSTEM_PORT = new Guid("b9f4e088-cb98-4efb-a2c7-ad07332643db");
        public static readonly Guid FWPM_CONDITION_ALE_REAUTH_REASON = new Guid("b482d227-1979-4a98-8044-18bbe6237542");
        public static readonly Guid FWPM_CONDITION_ALE_NAP_CONTEXT = new Guid("46275a9d-c03f-4d77-b784-1c57f4d02753");
        public static readonly Guid FWPM_CONDITION_KM_AUTH_NAP_CONTEXT = new Guid("35d0ea0e-15ca-492b-900e-97fd46352cce");
        public static readonly Guid FWPM_CONDITION_REMOTE_USER_TOKEN = new Guid("9bf0ee66-06c9-41b9-84da-288cb43af51f");
        public static readonly Guid FWPM_CONDITION_RPC_IF_UUID = new Guid("7c9c7d9f-0075-4d35-a0d1-8311c4cf6af1");
        public static readonly Guid FWPM_CONDITION_RPC_IF_VERSION = new Guid("eabfd9b7-1262-4a2e-adaa-5f96f6fe326d");
        public static readonly Guid FWPM_CONDITION_RPC_IF_FLAG = new Guid("238a8a32-3199-467d-871c-272621ab3896");
        public static readonly Guid FWPM_CONDITION_DCOM_APP_ID = new Guid("ff2e7b4d-3112-4770-b636-4d24ae3a6af2");
        public static readonly Guid FWPM_CONDITION_IMAGE_NAME = new Guid("d024de4d-deaa-4317-9c85-e40ef6e140c3");
        public static readonly Guid FWPM_CONDITION_RPC_PROTOCOL = new Guid("2717bc74-3a35-4ce7-b7ef-c838fabdec45");
        public static readonly Guid FWPM_CONDITION_RPC_AUTH_TYPE = new Guid("daba74ab-0d67-43e7-986e-75b84f82f594");
        public static readonly Guid FWPM_CONDITION_RPC_AUTH_LEVEL = new Guid("e5a0aed5-59ac-46ea-be05-a5f05ecf446e");
        public static readonly Guid FWPM_CONDITION_SEC_ENCRYPT_ALGORITHM = new Guid("0d306ef0-e974-4f74-b5c7-591b0da7d562");
        public static readonly Guid FWPM_CONDITION_SEC_KEY_SIZE = new Guid("4772183b-ccf8-4aeb-bce1-c6c6161c8fe4");
        public static readonly Guid FWPM_CONDITION_IP_LOCAL_ADDRESS_V4 = new Guid("03a629cb-6e52-49f8-9c41-5709633c09cf");
        public static readonly Guid FWPM_CONDITION_IP_LOCAL_ADDRESS_V6 = new Guid("2381be84-7524-45b3-a05b-1e637d9c7a6a");
        public static readonly Guid FWPM_CONDITION_PIPE = new Guid("1bd0741d-e3df-4e24-8634-762046eef6eb");
        public static readonly Guid FWPM_CONDITION_IP_REMOTE_ADDRESS_V4 = new Guid("1febb610-3bcc-45e1-bc36-2e067e2cb186");
        public static readonly Guid FWPM_CONDITION_IP_REMOTE_ADDRESS_V6 = new Guid("246e1d8c-8bee-4018-9b98-31d4582f3361");
        public static readonly Guid FWPM_CONDITION_PROCESS_WITH_RPC_IF_UUID = new Guid("e31180a8-bbbd-4d14-a65e-7157b06233bb");
        public static readonly Guid FWPM_CONDITION_RPC_EP_VALUE = new Guid("dccea0b9-0886-4360-9c6a-ab043a24fba9");
        public static readonly Guid FWPM_CONDITION_RPC_EP_FLAGS = new Guid("218b814a-0a39-49b8-8e71-c20c39c7dd2e");
        public static readonly Guid FWPM_CONDITION_CLIENT_TOKEN = new Guid("c228fc1e-403a-4478-be05-c9baa4c05ace");
        public static readonly Guid FWPM_CONDITION_RPC_SERVER_NAME = new Guid("b605a225-c3b3-48c7-9833-7aefa9527546");
        public static readonly Guid FWPM_CONDITION_RPC_SERVER_PORT = new Guid("8090f645-9ad5-4e3b-9f9f-8023ca097909");
        public static readonly Guid FWPM_CONDITION_RPC_PROXY_AUTH_TYPE = new Guid("40953fe2-8565-4759-8488-1771b4b4b5db");
        public static readonly Guid FWPM_CONDITION_CLIENT_CERT_KEY_LENGTH = new Guid("a3ec00c7-05f4-4df7-91f2-5f60d91ff443");
        public static readonly Guid FWPM_CONDITION_CLIENT_CERT_OID = new Guid("c491ad5e-f882-4283-b916-436b103ff4ad");
        public static readonly Guid FWPM_CONDITION_NET_EVENT_TYPE = new Guid("206e9996-490e-40cf-b831-b38641eb6fcb");
        public static readonly Guid FWPM_CONDITION_PEER_NAME = new Guid("9b539082-eb90-4186-a6cc-de5b63235016");
        public static readonly Guid FWPM_CONDITION_REMOTE_ID = new Guid("f68166fd-0682-4c89-b8f5-86436c7ef9b7");
        public static readonly Guid FWPM_CONDITION_AUTHENTICATION_TYPE = new Guid("eb458cd5-da7b-4ef9-8d43-7b0a840332f2");
        public static readonly Guid FWPM_CONDITION_KM_TYPE = new Guid("ff0f5f49-0ceb-481b-8638-1479791f3f2c");
        public static readonly Guid FWPM_CONDITION_KM_MODE = new Guid("feef4582-ef8f-4f7b-858b-9077d122de47");
        public static readonly Guid FWPM_CONDITION_IPSEC_POLICY_KEY = new Guid("ad37dee3-722f-45cc-a4e3-068048124452");
        public static readonly Guid FWPM_CONDITION_QM_MODE = new Guid("f64fc6d1-f9cb-43d2-8a5f-e13bc894f265");
    }
}
