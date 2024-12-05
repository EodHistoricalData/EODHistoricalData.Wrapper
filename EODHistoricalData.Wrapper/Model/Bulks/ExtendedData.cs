using System;

namespace EOD.Model.Bulks
{
	/// <summary>
	/// 
	/// </summary>
	public class ExtendedData
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
		public string Exchange_Short_Name { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? MarketCapitalization { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Open { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? High { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Low { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Close { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Adjusted_Close { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public long? Volume { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Ema_50d { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Ema_200d { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Hi_250d { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Lo_250d { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Prev_Close { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Change { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Change_P { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public decimal? Avgvol_14d { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public decimal? Avgvol_50d { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public decimal? Avgvol_200d { get; set; }
	}
}


