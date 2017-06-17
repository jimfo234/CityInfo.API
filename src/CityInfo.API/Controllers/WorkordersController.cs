using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Route("api/workorders")]
    public class WorkordersController : Controller
    {
        [HttpGet()]
        public IActionResult GetWorkorderData()
        {
            string spName = "GetWorkorderData";
            List<Models.WorkorderDto> workorderData = new List<Models.WorkorderDto>();

            try
            {
                string connString = @"Data Source=JIMPC\SQLEXPRESS01;Database=EntMobSync;User Id=sa;Password=123Jim";
                BaseDataAccess baseDb = new BaseDataAccess(connString);

                using (SqlDataReader dr = baseDb.GetDataReader(spName, null))
                {
                    while (dr.Read())
                    {
                        Models.WorkorderDto workorders = new Models.WorkorderDto();
                        workorders.WorkOrderID = Convert.ToInt32(dr["WorkOrderID"]);
                        workorders.EntWO_ID = Convert.ToInt32(dr["EntWO_ID"]);
                        workorders.WO_Number = dr["WO_Number"].ToString();
                        workorders.WO_Short_Desc = dr["WO_Short_Desc"].ToString();
                        workorders.WO_Long_Desc = dr["WO_Long_Desc"].ToString();
                        workorders.EquipDesc = dr["EquipDesc"].ToString();
                        workorders.LoginName = dr["LoginName"].ToString();
                        workorders.FullName = dr["FullName"].ToString();
                        workorders.MobileStatus = dr["MobileStatus"].ToString();
                        workorders.WOSequence = Utility.ConfirmDecimalOrZero(dr["WOSequence"]);
                        workorders.PriorityDesc = dr["PriorityDesc"].ToString();
                        workorders.MachineDesc = dr["MachineDesc"].ToString();
                        workorders.Location = dr["Location"].ToString();
                        DateTime? tempDate = Utility.ConfirmDateTimeOrNull(dr["DateRequired"].ToString());
                        workorders.DateRequired = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        tempDate = Utility.ConfirmDateTimeOrNull(dr["StartDate"].ToString());
                        workorders.StartDate = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        workorders.Symptom = dr["Symptom"].ToString();
                        workorders.Cause = dr["Cause"].ToString();
                        workorders.Action = dr["Action"].ToString();
                        workorders.CauseDesc = dr["CauseDesc"].ToString();
                        workorders.RepairDesc = dr["RepairDesc"].ToString();
                        workorders.SymptomCodeText = dr["SymptomCodeText"].ToString();
                        workorders.RequestedBy = dr["RequestedBy"].ToString();
                        workorders.TradeDesc = dr["TradeDesc"].ToString();
                        workorderData.Add(workorders);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogCritical($"Exception while executing " + spName + ": " + ex.Message); 
                return StatusCode(500, "A problem happened while handling your request.");
            }

            if (workorderData.Count == 0)
                return NotFound();

            return Ok(workorderData);
        }
    }
}
