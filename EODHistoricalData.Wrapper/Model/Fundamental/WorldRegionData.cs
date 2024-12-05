using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class WorldData
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Equity_%")]
		public double? EquityPercent { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Relative_to_Category")]
		public double? RelativeToCategory { get; set; }
	}
}