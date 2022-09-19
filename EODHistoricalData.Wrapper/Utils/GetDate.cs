using System;

namespace EOD.Utils
{
    /// <summary>
    /// 
    /// </summary>
    internal class GetDate
    {
        /// <summary>
        /// Parse string into date
        /// </summary>
        /// <param name="dateStr">Date in string format</param>
        /// <returns>Null, if the string is equals to '0000-00-00'</returns>
        internal static DateTime? ParseDate(string dateStr)
        {
            if (dateStr == "0000-00-00")
            {
                return null;
            }
            else
            {
                return DateTime.Parse(dateStr);
            }
        }
    }
}
