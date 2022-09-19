using EOD.Model.Fundamental;
using System;
using System.Collections.Generic;
using System.Text;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class Holders
    {
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, HoldersData> Institutions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, HoldersData> Funds { get; set; }
    }
}
