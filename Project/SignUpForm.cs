using Project.Config;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class SignUpForm : Form
    {

        private DB db;

        public SignUpForm()
        {
            InitializeComponent();

            db = new DB();

            btnClose.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.BorderColor = Color.Green;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please enter your credentials.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!db.SearchUserInfo(txtUsername.Text, txtPassword.Text))
            {

                db.InsertUserInfo(txtUsername.Text, txtPassword.Text, txtEmail.Text);
                MessageBox.Show("You are signed up successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sign up failed : The user already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
