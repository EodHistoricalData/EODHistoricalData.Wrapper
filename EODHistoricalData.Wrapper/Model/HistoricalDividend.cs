using System;

namespace EOD.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class HistoricalDividend
	{
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DeclarationDate { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RecordDate { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PaymentDate { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Period { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Value { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? UnadjustedValue { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Currency { get; set; }
	}
}
