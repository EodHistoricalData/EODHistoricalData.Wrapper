using EOD.Model;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
	/// <summary>
	/// Financial news API
	/// </summary>
	internal interface IFinancialNewsAPI
	{
		Task<List<FinancialNews>> GetFinancialNewsAsync(string s = null, string t = null,
			DateTime? from = null, DateTime? to = null, int? limit = null, int? offset = null);
	}
}
