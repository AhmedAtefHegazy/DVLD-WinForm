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

        public void FillPersonInfo(People Person)
        {
            lblPersonId.Text = Person.PersonID.ToString();
            lblPersonName.Text = Person.FirstName + Person.SecondName
                + Person.ThirdName + Person.FourthName;
            lblPersonNationalNo.Text = Person.NationalNo.ToString();
            lblPersonDateOfBirth.Text = Person.DateOfBirth.ToString();
            lblPersonGender.Text = Person.Gender.ToString();
            lblPersonPhone.Text = Person.PhoneNumber.ToString();
            lblPersonEmail.Text = Person.Email.ToString();
            lblPersonCountry.Text = Person.CountryID.ToString(); //TODO: Show the real country not the ID
            lblPersonAddress.Text = Person.Address.ToString();

            if (Person.ImagePath != null)
                PBPersonImage.ImageLocation = Person.ImagePath;
            else if (Person.ImagePath == null)
            {
                if (Person.Gender == 'M')
                    PBPersonImage.Image = Resources.Male_512;
                else
                    PBPersonImage.Image = Resources.Female_512;
            }



        }
    }
}
