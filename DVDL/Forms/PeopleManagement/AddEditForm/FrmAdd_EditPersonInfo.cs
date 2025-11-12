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
        int PersonID = 0;

        public FrmAdd_EditPersonInfo(int PersonID)
        {
            InitializeComponent(PersonID);
            InitializeCountryComboBox();
            FillFieldsWithPersonInfo(PersonID);

            this.PersonID = PersonID;
        }

        private void InitializeCountryComboBox()
        {
            CBCountry.DataSource = Countries.GetAllCountries();
            CBCountry.DisplayMember = "CountryName";
            CBCountry.ValueMember = "CountryID";
            CBCountry.SelectedValue = "51";
        }

        private void AddPerson()
        {
            People Person = new People();
            FillPesonWithFields(Person, true);
            Person.Save();

            lblPersonId.Text = Person.PersonID.ToString();
        }

        private void UpdatePerson(int PersonID)
        {
            People Person = People.Find(PersonID);
            FillPesonWithFields(Person);
            Person.Save();
        }

        private void FillPesonWithFields(People Person, bool IsAddNew = false)
        {
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

            Person.ImagePath = (Person.ImagePath != "") ?
            SaveImage(Person.ImagePath, IsAddNew) :
                "";

            Person.NationalityCountryID = (short)CBCountry.SelectedIndex;
        }

        private string SaveImage(string PersonImagePath, bool IsAddNew = false)
        {
            if (!Directory.Exists("C:/DVDL-People-Images"))
                Directory.CreateDirectory("C:/DVDL-People-Images");

            string SavePath = $"C:/DVDL-People-Images/{Guid.NewGuid()}{Path.GetExtension(PersonImagePath)}";

            if (!IsAddNew)
                File.Delete(PersonImagePath);

            File.Copy(PersonImagePath, SavePath);

            return SavePath;
        }

        private void FillFieldsWithPersonInfo(int PersonID)
        {
            if (PersonID == -1)
                return;

            People person = People.Find(PersonID);
            if (person == null)
                return;

            // Fill text fields
            RTBNameFirst.Text = person.FirstName;
            RTBNameSecond.Text = person.SecondName;
            RTBNameThird.Text = person.ThirdName;
            RTBNameLast.Text = person.LastName;
            RTBNationalNo.Text = person.NationalNo;
            RTBAddress.Text = person.Address;
            RTBPhone.Text = person.Phone;
            RTBEmail.Text = person.Email;
            lblPersonId.Text = person.PersonID.ToString();

            // Date
            DTPDateOfBirth.Value = person.DateOfBirth;

            // Gender
            if (person.Gender == 'M')
                RBMale.Checked = true;
            else if (person.Gender == 'F')
                RBFemale.Checked = true;

            // Country
            CBCountry.SelectedValue = person.NationalityCountryID;

            // Image
            if (!string.IsNullOrEmpty(person.ImagePath) && File.Exists(person.ImagePath))
            {
                PBPersonImage.ImageLocation = person.ImagePath;
            }
            else
            {
                PBPersonImage.Image = (person.Gender == 'F') ? Resources.Female_512 : Resources.Male_512;
            }
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (IsAllFieldsValid())
            {
                if (PersonID == -1)
                {
                    AddPerson();
                }
                else
                {
                    UpdatePerson(PersonID);
                }

                return;
            }

            MessageBox.Show(@"Cannot Save ! 
Some Fields Is Invalid", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void RBMale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PBPersonImage.ImageLocation) || PBPersonImage.Image == Resources.Female_512)
            {
                PBPersonImage.Image = Resources.Male_512;
            }
        }

        private void RBFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PBPersonImage.ImageLocation) || PBPersonImage.Image == Resources.Male_512)
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
                PBPersonImage.ImageLocation = ImageDialog.FileName;
                LlblRemoveImage.Visible = true;
            }
        }

        private void LlblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (PBPersonImage.Image != null && PBPersonImage.Image != Resources.Male_512 && PBPersonImage.Image != Resources.Female_512)
            {
                PBPersonImage.Image = (RBMale.Checked) ? Resources.Male_512 : Resources.Female_512;
                LlblRemoveImage.Visible = false;
            }
        }

    }
}
