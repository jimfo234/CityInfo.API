using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class WorkorderDto
    {
        public int WorkOrderID { get; set; }
        public int EntWO_ID { get; set; }
        public string WO_Number { get; set; }
        public string WO_Short_Desc { get; set; }
        public string WO_Long_Desc { get; set; }
        public string EquipDesc { get; set; }
        public string LoginName { get; set; }
        public string FullName { get; set; }
        public string MobileStatus { get; set; }
        public decimal WOSequence { get; set; }
        public string PriorityDesc { get; set; }
        public string MachineDesc { get; set; }
        public string Location { get; set; }
        public string DateRequired { get; set; }
        public string StartDate { get; set; }
        public string Symptom { get; set; }
        public string Cause { get; set; }
        public string Action { get; set; }
        public string CauseDesc { get; set; }
        public string RepairDesc { get; set; }
        public string SymptomCodeText { get; set; }
        public string RequestedBy { get; set; }
        public string TradeDesc { get; set; }
    }
}
