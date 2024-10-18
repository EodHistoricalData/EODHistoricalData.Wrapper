using Newtonsoft.Json;
using System;

namespace EOD.Model.TechnicalIndicators
{
	/// <summary>
	/// 
	/// </summary>
	public class Stochastic
	{
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("k_values")]
		public double? Kvalues { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("d_values")]
		public double? Dvalues { get; set; }
	}
}
