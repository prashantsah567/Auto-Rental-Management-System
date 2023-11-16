using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMSDALayer;
using System.IO;

namespace ARMSBOLayer
{
    public class CreditCard
    {
        //private datas
        private string m_CreditCardNumber;
        private string m_CreditCardOwnerName;
        private string m_CreditCardIssuingCompany;
        private byte m_MerchantCode;
        private string m_MerchantName;
        private DateTime m_ExpDate;
        private string m_AddressLine1;
        private string m_AddressLine2;
        private string m_City;
        private string m_StateCode;
        private string m_ZipCode;
        private string m_Country;
        private decimal m_CreditCardLimit;
        private decimal m_CreditCardBalance;
        private bool m_ActivationStatus;

        //setting up the properties
        public string CreditCardNumber
        {
            get { return m_CreditCardNumber; }
            set { m_CreditCardNumber = value; }
        }
        public string CreditCardOwnerName
        {
            get { return m_CreditCardOwnerName; }
            set { m_CreditCardOwnerName = value; }
        }
        public string CreditCardIssuingCompany
        {
            get { return m_CreditCardIssuingCompany; }
            set { m_CreditCardIssuingCompany = value; }
        }
        public byte MerchantCode
        {
            get { return m_MerchantCode; }
            set { m_MerchantCode = value; }
        }
        public string MerchantName
        {
            get { return m_MerchantName; }
            set { m_MerchantName = value; }
        }
        public DateTime ExpDate
        {
            get { return m_ExpDate; }
            set { m_ExpDate = value; }
        }
        public string AddressLine1
        {
            get { return m_AddressLine1; }
            set { m_AddressLine1 = value; }
        }
        public string AddressLine2
        {
            get { return m_AddressLine2; }
            set { m_AddressLine2 = value; }
        }
        public string City
        {
            get { return m_City; }
            set { m_City = value; }
        }
        public string StateCode
        {
            get { return m_StateCode; }
            set { m_StateCode = value; }
        }
        public string ZipCode
        {
            get { return m_ZipCode; }
            set { m_ZipCode = value; }
        }
        public string Country
        {
            get { return m_Country; }
            set { m_Country = value; }
        }
        public decimal CreditCardLimit
        {
            get { return m_CreditCardLimit;}
            set { m_CreditCardLimit = value; }
        }
        public decimal CreditCardBalance
        {
            get { return m_CreditCardBalance; }
            set { m_CreditCardBalance = value; }
        }
        public bool ActivationStatus
        {
            get { return m_ActivationStatus; }
            //set { m_ActivationStatus = true; }
        }

        //adding the constructors
        public CreditCard()
        {
            m_CreditCardNumber = "";
            m_CreditCardOwnerName = "";
            m_CreditCardIssuingCompany = "";
            m_MerchantCode = 0;
            m_MerchantName = "";
            m_ExpDate = new DateTime().Date;
            m_AddressLine1 = "";
            m_AddressLine2 = "";
            m_City = "";
            m_StateCode = "";
            m_ZipCode = "";
            m_Country = "";
            m_CreditCardLimit = 3000.0M;
            m_CreditCardBalance = 3000.0M;
            m_ActivationStatus = true;
        }

        public CreditCard(string CreditCardNumber_val, string CreditCardOwnerName_val, string CreditCardIssuingCompany_val, byte MerchantCode_val,
            string ExpDate_val, string AddressLine1_val, string AddressLine2_val, string City_val, string StateCode_val, string ZipCode_val, 
            string Country_val, decimal CreditCardLimit_val = 3000.0M, decimal CreditCardBalance_val=3000.0M)
        {
            this.CreditCardNumber = CreditCardNumber_val;
            this.CreditCardOwnerName = CreditCardOwnerName_val;
            this.CreditCardIssuingCompany = CreditCardIssuingCompany_val;
            this.MerchantCode = MerchantCode_val;
            this.ExpDate = DateTime.Parse(ExpDate_val);
            this.AddressLine1 = AddressLine1_val;
            this.AddressLine2 = AddressLine2_val;
            this.City = City_val;
            this.StateCode = StateCode_val;
            this.ZipCode = ZipCode_val;
            this.Country = Country_val;
            this.CreditCardLimit = CreditCardLimit_val;
            this.CreditCardBalance = CreditCardBalance_val;
            m_ActivationStatus = true;
        }

        //adding the destructor
        ~CreditCard()
        {
            
        }

        //defininig methods
        public void Print()
        {
            StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true);

            objPrinterFile.WriteLine("The Credit Card Information: "); 
            objPrinterFile.WriteLine("Credit Card Number = {0}", m_CreditCardNumber); 
            objPrinterFile.WriteLine("Credit Card Owner Name = {0}", m_CreditCardOwnerName); 
            objPrinterFile.WriteLine("Merchant Company Name = {0}", m_MerchantName); 
            objPrinterFile.WriteLine("Expiration Date = {0}", m_ExpDate); 
            objPrinterFile.WriteLine("Billing Address Line 1 = {0}", m_AddressLine1); 
            objPrinterFile.WriteLine("Billing Address Line 2 = {0}", m_AddressLine2); 
            objPrinterFile.WriteLine("Billing City = {0}", m_City); 
            objPrinterFile.WriteLine("Billing State = {0}", m_StateCode); 
            objPrinterFile.WriteLine("Billing Zipcode = {0}", m_ZipCode); 
            objPrinterFile.WriteLine("Billing Country = {0}", m_Country); 
            objPrinterFile.WriteLine("Credit Card Limit = {0}", m_CreditCardLimit);
            objPrinterFile.WriteLine("Credit Card Balance = {0}", m_CreditCardBalance);
            objPrinterFile.WriteLine("Activation Status = {0}", m_ActivationStatus); 

            objPrinterFile.WriteLine(); 
            objPrinterFile.WriteLine();

            objPrinterFile.Close();
        }

        public bool Activate()
        {
            m_ActivationStatus = true;
            return m_ActivationStatus;
        }

        public bool Deactivate()
        {
            m_ActivationStatus = false;
            return m_ActivationStatus;
        }

        //Data access methods
        public bool Load(string key)
        {
            return DALayer_Load(key);
        }

        public bool Insert()
        {
            return DALayer_Insert();
        }

        public bool Update()
        {
            return DALayer_Update();
        }

        public bool Delete(string key)
        {
            return DALayer_Delete(key);
        }

        public static List<CreditCard> GetAllCreditCards()
        {
            return DALayer_GetAllCreditCards();
        }

        //data access helper methods declarations
        protected bool DALayer_Load(string key)
        {
            return true;
        }
        protected bool DALayer_Insert()
        {
            return true;
        }
        protected bool DALayer_Update()
        {
            return true;
        }
        protected bool DALayer_Delete(string key)
        {
            return true;
        }
        protected static List<CreditCard> DALayer_GetAllCreditCards()
        {
            return null;
        }
    }
}
