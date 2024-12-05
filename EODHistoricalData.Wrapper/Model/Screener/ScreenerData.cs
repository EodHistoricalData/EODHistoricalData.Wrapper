using System;

namespace EOD.Model.Screener
{
	/// <summary>
	/// 
	/// </summary>
	public class ScreenerData
	{
		/// <summary>
		/// 
		/// </summary>
		public string Code { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Last_Day_Data_Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Adjusted_Close { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Refund_1d { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public double? Refund_1dP { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public double? Refund_5d { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public decimal? Refund_5dP { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Exchange { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Currency_Symbol { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public decimal? Market_Capitalization { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Earnings_Share { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Dividend_Yield { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Sector { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Industry { get; set; }

	}
}
