using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMSDALayer;
using System.IO;

namespace ARMSBOLayer
{
    class USStates
    {
        //public properties
        public byte StateID { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }

        //constructors
        public USStates()
        {
            this.StateID = 0;
            this.StateCode = "";
            this.StateName = "";
        }

        public USStates(byte StateID_val, string StateCode_val, string StateName_val)
        {
            this.StateID = StateID_val;
            this.StateCode = StateCode_val;
            this.StateName = StateName_val;
        }

        //destructor
        ~USStates()
        {

        }

        //public methods
        public void Print()
        {
            StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true);

            objPrinterFile.WriteLine("US State Information: ");
            objPrinterFile.WriteLine("US State ID = {0}", StateID);
            objPrinterFile.WriteLine("US State Code = {0}", StateCode);
            objPrinterFile.WriteLine("US State Name = {0}", StateName);

            objPrinterFile.WriteLine();
            objPrinterFile.WriteLine();

            objPrinterFile.Close();
        }

        public static List<USStates> GetAllUSStates()
        {
            return DALayer_GetAllUSStates();
        }

        public static List<USStates> DALayer_GetAllUSStates()
        {
            //logic to get the us states -- goes here
            return null;
        }
    }
}
