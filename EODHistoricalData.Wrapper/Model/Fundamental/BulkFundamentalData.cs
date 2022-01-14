namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class BulkFundamentalData
    {
        /// <summary>
        /// 
        /// </summary>
        public General? General { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Highlights? Highlights { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Valuation? Valuation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SplitsDividends? SplitsDividends { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, BulkEarnings>? Earnings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, Financials>? Financials { get; set; }
    }
}

