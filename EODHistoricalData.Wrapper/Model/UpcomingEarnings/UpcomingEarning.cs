using System.Collections.Generic;

namespace EOD.Model.UpcomingEarnings
{
	/// <summary>
	/// 
	/// </summary>
	public class UpcomingEarning
	{
		/// <summary>
		/// 
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Symbols { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public List<Earning> Earnings { get; set; }
	}
}

