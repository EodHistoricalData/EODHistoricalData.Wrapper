using System;

namespace EOD.Model.TechnicalIndicators
{
	/// <summary>
	/// 
	/// </summary>
	public class BollingerBands
	{
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Uband { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Mband { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Lband { get; set; }
	}
}
