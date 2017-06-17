using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class Utility
    {
        /// <summary>
        /// Converts byte array to string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        internal static string ConvertByteArrayToString(byte[] value)
        {
            try
            {
                string hex = BitConverter.ToString(value);
                hex = hex.Replace("-", "");
                return hex;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Confirms object provided is an integer datatype or returns zero
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        internal static int ConfirmIntOrZero(object obj)
        {
            try
            {
                //replace any potential commas
                string str = obj.ToString().Replace(",", "");
                return Convert.ToInt32(str);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Confirms object provided is an double datatype or returns zero
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        internal static double ConfirmDoubleOrZero(object obj)
        {
            try
            {
                //replace any potential commas
                string str = obj.ToString().Replace(",", "");
                return Convert.ToDouble(str);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Confirms object provided is an decimal datatype or returns zero
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        internal static decimal ConfirmDecimalOrZero(object obj)
        {
            try
            {
                //replace any potential commas
                string str = obj.ToString().Replace(",", "");
                return Convert.ToDecimal(str);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Confirms object provided is an boolean datatype
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        internal static bool ConfirmBool(object obj)
        {
            try
            {
                return Convert.ToBoolean(obj);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Confirms object is DateTime datatype
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        internal static DateTime ConfirmDateTime(object obj)
        {
            try
            {
                return Convert.ToDateTime(obj);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// Confirms object is DateTime datatype or null
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        internal static DateTime? ConfirmDateTimeOrNull(object obj)
        {
            if (DBNull.Value.Equals(obj))
                return null;
            try
            {
                return Convert.ToDateTime(obj);
            }
            catch
            {
                return null;
            }
        }
    }
}
