using EOD.Model.Fundamental;
using System.Collections.Generic;

namespace EOD.Model.BulkFundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class BulkFundamentalData
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
        /// Extended
        /// </summary>
        public SharesStats SharesStats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Technicals Technicals { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SplitsDividends SplitsDividends { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, BulkEarnings> Earnings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Financials Financials { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public AnalystRatings AnalystRatings { get; set; }
    }
}

