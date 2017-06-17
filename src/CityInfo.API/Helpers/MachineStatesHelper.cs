using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class MachineStatesHelper
    {
        public List<Models.MachineStatesDto> GetMachineStates(string connString)
        {
            string spName = "GetMachineStatesData";
            List<Models.MachineStatesDto> machineStatesData = new List<Models.MachineStatesDto>();

            try
            {
                BaseDataAccess baseDb = new BaseDataAccess(connString);

                using (SqlDataReader dr = baseDb.GetDataReader(spName, null))
                {
                    while (dr.Read())
                    {
                        Models.MachineStatesDto machineStates = new Models.MachineStatesDto();
                        machineStates.MachineStateID = Utility.ConfirmIntOrZero(dr["MachineStateID"]);
                        machineStates.MachineStateDesc = (dr["MachineStateDesc"]).ToString();
                        machineStates.Active = Utility.ConfirmBool(dr["Active"]);
                        byte[] value = (byte[])(dr["rowversion"]);
                        machineStates.rowversion = Utility.ConvertByteArrayToString(value);
                        machineStatesData.Add(machineStates);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogCritical($"Exception while executing " + spName); 
                throw new Exception(ex.Message);
            }

            if (machineStatesData.Count == 0)
                return null;

            return machineStatesData;
        }
    }
}
