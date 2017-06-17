using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class LocationsHelper
    {
        public List<Models.LocationsDto> GetLocations(string connString)
        {
            string spName = "GetLocationsData";
            List<Models.LocationsDto> locationsData = new List<Models.LocationsDto>();

            try
            {
                BaseDataAccess baseDb = new BaseDataAccess(connString);

                using (SqlDataReader dr = baseDb.GetDataReader(spName, null))
                {
                    while (dr.Read())
                    {
                        Models.LocationsDto locations = new Models.LocationsDto();
                        locations.LocationID = Utility.ConfirmIntOrZero(dr["LocationID"]);
                        locations.Name = (dr["Name"]).ToString();
                        locations.Enabled = Utility.ConfirmBool(dr["Enabled"]);
                        byte[] value = (byte[])(dr["rowversion"]);
                        locations.rowversion = Utility.ConvertByteArrayToString(value);
                        locationsData.Add(locations);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogCritical($"Exception while executing " + spName); 
                throw new Exception(ex.Message);
            }

            if (locationsData.Count == 0)
                return null;

            return locationsData;
        }
    }
}
