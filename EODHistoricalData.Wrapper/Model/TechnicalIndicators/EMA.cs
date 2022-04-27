using Newtonsoft.Json;
using System;

namespace EOD.Model.TechnicalIndicators
{
    /// <summary>
    /// 
    /// </summary>
    public class EMA
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ema")]
        public double? EMAData { get; set; }
    }
}
