using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMSDALayer;
using System.IO;

namespace ARMSBOLayer
{
    class CreditCardMerchant
    {
        //public properties
        public byte MerchantCode { get; set; }
        public string MerchantName { get; set; }
        //constructors
        public CreditCardMerchant()
        {
            this.MerchantCode = 0;
            this.MerchantName = "";
        }
        public CreditCardMerchant(byte MerchantCode_val, string MerchantName_val)
        {
            this.MerchantCode = MerchantCode_val;
            this.MerchantName = MerchantName_val;
        }
        //destructor
        ~CreditCardMerchant()
        {

        }
        //public methods
        public void Print()
        {
            StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true);

            objPrinterFile.WriteLine("Merchant Information: ");
            objPrinterFile.WriteLine("Merchant Code = {0}", MerchantCode);
            objPrinterFile.WriteLine("Merchant Name = {0}", MerchantName);

            objPrinterFile.WriteLine();
            objPrinterFile.WriteLine();

            objPrinterFile.Close();
        }

        public static List<CreditCardMerchant> GetAllCreditCardMerchant()
        {
            return DALayer_GetAllCCMerchants();
        }

        public static List<CreditCardMerchant> DALayer_GetAllCCMerchants()
        {
            //logic to get the us states -- goes here
            return null;
        }

    }
}
