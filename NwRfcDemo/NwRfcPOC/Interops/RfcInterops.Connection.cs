using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetConnector.Interops
{
    internal static partial class RfcInterops
    {

        [DllImport(NwRfcLib)]
        public static extern IntPtr RfcOpenConnection(RFC_CONNECTION_PARAMETER[] connectionParams, uint paramCount, out RFC_ERROR_INFO errorInfo);


        [DllImport(NwRfcLib)]
        public static extern RFC_RC RfcCloseConnection(IntPtr rfcHandle, out RFC_ERROR_INFO errorInfo);

        [DllImport(NwRfcLib)]
        public static extern RFC_RC RfcInvoke(IntPtr rfcHandle, IntPtr funcHandle, out RFC_ERROR_INFO errorInfo);



        internal struct RFC_CONNECTION_PARAMETER
        {
            [MarshalAs(UnmanagedType.LPTStr)]
            public string Name;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string Value;
        }
    }
}
