using System.Collections.Generic;

namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class Earnings
	{
		/// <summary>
		/// 
		/// </summary>
		public Dictionary<string, EarningsHistoryData> History { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public Dictionary<string, EarningsTrendData> Trend { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public Dictionary<string, EarningsAnnualData> Annual { get; set; }
	}
}
