using System;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class Highlights
    {
        /// <summary>
        /// 
        /// </summary>
        public long? MarketCapitalization { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? MarketCapitalizationMln { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? EBITDA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? PERatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? PEGRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? WallStreetTargetPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? BookValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? DividendShare { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? DividendYield { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? EarningsShare { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? EPSEstimateCurrentYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? EPSEstimateNextYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? EPSEstimateNextQuarter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? EPSEstimateCurrentQuarter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? MostRecentQuarter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ProfitMargin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? OperatingMarginTTM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ReturnOnAssetsTTM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ReturnOnEquityTTM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? RevenueTTM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? RevenuePerShareTTM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? QuarterlyRevenueGrowthYOY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? GrossProfitTTM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? DilutedEpsTTM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? QuarterlyEarningsGrowthYOY { get; set; }
    }
}
