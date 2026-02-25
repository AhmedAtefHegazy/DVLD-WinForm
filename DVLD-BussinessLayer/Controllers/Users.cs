using System.Data;

namespace DVLD_BussinessLayer.Controllers
{
    public class Users
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public short IsActive { get; set; }

        private enum enMode { Update = 0, AddNew = 1 };
        private enMode Mode = enMode.AddNew;

        public Users()
        {
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = -1;
            Mode = enMode.AddNew;
        }

        private Users(int UserID, int PersonID, string UserName, string Password, short IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }

        public static Users FindByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName = "";
            string Password = "";
            short IsActive = -1;

            if (DVLD_DataAccessLayer.UsersData.GetUserByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new Users(UserID, PersonID, UserName, Password, IsActive);
            }

            else
                return null;
        }

        public static Users FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = "";
            string Password = "";
            short IsActive = -1;

            if (DVLD_DataAccessLayer.UsersData.GetUserByPersonID(ref UserID, PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new Users(UserID, PersonID, UserName, Password, IsActive);
            }

            else
                return null;
        }

        private bool _AddNewUser()
        {
            this.UserID = DVLD_DataAccessLayer.UsersData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);

            return (UserID != -1);
        }

        private bool _UpdateUser()
        {
            return (DVLD_DataAccessLayer.UsersData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive));
        }

        public static bool DeleteUser(int UserID)
        {
            return (DVLD_DataAccessLayer.UsersData.DeleteUser(UserID));
        }

        public static bool IsUserExist(int UserID)
        {
            return (DVLD_DataAccessLayer.UsersData.IsUserExist(UserID));
        }

        public static bool IsUserCredintalsValid(string UserName, string Password)
        {
            return (DVLD_DataAccessLayer.UsersData.IsUserCredintalsValid(UserName, Password));
        }

        public DataTable GetAllUsers()
        {
            return DVLD_DataAccessLayer.UsersData.GetAllUsers();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

    }
}
