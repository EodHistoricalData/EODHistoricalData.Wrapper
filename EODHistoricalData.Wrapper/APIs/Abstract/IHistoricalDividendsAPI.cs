using EOD.Model;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
	/// <summary>
	/// Historical Dividends API
	/// </summary>
	internal interface IHistoricalDividendsAPI
	{
		Task<List<HistoricalDividend>> GetDataAsync(string ticker, DateTime? from, DateTime? to);

		Task<List<HistoricalSplit>> GetHistoricalSplitsAsync(string ticker, DateTime? from, DateTime? to);
	}
}
