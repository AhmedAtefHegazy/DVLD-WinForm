using System;
using System.Windows.Forms;

namespace DVDL.Forms.Users.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CBShowPassword.Checked == true)
            {
                tbPassword.PasswordChar = '\0';
            }

            else
            {
                tbPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DVLD_BussinessLayer.Controllers.Users.IsUserCredintalsValid(tbUserName.Text, tbPassword.Text))
            {
                this.Visible = false;
                FrmMain MainForm = new FrmMain();
                MainForm.ShowDialog();
            }
        }
    }
}
