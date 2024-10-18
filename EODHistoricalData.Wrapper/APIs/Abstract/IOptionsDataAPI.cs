using EOD.Model.OptionsData;

using System;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
	/// <summary>
	/// Stock options data
	/// </summary>
	internal interface IOptionalDataAPI
	{
		/// <summary>
		/// Get stock options data
		/// </summary>
		/// <param name="ticker">Consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, 
		/// then you can use, for example, AAPL.MX for Mexican Stock Exchange. 
		/// Or AAPL.US for NASDAQ.</param>
		/// <param name="from">filters OPTIONS by expirationDate. Default value: today.</param>
		/// <param name="to">filters OPTIONS by expirationDate. Default value: '2100-01-01'.</param>
		/// <param name="trade_date_from">filters OPTIONS by lastTradeDateTime. Default value: NONE.</param>
		/// <param name="trade_date_to">filters OPTIONS by lastTradeDateTime. Default value: NONE.</param>
		/// <param name="contract_name">returns only the data for particular contract.</param>
		/// <returns></returns>
		Task<OptionsData> GetOptionsDataAsync(string ticker, DateTime? from = null, DateTime? to = null, DateTime? trade_date_from = null, DateTime? trade_date_to = null, string contract_name = null);
	}
}
