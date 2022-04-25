using System.Collections.Generic;

namespace EOD.Model.EarningTrends
{
    /// <summary>
    /// 
    /// </summary>
    public class EarningTrend
    {
        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Symbols { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, CompanyTrend[]> CompanyTrends { get; set; }
    }
}
