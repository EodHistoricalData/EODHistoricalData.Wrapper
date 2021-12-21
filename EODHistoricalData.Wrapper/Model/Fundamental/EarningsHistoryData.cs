namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class EarningsHistoryData
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ReportDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? BeforeAfterMarket { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? EpsActual { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? EpsEstimate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? EpsDifference { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? SurprisePercent { get; set; }
    }
}
