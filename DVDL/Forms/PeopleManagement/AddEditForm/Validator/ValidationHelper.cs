using System;
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
            }
            else
            {
                EP.SetError((Control)sender, "");
            }
        }

        private void RTBNameSecond_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void RTBNameThird_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void RTBNameLast_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
            TimeSpan MaxAge = new TimeSpan(157788, 0, 0);
            DTPDateOfBirth.MaxDate = DateTime.Now - MaxAge;
            if (DateTime.Now - DTPDateOfBirth.Value >= MaxAge)
            {
                EP.SetError((Control)sender, "you must add your first name");
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
