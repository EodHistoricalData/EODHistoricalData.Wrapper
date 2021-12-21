namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class Income_Statement
    {
        /// <summary>
        /// 
        /// </summary>
        public string? Currency_symbol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<DateTime, Income_StatementData>? Quarterly { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<DateTime, Income_StatementData>? Yearly { get; set; }
    }
}
