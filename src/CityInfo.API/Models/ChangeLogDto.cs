using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class ChangeLogDto
    {
        public int ChangeLogID { get; set; }
        public int TableID { get; set; }
        public int KeyValue { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public bool RecordDeleted { get; set; }
    }
}
