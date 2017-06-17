using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class VerbageDto
    {
        public int verbageid { get; set; }
        public string code { get; set; }
        public string long_desc { get; set; }
        public string typedesc { get; set; }
        public int category { get; set; }
        public string rtf_long_desc { get; set; }
    }
}
