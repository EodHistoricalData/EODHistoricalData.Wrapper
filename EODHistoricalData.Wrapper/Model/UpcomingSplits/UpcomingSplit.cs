using System;
using System.Collections.Generic;

namespace EOD.Model.UpcomingSplits
{
	/// <summary>
	/// 
	/// </summary>
	public class UpcomingSplit
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
		public DateTime? From { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? To { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public List<Split> Splits { get; set; }
	}
}

