namespace EOD.Model.Fundamental
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
        public DateTime? DividendDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ExDividendDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? LastSplitFactor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? LastSplitDate { get; set; }
    }
}

