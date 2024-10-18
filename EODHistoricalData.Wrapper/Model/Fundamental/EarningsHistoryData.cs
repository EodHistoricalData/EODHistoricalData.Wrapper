using EOD.Utils;
using Newtonsoft.Json;
using System;

namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class EarningsHistoryData
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("ReportDate")]
		private string ReportDateJSON { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("none0")]
		public DateTime? ReportDate { get => GetDate.ParseDate(ReportDateJSON); }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Date")]
		private string DateJSON { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("none1")]
		public DateTime? Date { get => GetDate.ParseDate(DateJSON); }
		/// <summary>
		/// 
		/// </summary>
		public string BeforeAfterMarket { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Currency { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EpsActual { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EpsEstimate { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EpsDifference { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? SurprisePercent { get; set; }
	}
}
