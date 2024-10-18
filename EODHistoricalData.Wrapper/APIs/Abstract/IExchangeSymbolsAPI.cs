using EOD.Model;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
	internal interface IExchangeSymbolsAPI
	{
		/// <summary>
		/// To get a list of symbols for exchange
		/// </summary>
		Task<List<ExchangeSymbol>> GetExchangeSymbolsAsync(string code);
	}
}
