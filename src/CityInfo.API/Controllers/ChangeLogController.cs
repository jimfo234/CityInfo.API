using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CityInfo.API.Controllers
{
    [Route("api/changelog")]
    public class ChangeLogController : Controller
    {
        [HttpGet("{id:int}")]
        public IActionResult GetChangeLog(int id)
        {
            string spName = "TestGetChangeLog";
            ChangeLogDto changeLog = new ChangeLogDto();
            try
            {
                string connString = @"Data Source=JIMPC\SQLEXPRESS01;Database=EntMobSync;User Id=sa;Password=123Jim";
                BaseDataAccess baseDb = new BaseDataAccess(connString);
                List<DbParameter> parameterList = new List<DbParameter>();
                parameterList.Add(baseDb.GetParameter("ChangeLogID", id));

                using (SqlDataReader dr = baseDb.GetDataReader(spName, parameterList))
                {              
                    if (dr.Read())
                    {
                        changeLog.ChangeLogID = Convert.ToInt32(dr["ChangeLogID"]);
                        changeLog.TableID = Convert.ToInt32(dr["TableID"]);
                        changeLog.KeyValue = Convert.ToInt32(dr["KeyValue"]);
                        changeLog.ModifiedDateTime = Convert.ToDateTime(dr["ModifiedDateTime"]);
                        changeLog.RecordDeleted = Convert.ToBoolean(dr["RecordDeleted"]);
                    }
                    else
                        return NotFound();
                }
            }
            catch (Exception)
            {
                //_logger.LogCritical($"Exception while executing " + spName); 
                return StatusCode(500, "A problem happened while handling your request.");
            }

            return Ok(changeLog);
        }
    }
}
