using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class CatalogDto
    {
        public int invid { get; set; }
        public int primesupplierid { get; set; }
        public string code { get; set; }
        public int classid { get; set; }
        public int typeid { get; set; }
        public string short_desc { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public int stockingpart { get; set; }
        public int trackable { get; set; }
        public int manufid { get; set; }
        public string manufpartno { get; set; }
        public string supplierpartno { get; set; }
        public decimal cost { get; set; }
        public string catnotes { get; set; }
        public string specialhandling { get; set; }
        public string measunit { get; set; }
        public int taxid { get; set; }
        public int category { get; set; }
        public int numdrawings { get; set; }
        public string avgbegindate { get; set; }
        public decimal avgmonthlyusage { get; set; }
        public decimal totalusage { get; set; }
        public string lastpurchasedate { get; set; }
        public int allowoverages { get; set; }
        public decimal ovgamount { get; set; }
        public string spec1 { get; set; }
        public string spec2 { get; set; }
        public string spec3 { get; set; }
        public string spec4 { get; set; }
        public string spec5 { get; set; }
        public string spec6 { get; set; }
        public string spec7 { get; set; }
        public string spec8 { get; set; }
        public string spec9 { get; set; }
        public string spec10 { get; set; }
        public int specid { get; set; }
        public bool deleted { get; set; }
        public string datedeleted { get; set; }
        public int userideleted { get; set; }
        public string Seg1 { get; set; }
        public string Seg2 { get; set; }
        public string Seg3 { get; set; }
        public string Seg4 { get; set; }
        public string Seg5 { get; set; }
        public string Seg6 { get; set; }
        public string OriginalNumber { get; set; }
        public int Consignment { get; set; }
        public int NonConsignInvID { get; set; }
        public int BlanketID { get; set; }
        public int VendorManaged { get; set; }
        public string msds_number { get; set; }
        public string msds_expires { get; set; }
        public string Seg7 { get; set; }
        public string Seg8 { get; set; }
        public string Seg9 { get; set; }
        public string Seg10 { get; set; }
        public decimal ConversionFactor { get; set; }
        public string rtf_SpecialHandling { get; set; }
        public string rtf_catnotes { get; set; }
        public int SupercededByInvID { get; set; }
        public string rowversion { get; set; }
    }
}
