using System;
using System.Data;
using DVLD_DataAccessLayer;

namespace PeopleBusinessLayer
{
    public class People
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalNo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }
        public string ImagePath { get; set; }
        public short NationalityCountryID { get; set; }

        private enum enMode { Update = 0, AddNew = 1 };
        private enMode Mode;

        public People()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.NationalNo = "";
            this.Phone = "";
            this.Email = "";
            this.Gender = 'U'; // U = Unknown
            this.ImagePath = "";
            this.NationalityCountryID = -1;

            Mode = enMode.AddNew;
        }

        private People(int PersonID, string FirstName, string SecondName,
            string ThirdName, string LastName, string Address,
            DateTime DateOfBirth, string NationalNo, string Phone,
            string Email, char Gender, string ImagePath, short NationalityCountryID)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.NationalNo = NationalNo;
            this.Phone = Phone;
            this.Email = Email;
            this.Gender = Gender;
            this.ImagePath = ImagePath;
            this.NationalityCountryID = NationalityCountryID;

            Mode = enMode.Update;
        }

        public static People Find(int ID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "";
            string Address = "", NationalNo = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            char Gender = 'U';
            short NationalityCountryID = -1;

            if (PeopleData.GetPersonByID(ID, ref FirstName, ref SecondName
                , ref ThirdName, ref LastName, ref Address, ref DateOfBirth,
                ref NationalNo, ref Phone, ref Email, ref Gender,
                ref ImagePath, ref NationalityCountryID))
            {
                return new People(ID, FirstName, SecondName, ThirdName,
                    LastName, Address, DateOfBirth, NationalNo, Phone,
                    Email, Gender, ImagePath, NationalityCountryID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewPerson()
        {
            this.PersonID = PeopleData.AddNewPerson(this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.Address, this.DateOfBirth,
                this.NationalNo, this.Phone, this.Email, this.Gender,
                this.ImagePath, this.NationalityCountryID);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return PeopleData.UpdatePerson(this.PersonID, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.Address, this.DateOfBirth,
                this.NationalNo, this.Phone, this.Email, this.Gender,
                this.ImagePath, this.NationalityCountryID);
        }

        public static bool DeletePerson(int PersonID)
        {
            return PeopleData.DeletePerson(PersonID);
        }

        public static bool IsPersonExist(int PersonID)
        {
            return PeopleData.IsPersonExist(PersonID);
        }

        public static bool IsNationalNoExist(string NationalNo)
        {
            return PeopleData.IsPersonExist(NationalNo);
        }

        public static DataTable GetAllPeople()
        {
            return PeopleData.GetAllPeople();
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
