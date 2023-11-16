using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMSDALayer;
using System.IO;

namespace ARMSBOLayer
{
    class Country
    {
        //setting up the properties
        public byte CountryID { get; set; }
        public string CountryCode2Char { get; set; }
        public string CountryCode3Char { get; set; }
        public string CountryName { get; set; }

        //constructors
        public Country()
        {
            this.CountryID = 0;
            this.CountryCode2Char = "";
            this.CountryCode3Char = "";
            this.CountryName = "";
        }
        public Country(byte CountryID_val, string CountryCode2Char_val, string CountryCode3Char_val, string CountryName_val)
        {
            this.CountryID = CountryID_val;
            this.CountryCode2Char = CountryCode2Char_val;
            this.CountryCode3Char = CountryCode3Char_val;
            this.CountryName = CountryName_val;
        }
        
        //destructor
        ~Country()
        {

        }

        //public methods
        public void Print()
        {
            StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true);

            objPrinterFile.WriteLine("Country Information: ");
            objPrinterFile.WriteLine("Country ID = {0}", CountryID);
            objPrinterFile.WriteLine("Country Code 2 Characters = {0}", CountryCode2Char);
            objPrinterFile.WriteLine("Country Code 3 Characters = {0}", CountryCode3Char);
            objPrinterFile.WriteLine("Country Name = {0}", CountryName);

            objPrinterFile.WriteLine();
            objPrinterFile.WriteLine();

            objPrinterFile.Close();
        }

        public static List<Country> GetAllCountries()
        {
            return DALayer_GetAllCountries();
        }

        public static List<Country> DALayer_GetAllCountries()
        {
            return null;
        }

    }
}
