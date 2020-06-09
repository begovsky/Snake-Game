using Project.Config;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class LoginForm : Form
    {
        internal DB db;
        public LoginForm()
        {
            InitializeComponent();

            btnLogin.FlatAppearance.BorderColor = Color.Green;
            btnSignUp.FlatAppearance.BorderColor = Color.Green;
            btnClose.FlatAppearance.BorderSize = 0;
        }

        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();

        private void txtPassword_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        private void bntSignUp_Click(object sender, EventArgs e)
        {

            SignUpForm signupForm = new SignUpForm();
            signupForm.Show();

            txtUsername.Clear();
            txtPassword.Clear();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (db.SearchUserInfo(txtUsername.Text, txtPassword.Text))
            {
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is wrong.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            db = new DB();
        }

    }
}
