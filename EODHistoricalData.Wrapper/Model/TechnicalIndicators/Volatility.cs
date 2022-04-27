using Newtonsoft.Json;
using System;

namespace EOD.Model.TechnicalIndicators
{
    /// <summary>
    /// 
    /// </summary>
    public class Volatility
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volatility")]
        public double? VolatilityData { get; set; }
    }
}
