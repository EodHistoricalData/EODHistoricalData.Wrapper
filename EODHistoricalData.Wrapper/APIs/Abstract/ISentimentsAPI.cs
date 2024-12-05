using EOD.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
	/// <summary>
	/// Stock options data
	/// </summary>
	internal interface ISentimentsAPI
	{
		/// <summary>
		/// To get the aggregated sentiment data
		/// </summary>
		/// <param name="symbols">[REQUIRED]</param>
		/// <param name="from">[OPTIONAL]</param>
		/// <param name="to">[OPTIONAL]</param>
		/// <param name="tweets">[OPTIONAL]</param>
		/// <returns></returns>
		Task<Dictionary<string, List<SentimentsData>>> GetSentimentsAsync(List<string> symbols, DateTime? from = null, DateTime? to = null, bool? tweets = null);
	}
}
