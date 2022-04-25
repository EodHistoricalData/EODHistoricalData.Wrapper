using System;

namespace EOD.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BondHistoricalData
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Yield { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Volume { get; set; }
    }
}

