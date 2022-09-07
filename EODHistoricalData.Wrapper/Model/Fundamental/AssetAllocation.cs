using Newtonsoft.Json;
using System.Collections.Generic;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class AssetAllocation
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Net_%")]
        public string NetPercentage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Long_%")]
        public string LongPercentage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Type")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Short_%")]
        public string ShortPercentage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Category_Average")]
        public string Category_Average { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Benchmark")]
        public string Benchmark { get; set; }
    }
}


