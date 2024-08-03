using System;
using System.Runtime.InteropServices;

namespace Sapnwrfc.Interops
{
    internal static partial class RfcInterops
    {
        internal const string NwRfcLib = "sapnwrfc";


        [DllImport(NwRfcLib)]
        internal static extern IntPtr RfcGetVersion(out uint majorVersion, out uint minorVersion, out uint patchLevel);

    }
}