using System.Data;
using DVLD_DataAccessLayer;

namespace CountriesBusinessLayer
{
    public class Countries
    {
        short NationalityCountryID { get; set; }
        string CountryName { get; set; }

        public Countries()
        {
            NationalityCountryID = 51;
            CountryName = "Egypt";
        }

        private Countries(short NationalityCountryID, string CountryName)
        {
            this.NationalityCountryID = NationalityCountryID;
            this.CountryName = CountryName;
        }

        public static Countries Find(int ID)
        {
            short NationalityCountryID = -1;
            string CountryName = "";

            if (CountriesData.GetCountryByID(NationalityCountryID, ref CountryName))
            {
                return new Countries(NationalityCountryID, CountryName);
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
