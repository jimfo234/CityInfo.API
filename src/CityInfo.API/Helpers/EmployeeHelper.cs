using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class EmployeeHelper
    {
        public List<Models.EmployeeDto> GetEmployee(string connString)
        {
            string spName = "GetEmployeeData";
            List<Models.EmployeeDto> employeeData = new List<Models.EmployeeDto>();

            try
            {
                BaseDataAccess baseDb = new BaseDataAccess(connString);

                using (SqlDataReader dr = baseDb.GetDataReader(spName, null))
                {
                    while (dr.Read())
                    {
                        Models.EmployeeDto employee = new Models.EmployeeDto();
                        employee.empid = Utility.ConfirmIntOrZero(dr["empid"]);
                        employee.empnumber = dr["empnumber"].ToString();
                        employee.empfname = dr["empfname"].ToString();
                        employee.emplname = dr["emplname"].ToString();
                        employee.empsin = dr["empsin"].ToString();
                        employee.emptitle = dr["emptitle"].ToString();
                        employee.empoffice = dr["empoffice"].ToString();
                        employee.empsuper = dr["empsuper"].ToString();
                        employee.emphphone = dr["emphphone"].ToString();
                        employee.empwphone = dr["empwphone"].ToString();
                        DateTime? tempDate = Utility.ConfirmDateTimeOrNull(dr["empdate"]);
                        employee.empdate = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        employee.empaddr = dr["empaddr"].ToString();
                        employee.moreaddr = dr["moreaddr"].ToString();
                        employee.empcity = dr["empcity"].ToString();
                        employee.empstate = dr["empstate"].ToString();
                        employee.empzip = dr["empzip"].ToString();
                        employee.emergcontact = dr["emergcontact"].ToString();
                        employee.emergphone = dr["emergphone"].ToString();
                        employee.emppic = dr["emppic"].ToString(); // to do - image
                        employee.shiftid = Utility.ConfirmIntOrZero(dr["shiftid"]);
                        employee.crewid = Utility.ConfirmIntOrZero(dr["crewid"]);
                        employee.notes = dr["notes"].ToString();
                        employee.Deleted = Utility.ConfirmIntOrZero(dr["Deleted"]);
                        tempDate = Utility.ConfirmDateTimeOrNull(dr["DateDeleted"]);
                        employee.DateDeleted = tempDate == null ? string.Empty : tempDate.Value.ToString("yyyy-MM-ddTH:mm:ss");
                        employee.UserIDeleted = Utility.ConfirmIntOrZero(dr["UserIDeleted"]);
                        employee.IsForeman = Utility.ConfirmBool(dr["emergphone"]);
                        employee.SecUserID = Utility.ConfirmIntOrZero(dr["SecUserID"]);
                        employee.Email1 = dr["Email1"].ToString();
                        employee.Email2 = dr["Email2"].ToString();
                        employee.MobilePhone = dr["MobilePhone"].ToString();
                        employee.OtherPhone = dr["OtherPhone"].ToString();
                        byte[] value = (byte[])(dr["rowversion"]);
                        employee.rowversion = Utility.ConvertByteArrayToString(value);
                        employeeData.Add(employee);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogCritical($"Exception while executing " + spName); 
                throw new Exception(ex.Message);
            }

            if (employeeData.Count == 0)
                return null;

            return employeeData;
        }
    }
}
