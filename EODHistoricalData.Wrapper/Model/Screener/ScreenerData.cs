using System;

namespace EOD.Model.Screener
{
    /// <summary>
    /// 
    /// </summary>
    public class ScreenerData
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? LastDayDataDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? AdjustedClose { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Refund1d { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? Refund1dP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? Refund5d { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? Refund5dP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Exchange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CurrencySymbol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? MarketCapitalization { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? EarningsShare { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? DividendYield { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Sector { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Industry { get; set; }

    }
}
