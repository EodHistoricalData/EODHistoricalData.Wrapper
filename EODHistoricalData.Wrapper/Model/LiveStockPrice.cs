namespace EOD.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LiveStockPrice
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        public double? PreviousClose { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Change { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Change_p { get; set; }
    }
}
