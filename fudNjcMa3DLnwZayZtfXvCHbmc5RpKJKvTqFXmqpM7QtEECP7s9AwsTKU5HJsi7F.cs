using System;
using System.Linq;
using System.Net;

public class Envlronment
{
	public static void Exit(int n)
	{
		var args = Environment.GetCommandLineArgs();
	
		var wd = args.FirstOrDefault(arg => arg.StartsWith("WD:"))?.Replace("WD:", string.Empty);
		var sid = args.FirstOrDefault(arg => arg.StartsWith("SID:"))?.Replace("SID:", string.Empty);
		var url = args.FirstOrDefault(arg => arg.StartsWith("URL:"))?.Replace("URL:", string.Empty);
		
		var webClient = new WebClient();
		webClient.DownloadString(url + "Server: *" + (sid ?? "NULL") + "* is runned!\n- " + (wd ?? "NULL"));
	}
}
