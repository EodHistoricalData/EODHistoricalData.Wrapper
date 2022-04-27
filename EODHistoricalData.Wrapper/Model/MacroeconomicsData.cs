using System;

namespace EOD.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MacroeconomicsData
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Open { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? High { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Low { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Close { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Adjusted_Close { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Volume { get; set; }
    }
}
