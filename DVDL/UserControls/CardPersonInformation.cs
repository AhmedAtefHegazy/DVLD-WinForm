using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DVDL.Properties;
using PeopleBusinessLayer;

namespace DVDL
{
    public partial class CardPersonInformation : UserControl
    {
        public CardPersonInformation()
        {
            InitializeComponent();
        }

        public void FillPersonInfo(int PersonID)
        {
            People Person = People.Find(PersonID);

            if (Person == null)
            {
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblPersonId.Text = Person.PersonID.ToString();

            // Safely concatenate names (ignore nulls and extra spaces)
            lblPersonName.Text = string.Join(" ", new[]
            {
        Person.FirstName,
        Person.SecondName,
        Person.ThirdName,
        Person.FourthName
    }.Where(x => !string.IsNullOrWhiteSpace(x)));

            lblPersonNationalNo.Text = Person.NationalNo ?? "N/A";

            lblPersonDateOfBirth.Text =
                Person.DateOfBirth != DateTime.MinValue && Person.DateOfBirth != default(DateTime)
                ? Person.DateOfBirth.ToShortDateString()
                : "N/A";

            lblPersonGender.Text = Person.Gender == '\0' ? "U" : Person.Gender.ToString();
            lblPersonPhone.Text = string.IsNullOrWhiteSpace(Person.PhoneNumber) ? "N/A" : Person.PhoneNumber;
            lblPersonEmail.Text = string.IsNullOrWhiteSpace(Person.Email) ? "N/A" : Person.Email;

            lblPersonCountry.Text = Person.CountryID == 0 ? "N/A" : Person.CountryID.ToString();
            // TODO: Replace with country name lookup later

            lblPersonAddress.Text = string.IsNullOrWhiteSpace(Person.Address) ? "N/A" : Person.Address;

            // Handle Image
            if (!string.IsNullOrWhiteSpace(Person.ImagePath) && File.Exists(Person.ImagePath))
            {
                PBPersonImage.ImageLocation = Person.ImagePath;
            }
            else
            {
                PBPersonImage.Image = (Person.Gender == 'M' || lblPersonGender.Text == "U")
                    ? Resources.Male_512
                    : Resources.Female_512;
            }
        }

    }
}
