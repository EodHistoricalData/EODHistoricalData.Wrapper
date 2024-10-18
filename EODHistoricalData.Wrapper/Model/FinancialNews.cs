using System.Collections.Generic;

namespace EOD.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class FinancialNews
	{
		/// <summary>
		/// 
		/// </summary>
		public string Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Link { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public List<string> Symbols { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public List<string> Tags { get; set; }
	}
}
