using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class PriorityDto
    {
        public int priorityid { get; set; }
        public string short_desc { get; set; }
        public string long_desc { get; set; }
        public string rowversion { get; set; }    
    }
}
