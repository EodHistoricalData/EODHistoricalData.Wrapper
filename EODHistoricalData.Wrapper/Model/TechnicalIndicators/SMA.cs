using Newtonsoft.Json;
using System;

namespace EOD.Model.TechnicalIndicators
{
    /// <summary>
    /// 
    /// </summary>
    public class SMA
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sma")]
        public double? SMAData { get; set; }
    }
}
