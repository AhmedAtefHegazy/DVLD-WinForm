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
        int PersonID = -1;

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
            CBCountry.SelectedValue = 51;
        }

        private bool AddPerson()
        {
            bool IsPersonAdded = false;

            People Person = new People();
            FillPesonWithFields(Person, true);
            IsPersonAdded = Person.Save();
            PersonID = Person.PersonID;
            PBPersonImage.ImageLocation = Person.ImagePath;
            lblPersonId.Text = Person.PersonID.ToString();
            LBLFormStatus.Text = "Update Person";
            return IsPersonAdded;
        }

        private bool UpdatePerson(int PersonID)
        {
            bool IsPersonUpdated = false;

            People Person = People.Find(PersonID);
            FillPesonWithFields(Person);
            IsPersonUpdated = Person.Save();

            return IsPersonUpdated;
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

            Person.ImagePath = SaveImage(PBPersonImage.ImageLocation, Person.ImagePath, IsAddNew);

            Person.NationalityCountryID = Convert.ToInt16(CBCountry.SelectedValue);
        }

        private string SaveImage(string SelectedImagePath, string OldSavedPath, bool IsAddNew = false)
        {
            // If PictureBox has default image (male/female), treat as no personal image
            bool isDefaultImage =
                PBPersonImage.Image == Resources.Male_512 ||
                PBPersonImage.Image == Resources.Female_512;

            // Case 1: user selected a valid file
            if (File.Exists(SelectedImagePath) && !isDefaultImage)
            {
                // Ensure save directory exists
                string saveDir = "C:/DVDL-People-Images";
                if (!Directory.Exists(saveDir))
                    Directory.CreateDirectory(saveDir);

                // Generate a unique filename
                string SavePath = Path.Combine(saveDir, $"{Guid.NewGuid()}{Path.GetExtension(SelectedImagePath)}");

                // Copy new file
                File.Copy(SelectedImagePath, SavePath, true);

                // If editing an existing person, remove old image if it’s different
                if (!IsAddNew && File.Exists(OldSavedPath) && OldSavedPath != SelectedImagePath)
                    File.Delete(OldSavedPath);

                return SavePath;
            }

            // Case 2: default image (means user didn’t select a personal image)
            else if (!isDefaultImage)
            {
                // If editing and old file existed, delete it
                if (!IsAddNew && File.Exists(OldSavedPath))
                    File.Delete(OldSavedPath);

                return "";
            }

            // Case 3: unchanged old image (user didn’t modify anything)
            else
            {
                return OldSavedPath;
            }
        }

        private void FillFieldsWithPersonInfo(int PersonID)
        {
            if (PersonID == -1)
            {
                LlblRemoveImage.Visible = false;
                return;
            }

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
                LlblRemoveImage.Visible = true;
            }
            else
            {
                PBPersonImage.Image = (person.Gender == 'F') ? Resources.Female_512 : Resources.Male_512;
                LlblRemoveImage.Visible = false;
            }
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (PersonID == -1)
            {
                if (IsAllFieldsFilled())
                {

                    if (AddPerson())
                        MessageBox.Show("Person Added Successfully !");
                    else
                        MessageBox.Show("Person Not Added !");
                }
                else
                    MessageBox.Show("Please fill all fields first");
            }
            else
            {

                if (UpdatePerson(PersonID))
                    MessageBox.Show("Person Updated Successfully !");
                else
                    MessageBox.Show("Person Not Updated !");
                return;
            }
        }

        private void SetDefaultImage()
        {
            PBPersonImage.Image = RBMale.Checked ? Resources.Male_512 : Resources.Female_512;
            PBPersonImage.ImageLocation = "";
            LlblRemoveImage.Visible = false;
        }

        private void RBMale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PBPersonImage.ImageLocation) || PBPersonImage.Image == Resources.Female_512)
            {
                SetDefaultImage();
            }
        }

        private void RBFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PBPersonImage.ImageLocation) || PBPersonImage.Image == Resources.Male_512)
            {
                SetDefaultImage();
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
                PBPersonImage.ImageLocation = "";
                PBPersonImage.Image = (RBMale.Checked) ? Resources.Male_512 : Resources.Female_512;
                LlblRemoveImage.Visible = false;
            }
        }

    }
}
