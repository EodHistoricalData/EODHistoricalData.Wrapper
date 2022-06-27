using Newtonsoft.Json;

namespace EOD.Model.BulkFundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class Technicals
    {
        /// <summary>
        /// 
        /// </summary>
        public double? Beta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("52WeekHigh")]
        public double? Week52High { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("52WeekLow")]
        public double? Week52Low { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("50DayMA")]
        public double? Day50MA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("200DayMA")]
        public double? Day200MA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? SharesShort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? SharesShortPriorMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ShortRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ShortPercent { get; set; }
    }
}
