using System;

namespace EOD.Model.Bulks
{
    /// <summary>
    /// 
    /// </summary>
    public class Bulk
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Exchange_Short_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Open { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string High { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Low { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Close { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Adjusted_Close { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Volume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Prev_Close { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Change { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Change_p { get; set; }
    }
}
