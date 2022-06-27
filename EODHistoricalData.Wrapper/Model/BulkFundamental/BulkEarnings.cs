using System;

namespace EOD.Model.BulkFundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class BulkEarnings
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date { get; set; }
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


