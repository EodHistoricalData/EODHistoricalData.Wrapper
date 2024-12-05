using EOD.Model.EarningTrends;
using System.Collections.Generic;

namespace EOD.Model.BulkFundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class BulkEarnings
	{
		/// <summary>
		/// 
		/// </summary>
		public string Date { get; set; }
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
		/// <summary>
		/// Extended (date-values)
		/// </summary>
		public Dictionary<string, Trend> Trend { get; set; }
	}
}


