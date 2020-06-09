using Project.Config;
using System;
using System.Media;
using System.Windows.Forms;

namespace Project.User_Controls
{
    public partial class ucRecord : UserControl
    {
        private SoundPlayer player = new SoundPlayer();
        DB db;
        public ucRecord()
        {
            InitializeComponent();

            db = new DB();

            lblRecord.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            label2.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            lblReseted.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            pbAnimation.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            lblRecord.Location.Offset(31, 36);

            lblRecord.Text = DB.currentUser.Record.ToString();

            if (DB.currentUser.Record == 0)
            {
                btnResetScore.Enabled = false;
            }
            else
            {
                player.SoundLocation = "record.wav";
                player.Play();
            }
            lblReseted.Visible = false;
        }

        private void btnResetScore_Click(object sender, EventArgs e)
        {
            db.UserRecordReset();
            lblRecord.Text = DB.currentUser.Record.ToString();
            lblReseted.Visible = true;
        }

        private void ucRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
