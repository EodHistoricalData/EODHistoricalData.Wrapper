using System;

namespace EOD.Model.BulkFundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class SplitsDividends
    {
        /// <summary>
        /// 
        /// </summary>
        public double? ForwardAnnualDividendRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ForwardAnnualDividendYield { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? PayoutRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DividendDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ExDividendDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LastSplitFactor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LastSplitDate { get; set; }
    }
}

