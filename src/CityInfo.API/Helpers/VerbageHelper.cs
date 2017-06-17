using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class VerbageHelper
    {
        public List<Models.VerbageDto> GetVerbage(string connString)
        {
            string spName = "GetVerbageData";
            List<Models.VerbageDto> verbageData = new List<Models.VerbageDto>();

            try
            {
                BaseDataAccess baseDb = new BaseDataAccess(connString);

                using (SqlDataReader dr = baseDb.GetDataReader(spName, null))
                {
                    while (dr.Read())
                    {
                        Models.VerbageDto verbage = new Models.VerbageDto();
                        verbage.verbageid = Utility.ConfirmIntOrZero(dr["verbageid"]);
                        verbage.code = dr["code"].ToString();
                        verbage.long_desc = dr["long_desc"].ToString();
                        verbage.typedesc = dr["typedesc"].ToString();
                        verbage.category = Utility.ConfirmIntOrZero(dr["category"]);
                        verbage.rtf_long_desc = dr["rtf_long_desc"].ToString();
                        verbageData.Add(verbage);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogCritical($"Exception while executing " + spName); 
                throw new Exception(ex.Message);
            }

            if (verbageData.Count == 0)
                return null;

            return verbageData;
        }
    }
}
