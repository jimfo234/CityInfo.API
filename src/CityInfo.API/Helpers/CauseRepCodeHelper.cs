using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CauseRepCodeHelper
    {
        public List<Models.CauseRepCodeDto> GetCauseRepCode(string connString)
        {
            string spName = "GetCauseRepCodeData";
            List<Models.CauseRepCodeDto> causeRepCodeData = new List<Models.CauseRepCodeDto>();

            try
            {
                BaseDataAccess baseDb = new BaseDataAccess(connString);

                using (SqlDataReader dr = baseDb.GetDataReader(spName, null))
                {
                    while (dr.Read())
                    {
                        Models.CauseRepCodeDto causeRepCode = new Models.CauseRepCodeDto();
                        causeRepCode.codeid = Utility.ConfirmIntOrZero(dr["codeid"]);
                        causeRepCode.type = dr["type"].ToString();
                        causeRepCode.code = dr["code"].ToString();
                        causeRepCode.short_desc = dr["short_desc"].ToString();
                        causeRepCode.description = dr["description"].ToString();
                        byte[] value = (byte[])(dr["rowversion"]);
                        causeRepCode.rowversion = Utility.ConvertByteArrayToString(value);
                        causeRepCodeData.Add(causeRepCode);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogCritical($"Exception while executing " + spName); 
                throw new Exception(ex.Message);
            }

            if (causeRepCodeData.Count == 0)
                return null;

            return causeRepCodeData;
        }
    }
}
