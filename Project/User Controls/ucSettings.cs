using Project.ClassSnake;
using System;
using System.Windows.Forms;

namespace Project.User_Controls
{
    public partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            InitializeComponent();

            lblMusic.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            lblLevel.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            tbLevel.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            radioButton1.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            radioButton2.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            radioButton3.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            tbSound.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            panelInfo.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            groupBox.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            lblAppearance.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            groupBox.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            pbAnimation.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);

            lblInfo.Text = "This game is made by:\nBegovsky";
            lblSupport.Text = "Follow me on my github!";
            lblEmail.Text = "Github: https://github.com/begovsky";

        }

        private void pbFacebook_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://www.facebook.com/mustafa.rizabegovic");

        private void pbInstagram_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://www.instagram.com/begovsky/");

        private void pbTwitter_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://twitter.com/begovsky");

        private void tbLevel_ValueChanged(object sender, EventArgs e)
        {
            switch (tbLevel.Value)
            {

                case 0:
                    Settings.Speed = 12;
                    break;
                case 1:
                    Settings.Level = 1;
                    break;
                case 2:
                    Settings.Level = 2;
                    break;
                case 3:
                    Settings.Level = 3;
                    break;
                default:
                    break;
            }
        }
    }
}
