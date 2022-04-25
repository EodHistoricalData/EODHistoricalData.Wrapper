using System;

namespace EOD.Model.Bulks
{
    /// <summary>
    /// 
    /// </summary>
    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ExchangeShortName { get; set; }
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
        public double? AdjustedClose { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Volume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? PrevClose { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Change { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ChangeP { get; set; }
    }
}

