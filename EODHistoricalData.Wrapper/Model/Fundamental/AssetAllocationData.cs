using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class AssetAllocationData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Long_%")]
        public double? LongPercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Short_%")]
        public double? ShortPercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Net_Assets_%")]
        public double? NetAssetsPercent { get; set; }
    }
}
