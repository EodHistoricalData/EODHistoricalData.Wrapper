using Newtonsoft.Json;
using System.Collections.Generic;

namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class ETFData
	{
		/// <summary>
		/// 
		/// </summary>
		public string ISIN { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Company_Name { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Company_URL { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string ETF_URL { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Domicile { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Index_Name { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Yield { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Dividend_Paying_Frequency { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Inception_Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Max_Annual_Mgmt_Charge { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Ongoing_Charge { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Date_Ongoing_Charge { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NetExpenseRatio { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? AnnualHoldingsTurnover { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalAssets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("none")]
		public decimal? Average_Mkt_Cap_Mil
		{
			get => decimal.TryParse(Average_Mkt_Cap_Mil_String, out decimal result) ? result : 0;
			set { }
		}
		[JsonProperty("Average_Mkt_Cap_Mil")]
		private string Average_Mkt_Cap_Mil_String { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public MarketCapitalisationETF Market_Capitalisation { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public AssetAllocationETF Asset_Allocation { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public WorldRegionETF World_Regions { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public SectorWeightETF Sector_Weights { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public Dictionary<string, FixedIncomeData> Fixed_Income { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public long? Holdings_Count { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public Dictionary<string, Holding> Top_10_Holdings { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public Dictionary<string, Holding> Holdings { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public ValuationsGrowth Valuations_Growth { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public MorningStar MorningStar { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public Performance Performance { get; set; }

	}
}

