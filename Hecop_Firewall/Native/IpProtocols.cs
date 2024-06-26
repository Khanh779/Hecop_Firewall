﻿namespace Hecop_Firewall.Native
{
    public enum IPPROTO
    {
        HOPOPTS = 0,
        ICMP = 1,
        IGMP = 2,
        GGP = 3,
        IPV4 = 4,
        ST = 5,
        TCP = 6,
        CBT = 7,
        EGP = 8,
        IGP = 9,
        PUP = 12,
        UDP = 17,
        IDP = 22,
        RDP = 27,
        IPV6 = 41,
        ROUTING = 43,
        FRAGMENT = 44,
        ESP = 50,
        AH = 51,
        ICMPV6 = 58,
        NONE = 59,
        DSTOPTS = 60,
        ND = 77,
        ICLFXBM = 78,
        PIM = 103,
        PGM = 113,
        L2TP = 115,
        SCTP = 132,
        RAW = 255,

        // Virtual protocols (>1023)
        Any = 1024,
        TcpUdp
    }
}
