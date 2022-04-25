using System;
using System.Collections.Generic;

namespace EOD.Model.OptionsData
{
    /// <summary>
    /// 
    /// </summary>
    public class OptionsData
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Exchange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? LastTradeDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? LastTradePrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Data> Data { get; set; }
    }
}
