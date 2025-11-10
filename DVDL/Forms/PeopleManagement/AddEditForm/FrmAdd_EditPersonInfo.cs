using System;
using System.IO;
using System.Windows.Forms;
using CountriesBusinessLayer;
using DVDL.Properties;
using PeopleBusinessLayer;

namespace DVDL.Forms.PeopleManagement
{
    public partial class FrmAdd_EditPersonInfo : Form
    {
        People Person;
        int PersonID = 0;

        public FrmAdd_EditPersonInfo(int PersonID)
        {
            InitializeComponent(PersonID);
            InitializeCountryComboBox();
            this.PersonID = PersonID;
        }

        private void InitializeCountryComboBox()
        {
            CBCountry.DataSource = Countries.GetAllCountries();
            CBCountry.DisplayMember = "CountryName";
            CBCountry.ValueMember = "CountryID";
            CBCountry.SelectedValue = "51";
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (IsAllFieldsValid())
            {
                if (PersonID == -1)
                {
                    Person = new People();

                    Person.FirstName = RTBNameFirst.Text;
                    Person.SecondName = RTBNameSecond.Text;
                    Person.ThirdName = RTBNameThird.Text;
                    Person.LastName = RTBNameLast.Text;
                    Person.Address = RTBAddress.Text;
                    Person.DateOfBirth = DTPDateOfBirth.Value;
                    Person.NationalNo = RTBNationalNo.Text;
                    Person.Phone = RTBPhone.Text;
                    Person.Email = RTBEmail.Text;
                    Person.Gender = RBMale.Checked ? 'M' : (RBFemale.Checked ? 'F' : '\0');
                    Person.ImagePath = PBPersonImage.ImageLocation;
                    Person.NationalityCountryID = (short)CBCountry.SelectedIndex;
                    Person.Save();

                    lblPersonId.Text = Person.PersonID.ToString();
                }
                else
                {

                }

                return;
            }

            MessageBox.Show(@"Cannot Save ! 
Some Fields Is Invalid", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void RBMale_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMale.Checked && Person.ImagePath == "")
            {
                PBPersonImage.Image = Resources.Male_512;
            }
        }

        private void RBFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (RBFemale.Checked && Person.ImagePath == "")
            {
                PBPersonImage.Image = Resources.Female_512;
            }
        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ImageDialog = new OpenFileDialog();

            ImageDialog.Title = "Select an Image";
            ImageDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tif;*.tiff;*.webp|All Files|*.*";
            ImageDialog.DefaultExt = "jpg";

            if (ImageDialog.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists("C:/Images"))
                    Directory.CreateDirectory("C:/Images");
                string SavePath = $"C:/Images/{Guid.NewGuid()}.{Path.GetExtension(ImageDialog.FileName)}";

                File.Copy(ImageDialog.FileName, SavePath);
                if (Person.ImagePath != "")
                {
                    File.Delete(Person.ImagePath);
                }
                else
                    Person.ImagePath = SavePath;

                PBPersonImage.ImageLocation = SavePath;
            }


        }
    }
}
