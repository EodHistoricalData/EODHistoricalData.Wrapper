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
        public ETFData ETFData { get; set; }
        /// <summary>
        /// 
        /// </summary>
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
