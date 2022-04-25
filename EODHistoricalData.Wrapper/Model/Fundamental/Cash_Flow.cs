using System;
using System.Collections.Generic;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class Cash_Flow
    {
        /// <summary>
        /// 
        /// </summary>
        public string Currency_symbol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<DateTime, Cash_FlowData> Quarterly { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<DateTime, Cash_FlowData> Yearly { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Cash_FlowData Quarterly_last_0 { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Cash_FlowData Quarterly_last_1 { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Cash_FlowData Quarterly_last_2 { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Cash_FlowData Quarterly_last_3 { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Cash_FlowData Yearly_last_0 { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Cash_FlowData Yearly_last_1 { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Cash_FlowData Yearly_last_2 { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Cash_FlowData Yearly_last_3 { get; set; }
    }
}
