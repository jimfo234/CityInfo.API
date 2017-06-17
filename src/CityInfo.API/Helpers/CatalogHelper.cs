using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CatalogHelper
    {
        public List<Models.CatalogDto> GetCatalog(string connString)
        {
            string spName = "GetCatalogData";
            List<Models.CatalogDto> catalogData = new List<Models.CatalogDto>();

            try
            {
                BaseDataAccess baseDb = new BaseDataAccess(connString);

                using (SqlDataReader dr = baseDb.GetDataReader(spName, null))
                {
                    while (dr.Read())
                    {
                        Models.CatalogDto catalog = new Models.CatalogDto();
                        catalog.invid = Utility.ConfirmIntOrZero(dr["invid"]);
                        catalog.primesupplierid = Utility.ConfirmIntOrZero(dr["primesupplierid"]);
                        catalog.code = dr["code"].ToString();
                        catalog.classid = Utility.ConfirmIntOrZero(dr["classid"]);
                        catalog.typeid = Utility.ConfirmIntOrZero(dr["typeid"]);
                        catalog.short_desc = dr["short_desc"].ToString();
                        catalog.description = dr["description"].ToString();
                        catalog.type = dr["type"].ToString();
                        catalog.stockingpart = Utility.ConfirmIntOrZero(dr["stockingpart"]);
                        catalog.trackable = Utility.ConfirmIntOrZero(dr["trackable"]);
                        catalog.manufid = Utility.ConfirmIntOrZero(dr["manufid"]);
                        catalog.manufpartno = dr["manufpartno"].ToString();
                        catalog.supplierpartno = dr["supplierpartno"].ToString();
                        catalog.cost = Utility.ConfirmDecimalOrZero(dr["cost"].ToString());
                        catalog.catnotes = dr["catnotes"].ToString();
                        catalog.specialhandling = dr["specialhandling"].ToString();
                        catalog.measunit = dr["measunit"].ToString();
                        catalog.taxid = Utility.ConfirmIntOrZero(dr["taxid"]);
                        catalog.category = Utility.ConfirmIntOrZero(dr["category"]);
                        catalog.numdrawings = Utility.ConfirmIntOrZero(dr["numdrawings"]);

                        DateTime? tempDate = Utility.ConfirmDateTimeOrNull(dr["avgbegindate"]);
                        catalog.avgbegindate = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        catalog.avgmonthlyusage = Utility.ConfirmDecimalOrZero(dr["avgmonthlyusage"]);
                        catalog.totalusage = Utility.ConfirmDecimalOrZero(dr["totalusage"]);
                        tempDate = Utility.ConfirmDateTimeOrNull(dr["lastpurchasedate"]);
                        catalog.lastpurchasedate = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        catalog.allowoverages = Utility.ConfirmIntOrZero(dr["allowoverages"]);
                        catalog.ovgamount = Utility.ConfirmDecimalOrZero(dr["ovgamount"]);
                        catalog.spec1 = dr["spec1"].ToString();
                        catalog.spec2 = dr["spec2"].ToString();
                        catalog.spec3 = dr["spec3"].ToString();
                        catalog.spec4 = dr["spec4"].ToString();
                        catalog.spec5 = dr["spec5"].ToString();
                        catalog.spec6 = dr["spec6"].ToString();
                        catalog.spec7 = dr["spec7"].ToString();
                        catalog.spec8 = dr["spec8"].ToString();
                        catalog.spec9 = dr["spec9"].ToString();
                        catalog.spec10 = dr["spec10"].ToString();
                        catalog.specid = Utility.ConfirmIntOrZero(dr["specid"]);
                        catalog.deleted = Utility.ConfirmBool(dr["deleted"]);
                        tempDate = Utility.ConfirmDateTimeOrNull(dr["datedeleted"]);
                        catalog.datedeleted = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        catalog.userideleted = Utility.ConfirmIntOrZero(dr["userideleted"]);

                        catalog.Seg1 = dr["Seg1"].ToString();
                        catalog.Seg2 = dr["Seg2"].ToString();
                        catalog.Seg3 = dr["Seg3"].ToString();
                        catalog.Seg4 = dr["Seg4"].ToString();
                        catalog.Seg5 = dr["Seg5"].ToString();
                        catalog.Seg6 = dr["Seg6"].ToString();
                        catalog.OriginalNumber = dr["OriginalNumber"].ToString();
                        catalog.Consignment = Utility.ConfirmIntOrZero(dr["Consignment"]);
                        catalog.NonConsignInvID = Utility.ConfirmIntOrZero(dr["NonConsignInvID"]);
                        catalog.BlanketID = Utility.ConfirmIntOrZero(dr["BlanketID"]);
                        catalog.VendorManaged = Utility.ConfirmIntOrZero(dr["VendorManaged"]);
                        catalog.msds_number = dr["msds_number"].ToString();
                        tempDate = Utility.ConfirmDateTimeOrNull(dr["msds_expires"]);
                        catalog.msds_expires = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        catalog.Seg7 = dr["Seg7"].ToString();
                        catalog.Seg8 = dr["Seg8"].ToString();
                        catalog.Seg9 = dr["Seg9"].ToString();
                        catalog.Seg10 = dr["Seg10"].ToString();
                        catalog.ConversionFactor = Utility.ConfirmDecimalOrZero(dr["ConversionFactor"]);
                        catalog.rtf_SpecialHandling = dr["rtf_SpecialHandling"].ToString();
                        catalog.rtf_catnotes = dr["rtf_catnotes"].ToString();

                        catalog.SupercededByInvID = Utility.ConfirmIntOrZero(dr["SupercededByInvID"]);
                        byte[] value = (byte[])(dr["rowversion"]);
                        catalog.rowversion = Utility.ConvertByteArrayToString(value);
                        catalogData.Add(catalog);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogCritical($"Exception while executing " + spName); 
                throw new Exception(ex.Message);
            }

            if (catalogData.Count == 0)
                return null;

            return catalogData;
        }
    }
}
