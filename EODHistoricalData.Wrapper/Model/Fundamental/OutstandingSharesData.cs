using System;
using System.Collections.Generic;
using System.Text;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class OutstandingSharesData
    {
        /// <summary>
        /// 
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateFormatted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SharesMln { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Shares { get; set; }
    }
}
