using System;

namespace EOD.Model.UpcomingEarnings
{
    /// <summary>
    /// 
    /// </summary>
    public class Earning
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Report_Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Before_After_Market { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Actual { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Estimate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Difference { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Percent { get; set; }
    }
}
