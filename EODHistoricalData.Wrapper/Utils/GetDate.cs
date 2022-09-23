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
        /// <returns></returns>
        internal static DateTime? ParseDate(string dateStr)
        {
            if (DateTime.TryParse(dateStr, out var date))
            {
                return date;
            }
            else
            {
                return null;
            }
        }
    }
}
