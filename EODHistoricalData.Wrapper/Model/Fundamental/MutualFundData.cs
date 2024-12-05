using Newtonsoft.Json;
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
		public string Update_Date { get; set; }
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
		public string Inception_Date { get; set; }
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
		public string Expense_Ratio_Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Asset_Allocation")]
		public Dictionary<int, AssetAllocation> Asset_Allocation { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("asset_allocation")]
		public string Asset_allocation { get; set; }

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
		[JsonProperty("Market_Capitalization")]
		public Dictionary<int, MarketCapitalization> Market_Capitalization { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("market_capitalization")]
		public string Market_capitalization { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public Dictionary<string, Dictionary<int, SectorWeights>> Sector_Weights { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("sector_weights")]
		public string Sector_weights { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public Dictionary<string, Dictionary<int, WorldRegion>> World_Regions { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("world_regions")]
		public string World_regions { get; set; }
	}
}



