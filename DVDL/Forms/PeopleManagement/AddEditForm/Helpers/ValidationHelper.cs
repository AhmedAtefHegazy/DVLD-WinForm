using System;
using System.Linq;
using System.Windows.Forms;

namespace DVDL.Forms.PeopleManagement
{
    public partial class FrmAdd_EditPersonInfo : Form
    {
        private void RTBNameFirst_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNameFirst.Text))
            {
                EP.SetError((Control)sender, "you must add your first name");
                e.Cancel = true;
            }
            else if (RTBNameFirst.Text.Any(char.IsDigit) || RTBNameFirst.Text.Any(char.IsPunctuation))
            {
                EP.SetError((Control)sender, "First name cannot contain numbers");
                e.Cancel = true;
            }
            else
            {
                EP.SetError((Control)sender, "");
                e.Cancel = false;
            }
        }

        private void RTBNameSecond_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNameSecond.Text))
            {
                EP.SetError((Control)sender, "you must add your Second name");
                e.Cancel = true;
            }
            else if (RTBNameSecond.Text.Any(char.IsDigit) || RTBNameSecond.Text.Any(char.IsPunctuation))
            {
                EP.SetError((Control)sender, "Second name cannot contain numbers");
                e.Cancel = true;
            }
            else
            {
                EP.SetError((Control)sender, "");
                e.Cancel = false;
            }
        }

        private void RTBNameThird_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNameThird.Text))
            {
                EP.SetError((Control)sender, "you must add your Third name");
                e.Cancel = true;
            }
            else if (RTBNameThird.Text.Any(char.IsDigit) || RTBNameThird.Text.Any(char.IsPunctuation))
            {
                EP.SetError((Control)sender, "Third name cannot contain numbers");
                e.Cancel = true;
            }
            else
            {
                EP.SetError((Control)sender, "");
                e.Cancel = false;
            }
        }

        private void RTBNameLast_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNameLast.Text))
            {
                EP.SetError((Control)sender, "you must add your Last name");
                e.Cancel = true;
            }
            else if (RTBNameLast.Text.Any(char.IsDigit) || RTBNameLast.Text.Any(char.IsPunctuation))
            {
                EP.SetError((Control)sender, "Last name cannot contain numbers");
                e.Cancel = true;
            }
            else
            {
                EP.SetError((Control)sender, "");
                e.Cancel = false;
            }
        }

        private void CBCountry_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNameFirst.Text))
            {
                EP.SetError((Control)sender, "you must add your first name");
            }
            else
            {
                EP.SetError((Control)sender, "");
            }
        }

        private void DTPDateOfBirth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //this is the max age (18) years old (365.25(Days per year)×18(Years)×24(Hours per day))
            TimeSpan MinAge = new TimeSpan(157788, 0, 0);

            if (DateTime.Now - DTPDateOfBirth.Value <= MinAge)
            {
                EP.SetError((Control)sender, "The Age must be bigger than 18");
            }
            else
            {
                EP.SetError((Control)sender, "");
            }
        }

        private void RTBAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNameFirst.Text))
            {
                EP.SetError((Control)sender, "you must add your first name");
            }
            else
            {
                EP.SetError((Control)sender, "");
            }
        }

        private void RTBPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNameFirst.Text))
            {
                EP.SetError((Control)sender, "you must add your first name");
            }
            else
            {
                EP.SetError((Control)sender, "");
            }
        }

        private void RTBEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNameFirst.Text))
            {
                EP.SetError((Control)sender, "you must add your first name");
            }
            else
            {
                EP.SetError((Control)sender, "");
            }
        }

        private void RTBNationalNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNameFirst.Text))
            {
                EP.SetError((Control)sender, "you must add your first name");
            }
            else
            {
                EP.SetError((Control)sender, "");
            }
        }

    }
}
