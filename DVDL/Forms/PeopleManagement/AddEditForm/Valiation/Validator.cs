using System;
using System.Linq;
using System.Windows.Forms;
using PeopleBusinessLayer;

//Add boolians here that show me that all fields filled in right way to use it in save button to avoid doing validation twice

namespace DVDL.Forms.PeopleManagement
{
    public partial class FrmAdd_EditPersonInfo : Form
    {
        private bool IsFirstNameValid = false;
        private bool IsSecondNameValid = false;
        private bool IsThirdNameValid = false;
        private bool IsLastNameValid = false;
        private bool IsDateOfBirthValid = false;
        private bool IsAddressValid = false;
        private bool IsPhoneValid = false;
        private bool IsEmailValid = true;
        private bool IsNationalNoValid = false;

        private bool IsAllFieldsFilled()
        {
            return IsFirstNameValid && IsSecondNameValid
                && IsThirdNameValid && IsLastNameValid
                && IsDateOfBirthValid && IsAddressValid
                && IsPhoneValid && IsEmailValid && IsNationalNoValid;
        }

        private void RTBNameFirst_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNameFirst.Text))
            {
                EP.SetError((Control)sender, "you must add your first name");
                IsFirstNameValid = false;
                e.Cancel = true;
            }
            else if (RTBNameFirst.Text.Any(char.IsDigit) || RTBNameFirst.Text.Any(char.IsPunctuation))
            {
                EP.SetError((Control)sender, "First name cannot contain numbers");
                IsFirstNameValid = false;
                e.Cancel = true;
            }
            else
            {
                EP.SetError((Control)sender, "");
                IsFirstNameValid = true;
                e.Cancel = false;
            }
        }

        private void RTBNameSecond_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNameSecond.Text))
            {
                EP.SetError((Control)sender, "you must add your Second name");
                IsSecondNameValid = false;
                e.Cancel = true;
            }
            else if (RTBNameSecond.Text.Any(char.IsDigit) || RTBNameSecond.Text.Any(char.IsPunctuation))
            {
                EP.SetError((Control)sender, "Second name cannot contain numbers");
                IsSecondNameValid = false;
                e.Cancel = true;
            }
            else
            {
                EP.SetError((Control)sender, "");
                IsSecondNameValid = true;
                e.Cancel = false;
            }
        }

        private void RTBNameThird_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNameThird.Text))
            {
                EP.SetError((Control)sender, "you must add your Third name");
                IsThirdNameValid = false;
                e.Cancel = true;
            }
            else if (RTBNameThird.Text.Any(char.IsDigit) || RTBNameThird.Text.Any(char.IsPunctuation))
            {
                EP.SetError((Control)sender, "Third name cannot contain numbers");
                IsThirdNameValid = false;
                e.Cancel = true;
            }
            else
            {
                EP.SetError((Control)sender, "");
                IsThirdNameValid = true;
                e.Cancel = false;
            }
        }

        private void RTBNameLast_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNameLast.Text))
            {
                EP.SetError((Control)sender, "you must add your Last name");
                IsLastNameValid = false;
                e.Cancel = true;
            }
            else if (RTBNameLast.Text.Any(char.IsDigit) || RTBNameLast.Text.Any(char.IsPunctuation))
            {
                EP.SetError((Control)sender, "Last name cannot contain numbers");
                IsLastNameValid = false;
                e.Cancel = true;
            }
            else
            {
                EP.SetError((Control)sender, "");
                IsLastNameValid = true;
                e.Cancel = false;
            }
        }

        private void DTPDateOfBirth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //this is the max age (18) years old (365.25(Days per year)×18(Years)×24(Hours per day))
            TimeSpan MinAge = new TimeSpan(157788, 0, 0);
            DateTime MaxDate = new DateTime(1900, 1, 1);

            if ((DateTime.Now - DTPDateOfBirth.Value <= MinAge || DTPDateOfBirth.Value <= MaxDate)
                && string.IsNullOrWhiteSpace(DTPDateOfBirth.Text))
            {
                EP.SetError((Control)sender, "The Age must be bigger than 18");
                IsDateOfBirthValid = false;
                e.Cancel = true;
            }
            else
            {
                EP.SetError((Control)sender, "");
                IsDateOfBirthValid = true;
                e.Cancel = false;
            }
        }

        private void RTBAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBAddress.Text))
            {
                EP.SetError((Control)sender, "You Must Add Address");
                IsAddressValid = false;
                e.Cancel = true;
            }
            else
            {
                EP.SetError((Control)sender, "");
                IsAddressValid = true;
                e.Cancel = false;
            }
        }

        private void RTBPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string phone = RTBPhone.Text.Trim();

            // Check if phone is empty or not digits or not 11 characters
            if (string.IsNullOrWhiteSpace(phone) || phone.Any(char.IsLetter) || phone.Any(char.IsPunctuation) || phone.Length != 11)
            {
                EP.SetError(RTBPhone, "Enter a valid phone number (must be 11 digits)");
                IsPhoneValid = false;
                e.Cancel = true;
            }

            else if (phone.Length >= 3)
            {
                string prefix = phone.Substring(0, 3);
                if (prefix != "010" && prefix != "011" && prefix != "012" && prefix != "015")
                {
                    EP.SetError(RTBPhone, "Phone must start with 010, 011, 012, or 015");
                    IsPhoneValid = false;
                    e.Cancel = true;
                }
                else
                {
                    EP.SetError(RTBPhone, "");
                    IsPhoneValid = true;
                    e.Cancel = false;
                }
            }

            else
            {
                EP.SetError(RTBPhone, "");
                IsPhoneValid = true;
                e.Cancel = false;
            }

        }

        private void RTBEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(RTBEmail.Text))
            {
                if (!(RTBEmail.Text.Contains("@gmail.com")
                    || RTBEmail.Text.Contains("@hotmail.com")
                    || RTBEmail.Text.Contains("@yahoo.com")
                    ))
                {
                    EP.SetError(RTBEmail, "Enter Valid Email");
                    IsEmailValid = false;
                    e.Cancel = true;
                }
                else
                {
                    EP.SetError(RTBEmail, "");
                    IsEmailValid = true;
                    e.Cancel = false;
                }
            }
            else
            {
                EP.SetError(RTBEmail, "");
                IsEmailValid = true;
                e.Cancel = false;
            }
        }

        private void RTBNationalNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNationalNo.Text))
            {
                EP.SetError((Control)sender, "you must add National Number");
                IsNationalNoValid = false;
                e.Cancel = true;
            }
            else if (People.IsNationalNoExist(RTBNationalNo.Text))
            {
                EP.SetError((Control)sender, "This National Nubmer Is Used");
                IsNationalNoValid = false;
                e.Cancel = true;
            }
            else
            {
                EP.SetError((Control)sender, "");
                IsNationalNoValid = true;
                e.Cancel = false;
            }
        }

    }
}
