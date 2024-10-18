using EOD.Utils;
using Newtonsoft.Json;
using System;

namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class EarningsAnnualData
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Date")]
		private string DateJSON { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("none0")]
		public DateTime? Date { get => GetDate.ParseDate(DateJSON); }
		/// <summary>
		/// 
		/// </summary>
		public double? EpsActual { get; set; }
	}
}
