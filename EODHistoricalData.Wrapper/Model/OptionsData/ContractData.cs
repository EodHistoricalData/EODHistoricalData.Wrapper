using Newtonsoft.Json;
using System;

namespace EOD.Model.OptionsData
{
    /// <summary>
    /// 
    /// </summary>
    public class ContractData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("contractName")]
        public string ContractName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("contractSize")]
        public string ContractSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("contractPeriod")]
        public string ContractPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inTheMoney")]
        public string InTheMoney { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lastTradeDateTime")]
        public string LastTradeDateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("strike")]
        public long? Strike { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lastPrice")]
        public double? LastPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bid")]
        public double? Bid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ask")]
        public double? Ask { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("change")]
        public double? Change { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("changePercent")]
        public double? ChangePercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volume")]
        public long? Volume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("openInterest")]
        public long? OpenInterest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("impliedVolatility")]
        public double? ImpliedVolatility { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("delta")]
        public double? Delta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gamma")]
        public double? Gamma { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("theta")]
        public double? Theta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vega")]
        public double? Vega { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rho")]
        public double? Rho { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("theoretical")]
        public double? Theoretical { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("intrinsicValue")]
        public double? IntrinsicValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("timeValue")]
        public double? TimeValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("daysBeforeExpiration")]
        public uint? DaysBeforeExpiration { get; set; }
    }
}
