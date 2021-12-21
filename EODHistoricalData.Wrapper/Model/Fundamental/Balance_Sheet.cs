namespace EOD.Model.Fundamental
{
    /// <summary>
    /// Balance Sheet
    /// </summary>
    public class Balance_Sheet
    {
        /// <summary>
        /// Currency_symbol
        /// </summary>
        public string? Currency_symbol { get; set; }
        /// <summary>
        /// Quarterly
        /// </summary>
        public Dictionary<DateTime, Balance_SheetData>? Quarterly { get; set; }
        /// <summary>
        /// Yearly
        /// </summary>
        public Dictionary<DateTime, Balance_SheetData>? Yearly { get; set; }
    }
}
