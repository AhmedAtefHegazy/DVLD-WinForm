using System.Data;
using DVLD_DataAccessLayer;

namespace DVLD_BussinessLayer
{
    internal class Countries
    {
        short CountryID { get; set; }
        string CountryName { get; set; }

        public Countries()
        {
            CountryID = 51;
            CountryName = "Egypt";
        }

        private Countries(short CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static Countries Find(int ID)
        {
            short CountryID = -1;
            string CountryName = "";

            if (CountriesData.GetCountryByID(CountryID, ref CountryName))
            {
                return new Countries(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllCountries()
        {
            return CountriesData.GetAllCountries();
        }
    }
}
