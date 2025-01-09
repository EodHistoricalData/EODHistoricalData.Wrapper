using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class SectorWeightETF
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Basic Materials")]
        public WorldData BasicMaterials { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Consumer Cyclicals")]
        public WorldData ConsumerCyclicals { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Financial Services")]
        public WorldData FinancialServices { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public WorldData Energy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public WorldData Industrials { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public WorldData Technology { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Consumer Defensive")]
        public WorldData ConsumerDefencive { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public WorldData Healthcare { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public WorldData Utilities { get; set; }
    }
}

