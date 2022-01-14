using EOD.Model.BondsFundamentalData;
using EOD.Model.Bulks;
using EOD.Model.EarningTrends;
using EOD.Model.ExchangeDetails;
using EOD.Model.IPOs;
using EOD.Model.OptionsData;
using EOD.Model.Screener;
using EOD.Model.TechnicalIndicators;
using EOD.Model.UpcomingEarnings;
using EOD.Model.UpcomingSplits;
using System.Net;

namespace EOD
{
    /// <summary>
    /// Provides clients with access to the library functionality. 
    /// </summary>
    public class API
    {
        private readonly IIntradayHistoricalDataAPI intradayHistoricalDataAPI;
        private readonly IEndOfDayHistoricalDataAPI endOfDayHistoricalDataAPI;
        private readonly IFundamentalDataAPI fundamentalDataAPI;
        private readonly ISearchAPI searchAPI;
        private readonly IUserAPI userAPI;
        private readonly ILiveStockPricesAPI liveStockPricesAPI;
        private readonly IExchangesAPI exchangesAPI;
        private readonly IHistoricalDividendsAPI historicalDividendsAPI;
        private readonly IMacroIndicatorsAPI macroIndicatorsAPI;
        private readonly IExchangeSymbolsAPI exchangeSymbolsAPI;
        private readonly IOptionalDataAPI optionalDataAPI;
        private readonly IEconomicEventDataAPI economicEventDataAPI;
        private readonly IInsiderTransactionsAPI insiderTransactionsAPI;
        private readonly ICalendarAPI calendarAPI;
        private readonly IBondsFundamentalsAndHistoricalAPI bondsFundamentalsAndHistoricalAPI;
        private readonly IBulkAPI bulkAPI;
        private readonly IExchangeDetailsAPI exchangeDetailsAPI;
        private readonly IFinancialNewsAPI financialNewsAPI;
        private readonly IStockMarketScreenerAPI stockMarketScreenerAPI;
        private readonly ITechnicalIndicatorAPI technicalIndicatorAPI;

        #region Enums

        /// <summary>
        /// The period of end of day historical data
        /// </summary>
        public enum HistoricalPeriod
        {
            /// <summary>
            /// 1 day
            /// </summary>
            Daily,
            /// <summary>
            /// 1 week
            /// </summary>
            Weekly,
            /// <summary>
            /// 1 month
            /// </summary>
            Monthly
        }

        /// <summary>
        /// The interval of intraday historical data
        /// </summary>
        public enum IntradayHistoricalInterval
        {
            /// <summary>
            /// 1 minute
            /// </summary>
            OneMinute,
            /// <summary>
            /// 5 minutes
            /// </summary>
            FiveMinutes,
            /// <summary>
            /// 1 hour
            /// </summary>
            OneHour
        }

        /// <summary>
        /// Comparison by some periods
        /// </summary>
        public enum Comparison
        {
            /// <summary>
            /// Month-over-Month
            /// </summary>
            MoM,
            /// <summary>
            /// Quarter-on-Quarter
            /// </summary>
            QoQ,
            /// <summary>
            /// Year-over-Year
            /// </summary>
            YoY
        }

        /// <summary>
        /// Sort response data
        /// </summary>
        public enum Order
        {
            /// <summary>
            /// Ascending order
            /// </summary>
            Ascending,
            /// <summary>
            /// Descending order
            /// </summary>
            Descending
        }

        /// <summary>
        /// Screener API supported fields
        /// </summary>
        public enum Field
        {
            /// <summary>
            /// ticker code - string
            /// </summary>
            Code,
            /// <summary>
            /// ticker name - string
            /// </summary>
            Name,
            /// <summary>
            /// exchange code - string
            /// </summary>
            Exchange,
            /// <summary>
            /// sector - string
            /// </summary>
            Sector,
            /// <summary>
            /// industry - string
            /// </summary>
            Industry,
            /// <summary>
            /// Number - Market Capitalization, the latest value. Please note, that input for market_capitalization in USD
            /// </summary>
            MarketCapitalization,
            /// <summary>
            /// Number - Earnings-per-share (EPS), the latest value.
            /// </summary>
            EarningsShare,
            /// <summary>
            /// Number - Dividend yield, the latest value.
            /// </summary>
            DividendYield,
            /// <summary>
            /// Number - The last day gain/loss in percent. Useful to get top gainers, losers for the past day.
            /// </summary>
            Refund1dP,
            /// <summary>
            /// Number - The last 5 days gain/loss in percent. Useful to get top gainers, losers for the past week.
            /// </summary>
            Refund5dP
        }

        /// <summary>
        /// Screnner API supported operations
        /// </summary>
        public enum Operation
        {
            /// <summary>
            /// to compare strings
            /// </summary>
            Matches,
            /// <summary>
            /// to compare strings and numbers
            /// </summary>
            Equals,
            /// <summary>
            /// to compare numbers
            /// </summary>
            More,
            /// <summary>
            /// to compare numbers
            /// </summary>
            Less,
            /// <summary>
            /// to compare numbers
            /// </summary>
            NotLess,
            /// <summary>
            /// to compare numbers
            /// </summary>
            NotMore,
            /// <summary>
            /// to compare numbers
            /// </summary>
            NotEquals
        }

        #endregion

        /// <summary>
        /// Constructor fasade class API.eod
        /// </summary>
        /// <param name="apiKey">your api key</param>
        /// <param name="proxy">proxy settings</param>
        public API(string apiKey, IWebProxy? proxy = null)
        {
            intradayHistoricalDataAPI = new IntradayHistoricalDataAPI(apiKey, proxy);
            endOfDayHistoricalDataAPI = new EndOfDayHistoriacalDataAPI(apiKey, proxy);
            fundamentalDataAPI = new FundamentalDataAPI(apiKey, proxy);
            searchAPI = new SearchAPI(apiKey, proxy);
            userAPI = new UserAPI(apiKey, proxy);
            liveStockPricesAPI = new LiveStockPricesAPI(apiKey, proxy);
            exchangesAPI = new ExchangesAPI(apiKey, proxy);
            historicalDividendsAPI = new HistoricalDividendsAPI(apiKey, proxy);
            macroIndicatorsAPI = new MacroIndicatorsAPI(apiKey, proxy);
            exchangeSymbolsAPI = new ExchangeSymbolsAPI(apiKey, proxy);
            optionalDataAPI = new OptionsDataAPI(apiKey, proxy);
            economicEventDataAPI = new EconomicEventDataAPI(apiKey, proxy);
            insiderTransactionsAPI = new InsiderTransactionsAPI(apiKey, proxy);
            calendarAPI = new CalendarAPI(apiKey, proxy);
            bondsFundamentalsAndHistoricalAPI = new BondsFundamentalsAndHistoricalAPI(apiKey, proxy);
            bulkAPI = new BulkAPI(apiKey, proxy);
            exchangeDetailsAPI = new ExchangeDetailsAPI(apiKey, proxy);
            financialNewsAPI = new FinancialNewsAPI(apiKey, proxy);
            stockMarketScreenerAPI = new StockMarketScreenerAPI(apiKey, proxy);
            technicalIndicatorAPI = new TechnicalIndicatorAPI(apiKey, proxy);
        }

        /// <summary>
        /// Get intraday historical stock price data
        /// </summary>
        /// <param name="ticker">ticker consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example, AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ.</param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="interval">the possible intervals: ‘5m’ for 5-minutes, ‘1h’ for 1 hour, and ‘1m’ for 1-minute intervals</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<List<IntradayHistoricalStockPrice>> GetIntradayHistoricalStockPriceAsync(string ticker, DateTime from, DateTime to, IntradayHistoricalInterval interval)
        {
            CheckTicker(ticker);

            string intervalToString = interval switch
            {
                IntradayHistoricalInterval.OneMinute => "1m",
                IntradayHistoricalInterval.FiveMinutes => "5m",
                IntradayHistoricalInterval.OneHour => "1h",
                _ => "1m",
            };

            return await intradayHistoricalDataAPI.GetDataAsync(ticker, from, to, intervalToString);
        }

        /// <summary>
        /// Get end-of-day historical stock price data 
        /// </summary>
        /// <param name="ticker">ticker consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example, AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ.</param>
        /// <param name="from">start search period</param>
        /// <param name="to">end search period</param>
        /// <param name="period">search data interval</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<List<HistoricalStockPrice>> GetEndOfDayHistoricalStockPriceAsync(string ticker, DateTime from, DateTime to, HistoricalPeriod period)
        {
            CheckTicker(ticker);

            string periodToString = period switch
            {
                HistoricalPeriod.Daily => "d",
                HistoricalPeriod.Weekly => "w",
                HistoricalPeriod.Monthly => "m",
                _ => "d",
            };

            return await endOfDayHistoricalDataAPI.GetDataAsync(ticker, from, to, periodToString);
        }

        /// <summary>
        /// Get fundamental data feed
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example, AAPL.MX for Mexican Stock Exchange. Or AAPL.US for NASDAQ.</param>
        /// <param name="filters">supports several, comma-separated, filters (for example: filter=Financials::Balance_Sheet::yearly or filter=General::Code,General,Earnings)</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<FundamentalData> GetFundamentalDataAsync(string ticker, string? filters = null)
        {
            CheckTicker(ticker);

            return await fundamentalDataAPI.GetFundamentalsDataAsync(ticker, filters);
        }

        /// <summary>
        /// Bulk Fundamentals Output
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, 
        /// then you can use, for example, AAPL.MX for Mexican Stock Exchange.</param>
        /// <param name="offset">The first symbol you will get</param>
        /// <param name="limit">The number of symbols you will get</param>
        /// <param name="symbols">To get the data for several symbols instead of the entire exchange.
        /// in this case, the exchange code will be ignored</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<BulkFundamental> GetBulkFundamentalsDataAsync(string ticker, int? offset = null, int? limit = null, string? symbols = null)
        {
            if (ticker == string.Empty) throw new ArgumentNullException(nameof(ticker));

            return await fundamentalDataAPI.GetBulkFundamentalsDataAsync(ticker, offset, limit, symbols);
        }

        /// <summary>
        /// Get user data
        /// </summary>
        public async Task<User> GetUserDataAsync()
        {
            return await userAPI.GetUserAsync();
        }

        /// <summary>
        /// Search API for Stocks, ETFs, Mutual Funds, and Indices
        /// </summary>
        /// <param name="searchString">String. REQUIRED. Could be any string with a ticker code or company name. 
        /// Examples: ‘AAPL’, ‘Apple Inc’, ‘Apple’. You can also use ISINs for the search: US0378331005. 
        /// There are no limitations to a minimum number of symbols in the query string</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<List<SearchResult>> GetSearchResultAsync(string searchString)
        {
            if (searchString == string.Empty) throw new ArgumentNullException(nameof(searchString));

            return await searchAPI.GetQuerySearchExtendedAsync(searchString);
        }

        /// <summary>
        /// Get live stock prices data
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use,
        /// for example, AAPL.MX for Mexican Stock Exchange. Or AAPL.US for NASDAQ.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<LiveStockPrice> GetLiveStockPricesAsync(string ticker)
        {
            CheckTicker(ticker);

            return await liveStockPricesAPI.GetLiveStockPricesAsync(ticker);
        }

        /// <summary>
        /// Get the full list of supported exchanges with names, codes, operating MICs, country, and currency 
        /// </summary>
        public async Task<List<Exchange>> GetExchangeAsync()
        {
            return await exchangesAPI.GetExchangeAsync();
        }

        /// <summary>
        /// Get a list of symbols for exchange 
        /// </summary>
        /// /// <param name="code">EXCHANGE_CODE</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<List<ExchangeSymbol>> GetExchangeSymbolsAsync(string code)
        {
            if (code == string.Empty) throw new ArgumentNullException(nameof(code));

            return await exchangeSymbolsAPI.GetExchangeSymbolsAsync(code);
        }

        /// <summary>
        /// Get historical dividends 
        /// </summary>
        /// <param name="ticker">ticker consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use,
        /// for example, AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ.</param>
        /// <param name="from">start search period</param>
        /// <param name="to">end search period</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<List<HistoricalDividend>> GetHistoricalDividendsAsync(string ticker, DateTime from, DateTime to)
        {
            CheckTicker(ticker);

            return await historicalDividendsAPI.GetDataAsync(ticker, from, to);
        }

        /// <summary>
        /// To get splits for any tickers
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}</param>
        /// <param name="from">date from with format “Y-m-d”</param>
        /// <param name="to">date to with format “Y-m-d”</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<List<HistoricalSplit>> GetHistoricalSplitsAsync(string ticker, DateTime from, DateTime to)
        {
            CheckTicker(ticker);

            return await historicalDividendsAPI.GetHistoricalSplitsAsync(ticker, from, to);
        }

        /// <summary>
        /// Get macro indicator
        /// </summary>
        /// <param name="country">Defines the country for which the indicator will be shown. The country should be defined in the Alpha-3 ISO format.</param>
        /// <param name="indicator">Defines which macroeconomics data indicator will be shown.</param>
        /// <returns></returns>
        public async Task<List<MacroIndicator>> GetMacroIndicatorsAsync(string country, string indicator)
        {
            return await macroIndicatorsAPI.GetDataAsync(country, indicator);
        }

        /// <summary>
        /// Get stock optional data
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
        /// <exception cref="ArgumentException"></exception>
        public async Task<OptionsData> GetOptionsDataAsync(string ticker, DateTime? from, DateTime? to, DateTime? trade_date_from, DateTime? trade_date_to, string? contract_name)
        {
            CheckTicker(ticker);

            return await optionalDataAPI.GetOptionsDataAsync(ticker, from, to, trade_date_from, trade_date_to, contract_name);
        }

        /// <summary>
        /// Provides the past and future events from all around the world like Retail Sails, Bond Auctions, PMI Releases and many other Economic Events data
        /// </summary>
        /// <param name="from">Optional. The format is ‘YYYY-MM-DD’.</param>
        /// <param name="to">Optional. The format is ‘YYYY-MM-DD’.</param>
        /// <param name="country">OPTIONAL. The country code in ISO 3166 format, 2 symbols.</param>
        /// <param name="comparison">OPTIONAL. Possible values: mom, qoq, yoy.</param>
        /// <param name="offset">OPTIONAL. Possible values from 0 to 1000.</param>
        /// <param name="limit">OPTIONAL. POssible values from 0 to 1000.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<EconomicEventData>> GetEconomicEventsDataAsync(DateTime? from, DateTime? to, string? country, Comparison? comparison, int? offset, int? limit)
        {
            if (offset < 0 && offset > 1000) throw new ArgumentOutOfRangeException(nameof(offset));
            if (limit < 0 && limit > 1000) throw new ArgumentOutOfRangeException(nameof(offset));

            string? comparisonToString = comparison switch
            {
                Comparison.MoM => "mom",
                Comparison.QoQ => "qoq",
                Comparison.YoY => "yoy",
                _ => null,
            };

            return await economicEventDataAPI.GetEconomicEventsDataAsync(from, to, country, comparisonToString, offset, limit);
        }

        /// <summary>
        /// To get insider transactions
        /// </summary>
        /// <param name="limit">OPTIONAL. The limit for entries per result, from 1 to 1000. Default value: 100.</param>
        /// <param name="from">OPTIONAL. The format is ‘YYYY-MM-DD’.</param>
        /// <param name="to">OPTIONAL. The format is ‘YYYY-MM-DD’.</param>
        /// <param name="ticker">OPTIONAL. To get the data only for Apple Inc (AAPL), use AAPL.US or AAPL ticker code. By default, all possible symbols will be displayed.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<InsiderTransaction>> GetInsiderTransactionsAsync(int? limit, DateTime? from, DateTime? to, string? ticker)
        {
            if (limit < 1 && limit > 1000) throw new ArgumentOutOfRangeException(nameof(limit));

            return await insiderTransactionsAPI.GetInsiderTransactionsAsync(limit, from, to, ticker);
        }

        /// <summary>
        /// To get upcoming earnings
        /// </summary>
        /// <param name="from">OPTIONAL. Format: YYYY-MM-DD. The start date for earnings data, if not provided, today will be used.</param>
        /// <param name="to">OPTIONAL. Format: YYYY-MM-DD. The end date for earnings data, if not provided, today + 7 days will be used.</param>
        /// <param name="ticker">OPTIONAL. You can request specific symbols to get historical and upcoming data. If ‘symbols’ used, then ‘from’ and ‘to’ parameters will be ignored.
        /// You can use one symbol: ‘AAPL.US’ or several symbols separated by a comma: ‘AAPL.US, MS’</param>
        /// <returns></returns>
        public async Task<UpcomingEarning> GetUpcomingEarningsAsync(DateTime? from, DateTime? to, string? ticker)
        {
            return await calendarAPI.GetUpcomingEarningsAsync(from, to, ticker);
        }

        /// <summary>
        /// To get earning trends
        /// </summary>
        /// <param name="ticker">REQUIRED. You can request specific symbols to get historical and upcoming data.
        /// You can use one symbol: ‘AAPL.US’ or several symbols separated by a comma: ‘AAPL.US, MS’</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<EarningTrend> GetEarningTrendsAsync(string ticker)
        {
            CheckTicker(ticker);

            return await calendarAPI.GetEarningTrendsAsync(ticker);
        }

        /// <summary>
        /// To get Upcoming IPOs
        /// </summary>
        /// <param name="from">OPTIONAL. Format: YYYY-MM-DD. The start date for ipos data, if not provided, today will be used.</param>
        /// <param name="to">OPTIONAL. Format: YYYY-MM-DD. The end date for ipos data, if not provided, today + 7 days will be used.</param>
        /// <returns></returns>
        public async Task<UpcomingIPO> GetUpcomingIPOsAsync(DateTime? from = null, DateTime? to = null)
        {
            return await calendarAPI.GetUpcomingIPOsAsync(from, to);
        }

        /// <summary>
        /// To get Upcoming Splits
        /// </summary>
        /// <param name="from">OPTIONAL. Format: YYYY-MM-DD. The start date for splits data, if not provided, today will be used.</param>
        /// <param name="to">OPTIONAL. Format: YYYY-MM-DD. The end date for splits data, if not provided, today + 7 days will be used.</param>
        /// <returns></returns>
        public async Task<UpcomingSplit> GetUpcomingSplitsAsync(DateTime? from = null, DateTime? to = null)
        {
            return await calendarAPI.GetUpcomingSplitsAsync(from, to);
        }

        /// <summary>
        /// To get bonds fundamental data feed
        /// </summary>
        /// <param name="code">CUSIP of a particular bond, it’s also could be an ISIN</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<BondsFundamentalData> GetBondsFundamentalDataAsync(string code)
        {
            if (code == string.Empty) throw new ArgumentNullException(nameof(code));

            return await bondsFundamentalsAndHistoricalAPI.GetBondsFundamendalDataAsync(code);
        }

        /// <summary>
        /// To get bond historical data
        /// </summary>
        /// <param name="code">You should use ISIN ID and “.BOND”</param>
        /// <param name="from">the format is ‘YYYY-MM-DD’.</param>
        /// <param name="to">the format is ‘YYYY-MM-DD’.</param>
        /// <param name="order">Use ‘a’ for ascending dates (from old to new), ‘d’ for descending dates (from new to old)</param>
        /// <param name="period">Period of prices.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<List<BondHistoricalData>> GetBondHistoricalDataAsync(string code, DateTime? from = null, DateTime? to = null, Order? order = null, HistoricalPeriod? period = null)
        {
            if (code == string.Empty) throw new ArgumentNullException(nameof(code));

            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            string periodToString = period switch
            {
                HistoricalPeriod.Daily => "d",
                HistoricalPeriod.Weekly => "w",
                HistoricalPeriod.Monthly => "m",
                _ => "d",
            };

            return await bondsFundamentalsAndHistoricalAPI.GetBondHistoricalDataAsync(code, from, to, orderToString, periodToString);
        }

        /// <summary>
        /// To get macroeconomic data
        /// </summary>
        /// <param name="ticker">"County code + period" or "Bank code" + ".ExchangeCode"</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<List<MacroeconomicsData>> GetMacroeconomicsDataAsync(string ticker)
        {
            if (ticker == string.Empty) throw new ArgumentNullException(nameof(ticker));

            return await macroIndicatorsAPI.GetMacroeconomicsDataAsync(ticker);
        }

        /// <summary>
        /// To get the data for the entire exchange for a particular day
        /// </summary>
        /// <param name="code">country code or ticker</param>
        /// <param name="type">"Splits", "dividends" or empty for EOD</param>
        /// <param name="date">if you need any specific date</param>
        /// <param name="symbols">To download last day data for several symbols, for example, for MSFT and AAPL</param>
        /// <returns></returns>
        public async Task<List<Bulk>> GetBulksAsync(string code, string? type, DateTime? date, string? symbols)
        {
            return await bulkAPI.GetBulksAsync(code, type, date, symbols);
        }

        /// <summary>
        /// If you need more data for the entire exchange for a particular day, like company name, EMA 50 and EMA 200 and average volumes for 14, 50 and 200 days.
        /// </summary>
        /// <param name="code">country code or ticker</param>
        /// <param name="type">"Splits", "dividends" or empty for EOD</param>
        /// <param name="date">if you need any specific date</param>
        /// <param name="symbols">To download last day data for several symbols (example: MSFT,AAPL,BMW.XETRA,SAP.F)</param>
        /// <returns></returns>
        public async Task<List<ExtendedBulk>> GetExtendedBulksAsync(string code, string? type, DateTime? date, string? symbols)
        {
            return await bulkAPI.GetExtendedBulksAsync(code, type, date, symbols);
        }

        /// <summary>
        /// Get details on each exchange
        /// </summary>
        /// <param name="code">EXCHANGE_CODE</param>
        /// <param name="from">the format is ‘YYYY-MM-DD’. The default value is 6 months before the current date.</param>
        /// <param name="to">the format is ‘YYYY-MM-DD’. The default value is 6 months after the current date.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<ExchangeDetail> GetExchangeDetailsAsync(string code, DateTime? from = null, DateTime? to = null)
        {
            if (code == string.Empty) throw new ArgumentNullException(nameof(code));

            return await exchangeDetailsAPI.GetExchangeDetailsAsync(code, from, to);
        }

        /// <summary>
        /// a powerful tool that helps you get company news and filter out them by date,
        /// type of news and certain tickers with the given parameters.
        /// </summary>
        /// <param name="s">REQUIRED if parameter ‘t’ not set. The ticker code to get news for.</param>
        /// <param name="t">REQUIRED if parameter ‘s’ not set. The tag to get news on a given topic.</param>
        /// <param name="from">the format is ‘YYYY-MM-DD’</param>
        /// <param name="to">the format is ‘YYYY-MM-DD’</param>
        /// <param name="limit">OPTIONAL. The number of results should be returned with the query.
        /// Default value: 50, minimum value: 1, maximum value: 1000.</param>
        /// <param name="offset">OPTIONAL. The offset of the data. Default value: 0, minimum value: 0, maximum value: 100.
        /// For example, to get 100 symbols starting from 200 you should use limit=100 and offset=200.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<FinancialNews>> GetFinancialNewsAsync(string? s = null, string? t = null,
            DateTime? from = null, DateTime? to = null, int? limit = null, int? offset = null)
        {
            if (!(t != null ^ s != null)) throw new ArgumentException("One of the parameters (s or t) must be set");
            if (offset != null && (offset < 0 || offset > 100)) throw new ArgumentOutOfRangeException(nameof(offset));
            if (limit != null && (limit < 1 || limit > 1000)) throw new ArgumentOutOfRangeException(nameof(offset));

            return await financialNewsAPI.GetFinancialNewsAsync(s, t, from, to, limit, offset);
        }

        /// <summary>
        /// The Screener API is a powerful tool that helps you filter out tickers with the given parameters.
        /// </summary>
        /// <param name="filters">OPTIONAL. Filters out tickers by different fields.</param>
        /// <param name="signals">OPTIONAL. Usage: signals=signal1,signal2,…,signalN. Filter out tickers by signals, the calculated fields.</param>
        /// <param name="sort">OPTIONAL. Usage: sort=field_name.(asc|desc). Sorts all fields with type ‘Number’ in ascending/descending order.</param>
        /// <param name="limit">OPTIONAL. The number of results should be returned with the query. Default value: 50</param>
        /// <param name="offset">OPTIONAL. The offset of the data. Default value: 0</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<StockMarkerScreener> GetStockMarketScreenerAsync(List<(Field, Operation, string)>? filters = null, string? signals = null,
            string? sort = null, int? limit = null, int? offset = null)
        {
            if (offset < 0 && offset > 1000) throw new ArgumentOutOfRangeException(nameof(offset));
            if (limit < 1 && limit > 100) throw new ArgumentOutOfRangeException(nameof(offset));

            string filterstring = "";
            if (filters != null)
            {
                filterstring = FiltersToString(filters);
            }

            return await stockMarketScreenerAPI.GetStockMarketScreenerAsync(filterstring, signals, sort, limit, offset);
        }

        /// <summary>
        /// Сollects a string from a list of tuples
        /// </summary>
        /// <param name="filters"></param>
        /// <returns>String</returns>
        /// <exception cref="ArgumentException"></exception>
        private static string FiltersToString(List<(Field, Operation, string)> filters)
        {
            string filterstring = "[";

            for (int i = 0; i < filters.Count; i++)
            {
                string field = filters[i].Item1 switch
                {
                    Field.Code => "\"code\"",
                    Field.Name => "\"name\"",
                    Field.Exchange => "\"exchange\"",
                    Field.Sector => "\"sector\"",
                    Field.Industry => "\"industry\"",
                    Field.MarketCapitalization => "\"market_capitalization\"",
                    Field.EarningsShare => "\"earnings_share\"",
                    Field.DividendYield => "\"dividend_yield\"",
                    Field.Refund1dP => "\"refund_1d_p\"",
                    Field.Refund5dP => "\"refund_5d_p\"",
                    _ => throw new NotImplementedException()
                };

                string operation = filters[i].Item2 switch
                {
                    Operation.Matches => "\"match\"",
                    Operation.Equals => "\"=\"",
                    Operation.More => "\">\"",
                    Operation.Less => "\"<\"",
                    Operation.NotLess => "\">=\"",
                    Operation.NotMore => "\"<=\"",
                    Operation.NotEquals => "\"!=\"",
                    _ => throw new NotImplementedException()
                };

                if (Double.TryParse(filters[i].Item3, out _))
                {
                    filterstring += "[" + field + "," + operation + "," + filters[i].Item3 + "],";
                }
                else
                {
                    filterstring += "[" + field + "," + operation + ",\"" + filters[i].Item3 + "\"],";
                }
            }

            filterstring = filterstring.Remove(filterstring.Length - 1);
            filterstring += "]";
            return filterstring;
        }

        /// <summary>
        /// This function returns the Simple Moving Average indicator
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <param name="splitAdjustedOnly">default value is ‘0’. By default, we calculate data for some functions by closes adjusted with splits and dividends.
        /// If you need to calculate the data by closes adjusted only with splits, set this parameter to ‘1’.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<SMA>> GetSMAAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, Order? order = null, int? splitAdjustedOnly = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);
            CheckSplitAdjustedOnly(splitAdjustedOnly);
            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetSMAAsync(ticker, period, from, to, orderToString, splitAdjustedOnly);
        }

        /// <summary>
        /// This function returns the Exponential Moving Average indicator
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <param name="splitAdjustedOnly">default value is ‘0’. By default, we calculate data for some functions by closes adjusted with splits and dividends.
        /// If you need to calculate the data by closes adjusted only with splits, set this parameter to ‘1’.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<EMA>> GetEMAAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, Order? order = null, int? splitAdjustedOnly = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);
            CheckSplitAdjustedOnly(splitAdjustedOnly);
            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetEMAAsync(ticker, period, from, to, orderToString, splitAdjustedOnly);
        }

        /// <summary>
        /// This function returns the Weighted Moving Average indicator
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <param name="splitAdjustedOnly">default value is ‘0’. By default, we calculate data for some functions by closes adjusted with splits and dividends.
        /// If you need to calculate the data by closes adjusted only with splits, set this parameter to ‘1’.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<WMA>> GetWMAAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, Order? order = null, int? splitAdjustedOnly = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);
            CheckSplitAdjustedOnly(splitAdjustedOnly);
            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetWMAAsync(ticker, period, from, to, orderToString, splitAdjustedOnly);
        }

        /// <summary>
        /// It’s not a technical indicator itself, but we added this function to our API. By default Open, High, Low and Close values (OHLC)
        /// we provide in raw values and adjust neither for splits nor for dividends. While ‘adjusted_close’ values are adjusted both to splits
        /// and dividends. However, if you need only split-adjusted closes, you can use this function to get the desired time series.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <param name="historicalPeriod">aggregation period. Default value – ‘d’ (daily)</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<SplitAdjustedData>> GetSplitAdjustedDataAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, Order? order = null, HistoricalPeriod? historicalPeriod = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);

            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetSplitAdjustedDataAsync(ticker, period, from, to, orderToString, historicalPeriod);
        }

        /// <summary>
        /// This function returns the Average Trading Volume.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<AverageVolume>> GetAverageVolumeAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, Order? order = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);

            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetAverageVolumeAsync(ticker, period, from, to, orderToString);
        }

        /// <summary>
        /// This function returns the Average Trading Volume in currency.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<AverageVolumebyPrice>> GetAverageVolumebyPriceAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, Order? order = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);

            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetAverageVolumebyPriceAsync(ticker, period, from, to, orderToString);
        }

        /// <summary>
        /// This function returns the Volatility, a statistical measure of the dispersion of returns for a given security or market index.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <param name="splitAdjustedOnly">default value is ‘0’. By default, we calculate data for some functions by closes adjusted with splits and dividends.
        /// If you need to calculate the data by closes adjusted only with splits, set this parameter to ‘1’.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Volatility>> GetVolatilityAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, Order? order = null, int? splitAdjustedOnly = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);
            CheckSplitAdjustedOnly(splitAdjustedOnly);
            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetVolatilityAsync(ticker, period, from, to, orderToString, splitAdjustedOnly);
        }

        /// <summary>
        /// This function returns Stochastic values.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <param name="fast_kperiod">Fast K-period, the default value is 14. Valid range from 2 to 100000.</param>
        /// <param name="slow_kperiod">Slow K-period, the default value is 3. Valid range from 2 to 100000.</param>
        /// <param name="slow_dperiod">Slow D-period, the default value is 3. Valid range from 2 to 100000.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Stochastic>> GetStochasticAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
            Order? order = null, int? fast_kperiod = null, int? slow_kperiod = null, int? slow_dperiod = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);
            if (fast_kperiod != null && (fast_kperiod < 2 || fast_kperiod > 100000)) throw new ArgumentOutOfRangeException(nameof(fast_kperiod));
            if (slow_kperiod != null && (slow_kperiod < 2 || slow_kperiod > 100000)) throw new ArgumentOutOfRangeException(nameof(slow_kperiod));
            if (slow_dperiod != null && (slow_dperiod < 2 || slow_dperiod > 100000)) throw new ArgumentOutOfRangeException(nameof(slow_dperiod));

            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetStochasticAsync(ticker, period, from, to, orderToString, fast_kperiod, slow_kperiod, slow_dperiod);
        }

        /// <summary>
        /// This function returns the Relative Strength Index (RSI) technical indicator.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <param name="splitAdjustedOnly">default value is ‘0’. By default, we calculate data for some functions by closes adjusted with splits and dividends.
        /// If you need to calculate the data by closes adjusted only with splits, set this parameter to ‘1’.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<RelativeStrengthIndex>> GetRelativeStrengthIndexAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, Order? order = null, int? splitAdjustedOnly = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);
            CheckSplitAdjustedOnly(splitAdjustedOnly);
            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetRelativeStrengthIndexAsync(ticker, period, from, to, orderToString, splitAdjustedOnly);
        }

        /// <summary>
        /// This function returns the Standard Deviation (stddev) technical indicator.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<StandardDeviation>> GetStandardDeviationAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, Order? order = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);

            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetStandardDeviationAsync(ticker, period, from, to, orderToString);
        }

        /// <summary>
        /// This function returns Stochastic Relative Strength Index values.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <param name="fast_kperiod">Fast K-period, the default value is 14. Valid range from 2 to 100000.</param>
        /// <param name="fast_dperiod">Fast D-period, the default value is 14. Valid range from 2 to 100000.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<StochasticRelativeStrengthIndex>> GetStochasticRelativeStrengthIndexAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
            Order? order = null, int? fast_kperiod = null, int? fast_dperiod = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);
            if (fast_kperiod != null && (fast_kperiod < 2 || fast_kperiod > 100000)) throw new ArgumentOutOfRangeException(nameof(fast_kperiod));
            if (fast_dperiod != null && (fast_dperiod < 2 || fast_dperiod > 100000)) throw new ArgumentOutOfRangeException(nameof(fast_dperiod));

            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetStochasticRelativeStrengthIndexAsync(ticker, period, from, to, orderToString, fast_kperiod, fast_dperiod);
        }

        /// <summary>
        /// This function returns the Linear Regression Slope.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <param name="splitAdjustedOnly">default value is ‘0’. By default, we calculate data for some functions by closes adjusted with splits and dividends.
        /// If you need to calculate the data by closes adjusted only with splits, set this parameter to ‘1’.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Slope>> GetSlopeAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, Order? order = null, int? splitAdjustedOnly = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);
            CheckSplitAdjustedOnly(splitAdjustedOnly);
            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetSlopeAsync(ticker, period, from, to, orderToString, splitAdjustedOnly);
        }

        /// <summary>
        /// This function returns the Directional Movement Index.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<DirectionalMovementIndex>> GetDirectionalMovementIndexAsync(string ticker, int? period = null, DateTime? from = null,
            DateTime? to = null, Order? order = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);
            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetDirectionalMovementIndexAsync(ticker, period, from, to, orderToString);
        }

        /// <summary>
        /// This function returns the Average Directional Movement Index.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<AverageDirectionalMovementIndex>> GetAverageDirectionalMovementIndexAsync(string ticker, int? period = null,
            DateTime? from = null, DateTime? to = null, Order? order = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);
            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetAverageDirectionalMovementIndexAsync(ticker, period, from, to, orderToString);
        }

        /// <summary>
        /// This function returns Moving Average Convergence/Divergence values.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <param name="splitAdjustedOnly">default value is ‘0’. By default, we calculate data for some functions by closes adjusted with splits and dividends.
        /// If you need to calculate the data by closes adjusted only with splits, set this parameter to ‘1’.</param>
        /// <param name="fast_period">the default value is 12. Valid range from 2 to 100000.</param>
        /// <param name="slow_period">the default value is 26. Valid range from 2 to 100000.</param>
        /// <param name="signal_period">the default value is 9. Valid range from 2 to 100000.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<MovingAverageConvergence>> GetMovingAverageConvergenceAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
            Order? order = null, int? splitAdjustedOnly = null, int? fast_period = null, int? slow_period = null, int? signal_period = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);
            CheckSplitAdjustedOnly(splitAdjustedOnly);

            if (fast_period != null && (fast_period < 2 || fast_period > 100000)) throw new ArgumentOutOfRangeException(nameof(fast_period));
            if (slow_period != null && (slow_period < 2 || slow_period > 100000)) throw new ArgumentOutOfRangeException(nameof(slow_period));
            if (signal_period != null && (signal_period < 2 || signal_period > 100000)) throw new ArgumentOutOfRangeException(nameof(period));

            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetMovingAverageConvergenceAsync(ticker, period, from, to, orderToString, splitAdjustedOnly, fast_period, slow_period, signal_period);
        }

        /// <summary>
        /// This function returns the average of true ranges over the specified period.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<AverageTrueRange>> GetAverageTrueRangeAsync(string ticker, int? period = null, DateTime? from = null,
            DateTime? to = null, Order? order = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);

            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetAverageTrueRangeAsync(ticker, period, from, to, orderToString);
        }

        /// <summary>
        /// This function returns the CCI data. The Commodity Channel Index​ (CCI) is a momentum-based oscillator used to help determine
        /// when an investment vehicle is reaching a condition of being overbought or oversold.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<CommodityChannelIndex>> GetCommodityChannelIndexAsync(string ticker, int? period = null, DateTime? from = null,
            DateTime? to = null, Order? order = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);

            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetCommodityChannelIndexAsync(ticker, period, from, to, orderToString);
        }

        /// <summary>
        /// This function returns the Parabolic SAR values.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <param name="acceleration">Acceleration Factor used up to the Maximum value. Default value – 0.02.</param>
        /// <param name="maximum">Acceleration Factor Maximum value. Default value – 0.20.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<ParabolicSAR>> GetParabolicSARAsync(string ticker, int? period = null, DateTime? from = null,
            DateTime? to = null, Order? order = null, double? acceleration = null, double? maximum = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);

            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetParabolicSARAsync(ticker, period, from, to, orderToString, acceleration, maximum);
        }

        /// <summary>
        /// This file format returns the data in AmiBroker File format to import the data into AmiBroker software.
        /// </summary>
        /// <param name="ticker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example,
        /// AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ. </param>
        /// <param name="period">the number of data points used to calculate each moving average value.
        /// Valid range from 2 to 100000 with the default value – 50.</param>
        /// <param name="from">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="to">you can use these parameters with format ‘YYYY-MM-DD’.</param>
        /// <param name="order">use ‘a’ for ascending dates (from old to new) and ‘d’ for descending dates (from new to old).
        /// By default, dates are shown in ascending order.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<AmiBrokerData>> GetAmiBrokerDataAsync(string ticker, int? period = null, DateTime? from = null,
            DateTime? to = null, Order? order = null)
        {
            CheckTicker(ticker);
            CheckPeriod(period);

            string? orderToString = order switch
            {
                Order.Ascending => "a",
                Order.Descending => "d",
                _ => null,
            };

            return await technicalIndicatorAPI.GetAmiBrokerDataAsync(ticker, period, from, to, orderToString);
        }

        /// <summary>
        /// checking the ticker string for emptiness and the presence of a splitter
        /// </summary>
        /// <param name="ticker"></param>
        /// <returns>bool</returns>
        private static void CheckTicker(string ticker)
        {
            if ((ticker == string.Empty || !ticker.Contains('.')))
            {
                throw new ArgumentException("Ticker is empty or has no splitter.", nameof(ticker));
            }
        }

        /// <summary>
        /// checking the period for emptiness and acceptable range
        /// </summary>
        /// <param name="period"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private static void CheckPeriod(int? period = null)
        {
            if (period != null && (period < 2 || period > 100000)) throw new ArgumentOutOfRangeException(nameof(period));
        }

        /// <summary>
        /// checking splitAdjustedOnly for emptiness and acceptable values
        /// </summary>
        /// <param name="splitAdjustedOnly"></param>
        /// <exception cref="ArgumentException"></exception>
        private static void CheckSplitAdjustedOnly(int? splitAdjustedOnly = null)
        {
            if (splitAdjustedOnly != null && (splitAdjustedOnly != 0 & splitAdjustedOnly != 1))
                throw new ArgumentException("splitAdjustedOnly must be 0 or 1", nameof(splitAdjustedOnly));
        }
    }
}
