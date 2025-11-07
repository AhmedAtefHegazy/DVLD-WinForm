using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class PeopleData
    {


        // Get person by ID
        public static bool GetPersonByID(int PersonID, ref string FirstName, ref string SecondName
                , ref string ThirdName, ref string LastName
              , ref string Address, ref DateTime DateOfBirth, ref string NationalNo
              , ref string PhoneNumber, ref string Email, ref char Gender
              , ref string ImagePath, ref short CountryID)
        {
            bool IsFound = false;

            string Query = "SELECT * FROM People WHERE PersonID = @PersonID";
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    FirstName = Reader["FirstName"] == DBNull.Value ? string.Empty : Reader["FirstName"]?.ToString() ?? string.Empty;
                    SecondName = Reader["SecondName"] == DBNull.Value ? string.Empty : Reader["SecondName"]?.ToString() ?? string.Empty;
                    ThirdName = Reader["ThirdName"] == DBNull.Value ? string.Empty : Reader["ThirdName"]?.ToString() ?? string.Empty;
                    LastName = Reader["LastName"] == DBNull.Value ? string.Empty : Reader["LastName"]?.ToString() ?? string.Empty;
                    Address = Reader["Address"] == DBNull.Value ? string.Empty : Reader["Address"]?.ToString() ?? string.Empty;
                    DateOfBirth = Reader["DateOfBirth"] == DBNull.Value ? DateTime.MinValue : (DateTime)Reader["DateOfBirth"];
                    NationalNo = Reader["NationalNo"] == DBNull.Value ? string.Empty : Reader["NationalNo"]?.ToString() ?? string.Empty;
                    PhoneNumber = Reader["Phone"] == DBNull.Value ? string.Empty : Reader["Phone"]?.ToString() ?? string.Empty;
                    Email = Reader["Email"] == DBNull.Value ? string.Empty : Reader["Email"]?.ToString() ?? string.Empty;
                    Gender = Reader["Gender"] == DBNull.Value ? '\0' : Convert.ToChar(Reader["Gender"]);
                    ImagePath = Reader["ImagePath"] == DBNull.Value ? string.Empty : Reader["ImagePath"]?.ToString() ?? string.Empty;
                    CountryID = Reader["NationalityCountryID"] == DBNull.Value ? (short)0 : Convert.ToInt16(Reader["NationalityCountryID"]);

                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(ex, "People_Data-GetPersonByID");
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        // Get person by NationalNo
        public static bool GetPersonByNationalNo(ref int PersonID, ref string FullName
            , ref string Address, ref DateTime DateOfBirth, string NationalNo
            , ref string PhoneNumber, ref string Email, ref char Gender
            , ref string ImagePath, ref short CountryID)
        {
            bool IsFound = false;

            string Query = "SELECT * FROM People WHERE NationalNo = @NationalNo";
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    PersonID = (int)Reader["PersonID"];
                    FullName = Reader["FirstName"].ToString() + " " +
                               Reader["SecondName"].ToString() + " " +
                               Reader["ThirdName"].ToString() + " " +
                               Reader["FourthName"].ToString();

                    Address = Reader["Address"].ToString();
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    PhoneNumber = Reader["PhoneNumber"].ToString();
                    Email = Reader["Email"].ToString();
                    Gender = Convert.ToChar(Reader["Gender"]);
                    ImagePath = Reader["ImagePath"] == DBNull.Value ? "" : Reader["ImagePath"].ToString();
                    CountryID = Convert.ToInt16(Reader["CountryID"]);

                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(ex, "People_Data-GetPersonByNationalNo");
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        // Add new person
        public static int AddNewPerson(string FirstName,
            string SecondName, string ThirdName, string FourthName
            , string Address, DateTime DateOfBirth, string NationalNo
            , string PhoneNumber, string Email, char Gender
            , string ImagePath, short CountryID)
        {
            int PersonID = -1;

            string Query = @"INSERT INTO People
           (FirstName, SecondName, ThirdName, FourthName,
            Address, DateOfBirth, NationalNo, PhoneNumber,
            Email, Gender, ImagePath, CountryID)
           VALUES
           (@FirstName, @SecondName, @ThirdName, @FourthName,
            @Address, @DateOfBirth, @NationalNo, @PhoneNumber,
            @Email, @Gender, @ImagePath, @CountryID)

           SELECT SCOPE_IDENTITY()";
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@FourthName", FourthName);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            if (!string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null)
                {
                    int.TryParse(Result.ToString(), out PersonID);
                }
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(ex, "People_Data-AddNewPerson");
            }
            finally
            {
                Connection.Close();
            }

            return PersonID;
        }

        // Update person
        public static bool UpdatePerson(int PersonID, string FirstName,
            string SecondName, string ThirdName, string FourthName,
            string Address, DateTime DateOfBirth, string NationalNo,
            string PhoneNumber, string Email, char Gender,
            string ImagePath, short CountryID)
        {
            int RowsAffected = 0;

            string Query = @"UPDATE People
                             SET FirstName = @FirstName,
                                 SecondName = @SecondName,
                                 ThirdName = @ThirdName,
                                 FourthName = @FourthName,
                                 Address = @Address,
                                 DateOfBirth = @DateOfBirth,
                                 NationalNo = @NationalNo,
                                 PhoneNumber = @PhoneNumber,
                                 Email = @Email,
                                 Gender = @Gender,
                                 CountryID = @CountryID,
                                 ImagePath = @ImagePath
                             WHERE PersonID = @PersonID;";
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@FourthName", FourthName);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            if (!string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            try
            {
                Connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(ex, "People_Data-UpdatePerson");
                return false;
            }
            finally
            {
                Connection.Close();
            }

            return (RowsAffected > 0);
        }

        // Delete person
        public static bool DeletePerson(int PersonID)
        {
            int RowsAffected = 0;

            string Query = @"DELETE FROM People WHERE PersonID = @PersonID";
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(ex, "People_Data-DeletePerson");
                return false;
            }
            finally
            {
                Connection.Close();
            }

            return (RowsAffected > 0);
        }

        // Get all People
        public static DataTable GetAllPeople()
        {
            DataTable DT = new DataTable();

            string Query = "SELECT * FROM People";
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    DT.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(ex, "People_Data-GetAllPeople");
            }
            finally
            {
                Connection.Close();
            }

            return DT;
        }

        // Check if person exists
        public static bool IsPersonExist(int PersonID)
        {
            bool IsFound = false;

            string Query = @"SELECT 1 FROM People WHERE PersonID = @PersonID";
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();

                IsFound = (Result != null);
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(ex, "People_Data-IsPersonExist");
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

    }
}
