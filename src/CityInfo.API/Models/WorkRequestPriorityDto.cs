using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class WorkRequestPriorityDto
    {
        public int WorkRequestPriorityID { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public bool IsDefault { get; set; }
    }
}
