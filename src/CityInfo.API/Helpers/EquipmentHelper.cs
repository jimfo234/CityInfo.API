using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class EquipmentHelper
    {
        public List<Models.EquipmentDto> GetEquipment(string connString)
        {
            string spName = "GetEquipmentData";
            List<Models.EquipmentDto> equipmentData = new List<Models.EquipmentDto>();

            try
            {
                BaseDataAccess baseDb = new BaseDataAccess(connString);

                using (SqlDataReader dr = baseDb.GetDataReader(spName, null))
                {
                    while (dr.Read())
                    {
                        Models.EquipmentDto equipment = new Models.EquipmentDto();
                        equipment.equipid = Utility.ConfirmIntOrZero(dr["equipid"]);
                        equipment.equipnum = dr["equipnum"].ToString();
                        equipment.ischildren = Utility.ConfirmIntOrZero(dr["ischildren"]);
                        equipment.shortdesc = dr["shortdesc"].ToString();
                        equipment.description = dr["description"].ToString();
                        equipment.notes = dr["notes"].ToString();
                        equipment.parent = Utility.ConfirmIntOrZero(dr["parent"]);
                        equipment.location = dr["location"].ToString();
                        equipment.site = dr["site"].ToString();
                        equipment.site_contact = dr["site_contact"].ToString();
                        equipment.site_phone = dr["site_phone"].ToString();
                        equipment.catalogid = Utility.ConfirmIntOrZero(dr["catalogid"]);
                        equipment.componentid = Utility.ConfirmIntOrZero(dr["componentid"]);
                        equipment.numdrawings = Utility.ConfirmIntOrZero(dr["numdrawings"]);
                        equipment.manufacturer = dr["manufacturer"].ToString();
                        equipment.mfrcontact = dr["mfrcontact"].ToString();
                        equipment.mfrphone = dr["mfrphone"].ToString();
                        equipment.vendname = dr["vendname"].ToString();
                        equipment.vendphone = dr["vendphone"].ToString();
                        equipment.vendcontact = dr["vendcontact"].ToString();

                        equipment.model = dr["model"].ToString();
                        equipment.serialnum = dr["serialnum"].ToString();
                        DateTime? tempDate = Utility.ConfirmDateTimeOrNull(dr["inst_date"]);
                        equipment.inst_date = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        tempDate = Utility.ConfirmDateTimeOrNull(dr["war_date"]);
                        equipment.war_date = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        equipment.purgedcosts = Utility.ConfirmDecimalOrZero(dr["purgedcosts"]);
                        equipment.eqnotes = dr["eqnotes"].ToString();
                        equipment.user1 = dr["user1"].ToString();
                        equipment.user2 = dr["user2"].ToString();
                        equipment.user3 = dr["user3"].ToString();
                        equipment.user4 = dr["user4"].ToString();
                        equipment.user5 = dr["user5"].ToString();
                        equipment.user6 = dr["user6"].ToString();
                        equipment.user7 = dr["user7"].ToString();
                        equipment.user8 = dr["user8"].ToString();
                        equipment.user9 = dr["user9"].ToString();
                        equipment.user10 = dr["user10"].ToString();
                        equipment.specid = Utility.ConfirmIntOrZero(dr["specid"]);
                        equipment.Seg1 = dr["Seg1"].ToString();
                        equipment.Seg2 = dr["Seg2"].ToString();
                        equipment.Seg3 = dr["Seg3"].ToString();

                        equipment.Seg4 = dr["Seg4"].ToString();
                        equipment.Seg5 = dr["Seg5"].ToString();
                        equipment.Seg6 = dr["Seg6"].ToString();
                        equipment.WarrantyNotes = dr["WarrantyNotes"].ToString();
                        equipment.DepartmentID = Utility.ConfirmIntOrZero(dr["DepartmentID"]);
                        equipment.natural_order = dr["natural_order"].ToString();
                        equipment.lvl = Utility.ConfirmIntOrZero(dr["lvl"]);
                        equipment.IsFixedAsset = Utility.ConfirmBool(dr["IsFixedAsset"]);
                        equipment.AquisitionType = Utility.ConfirmIntOrZero(dr["AquisitionType"]);
                        equipment.AquisitionSource = dr["AquisitionSource"].ToString();
                        equipment.IncludesMaint = Utility.ConfirmIntOrZero(dr["IncludesMaint"]);
                        equipment.MaintContractor = dr["MaintContractor"].ToString();
                        tempDate = Utility.ConfirmDateTimeOrNull(dr["ContractStart"]);
                        equipment.ContractStart = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        tempDate = Utility.ConfirmDateTimeOrNull(dr["ContractEnd"]);
                        equipment.ContractEnd = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        tempDate = Utility.ConfirmDateTimeOrNull(dr["EquipReturn"]);
                        equipment.EquipReturn = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        equipment.MileageBegin = Utility.ConfirmDecimalOrZero(dr["MileageBegin"]);
                        equipment.MileageEnd = Utility.ConfirmDecimalOrZero(dr["MileageEnd"]);
                        equipment.MileageMax = Utility.ConfirmDecimalOrZero(dr["MileageMax"]);
                        equipment.MileageUnits = Utility.ConfirmIntOrZero(dr["MileageUnits"]);
                        equipment.MileageUnitsOther = dr["MileageUnitsOther"].ToString();

                        equipment.InterestRate = Utility.ConfirmDecimalOrZero(dr["InterestRate"]);
                        equipment.Principal = Utility.ConfirmDecimalOrZero(dr["Principal"]);
                        equipment.Term = Utility.ConfirmDecimalOrZero(dr["Term"]);
                        equipment.Buyout = Utility.ConfirmDecimalOrZero(dr["Buyout"]);
                        equipment.Payment = Utility.ConfirmDecimalOrZero(dr["Payment"]);
                        equipment.Tax1 = Utility.ConfirmDecimalOrZero(dr["Tax1"]);
                        equipment.Tax2 = Utility.ConfirmDecimalOrZero(dr["Tax2"]);
                        equipment.AquisitionNotes = dr["AquisitionNotes"].ToString();
                        equipment.HasAquisitionDetail = Utility.ConfirmIntOrZero(dr["HasAquisitionDetail"]);

                        int index = dr.GetOrdinal("ECPlanGUID");
                        if (!dr.IsDBNull(index))
                        {
                            Guid tempGuid = dr.GetGuid(index);
                            equipment.ECPlanGUID = tempGuid.ToString();
                        }
                        else
                            equipment.ECPlanGUID = string.Empty;

                        equipment.Insurable = Utility.ConfirmBool(dr["Insurable"]);
                        equipment.GVW = Utility.ConfirmIntOrZero(dr["GVW"]);
                        equipment.GVWUnit = dr["GVWUnit"].ToString();
                        equipment.ModelYear = Utility.ConfirmIntOrZero(dr["ModelYear"]);
                        equipment.BodyStyle = dr["BodyStyle"].ToString();
                        equipment.FleetNum = dr["FleetNum"].ToString();
                        equipment.PlateNum = dr["PlateNum"].ToString();
                        equipment.PlateJurisdiction = dr["PlateJurisdiction"].ToString();
                        equipment.DefaultLaborRT_ACID = Utility.ConfirmIntOrZero(dr["DefaultLaborRT_ACID"]);
                        equipment.DefaultLaborOT_ACID = Utility.ConfirmIntOrZero(dr["DefaultLaborOT_ACID"]);

                        equipment.DefaultLaborDT_ACID = Utility.ConfirmIntOrZero(dr["DefaultLaborDT_ACID"]);
                        equipment.Seg7 = dr["Seg7"].ToString();
                        equipment.Seg8 = dr["Seg8"].ToString();
                        equipment.Seg9 = dr["Seg9"].ToString();
                        equipment.Seg10 = dr["Seg10"].ToString();
                        equipment.rtf_notes = dr["rtf_notes"].ToString();
                        equipment.rtf_eqnotes = dr["rtf_eqnotes"].ToString();
                        equipment.OverrideSegment1 = Utility.ConfirmBool(dr["OverrideSegment1"]);
                        equipment.OverrideSegment2 = Utility.ConfirmBool(dr["OverrideSegment2"]);
                        equipment.OverrideSegment3 = Utility.ConfirmBool(dr["OverrideSegment3"]);
                        equipment.OverrideSegment4 = Utility.ConfirmBool(dr["OverrideSegment4"]);
                        equipment.OverrideSegment5 = Utility.ConfirmBool(dr["OverrideSegment5"]);
                        equipment.OverrideSegment6 = Utility.ConfirmBool(dr["OverrideSegment6"]);
                        equipment.OverrideSegment7 = Utility.ConfirmBool(dr["OverrideSegment7"]);
                        equipment.OverrideSegment8 = Utility.ConfirmBool(dr["OverrideSegment8"]);
                        equipment.OverrideSegment9 = Utility.ConfirmBool(dr["OverrideSegment9"]);
                        equipment.OverrideSegment10 = Utility.ConfirmBool(dr["OverrideSegment10"]);
                        equipment.Criticality = Utility.ConfirmIntOrZero(dr["Criticality"]);
                        equipment.ENABLED = Utility.ConfirmBool(dr["ENABLED"]);
                        equipment.DefaultTaxID = Utility.ConfirmIntOrZero(dr["DefaultTaxID"]);

                        byte[] value = (byte[])(dr["rowversion"]);
                        equipment.rowversion = Utility.ConvertByteArrayToString(value);
                        equipment.site_email = dr["site_email"].ToString();
                        equipment.EquipTypeID = Utility.ConfirmIntOrZero(dr["EquipTypeID"]);
                        equipmentData.Add(equipment);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogCritical($"Exception while executing " + spName); 
                throw new Exception(ex.Message);
            }

            if (equipmentData.Count == 0)
                return null;

            return equipmentData;
        }
    }
}
