// See https://aka.ms/new-console-template for more information
using DotNetConnector.Interops;
using System.Data;
using System.Runtime.InteropServices;
using System;
 


class Options
{
    [Option('u', "username", Required = true, HelpText = "RFC User Name")]
    public string UserName { get; set; }

    [Option('p', "password", Required = true, HelpText = "RFC User Password")]
    public string Password { get; set; }

    [Option('h', "hostname", Required = true, HelpText = "RFC Server Hostname")]
    public string Hostname { get; set; }

    [Option('c', "client", Required = true, HelpText = "RFC Server Client Id")]
    public string Client { get; set; }

    [Option('t', "table", Required = true, HelpText = "Table")]
    public string GlAccount { get; set; }

}


class program
{
         

    public static void main(string args)
    {
        RfcInterops.RfcGetVersion(out var majorVersion, out var minorVersion, out var patchLevel);

        RfcInterops.RfcOpenConnection
        Console.WriteLine(majorVersion);
    }
}

