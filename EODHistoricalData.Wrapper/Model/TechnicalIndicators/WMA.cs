using Newtonsoft.Json;
using System;

namespace EOD.Model.TechnicalIndicators
{
    /// <summary>
    /// 
    /// </summary>
    public class WMA
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("wma")]
        public double? WMAData { get; set; }
    }
}
