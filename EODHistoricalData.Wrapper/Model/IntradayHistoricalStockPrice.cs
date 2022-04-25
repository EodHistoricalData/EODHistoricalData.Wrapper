using System;

namespace EOD.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IntradayHistoricalStockPrice
    {
        /// <summary>
        /// 
        /// </summary>
        public long? Timestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Gmtoffset { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateTime { get; set; }
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
        public decimal? Volume { get; set; }
    }
}
