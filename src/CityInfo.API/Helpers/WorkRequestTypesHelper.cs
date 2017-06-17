using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class WorkRequestTypesHelper
    {
        public List<Models.WorkRequestTypesDto> GetWorkRequestTypes(string connString)
        {
            string spName = "GetWorkRequestTypesData";
            List<Models.WorkRequestTypesDto> workRequestTypesData = new List<Models.WorkRequestTypesDto>();

            try
            {
                BaseDataAccess baseDb = new BaseDataAccess(connString);

                using (SqlDataReader dr = baseDb.GetDataReader(spName, null))
                {
                    while (dr.Read())
                    {
                        Models.WorkRequestTypesDto workRequestTypes = new Models.WorkRequestTypesDto();
                        workRequestTypes.WorkRequestTypeID = Utility.ConfirmIntOrZero(dr["WorkRequestTypeID"]);
                        workRequestTypes.Description = dr["Description"].ToString();
                        workRequestTypes.Enabled = Utility.ConfirmBool(dr["Enabled"]);

                        DateTime? tempDate = Utility.ConfirmDateTimeOrNull(dr["DeletedDate"]);
                        workRequestTypes.DeletedDate = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");

                        workRequestTypes.DeletedBySecuserID = Utility.ConfirmIntOrZero(dr["DeletedBySecuserID"]);

                        tempDate = Utility.ConfirmDateTimeOrNull(dr["CreatedDate"]);
                        workRequestTypes.CreatedDate = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");

                        workRequestTypes.CreatedBySecuserID = Utility.ConfirmIntOrZero(dr["CreatedBySecuserID"]);
                        workRequestTypes.IsDefault = Utility.ConfirmBool(dr["IsDefault"]);
                        workRequestTypes.NotifyOnCreateEmail = dr["NotifyOnCreateEmail"].ToString();
                        workRequestTypesData.Add(workRequestTypes);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogCritical($"Exception while executing " + spName); 
                throw new Exception(ex.Message);
            }

            if (workRequestTypesData.Count == 0)
                return null;

            return workRequestTypesData;
        }
    }
}
