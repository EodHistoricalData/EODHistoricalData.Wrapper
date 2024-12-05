using System;

namespace EOD.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class EconomicEventData
	{
		/// <summary>
		/// 
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Comparison { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Period { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Country { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Actual { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Previous { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Estimate { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Change { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Change_Percentage { get; set; }
	}
}
