using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer.Entities
{
    internal class Users
    {
        public static bool GetUserByID
            (int UserID, ref int PersonID, ref string UserName, ref string Password, ref short IsActive)
        {
            bool IsFound = false;

            string ConnectionString = DataAccessSettings.ConnectionString;
            string Query = @"Select 1 From Users Where ID = '@UserID' ";

            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserId", UserID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    PersonID = (int)Reader["PersonID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (short)Reader["IsActive"];
                    IsFound = true;
                }

                Reader.Close();
            }
            catch (Exception ex)
            {

                LoggingHelper.LogError(ex, "Users_Data-GetUserByID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool GetUserByPersonID
            (ref int UserID, int PersonID, ref string UserName, ref string Password, ref short IsActive)
        {
            bool IsFound = false;

            string ConnectionString = DataAccessSettings.ConnectionString;
            string Query = @"Select 1 From Users Where PersonID='@PersonID'";

            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    UserID = (int)Reader["UserID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (short)Reader["IsActive"];

                    IsFound = true;
                }

                Reader.Close();
            }
            catch (Exception ex)
            {

                LoggingHelper.LogError(ex, "Users_Data-GetUserByPersonID");
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        public static int AddNewUser(int PersonID, string UserName, string Password, short IsActive)
        {
            int UserID = -1;

            string ConnectionString = DataAccessSettings.ConnectionString;
            string Query = @"INSERT INTO Users 
                                    (PersonID,UserName,Password,IsActive)
                                    Values
                                    (@PersonID,@UserName,@Password,@,IsActive)
                                    SELECT SCOPE_IDENTITY()";

            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", UserName);
            Command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    int.TryParse(Result.ToString(), out UserID);
                }
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(ex, "Users_Data-AddNewUser");
            }
            finally
            {
                Connection.Close();
            }

            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, short IsActive)
        {
            bool IsUpdated = false;
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = @"Update Users 
                                    Set 
                                    PersonID=@PersonID,
                                    UserName=@UserName,
                                    Password=@Password,
                                    IsActive=@IsActive,
                                    Where UserID = '@UserID' ";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                Connection.Open();
                IsUpdated = Command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {

                LoggingHelper.LogError(ex, "Users_Data-UpdateUser");
            }
            finally
            {
                Connection.Close();
            }

            return IsUpdated;
        }

        public static bool DeleteUser(int UserID)
        {
            bool IsDeleted = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = @"Delete Users WHERE UserID=@UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                IsDeleted = Command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(ex, "Users_Data-DeleteUser");
            }
            finally
            {
                Connection.Close();
            }

            return IsDeleted;
        }

        public static DataTable GetAllUsers()
        {
            DataTable DTUsers = new DataTable();

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = @"Select * From Users Order by UserName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    DTUsers.Load(Reader);
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(ex, "Users_Data-GetAllUsers");
            }
            finally
            {
                Connection.Close();
            }

            return DTUsers;
        }

        public static bool IsUserExist(int UserID)
        {
            bool IsUserExist = false;
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = @"Select 1 FROM Users WHERE UserID='@UserID'";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    IsUserExist = true;
                }
            }
            catch (Exception ex)
            {

                LoggingHelper.LogError(ex, "Users_Data-IsUserExist");
            }
            finally
            {
                Connection.Close();
            }

            return IsUserExist;
        }

    }
}
