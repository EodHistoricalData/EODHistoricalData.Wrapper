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
    }
}