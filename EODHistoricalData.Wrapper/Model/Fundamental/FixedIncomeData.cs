using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class FixedIncomeData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Fund_%")]
        public double? FundPercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Relative_to_Category")]
        public double? RelativeToCategory { get; set; }
    }
}