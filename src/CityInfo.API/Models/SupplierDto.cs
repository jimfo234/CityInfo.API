using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class SupplierDto
    {
        public int supplierid { get; set; }
        public int suppgroupid { get; set; }
        public string num { get; set; }
        public string name { get; set; }
        public string addr1 { get; set; }
        public string addr2 { get; set; }
        public string city { get; set; }
        public string stateprov { get; set; }
        public string country { get; set; }
        public string zippc { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string contact { get; set; }
        public string mgr { get; set; }
        public string terms { get; set; }
        public decimal credit_limit { get; set; }
        public int currencyid { get; set; }
        public string protocol { get; set; }
        public int taxid { get; set; }
        public int deleted { get; set; }
        public string datedeleted { get; set; }
        public int userideleted { get; set; }
        public string BillAddr1 { get; set; }
        public string BillAddr2 { get; set; }
        public string BillCity { get; set; }
        public string BillStatProv { get; set; }
        public string BillPC { get; set; }
        public string BillCountry { get; set; }
        public string OldNum { get; set; }
        public string TaxNum { get; set; }
        public string EMail { get; set; }
        public string WWW { get; set; }
        public string Notes { get; set; }
        public int RaceID { get; set; }
        public int EthnicityID { get; set; }
        public int DisabilityID { get; set; }
        public bool WCBRequired { get; set; }
        public string WCBExpiryDate { get; set; }
        public string WCBVerifiedDate { get; set; }
        public string WCBVerifiedBy { get; set; }
        public int APACID { get; set; }
        public int DefaultShipperID { get; set; }
        public int DefaultDeliverID { get; set; }
        public string DefaultFOB { get; set; }
        public string PhoneMobile { get; set; }
        public string PhoneHome { get; set; }
        public string PhonePager { get; set; }
        public string WCBNumber { get; set; }
        public string rowversion { get; set; }
    }
}
