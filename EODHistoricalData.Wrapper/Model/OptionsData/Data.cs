using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EOD.Model.OptionsData
{
	/// <summary>
	/// 
	/// </summary>
	public class Data
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("expirationDate")]
		public DateTime? ExpirationDate { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("impliedVolatility")]
		public double? ImpliedVolatility { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("putVolume")]
		public long? PutVolume { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("callVolume")]
		public long? CallVolume { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("putCallVolumeRatio")]
		public double? PutCallVolumeRatio { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("putOpenInterest")]
		public long? PutOpenInterest { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("callOpenInterest")]
		public long? CallOpenInterest { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("putCallOpenInterestRatio")]
		public double? PutCallOpenInterestRatio { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("optionsCount")]
		public long? OptionsCount { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("options")]
		public Dictionary<string, List<ContractData>> Options { get; set; }
	}
}