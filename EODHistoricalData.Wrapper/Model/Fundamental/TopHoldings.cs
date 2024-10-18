using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class TopHoldings
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Owned { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Change { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none")]
        public double? Weight
        {
            get
            {
                if (string.IsNullOrEmpty(_weight))
                {
                    return null;
                }
                else
                {
                    return double.Parse(_weight.Replace("%", ""), CultureInfo.InvariantCulture) / 100.0;
                }
            }
            set
            {

            }
        }
        [JsonProperty("Weight")]
        private string _weight { get; set; }
    }
}
