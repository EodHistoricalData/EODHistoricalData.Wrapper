using System;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class HoldersData
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? TotalShares { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? TotalAssets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? CurrentShares { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Change { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Change_p { get; set; }
    }
}
