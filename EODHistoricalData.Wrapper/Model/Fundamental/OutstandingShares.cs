using System;
using System.Collections.Generic;
using System.Text;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class OutstandingShares
    {
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, OutstandingSharesData> Annual { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, OutstandingSharesData> Quarterly { get; set; }
    }
}
