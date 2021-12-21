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
        public string? Currency_symbol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<DateTime, Cash_FlowData>? Quarterly { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<DateTime, Cash_FlowData>? Yearly { get; set; }
    }
}
