using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class ValuationsRatesData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Price/Prospective Earnings")]
        public double? PriceProspectiveEarnings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Price/Book")]
        public double? PriceBook { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Price/Sales")]
        public double? PriceSales { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Price/Cash Flow")]
        public double? PriceCashFlow { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Dividend-Yield Factor")]
        public double? DividendYieldFactor { get; set; }
    }
}
