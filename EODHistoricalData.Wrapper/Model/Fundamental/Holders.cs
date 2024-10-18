using System.Collections.Generic;

namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class Holders
	{
		/// <summary>
		/// 
		/// </summary>
		public Dictionary<string, HoldersData> Institutions { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public Dictionary<string, HoldersData> Funds { get; set; }
	}
}
