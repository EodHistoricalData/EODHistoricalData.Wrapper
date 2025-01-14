using System.Globalization;

namespace EODHistoricalData.Wrapper.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public class GetDouble
    {
        /// <summary>
        /// For converting string to double
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static double ParseDouble(string value, double defaultValue)
        {

            //Try parsing in the current culture
            if (!double.TryParse(value, NumberStyles.Any, CultureInfo.CurrentCulture, out double result) &&
                //Then try in US english
                !double.TryParse(value, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
                //Then in neutral language
                !double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                result = defaultValue;
            }

            return result;
        }
    }
}
