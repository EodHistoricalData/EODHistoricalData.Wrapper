using System;
using System.Collections.Generic;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class MutualFundData
    {
        /// <summary>
        /// 
        /// </summary>
        public string Fund_Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Fund_Style { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Nav { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Prev_Close_Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Update_Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Portfolio_Net_Assets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Share_Class_Net_Assets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Morning_Star_Rating { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Morning_Star_Risk_Rating { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Morning_Star_Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Inception_Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Domicile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Yield { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Yield_YTD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Yield_1Year_YTD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Yield_3Year_YTD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Yield_5Year_YTD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Expense_Ratio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Expense_Ratio_Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<int, AssetAllocation> Asset_Allocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<int, ValueGrowth> Value_Growth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<int, TopHoldings> Top_Holdings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<int, MarketCapitalization> Market_Capitalization { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, Dictionary<int, SectorWeights>> Sector_Weights { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, Dictionary<int, WorldRegion>> World_Regions { get; set; }
    }
}



