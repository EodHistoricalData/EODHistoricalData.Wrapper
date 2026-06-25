using Newtonsoft.Json;
using System.Collections.Generic;
using EODHistoricalData.Wrapper.Utils;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class FundamentalData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public General General { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public Highlights Highlights { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public Valuation Valuation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public SharesStats SharesStats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public SplitsDividends SplitsDividends { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public AnalystRatings AnalystRatings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public Holders Holders { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public Dictionary<string, InsiderTransactions> InsiderTransactions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public ESGScores ESGScores { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public OutstandingShares OutstandingShares { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public Earnings Earnings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public Financials Financials { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public Technicals Technicals { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public ETFData ETF_Data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        [JsonProperty("MutualFund_Data")] 
        public MutualFundData MutualFund_Data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public Dictionary<int, Component> Components { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public Dictionary<int, HistoricalComponent> HistoricalTickerComponents { get; set; }
        /// <summary>
        /// for Crypto
        /// </summary>
        [JsonConverter(typeof(NaStringToNullConverter))]
        public Statistics Statistics { get; set; }
    }
}
