using System;
using System.Collections.Generic;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class Earnings
    {
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<DateTime, EarningsHistoryData> History { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<DateTime, EarningsTrendData> Trend { get; set; }
    }
}
