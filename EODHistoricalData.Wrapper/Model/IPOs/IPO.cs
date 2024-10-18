using System;

namespace EOD.Model.IPOs
{
	/// <summary>
	/// 
	/// </summary>
	public class IPO
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
		public string Exchange { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Currency { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Start_Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Filling_Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Amended_Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Price_From { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Price_To { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Offer_Price { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public long? Shares { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Deal_Type { get; set; }
	}
}
