using Newtonsoft.Json;

namespace EOD.Model.BulkFundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class Balance_SheetData
	{
		/// <summary>
		/// 
		/// </summary>
		public string Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Filing_date { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		[JsonProperty("currency_symbol")]
		public string CurrencySymbol { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TotalAssets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? IntangibleAssets { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? EarningAssets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? OtherCurrentAssets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TotalLiab { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TotalStockholderEquity { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? DeferredLongTermLiab { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? OtherCurrentLiab { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? CommonStock { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? CapitalStock { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? RetainedEarnings { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? OtherLiab { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? GoodWill { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? OtherAssets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Cash { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? СashAndEquivalents { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TotalCurrentLiabilities { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? CurrentDeferredRevenue { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? NetDebt { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? ShortTermDebt { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ShortLongTermDebt { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? ShortLongTermDebtTotal { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? OtherStockholderEquity { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? PropertyPlantEquipment { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TotalCurrentAssets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? LongTermInvestments { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NetTangibleAssets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ShortTermInvestments { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NetReceivables { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? LongTermDebt { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Inventory { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? AccountsPayable { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? TotalPermanentEquity { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? NoncontrollingInterestInConsolidatedEntity { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? TemporaryEquityRedeemableNoncontrollingInterests { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? AccumulatedOtherComprehensiveIncome { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? AdditionalPaidInCapital { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? CommonStockTotalEquity { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? PreferredStockTotalEquity { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? RetainedEarningsTotalEquity { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? TreasuryStock { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? AccumulatedAmortization { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? NonCurrrentAssetsOther { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? DeferredLongTermAssetCharges { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? NonCurrentAssetsTotal { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? CapitalLeaseObligations { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? LongTermDebtTotal { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? NonCurrentLiabilitiesOther { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? NonCurrentLiabilitiesTotal { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? NegativeGoodwill { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? Warrants { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? PreferredStockRedeemable { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? CapitalSurpluse { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? LiabilitiesAndStockholdersEquity { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? CashAndShortTermInvestments { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? PropertyPlantAndEquipmentGross { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? PropertyPlantAndEquipmentNet { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? AccumulatedDepreciation { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? NetWorkingCapital { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? NetInvestedCapital { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public double? CommonStockSharesOutstanding { get; set; }
	}
}
