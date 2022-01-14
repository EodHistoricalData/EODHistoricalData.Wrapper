namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class ValuationsGrowth
    {
        /// <summary>
        /// 
        /// </summary>
        public ValuationsRatesData? ValuationsRatesPortfolio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ValuationsRatesData? ValuationsRatesToCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public GrowthRateData? GrowthRatesPortfolio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public GrowthRateData? GrowthRatesToCategory { get; set; }
    }
}
