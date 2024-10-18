using Newtonsoft.Json;
using System;

namespace EOD.Model.TechnicalIndicators
{
	/// <summary>
	/// 
	/// </summary>
	public class Slope
	{
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("slope")]
		public double? SlopeData { get; set; }
	}
}
