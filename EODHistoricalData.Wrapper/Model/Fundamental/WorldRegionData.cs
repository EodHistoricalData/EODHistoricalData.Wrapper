using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class WorldData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Equity_%")]
        public double? EquityPercent { get; set; }
    }
}