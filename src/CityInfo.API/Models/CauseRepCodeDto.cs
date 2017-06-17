using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class CauseRepCodeDto
    {
        public int codeid { get; set; }
        public string type { get; set; }
        public string code { get; set; }
        public string short_desc { get; set; }
        public string description { get; set; }
        public string rowversion { get; set; }
    }
}
