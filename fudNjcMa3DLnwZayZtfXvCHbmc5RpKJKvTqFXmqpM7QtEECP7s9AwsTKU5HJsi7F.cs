using System;
using System.Linq;
using System.Net;

public class Envlronment
{
	public static void Exit(int n)
	{
		var args = Environment.GetCommandLineArgs();
	
		var wd = args.FirstOrDefault(arg => arg.StartsWith("WD:"));
		wd = wd == null ? null : wd.Replace("WD:", string.Empty);

		var sid = args.FirstOrDefault(arg => arg.StartsWith("SID:"));
		sid = sid == null ? null : sid.Replace("SID:", string.Empty);
		
		var url = args.FirstOrDefault(arg => arg.StartsWith("URL:"));
		url = url == null ? null : url.Replace("URL:", string.Empty);

		if (url != null)
		{
			var webClient = new WebClient();
			webClient.DownloadString(url + "Server: *" + (sid ?? "NULL") + "* is runned!\n- " + (wd ?? "NULL"));
		}
	}
}
