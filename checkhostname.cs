////
//
///

using System;
using System.Net.NetworkInformation;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Net;
using System.IO.Compression;

    public class Payload
    {
    	public static void Main() {
			
		
			string hostName = System.Net.Dns.GetHostEntry("").HostName;
			Console.WriteLine("your hostname: " + hostName);
			
			
			string domainName = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
			
			Console.WriteLine("domain name: " + domainName);
			
			
			if (domainName.Contains("")) {

			}
			else {
				
				System.Environment.Exit(0);
			}
    	}
    }
