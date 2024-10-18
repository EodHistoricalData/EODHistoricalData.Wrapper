using EOD.Model;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
	internal interface IEconomicEventDataAPI
	{
		/// <summary>
		/// To get the full list of supported exchanges with names, codes, operating MICs, country, and currency
		/// </summary>
		Task<List<EconomicEventData>> GetEconomicEventsDataAsync(DateTime? from = null, DateTime? to = null,
			string country = null, string comparison = null, int? offset = null, int? limit = null);
	}
}
