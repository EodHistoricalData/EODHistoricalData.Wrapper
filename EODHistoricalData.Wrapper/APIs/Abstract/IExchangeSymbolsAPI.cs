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
