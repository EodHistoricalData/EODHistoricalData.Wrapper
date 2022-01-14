namespace EOD.Model.TechnicalIndicators
{
    /// <summary>
    /// 
    /// </summary>
    public class MovingAverageConvergence
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Macd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Signal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Divergence { get; set; }
    }
}