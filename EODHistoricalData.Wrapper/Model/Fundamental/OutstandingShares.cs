using System.Collections.Generic;

namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class OutstandingShares
	{
		/// <summary>
		/// 
		/// </summary>
		public Dictionary<string, OutstandingSharesData> Annual { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public Dictionary<string, OutstandingSharesData> Quarterly { get; set; }
	}
}
