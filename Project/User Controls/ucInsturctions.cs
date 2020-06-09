using System.Linq;
using System.Windows.Forms;

namespace Project.User_Controls
{
    public partial class ucInsturctions : UserControl
    {
        public ucInsturctions()
        {
            InitializeComponent();

            pbArrows.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            pbSpace.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);

            foreach (Label item in this.Controls.OfType<Label>())
            {
                item.BackColor = System.Drawing.Color.FromArgb(119, 184, 54);
            }
        }
    }
}
