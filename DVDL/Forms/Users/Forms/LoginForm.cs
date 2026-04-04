using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DVDL.Forms.Users.Forms
{
    public partial class LoginForm : Form
    {
        private static string RegistryKeyPath = @"Hkey_Current_User\Software\DVDL";
        private static string UserNameValue = @"UserName";
        private static string PasswordValue = @"Password";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                string UserName = Registry.GetValue(RegistryKeyPath, UserNameValue, null) as string;
                string Password = Registry.GetValue(RegistryKeyPath, PasswordValue, null) as string;

                if (UserName != null)
                {
                    Console.WriteLine($"The value of UserName is: {UserName}");
                }

                else if (Password != null)
                {
                    Console.WriteLine($"The value of Password is: {Password}");
                }

                else
                {
                    Console.WriteLine($"Value {UserNameValue} or {PasswordValue} not found in the registry");
                }

                tbUserName.Text = UserName;
                tbPassword.Text = Password;
                CBRememberMe.Checked = true;
            }

            catch (Exception ex)
            {

                Console.WriteLine($"An error accourd: {ex.Message}");
            }
        }

        private void SaveLoginInfoInRegistry(string UserName, string Password, bool IsTheButtonChecked)
        {
            try
            {
                Registry.SetValue(RegistryKeyPath, "UserName", UserName);
                Console.WriteLine($"Value {UserName} Successfully written to the Registry.");
                Registry.SetValue(RegistryKeyPath, "Password", Password);
                Console.WriteLine($"Value {Password} Successfully written to the Registry.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error accourd: {ex.Message}");
            }
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

                SaveLoginInfoInRegistry(tbUserName.Text, tbPassword.Text, CBRememberMe.Checked);

                FrmMain MainForm = new FrmMain();
                MainForm.ShowDialog();
                this.Close();
            }
        }

    }
}
