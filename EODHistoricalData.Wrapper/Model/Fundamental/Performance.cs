using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class Performance
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("1y_Volatility")]
		public double? Volatility1y { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("3y_Volatility")]
		public double? Volatility3y { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("3y_ExpReturn")]
		public double? ExpReturn3y { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("3y_SharpRatio")]
		public double? SharpRatio3y { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Returns_YTD")]
		public double? Returns_YTD { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Returns_1Y")]
		public double? Returns_1Y { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Returns_3Y")]
		public double? Returns_3Y { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Returns_5Y")]
		public double? Returns_5Y { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Returns_10Y")]
		public double? Returns_10Y { get; set; }

	}
}
