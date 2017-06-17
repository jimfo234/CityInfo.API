using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class EquipmentDto
    {
        public int equipid { get; set; }
        public string equipnum { get; set; }
        public int ischildren { get; set; }
        public string shortdesc { get; set; }
        public string description { get; set; }
        public string notes { get; set; }
        public int parent { get; set; }
        public string location { get; set; }
        public string site { get; set; }
        public string site_contact { get; set; }
        public string site_phone { get; set; }
        public int catalogid { get; set; }
        public int componentid { get; set; }
        public int numdrawings { get; set; }
        public string manufacturer { get; set; }
        public string mfrcontact { get; set; }
        public string mfrphone { get; set; }
        public string vendname { get; set; }
        public string vendphone { get; set; }
        public string vendcontact { get; set; }
        public string model { get; set; }
        public string serialnum { get; set; }
        public string inst_date { get; set; }
        public string war_date { get; set; }
        public decimal purgedcosts { get; set; }
        public string eqnotes { get; set; }
        public string user1 { get; set; }
        public string user2 { get; set; }
        public string user3 { get; set; }
        public string user4 { get; set; }
        public string user5 { get; set; }
        public string user6 { get; set; }
        public string user7 { get; set; }
        public string user8 { get; set; }
        public string user9 { get; set; }
        public string user10 { get; set; }
        public int specid { get; set; }
        public string Seg1 { get; set; }
        public string Seg2 { get; set; }
        public string Seg3 { get; set; }
        public string Seg4 { get; set; }
        public string Seg5 { get; set; }
        public string Seg6 { get; set; }
        public string WarrantyNotes { get; set; }
        public int DepartmentID { get; set; }
        public string natural_order { get; set; }
        public int lvl { get; set; }
        public bool IsFixedAsset { get; set; }
        public int AquisitionType { get; set; }
        public string AquisitionSource { get; set; }
        public int IncludesMaint { get; set; }
        public string MaintContractor { get; set; }
        public string ContractStart { get; set; }
        public string ContractEnd { get; set; }
        public string EquipReturn { get; set; }
        public decimal MileageBegin { get; set; }
        public decimal MileageEnd { get; set; }
        public decimal MileageMax { get; set; }
        public int MileageUnits { get; set; }
        public string MileageUnitsOther { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Principal { get; set; }
        public decimal Term { get; set; }
        public decimal Buyout { get; set; }
        public decimal Payment { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public string AquisitionNotes { get; set; }
        public int HasAquisitionDetail { get; set; }
        public string ECPlanGUID { get; set; }
        public bool Insurable { get; set; }
        public int GVW { get; set; }
        public string GVWUnit { get; set; }
        public int ModelYear { get; set; }
        public string BodyStyle { get; set; }
        public string FleetNum { get; set; }
        public string PlateNum { get; set; }
        public string PlateJurisdiction { get; set; }
        public int DefaultLaborRT_ACID { get; set; }
        public int DefaultLaborOT_ACID { get; set; }
        public int DefaultLaborDT_ACID { get; set; }
        public string Seg7 { get; set; }
        public string Seg8 { get; set; }
        public string Seg9 { get; set; }
        public string Seg10 { get; set; }
        public string rtf_notes { get; set; }
        public string rtf_eqnotes { get; set; }
        public bool OverrideSegment1 { get; set; }
        public bool OverrideSegment2 { get; set; }
        public bool OverrideSegment3 { get; set; }
        public bool OverrideSegment4 { get; set; }
        public bool OverrideSegment5 { get; set; }
        public bool OverrideSegment6 { get; set; }
        public bool OverrideSegment7 { get; set; }
        public bool OverrideSegment8 { get; set; }
        public bool OverrideSegment9 { get; set; }
        public bool OverrideSegment10 { get; set; }
        public int Criticality { get; set; }
        public bool ENABLED { get; set; }
        public int DefaultTaxID { get; set; }
        public string rowversion { get; set; }
        public string site_email { get; set; }
        public int EquipTypeID { get; set; }
    }
}
