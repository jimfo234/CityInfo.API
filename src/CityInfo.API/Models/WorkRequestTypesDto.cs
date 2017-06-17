using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class WorkRequestTypesDto
    {
        public int WorkRequestTypeID { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public string DeletedDate { get; set; }
        public int DeletedBySecuserID { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedBySecuserID { get; set; }
        public bool IsDefault { get; set; }
        public string NotifyOnCreateEmail { get; set; }
    }
}
