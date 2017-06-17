using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class WorkRequestPriorityHelper
    {
        public List<Models.WorkRequestPriorityDto> GetWorkRequestPriority(string connString)
        {
            string spName = "GetWorkRequestPriorityData";
            List<Models.WorkRequestPriorityDto> workRequestPriorityData = new List<Models.WorkRequestPriorityDto>();

            try
            {
                BaseDataAccess baseDb = new BaseDataAccess(connString);

                using (SqlDataReader dr = baseDb.GetDataReader(spName, null))
                {
                    while (dr.Read())
                    {
                        Models.WorkRequestPriorityDto workRequestPriority = new Models.WorkRequestPriorityDto();
                        workRequestPriority.WorkRequestPriorityID = Utility.ConfirmIntOrZero(dr["WorkRequestPriorityID"]);
                        workRequestPriority.Priority = Utility.ConfirmIntOrZero(dr["Priority"]);
                        workRequestPriority.Description = dr["Description"].ToString();
                        workRequestPriority.Enabled = Utility.ConfirmBool(dr["Enabled"]);
                        workRequestPriority.IsDefault = Utility.ConfirmBool(dr["IsDefault"]);
                        workRequestPriorityData.Add(workRequestPriority);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogCritical($"Exception while executing " + spName); 
                throw new Exception(ex.Message);
            }

            if (workRequestPriorityData.Count == 0)
                return null;

            return workRequestPriorityData;
        }
    }
}
