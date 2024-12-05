using EOD.Utils;
using Newtonsoft.Json;
using System;

namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class OutstandingSharesData
	{
		/// <summary>
		/// 
		/// </summary>
		public string Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("DateFormatted")]
		private string DateFormattedJSON { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("none0")]
		public DateTime? DateFormatted { get => GetDate.ParseDate(DateFormattedJSON); }
		/// <summary>
		/// 
		/// </summary>
		public string SharesMln { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public decimal? Shares { get; set; }
	}
}
