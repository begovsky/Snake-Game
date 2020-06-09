using Project.User_Controls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WMPLib;


namespace Project
{
    public partial class MainScreen : Form
    {
        ucSettings ucSettings;
        ucRecord ucRecord;
        ucInsturctions ucInsturctions;

        public static SnakeGame snakeGame = new SnakeGame();

        public static WMPLib.WindowsMediaPlayer player { get; set; }

        public static int Level = 16;

        public MainScreen()
        {
            InitializeComponent();

            player = new WindowsMediaPlayer
            {
                URL = "song-2.mp3"
            };
            player.settings.volume = 70;
            player.settings.setMode("Loop", true);
            player.controls.play();

            this.Icon = new Icon("..\\..\\..\\Resources\\icon.ico");
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            pbSettings.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            pbMyRecord.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            pbInstructions.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            pbPlay.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            pbSound.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);

            panelUC.Hide();
            pbSound.Click += PbSound_Click;

        }

        private void PbSound_Click(object sender, EventArgs e)
        {
            if (player.settings.mute == false)
            {
                pbSound.Image = Image.FromFile("..\\..\\..\\Resources\\buttonSesKapali.png");
                player.settings.mute = true;
            }
            else
            {
                pbSound.Image = Image.FromFile("..\\..\\..\\Resources\\buttonSes.png");
                player.settings.mute = false;
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();

            ((PictureBox)sender).Visible = false;
            LoginForm loginForm = new LoginForm();
            this.Hide();

            loginForm.Show();
        }

        private void MainScreen_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls) // or whatever your container control is
            {
                if (item is PictureBox)
                {
                    PictureBox pb = (PictureBox)item;
                    if (pb.Bounds.Contains(PointToClient(MousePosition)))
                    {
                        pb.Visible = true;
                    }
                }
            }
        }

        private void pbSettings_Click(object sender, EventArgs e)
        {
            //panelProperties.Show();
            foreach (PictureBox item in this.Controls.OfType<PictureBox>())
            {
                if (item == pbForm)
                    continue;

                item.Hide();
            }

            if (ucSettings == null)
                ucSettings = new ucSettings();

            this.Controls.Add(ucSettings);
            ucSettings.SetBounds(204, -1, 595, 564);
            ucSettings.BringToFront();
            ucSettings.Show();



            ucSettings.pbBack.Click += pbBack_Click;
            ucSettings.radioButton1.CheckedChanged += RadioButton1_CheckedChanged;
            ucSettings.radioButton2.CheckedChanged += RadioButton2_CheckedChanged;
            ucSettings.radioButton3.CheckedChanged += RadioButton3_CheckedChanged;
            ucSettings.tbSound.ValueChanged += TbSound_ValueChanged;
            ucSettings.radioAppearance1.CheckedChanged += RadioArayuz1_CheckedChanged;
            ucSettings.radioAppearance2.CheckedChanged += RadioArayuz2_CheckedChanged;
            ucSettings.radioAppearance3.CheckedChanged += RadioArayuz3_CheckedChanged;

        }

        private void RadioArayuz3_CheckedChanged(object sender, EventArgs e) => snakeGame.pbCanvas.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\newBg1.png");

        private void RadioArayuz2_CheckedChanged(object sender, EventArgs e) => snakeGame.pbCanvas.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\board2.jpg");

        private void RadioArayuz1_CheckedChanged(object sender, EventArgs e) => snakeGame.pbCanvas.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\gameBg2.png");

        private void TbSound_ValueChanged(object sender, EventArgs e) => player.settings.volume = ucSettings.tbSound.Value;

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            player.URL = "song-3.mp3";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            player.URL = "song-1.mp3";
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            player.URL = "song-2.mp3";
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Show();
            ucSettings.Hide();

            foreach (PictureBox item in this.Controls.OfType<PictureBox>())
            {
                if (item == pbForm)
                    continue;

                item.Show();
            }
        }

        private void TbLevel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pbPlay_Click(object sender, EventArgs e)
        {
            Hide();
            snakeGame.Show(this);
            snakeGame.StartGame();

        }

        private void pbMyRecord_Click(object sender, EventArgs e)
        {
            foreach (PictureBox item in this.Controls.OfType<PictureBox>())
            {
                if (item == pbForm)
                    continue;

                item.Hide();
            }

            ucRecord = new ucRecord();

            this.Controls.Add(ucRecord);
            ucRecord.SetBounds(204, -1, 595, 564);

            ucRecord.BringToFront();
            ucRecord.btnResetScore.TabStop = false;
            ucRecord.btnResetScore.FlatAppearance.BorderSize = 0;

            ucRecord.Visible = true;
            ucRecord.lblReseted.Visible = false;

            ucRecord.pbBack.Click += pbBack_Click1;
        }

        private void pbBack_Click1(object sender, EventArgs e)
        {
            this.Show();
            ucRecord.Hide();

            foreach (PictureBox item in this.Controls.OfType<PictureBox>())
            {
                if (item == pbForm)
                    continue;

                item.Show();
            }
        }

        private void pbInstructions_Click(object sender, EventArgs e)
        {
            ucInsturctions = new ucInsturctions();

            this.Controls.Add(ucInsturctions);
            ucInsturctions.SetBounds(204, -1, 595, 564);
            ucInsturctions.BringToFront();
            ucInsturctions.pbBack.Click += pbBack_Click2;
        }

        private void pbBack_Click2(object sender, EventArgs e)
        {
            this.Show();
            ucInsturctions.Hide();

            foreach (PictureBox item in this.Controls.OfType<PictureBox>())
            {
                if (item == pbForm)
                    continue;

                item.Show();
            }
        }
    }
}
