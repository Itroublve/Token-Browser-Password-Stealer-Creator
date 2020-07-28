namespace ItroublveTSC2
{
    public partial class frm2 : global::System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2));
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
            this.WinInfo = new System.Windows.Forms.NotifyIcon(this.components);
            this.SaveMsgboxChng = new RoundBtn();
            this.WebhookPnl = new System.Windows.Forms.Panel();
            this.MessageTitleTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MessageDescTxt = new System.Windows.Forms.TextBox();
            this.HeadLinePnlInf.SuspendLayout();
            this.WebhookPnl.SuspendLayout();
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
            this.HeadLinePnlInf.Size = new System.Drawing.Size(420, 29);
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
            this.CloseBtn.Location = new System.Drawing.Point(394, -1);
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
            this.HeadServerLbl.Location = new System.Drawing.Point(153, 5);
            this.HeadServerLbl.Name = "HeadServerLbl";
            this.HeadServerLbl.Size = new System.Drawing.Size(115, 21);
            this.HeadServerLbl.TabIndex = 6166;
            this.HeadServerLbl.Text = "MESSAGEBOX";
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
            this.panel37.Location = new System.Drawing.Point(-2231, 210);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(3614, 2);
            this.panel37.TabIndex = 6307;
            // 
            // SaveMsgboxChng
            // 
            this.SaveMsgboxChng.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.SaveMsgboxChng.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.SaveMsgboxChng.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.SaveMsgboxChng.FlatAppearance.BorderSize = 0;
            this.SaveMsgboxChng.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.SaveMsgboxChng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.SaveMsgboxChng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveMsgboxChng.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.SaveMsgboxChng.Location = new System.Drawing.Point(127, 154);
            this.SaveMsgboxChng.Name = "SaveMsgboxChng";
            this.SaveMsgboxChng.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.SaveMsgboxChng.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.SaveMsgboxChng.OnHoverTextColor = System.Drawing.Color.White;
            this.SaveMsgboxChng.Size = new System.Drawing.Size(158, 27);
            this.SaveMsgboxChng.TabIndex = 6340;
            this.SaveMsgboxChng.Text = "MESSAGEBOX";
            this.SaveMsgboxChng.TextColor = System.Drawing.Color.White;
            this.SaveMsgboxChng.UseVisualStyleBackColor = true;
            this.SaveMsgboxChng.Click += new System.EventHandler(this.roundBtn1_Click);
            // 
            // WebhookPnl
            // 
            this.WebhookPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.WebhookPnl.Controls.Add(this.MessageTitleTxt);
            this.WebhookPnl.Location = new System.Drawing.Point(12, 49);
            this.WebhookPnl.Name = "WebhookPnl";
            this.WebhookPnl.Size = new System.Drawing.Size(395, 33);
            this.WebhookPnl.TabIndex = 6341;
            // 
            // MessageTitleTxt
            // 
            this.MessageTitleTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.MessageTitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageTitleTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTitleTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.MessageTitleTxt.Location = new System.Drawing.Point(7, 7);
            this.MessageTitleTxt.Name = "MessageTitleTxt";
            this.MessageTitleTxt.Size = new System.Drawing.Size(379, 18);
            this.MessageTitleTxt.TabIndex = 6153;
            this.MessageTitleTxt.Text = "Title";
            this.MessageTitleTxt.Enter += new System.EventHandler(this.MessageTitleTxt_Enter);
            this.MessageTitleTxt.Leave += new System.EventHandler(this.MessageTitleTxt_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.MessageDescTxt);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 33);
            this.panel1.TabIndex = 6342;
            // 
            // MessageDescTxt
            // 
            this.MessageDescTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.MessageDescTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageDescTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageDescTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.MessageDescTxt.Location = new System.Drawing.Point(7, 7);
            this.MessageDescTxt.Name = "MessageDescTxt";
            this.MessageDescTxt.Size = new System.Drawing.Size(379, 18);
            this.MessageDescTxt.TabIndex = 6153;
            this.MessageDescTxt.Text = "Your Error";
            this.MessageDescTxt.Enter += new System.EventHandler(this.MessageDescTxt_Enter);
            this.MessageDescTxt.Leave += new System.EventHandler(this.MessageDescTxt_Leave);
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(420, 229);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WebhookPnl);
            this.Controls.Add(this.SaveMsgboxChng);
            this.Controls.Add(this.panel37);
            this.Controls.Add(this.HeadLinePnlInf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItroublveTSC";
            this.Load += new System.EventHandler(this.frm2_Load);
            this.HeadLinePnlInf.ResumeLayout(false);
            this.HeadLinePnlInf.PerformLayout();
            this.WebhookPnl.ResumeLayout(false);
            this.WebhookPnl.PerformLayout();
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

        private global::System.Windows.Forms.Panel panel37;

        private global::System.Windows.Forms.NotifyIcon WinInfo;
        private RoundBtn SaveMsgboxChng;
        private System.Windows.Forms.Panel WebhookPnl;
        private System.Windows.Forms.TextBox MessageTitleTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox MessageDescTxt;
    }
}