using Newtonsoft.Json;
using System.Collections.Generic;

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
        public General General { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Highlights Highlights { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Valuation Valuation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SharesStats SharesStats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SplitsDividends SplitsDividends { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public AnalystRatings AnalystRatings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Holders Holders { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, InsiderTransactions> InsiderTransactions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ESGScores ESGScores { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public OutstandingShares OutstandingShares { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Earnings Earnings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Financials Financials { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Technicals Technicals { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ETFData ETF_Data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MutualFund_Data")] 
        public MutualFundData MutualFund_Data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<int, Component> Components { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<int, HistoricalComponent> HistoricalTickerComponents { get; set; }
    }
}
