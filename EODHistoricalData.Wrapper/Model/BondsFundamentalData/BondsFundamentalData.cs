using System;

namespace EOD.Model.BondsFundamentalData
{
    /// <summary>
    /// 
    /// </summary>
    public class BondsFundamentalData
    {
        /// <summary>
        /// 
        /// </summary>
        public string Isin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Cusip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Wkn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Sedol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FIGI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Coupon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? LastTradeDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Maturity_Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? YieldToMaturity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Callable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? NextCallDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MinimumSettlementAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParIntegralMultiple { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ClassificationData ClassificationData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Rating Rating { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IssueData IssueData { get; set; }
    }
}

