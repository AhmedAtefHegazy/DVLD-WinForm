using System;
using System.Data;
using DVLD_DataAccessLayer;

namespace PersonsBusinessLayer
{
    public class Persons
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string FourthName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalNo { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }
        public string ImagePath { get; set; }
        public short CountryID { get; set; }

        private enum enMode { Update = 0, AddNew = 1 };
        private enMode Mode = enMode.AddNew;

        public Persons()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.FourthName = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.NationalNo = "";
            this.PhoneNumber = "";
            this.Email = "";
            this.Gender = 'U'; // U = Unknown
            this.ImagePath = "";
            this.CountryID = -1;

            Mode = enMode.AddNew;
        }

        private Persons(int PersonID, string FirstName, string SecondName,
            string ThirdName, string FourthName, string Address,
            DateTime DateOfBirth, string NationalNo, string PhoneNumber,
            string Email, char Gender, string ImagePath, short CountryID)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.FourthName = FourthName;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.NationalNo = NationalNo;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Gender = Gender;
            this.ImagePath = ImagePath;
            this.CountryID = CountryID;

            Mode = enMode.Update;
        }

        public static Persons Find(int ID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", FourthName = "";
            string Address = "", NationalNo = "", PhoneNumber = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            char Gender = 'U';
            short CountryID = -1;

            if (PersonsData.GetPersonByID(ID, ref FirstName, ref SecondName
                , ref ThirdName, ref FourthName, ref Address, ref DateOfBirth,
                ref NationalNo, ref PhoneNumber, ref Email, ref Gender,
                ref ImagePath, ref CountryID))
            {
                return new Persons(ID, FirstName, SecondName, ThirdName,
                    FourthName, Address, DateOfBirth, NationalNo, PhoneNumber,
                    Email, Gender, ImagePath, CountryID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewPerson()
        {
            this.PersonID = PersonsData.AddNewPerson(this.FirstName, this.SecondName,
                this.ThirdName, this.FourthName, this.Address, this.DateOfBirth,
                this.NationalNo, this.PhoneNumber, this.Email, this.Gender,
                this.ImagePath, this.CountryID);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return PersonsData.UpdatePerson(this.PersonID, this.FirstName, this.SecondName,
                this.ThirdName, this.FourthName, this.Address, this.DateOfBirth,
                this.NationalNo, this.PhoneNumber, this.Email, this.Gender,
                this.ImagePath, this.CountryID);
        }

        public static bool DeletePerson(int PersonID)
        {
            return PersonsData.DeletePerson(PersonID);
        }

        public static bool IsPersonExist(int PersonID)
        {
            return PersonsData.IsPersonExist(PersonID);
        }

        public static DataTable GetAllPersons()
        {
            return PersonsData.GetAllPersons();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePerson();
            }
            return false;
        }
    }
}
