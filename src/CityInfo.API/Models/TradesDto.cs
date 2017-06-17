using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class TradesDto
    {
        public int tradeid { get; set; }
        public string tradedesc { get; set; }
        public decimal def_reg_rate { get; set; }
        public decimal def_ot_rate { get; set; }
        public decimal def_dt_rate { get; set; }
        public bool Deleted { get; set; }
        public string DateDeleted { get; set; }
        public int UserIDeleted { get; set; }
        public string rowversion { get; set; }
    }
}
