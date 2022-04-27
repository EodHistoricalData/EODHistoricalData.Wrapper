using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class GrowthRateData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Long-Term Projected Earnings Growth")]
        public double? LongTermProjectedEarningsGrowth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Historical Earnings Growth")]
        public double? HistoricalEarningsGrowth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Sales Growth")]
        public double? SalesGrowth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Cash-Flow Growth")]
        public double? CashFlowGrowth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Book-Value Growth")]
        public double? BookValueGrowth { get; set; }
    }
}
