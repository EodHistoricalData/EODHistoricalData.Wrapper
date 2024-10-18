using EOD.Utils;
using Newtonsoft.Json;
using System;

namespace EOD.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class SentimentsData
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
		public int? Count { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Normalized { get; set; }
	}
}
