using System;

namespace EOD.Model.UpcomingSplits
{
    /// <summary>
    /// 
    /// </summary>
    public class Split
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? SplitDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Optionable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? OldShares { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? NewShares { get; set; }
    }
}
