using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    internal class CountriesData
    {
        static public bool GetCountryByID(int CountryID, ref string CountryName)
        {
            bool IsFound = false;

            string Query = "SELECT 1 FROM People WHERE CountryID = @CountryID";
            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CountryName = (string)reader["CountryName"];
                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(ex, "Countries_Data-GetCountryByID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        static public DataTable GetAllCountries()
        {
            DataTable DTCountriesDate = new DataTable();
            string Query = "Select * From Countries";
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DTCountriesDate.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(ex, "Countries_Data-GetAllCountries");
            }
            finally
            {
                connection.Close();
            }
            return DTCountriesDate;
        }

    }
}
