using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class PriorityHelper
    {
        public List<Models.PriorityDto> GetPriority(string connString)
        {
            string spName = "GetPriorityData";
            List<Models.PriorityDto> priorityData = new List<Models.PriorityDto>();

            try
            {
                BaseDataAccess baseDb = new BaseDataAccess(connString);
                //List<DbParameter> parameterList = new List<DbParameter>();
                //parameterList.Add(baseDb.GetParameter("ChangeLogID", id));

                using (SqlDataReader dr = baseDb.GetDataReader(spName, null))
                {
                    while (dr.Read())
                    {
                        Models.PriorityDto priority = new Models.PriorityDto();
                        priority.priorityid = Utility.ConfirmIntOrZero(dr["priorityid"]);
                        priority.short_desc = (dr["short_desc"]).ToString();
                        priority.long_desc = dr["long_desc"].ToString();
                        byte[] value = (byte[])(dr["rowversion"]);
                        priority.rowversion = Utility.ConvertByteArrayToString(value);
                        priorityData.Add(priority);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogCritical($"Exception while executing " + spName); 
                throw new Exception(ex.Message);
            }

            if (priorityData.Count == 0)
                return null;

            return priorityData;
        }
    }
}
