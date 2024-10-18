using EOD.Utils;
using Newtonsoft.Json;
using System;

namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class Cash_FlowData
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Date")]
		private string DateJSON { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("none0")]
		public DateTime? Date { get => GetDate.ParseDate(DateJSON); }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Filing_date")]
		private string Filing_dateJSON { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("none1")]
		public DateTime? Filing_date { get => GetDate.ParseDate(Filing_dateJSON); }
		/// <summary>
		/// 
		/// </summary>
		public string Currency_symbol { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Investments { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ChangeToLiabilities { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TotalCashflowsFromInvestingActivities { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NetBorrowings { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TotalCashFromFinancingActivities { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ChangeToOperatingActivities { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NetIncome { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ChangeInCash { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? BeginPeriodCashFlow { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EndPeriodCashFlow { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TotalCashFromOperatingActivities { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Depreciation { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? OtherCashflowsFromInvestingActivities { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? DividendsPaid { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ChangeToInventory { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ChangeToAccountReceivables { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? SalePurchaseOfStock { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? OtherCashflowsFromFinancingActivities { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ChangeToNetincome { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? CapitalExpenditures { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ChangeReceivables { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? CashFlowsOtherOperating { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ExchangeRateChanges { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? CashAndCashEquivalentsChanges { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ChangeInWorkingCapital { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? StockBasedCompensation { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? OtherNonCashItems { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? FreeCashFlow { get; set; }

	}
}
