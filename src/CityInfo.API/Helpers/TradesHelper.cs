using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class TradesHelper
    {
        public List<Models.TradesDto> GetTrades(string connString)
        {
            string spName = "GetTradesData";
            List<Models.TradesDto> tradesData = new List<Models.TradesDto>();

            try
            {
                BaseDataAccess baseDb = new BaseDataAccess(connString);

                using (SqlDataReader dr = baseDb.GetDataReader(spName, null))
                {
                    while (dr.Read())
                    {
                        Models.TradesDto trades = new Models.TradesDto();
                        trades.tradeid = Utility.ConfirmIntOrZero(dr["tradeid"]);
                        trades.tradedesc = dr["tradedesc"].ToString();
                        trades.def_reg_rate = Utility.ConfirmDecimalOrZero(dr["def_reg_rate"]);
                        trades.def_ot_rate = Utility.ConfirmDecimalOrZero(dr["def_ot_rate"]);
                        trades.def_dt_rate = Utility.ConfirmDecimalOrZero(dr["def_dt_rate"]);
                        trades.Deleted = Utility.ConfirmBool(dr["Deleted"]);
                        DateTime? tempDate = Utility.ConfirmDateTimeOrNull(dr["DateDeleted"]);
                        trades.DateDeleted = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        trades.UserIDeleted = Utility.ConfirmIntOrZero(dr["UserIDeleted"]);
                        byte[] value = (byte[])(dr["rowversion"]);
                        trades.rowversion = Utility.ConvertByteArrayToString(value);
                        tradesData.Add(trades);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogCritical($"Exception while executing " + spName); 
                throw new Exception(ex.Message);
            }

            if (tradesData.Count == 0)
                return null;

            return tradesData;
        }
    }
}
