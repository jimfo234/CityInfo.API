using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class MachineStatesDto
    {
        public int MachineStateID { get; set; }
        public string MachineStateDesc { get; set; }
        public bool Active { get; set; }
        public string rowversion { get; set; }
    }
}
