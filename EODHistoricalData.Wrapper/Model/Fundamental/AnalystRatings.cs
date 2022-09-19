using System;
using System.Collections.Generic;
using System.Text;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public  class AnalystRatings
    {
        /// <summary>
        /// 
        /// </summary>
        public double? Rating { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TargetPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? StrongBuy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Buy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Sell { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? StrongSell { get; set; }
    }
}
