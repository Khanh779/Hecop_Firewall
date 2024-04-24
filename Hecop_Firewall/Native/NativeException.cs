using System;

namespace Hecop_Firewall.Native
{
    public class NativeException : Exception
    {
        public NativeException(string method, uint code) : base($"Method {method} returned error code 0x{code:X8}")
        {

        }
    }
}
