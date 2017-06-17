using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Route("api/masterfile")]
    public class MasterFileController : Controller
    {
        [HttpGet("{tableName}")]
        public IActionResult GetMasterTableData(string tableName)
        {
            Object returnVal = null;

            try
            {
                string connString = @"Data Source=JIMPC\SQLEXPRESS01;Database=GuardianDemo;User Id=sa;Password=123Jim";

                switch (tableName.ToUpper())
                {
                    case "CATALOG":
                        CatalogHelper catalog = new CatalogHelper();
                        returnVal = catalog.GetCatalog(connString);
                        break;
                    case "CAUSE_REP_CODE":
                        CauseRepCodeHelper causeRepCode = new CauseRepCodeHelper();
                        returnVal = causeRepCode.GetCauseRepCode(connString);
                        break;
                    case "EMPLOYEE":
                        EmployeeHelper employee = new EmployeeHelper();
                        returnVal = employee.GetEmployee(connString);
                        break;
                    case "EQUIPMENT":
                        EquipmentHelper equipment = new EquipmentHelper();
                        returnVal = equipment.GetEquipment(connString);
                        break;
                    case "LOCATIONS":
                        LocationsHelper locations = new LocationsHelper();
                        returnVal = locations.GetLocations(connString);
                        break;
                    case "MACHINESTATES":
                        MachineStatesHelper machineStates = new MachineStatesHelper();
                        returnVal = machineStates.GetMachineStates(connString);
                        break;
                    case "PRIORITY":
                        PriorityHelper priority = new PriorityHelper();
                        returnVal = priority.GetPriority(connString);
                        break;
                    case "SUPPLIER":
                        SupplierHelper supplier = new SupplierHelper();
                        returnVal = supplier.GetSupplier(connString);
                        break;
                    case "TRADES":
                        TradesHelper trades = new TradesHelper();
                        returnVal = trades.GetTrades(connString);
                        break;
                    case "VERBAGE":
                        VerbageHelper verbage = new VerbageHelper();
                        returnVal = verbage.GetVerbage(connString);
                        break;
                    case "WORKREQUESTPRIORITY":
                        WorkRequestPriorityHelper workRequestPriority = new WorkRequestPriorityHelper();
                        returnVal = workRequestPriority.GetWorkRequestPriority(connString);
                        break;
                    case "WORKREQUESTTYPES":
                        WorkRequestTypesHelper workRequestTypes = new WorkRequestTypesHelper();
                        returnVal = workRequestTypes.GetWorkRequestTypes(connString);
                        break;
                    default:
                        return NotFound();
                }    
            }
            catch (Exception)
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }

            // Not Found (404) response
            if (returnVal == null)
                return NotFound(); 

            // OK (200) response
            return Ok(returnVal); 
        }
    }
}
