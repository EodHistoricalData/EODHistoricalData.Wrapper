using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class WorldRegionETF
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("North America")]
		public WorldData NorthAmerica { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("United Kingdom")]
		public WorldData UnitedKingdom { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Europe Developed")]
		public WorldData EuropeDeveloped { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Europe Emerging")]
		public WorldData EuropeEmerging { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Africa/Middle East")]
		public WorldData AfricaMiddleEast { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public WorldData Japan { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public WorldData Australasia { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Asia Developed")]
		public WorldData AsiaDeveloped { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Asia Emerging")]
		public WorldData AsiaEmerging { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Latin America")]
		public WorldData LatinAmerica { get; set; }
	}
}
