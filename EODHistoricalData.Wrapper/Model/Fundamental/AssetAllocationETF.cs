using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class AssetAllocationETF
	{
		/// <summary>
		/// 
		/// </summary>
		public AssetAllocationData Cash { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public AssetAllocationData NotClassified { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Stock non-US")]
		public AssetAllocationData StocknonUS { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public AssetAllocationData Other { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Stock US")]
		public AssetAllocationData StockUS { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public AssetAllocationData Bond { get; set; }
	}
}

