using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class EmployeeDto
    {
        public int empid { get; set; }
        public string empnumber { get; set; }
        public string empfname { get; set; }
        public string emplname { get; set; }
        public string empsin { get; set; }
        public string emptitle { get; set; }
        public string empoffice { get; set; }
        public string empsuper { get; set; }
        public string emphphone { get; set; }
        public string empwphone { get; set; }
        public string empdate { get; set; }
        public string empaddr { get; set; }
        public string moreaddr { get; set; }
        public string empcity { get; set; }
        public string empstate { get; set; }
        public string empzip { get; set; }
        public string emergcontact { get; set; }
        public string emergphone { get; set; }
        public string emppic { get; set; }
        public int shiftid { get; set; }
        public int crewid { get; set; }
        public string notes { get; set; }
        public int Deleted { get; set; }
        public string DateDeleted { get; set; }
        public int UserIDeleted { get; set; }
        public bool IsForeman { get; set; }
        public int SecUserID { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string MobilePhone { get; set; }
        public string OtherPhone { get; set; }
        public string rowversion { get; set; }
    }
}
