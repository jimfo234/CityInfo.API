using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class SupplierHelper
    {
        public List<Models.SupplierDto> GetSupplier(string connString)
        {
            string spName = "GetSupplierData";
            List<Models.SupplierDto> supplierData = new List<Models.SupplierDto>();

            try
            {
                BaseDataAccess baseDb = new BaseDataAccess(connString);

                using (SqlDataReader dr = baseDb.GetDataReader(spName, null))
                {
                    while (dr.Read())
                    {
                        Models.SupplierDto supplier = new Models.SupplierDto();
                        supplier.supplierid = Utility.ConfirmIntOrZero(dr["supplierid"]);
                        supplier.suppgroupid = Utility.ConfirmIntOrZero(dr["suppgroupid"]);
                        supplier.num = dr["num"].ToString();
                        supplier.name = dr["name"].ToString();
                        supplier.addr1 = dr["addr1"].ToString();
                        supplier.addr2 = dr["addr2"].ToString();
                        supplier.city = dr["city"].ToString();
                        supplier.stateprov = dr["stateprov"].ToString();
                        supplier.country = dr["country"].ToString();
                        supplier.zippc = dr["zippc"].ToString();
                        supplier.phone = dr["phone"].ToString();
                        supplier.fax = dr["fax"].ToString();
                        supplier.contact = dr["contact"].ToString();
                        supplier.mgr = dr["mgr"].ToString();
                        supplier.terms = dr["terms"].ToString();
                        supplier.credit_limit = Utility.ConfirmDecimalOrZero(dr["credit_limit"]);
                        supplier.currencyid = Utility.ConfirmIntOrZero(dr["currencyid"]);
                        supplier.protocol = dr["protocol"].ToString();
                        supplier.taxid = Utility.ConfirmIntOrZero(dr["taxid"]);
                        supplier.deleted = Utility.ConfirmIntOrZero(dr["deleted"]);

                        DateTime? tempDate = Utility.ConfirmDateTimeOrNull(dr["datedeleted"]);
                        supplier.datedeleted = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        supplier.userideleted = Utility.ConfirmIntOrZero(dr["userideleted"]);
                        supplier.BillAddr1 = dr["BillAddr1"].ToString();
                        supplier.BillAddr2 = dr["BillAddr2"].ToString();
                        supplier.BillCity = dr["BillCity"].ToString();
                        supplier.BillStatProv = dr["BillStatProv"].ToString();
                        supplier.BillPC = dr["BillPC"].ToString();
                        supplier.BillCountry = dr["BillCountry"].ToString();
                        supplier.OldNum = dr["OldNum"].ToString();
                        supplier.TaxNum = dr["TaxNum"].ToString();
                        supplier.EMail = dr["EMail"].ToString();
                        supplier.WWW = dr["WWW"].ToString();
                        supplier.Notes = dr["Notes"].ToString();
                        supplier.RaceID = Utility.ConfirmIntOrZero(dr["RaceID"]);
                        supplier.EthnicityID = Utility.ConfirmIntOrZero(dr["EthnicityID"]);
                        supplier.DisabilityID = Utility.ConfirmIntOrZero(dr["DisabilityID"]);
                        supplier.WCBRequired = Utility.ConfirmBool(dr["WCBRequired"]);
                        tempDate = Utility.ConfirmDateTimeOrNull(dr["WCBExpiryDate"]);
                        supplier.WCBExpiryDate = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        tempDate = Utility.ConfirmDateTimeOrNull(dr["WCBVerifiedDate"]);
                        supplier.WCBVerifiedDate = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        supplier.WCBVerifiedBy = dr["WCBVerifiedBy"].ToString();

                        supplier.APACID = Utility.ConfirmIntOrZero(dr["APACID"]);
                        supplier.DefaultShipperID = Utility.ConfirmIntOrZero(dr["DefaultShipperID"]);
                        supplier.DefaultDeliverID = Utility.ConfirmIntOrZero(dr["DefaultDeliverID"]);
                        supplier.DefaultFOB = dr["DefaultFOB"].ToString();
                        supplier.PhoneMobile = dr["PhoneMobile"].ToString();
                        supplier.PhoneHome = dr["PhoneHome"].ToString();
                        supplier.PhonePager = dr["PhonePager"].ToString();
                        supplier.WCBNumber = dr["WCBNumber"].ToString();
                        byte[] value = (byte[])(dr["rowversion"]);
                        supplier.rowversion = Utility.ConvertByteArrayToString(value);
                        supplierData.Add(supplier);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogCritical($"Exception while executing " + spName); 
                throw new Exception(ex.Message);
            }

            if (supplierData.Count == 0)
                return null;

            return supplierData;
        }
    }
}
