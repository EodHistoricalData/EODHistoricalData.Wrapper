# EODHistoricalData.Wrapper

Made with Microsoft Visual Studio

[![.NET Version](https://img.shields.io/badge/.NET%20Standard-2.0-blue)](https://shields.io/)

# Contents

1. [General description](#general-description-arrow_up)
2. [Requirements](#requirements-arrow_up)
3. [Installation](#installation-arrow_up)
4. [Demo](#demo-arrow_up)
5. [Documentation](#documentation-arrow_up)
	- [Historical Prices, Splits and Dividends Data APIs](#historical-prices-splits-and-dividends-data-apis-arrow_up)
	- [Fundamental and Economic Financial Data APIs](#fundamental-and-economic-financial-data-apis-arrow_up)
	- [Exchanges Financial APIs](#exchanges-financial-apis-arrow_up)
6. [Disclaimer](#disclaimer-arrow_up)

## General description [:arrow_up:](#eodhistoricaldata.wrapper)
This library is the C# .NET SDK for the EOD Historical data REST API. It's intended to be used for data extraction for financial valuations, macroeconomic analyses, sentiment analysis, option strategies, technical analysis, development of machine learning models, and more!

## Requirements [:arrow_up:](#eodhistoricaldata.wrapper)
- You need to request an API key with the EOD team. Create your account at the following [link](https://eodhistoricaldata.com/)
	- ***Please be aware of the pricing plans and policies. Different plans have different data accesses.***
- ```C#``` >= 6.0

## Installation [:arrow_up:](#eodhistoricaldata.wrapper)

## Demo [:arrow_up:](#eodhistoricaldata.wrapper)

## Documentation [:arrow_up:](#eodhistoricaldata.wrapper)

Please be aware that some descriptions will come directly from the API's documentation because no further explanations were needed for the specific method. Additionally, for the sake of simplicity, I will use the following convention along with the whole document: 

```c#
using EOD;
// create the instance of the SDK
apiToken = "YOUR_API_KEY_GOES_HERE";
var _api = new API(apiToken);
// if you use proxy
System.Net.WebProxy proxy = new("YOUR_PROXY_SERVER_IP:PORT");
var _apiProxy = new API(apiKey, proxy);
```

### Historical Prices, Splits and Dividends Data APIs [:arrow_up:](#eodhistoricaldata.wrapper)

- **Stock Price Data API (End-Of-Day Historical Data)**: Retrieve end-of-day data for Stocks, ETFs, Mutual Funds, Bonds (Government and Corporate), Cryptocurrencies, and FOREX pairs.
	- Parameters:
		- ```tiker```(string): Required - ticker consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example, AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ.
		- ```from```(DateTime) and ```to```(DateTime): the beginning and end of the desired dates.
		- ```period```(HistricalPeriod): search data interval. By default, daily prices will be shown.
		- ```order```(Order): Optional - sorting data by dates. By default, dates are shown in ascending order.
	- Usage:
```c#
// AngloAmerican stock that trades from January 1 to December 11 in the London Stock Exchange
List<HistoricalStockPrice>? response = await _api.GetEndOfDayHistoricalStockPriceAsync('AAL.LSE', new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), HistoricalPeriod.Daily, Order.Ascending);
```
- **Live (Delayed) Stock Prices API**: The method supports almost all symbols and exchanges worldwide, and the prices provided have a 15-20 minutes delay. The method also offers combinations of multiple tickers with just one request. The only supported interval is the 1-minute interval. **The UNIX standard is used for the timestamp**.
	- Parameters:
		- ```tiker```(string): Required - ticker consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example, AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ.
	- Usage:
```c#
// An example of live (delayed) stock prices API for AAPL (Apple Inc)
List<HistoricalStockPrice>? response = await _api.GetLiveStockPricesAsync("AAPL.US");
```
- **Historical Splits and Dividends API**: Get the historical dividends, splits for any stock.
	- Parameters:
		- ```tiker```(string): Required - ticker consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example, AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ.
		- ```from```(DateTime) and ```to```(DateTime): the beginning and end of the desired dates
	- Usage:
```c#
// An example of historical dividends for AAPL (Apple Inc)
List<HistoricalDividend>? response = await _api.GetHistoricalDividendsAsync("AAPL.US", new DateTime(2000, 1, 1), new DateTime(2021, 12, 1));
//  An example of historical splits for AAPL (Apple Inc)
List<HistoricalSplit>? response = await _api.GetHistoricalSplitsAsync("AAPL.US", new DateTime(2000, 1, 1), new DateTime(2022, 01, 1));
```
- **Technical Indicator API**: Retrieve technical data associated with the price action of an instrument. The data is mainly oriented to technical indicators rather than any other price-action methodology (e.g., Elliot Waves, Wyckoff, etc.)
	- **Split Adjusted Data**: It’s not a technical indicator itself, but we added this function to our API. By default Open, High, Low and Close values (OHLC) we provide 		in raw values and adjust neither for splits nor for dividends. While ‘adjusted_close’ values are adjusted both to splits and dividends. However, if you need only split-	adjusted closes, you can use this function to get the desired time series.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
			- ```historicalPeriod```(HistoricalPeriod): Optional - aggregation period.
		- Usage:
		```c#
		SplitAdjustedData? response = await _api.GetSplitAdjustedDataAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Average Volume (avgvol)**: This function returns the Average Trading Volume.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
		- Usage:
		```c#
		AverageVolume? response = await _api.GetAverageVolumeAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Average Volume by Price (avgvolccy)**: This function returns the Average Trading Volume in currency.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
		- Usage:
		```c#
		AverageVolumebyPrice? response = await _api.GetAverageVolumebyPriceAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **SMA (Simple Moving Average)**: This function returns the Simple Moving Average indicator.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
			- ```historicalPeriod```(HistoricalPeriod): Optional - aggregation period.
			- ```splitAdjustedOnly```(int): Optional - default value is ‘0’. By default, we calculate data for some functions by closes adjusted with splits and dividends. If you need to calculate the data by closes adjusted only with splits, set this parameter to ‘1’.
		- Usage:
		```c#
		List<SMA>? response = await _api.GetSMAAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **EMA (Exponential Moving Average)**: This function returns the Exponential Moving Average indicator
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
			- ```historicalPeriod```(HistoricalPeriod): Optional - aggregation period.
			- ```splitAdjustedOnly```(int): Optional - default value is ‘0’. By default, we calculate data for some functions by closes adjusted with splits and dividends. If you need to calculate the data by closes adjusted only with splits, set this parameter to ‘1’.
		- Usage:
		```c#
		List<EMA>? response = await _api.GetEMAAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **WMA (Weighted Moving Average)**: This function returns the Weighted Moving Average indicator
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
			- ```historicalPeriod```(HistoricalPeriod): Optional - aggregation period.
			- ```splitAdjustedOnly```(int): Optional - default value is ‘0’. By default, we calculate data for some functions by closes adjusted with splits and dividends. If you need to calculate the data by closes adjusted only with splits, set this parameter to ‘1’.
		- Usage:
		```c#
		List<WMA>? response = await _api.GetWMAAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Volatility (Variance between returns)**: This function returns the Volatility, a statistical measure of the dispersion of returns for a given security or market index.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
			- ```splitAdjustedOnly```(int): Optional - default value is ‘0’. By default, we calculate data for some functions by closes adjusted with splits and dividends. If you need to calculate the data by closes adjusted only with splits, set this parameter to ‘1’.
		- Usage:
		```c#
		List<Volatility>? response = await _api.GetVolatilityAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Stochastic Technical Indicator**: This function returns Stochastic values.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
			- ```fast_kperiod```(int): Optional - Fast K-period, the default value is 14. Valid range from 2 to 100000.
			- ```slow_kperiod```(int): Optional - Slow K-period, the default value is 3. Valid range from 2 to 100000.
			- ```slow_dperiod```(int): Optional - Slow D-period, the default value is 3. Valid range from 2 to 100000.
		- Usage:
		```c#
		List<Stochastic>? response = await _api.GetStochasticAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Relative Strength Index (rsi)**: This function returns the Relative Strength Index (RSI) technical indicator.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
			- ```splitAdjustedOnly```(int): Optional - default value is ‘0’. By default, we calculate data for some functions by closes adjusted with splits and dividends. If you need to calculate the data by closes adjusted only with splits, set this parameter to ‘1’.
		- Usage:
		```c#
		List<RelativeStrengthIndex>? response = await _api.GetRelativeStrengthIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Standard Deviation (stddev)**: This function returns the Standard Deviation (stddev) technical indicator.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
		- Usage:
		```c#
		List<StandardDeviation>? response = await _api.GetStandardDeviationAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Stochastic Relative Strength Index**: This function returns Stochastic Relative Strength Index values.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
			- ```fast_kperiod```(int): Optional - Fast K-period, the default value is 14. Valid range from 2 to 100000.
			- ```fast_dperiod```(int): Optional - Fast D-period, the default value is 14. Valid range from 2 to 100000.
		- Usage:
		```c#
		List<StochasticRelativeStrengthIndex>? response = await _api.GetStochasticRelativeStrengthIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Slope (Linear Regression)**: This function returns the Linear Regression Slope.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
			- ```splitAdjustedOnly```(int): Optional - default value is ‘0’. By default, we calculate data for some functions by closes adjusted with splits and dividends. If you need to calculate the data by closes adjusted only with splits, set this parameter to ‘1’.
		- Usage:
		```c#
		List<Slope>? response = await _api.GetSlopeAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Directional Movement Index (dmi or dx)**: This function returns the Directional Movement Index.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
		- Usage:
		```c#
		List<DirectionalMovementIndex>? response = await _api.GetDirectionalMovementIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Average Directional Movement Index (adx)**: This function returns the Average Directional Movement Index.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
		- Usage:
		```c#
		List<AverageDirectionalMovementIndex>? response = await _api.GetAverageDirectionalMovementIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Moving Average Convergence/Divergence (macd)**: This function returns Moving Average Convergence/Divergence values.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
			- ```splitAdjustedOnly```(int): Optional - default value is ‘0’. By default, we calculate data for some functions by closes adjusted with splits and dividends. If you need to calculate the data by closes adjusted only with splits, set this parameter to ‘1’.
			- ```fast_period```(int): Optional - the default value is 12. Valid range from 2 to 100000.
			- ```slow_period```(int): Optional - the default value is 26. Valid range from 2 to 100000.
			- ```signal_period```(int): Optional - the default value is 9. Valid range from 2 to 100000.
		- Usage:
		```c#
		List<MovingAverageConvergence>? response = await _api.GetMovingAverageConvergenceAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Average True Range (ATR)**: This function returns the average of true ranges over the specified period.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
		- Usage:
		```c#
		List<AverageTrueRange>? response = await _api.GetAverageTrueRangeAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Commodity Channel Index (CCI)**: This function returns the CCI data. The Commodity Channel Index (CCI) is a momentum-based oscillator used to help determine when an investment vehicle is reaching a condition of being overbought or oversold.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
		- Usage:
		```c#
		List<CommodityChannelIndex>? response = await _api.GetCommodityChannelIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Parabolic SAR**: This function returns the Parabolic SAR values.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
			- ```acceleration```(double): Optional - Acceleration Factor used up to the Maximum value. Default value – 0.02.
			- ```maximum```(double): Optional - Acceleration Factor Maximum value. Default value – 0.20.
		- Usage:
		```c#
		List<ParabolicSAR>? response = await _api.GetParabolicSARAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
	- **Amibroker File format**: This file format returns the data in AmiBroker File format to import the data into AmiBroker software.
		- Parameters:
			- ```ticker```(string): Required - name of the instrument to retrieve data.
			- ```period```(int): Optional - the number of data points used to calculate each moving average value.
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
			- ```order```(Order): Optional – by default, dates are shown in ascending order.
		- Usage:
		```c#
		List<AmiBrokerData>? response = await _api.GetAmiBrokerDataAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
		```
- **Intraday Historical Data API**: Get intraday historical stock price data for US (NYSE and NASDAQ), Canada, and MOEX tickers. The 1-minute interval includes the pre-market and after-hours trading data from 2004 (more than 15 years of the data), and for the 5-minute intervals, the data starts from October 2020. For other tickers (mainly for international instruments), it is only available the 5-minute intervals and only from October 2020.
	- Parameters:
		- ```symbol```(string): Required - Name of the instrument to retrieve data.
		- ```interval```(IntradayHistoricalInterval): Required - the possible intervals: 5-minutes, 1 hour and 1-minute
		- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates. The maximum periods between ‘from’ and ‘to’ are 120 days for 1-minute interval, 600 days for 5-minute interval and 7200 days for 1 hour interval.
	- Usage:
```c#
// An example of every hour intraday historical stock price data for AAPL (Apple Inc)
List<IntradayHistoricalStockPrice>? response = await _api.GetIntradayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 12, 01), new DateTime(2021, 12, 31), IntradayHistoricalInterval.OneHour);
```
- **Options Data API**:  Stock options data for top US stocks from NYSE and NASDAQ, the data for Options starts from April 2018. Options data is updated daily; however, the API does not provide a history for options contracts prices or other related data. That means: for each contract, there is only the current price, bid/ask, etc. 
1. **IMPORTANT!** For backward compatibility, you should use the ```from``` parameter with any value before the expiration date, the API recommends '2000-01-01'. 
2. **Note**: option greeks and some additional value are available only for options with expiration date Feb 15, 2019, or later.

	- Parameters:
		- ```ticker```(string): Required - Could be any supported symbol. No default value.
		- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
		- ```trade_date_from```(DateTime): Optional - filters OPTIONS by ```lastTradeDateTime```. Default value is blank.
		- ```trade_date_to```(DateTime): Optional - filters OPTIONS by ```lastTradeDateTime```. Default value is blank.
		- ```contract_name```(string): Optional - Name of a particular contract.
	- Usage:
```c#
// An example of Stock options data for AAPL (Apple Inc)
List<IntradayHistoricalStockPrice>? response = await _api.GetOptionsDataAsync("AAPL.US");
```
### Fundamental and Economic Financial Data APIs [:arrow_up:](#eodhistoricaldata.wrapper)
- **Economic events API**: It provides the past and future events from all around the world like Retail Sails, Bond Auctions, PMI Releases and many other Economic Events data.
	- Parameters:
		- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
		- ```country```(string). Optional - The country code in ISO 3166 format, 2 symbols.
		- ```comparison```(string): Optional - Filter events by their periodicity.
		- ```offset```(int): Optional - Possible values from 0 to 1000.
		- ```limit```(int): Optional - The maximum amount of data to retrieve. Possible values from 0 to 1000.
	- Usage:
```c#
// An example of Economic Events Calendar data for the USA in 2021
List<EconomicEventData>? response = await _api.GetEconomicEventsDataAsync(new DateTime(2021, 01, 1), new DateTime(2021, 12, 31), "US");
```
- **Insider Transactions API**: The insider transactions API data is available for all US companies that report Form 4 to the SEC. Insider trading involves trading in a public company’s stock by someone who has non-public, material information about that stock for any reason.
	- Parameters:
		- ```limit```(int): Optional - The limit for entries per result, from 1 to 1000. Default value: 100.
		- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
		- ```ticker```(string): Optional - ticker of the company to retrieve data. By default, all possible symbols will be displayed.
	- Usage:
```c#
// An example of Insider Transactions the data only for Apple Inc in 2021
List<InsiderTransaction>? response = await _api.GetInsiderTransactionsAsync(null, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31), "AAPL.US");
```
- **Fundamental Data: Stocks, ETFs, Mutual Funds, Indices**: Access to fundamental data API for stocks, ETFs, Mutual Funds, and Indices from different exchanges and countries. Almost all major US, UK, EU, India, LATAM, and Asia exchanges are available.
	- Parameters:
		- ```ticker```(string): Required - Name of the instrument to retrieve data.
		- ```filters```(string): Optional - Multi-layer filtering helps to reduce the output of the request. Different layers are divided with ```::``` and it’s possible to have as many layers as you need. Additionally, you can request multiple fields from a particular layer using ```,```. Be aware that the order of the layers is from the macro keys to the micro-level.
	- Usage:
```c#
// An example of fundamental data feed for Apple Inc
FundamentalData? response = await _api.GetFundamentalDataAsync("AAPL.US");
// An example of filtered fundamental data feed for Apple Inc
FundamentalData? response = await _api.GetFundamentalDataAsync("AAPL.US", "General::Code,General,Earnings");
// An example of ETFs data for VTI.US
FundamentalData? response = await _api.GetFundamentalDataAsync("VTI.US");
```
- Bulk fundamentals API
	- Parameters (Bulk fundamentals):
		- ```ticker```(string): Required - consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example, AAPL.MX for Mexican Stock Exchange.
		- ```offset```(int): Optional - the first symbol you will get. Default value is 0.
		- ```limit```(int): Optional - the number of symbols you will get. Default value is 1000. Max value is 1000.
		- ```symbols```(string): Optional - To get the data for several symbols instead of the entire exchange. If not empty, the first parameter will be ignored.
	- Usage:
```c#
// An example of bulk fundamental data feed for NASDAQ exchange
Dictionary<string, BulkFundamentalData>? response = await _api.GetBulkFundamentalsDataAsync("NASDAQ", 500, 500);
```
- **Calendar API. Upcoming Earnings, Trends, IPOs and Splits**
	- **Upcoming Earnings**
		- Parameters:
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates. If ```from``` is not provided, today will be used. If ```to``` is not provided, today + 7 days will be used.
			- ```ticker```(string): Optional - You can request specific symbols to get historical and upcoming data. If ‘symbols’ used, then ‘from’ and ‘to’ parameters will be ignored. You can use one symbol: ‘AAPL.US’ or several symbols separated by a comma: ‘AAPL.US, MS’
		- Usage:
		```c#
		// An example to get upcoming earnings for Apple Inc
		UpcomingEarning? response = await _api.GetUpcomingEarningsAsync(, , "AAPL.US");
		```
	- **Earning Trends**
		- Parameters:
			- ```ticker```(string): Required - You can request specific symbols to get historical and upcoming data.
        /// You can use one symbol: ‘AAPL.US’ or several symbols separated by a comma: ‘AAPL.US, MS’.
		- Usage:
		```c#
		// An example to get earning trends for several symbols
		EarningTrend response = await _api.GetEarningTrendsAsync("AAPL.US, MS");
		```
	- **Upcoming IPOs**
		- Parameters:
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates for IPOs. If ```from``` is not provided, today will be used. If ```to``` is not provided, today + 7 days will be used.
		- Usage:
		```c#
		// An example to get all upcoming IPOs for April 2022
		UpcomingIPO response = await _api.GetUpcomingIPOsAsync(new DateTime(2022, 04, 1), new DateTime(2022, 04, 31));
		```
	- **Upcoming Splits**
		- Parameters:
			- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates for IPOs. If ```from``` is not provided, today will be used. If ```to``` is not provided, today + 7 days will be used.
		- Usage:
		```c#
		// An example to get all splits from December 2, 2018, to December 6, 2018
		UpcomingIPO response = await _api.GetUpcomingSplitsAsync(new DateTime(2018, 12, 2), new DateTime(2018, 12, 6));
		```
- **Macro Indicators API**: Macroeconomics is a part of economics dealing with the performance, structure, behavior, and decision-making of an economy as a whole. The Macroeconomics data API includes regional, national, and global economies. EOD provides the data for more than 30 macro indicators such as GDP, unemployment rates, national income, price indices, inflation rates, consumption, international trades, and many other significant indicators.
	- Parameters:
		- ```country```(string): Required - Defines the country for which the indicator will be shown. The country should be defined in the Alpha-3 ISO format. Possible values: CHL, FRA, DEU, etc.
		- ```indicator```(string): Optional - Defines which macroeconomics data indicator will be shown. The default value is ```'gdp_current_usd'```.
	- Usage:
```c#
// Get the available macroindicators names
List<MacroIndicator> response = await _api.GetMacroIndicatorsAsync();
// Request the Chilean interest rate
List<MacroIndicator> response = await _api.GetMacroIndicatorsAsync("CHL", "real_interest_rate");
```
- **Bonds Fundamentals API**: Bond covenants details.
	- Parameters:
		- ```code```(string): Required - CUSIP of a particular bond, it’s also could be an ISIN. Other IDs are not supported at the moment.
	- Usage:
```c#
// Request bonds fundamental data feed for CUSIP: US00213MAS35
BondsFundamentalData response = await _api.GetBondsFundamendalDataAsync("US00213MAS35");
```
### Exchanges Financial APIs [:arrow_up:](#eodhistoricaldata.wrapper)
- **Bulk API for EOD, Splits and Dividends**: This method allows you to download the data for an entire exchange for a particular day. It works for end-of-day historical data feed and splits and dividends data as well. You can also use NYSE or NASDAQ as exchange symbols for US tickers to get data only for NYSE or NASDAQ exchange. With this method is no longer necessary to perform thousands and thousands of API requests per day.
	- Parameters:
		- ```code```(string): Required - country code or ticker.
		- ```type```(string): Optional - "splits", "dividends" or empty for end of day data.
		- ```date```(DateTime): Optional - desired date. By default, the data for last trading day will be downloaded.
		- ```symbols```(string): Optional - To download last day data for several symbols (example: "MSFT,AAPL,BMW.XETRA,SAP.F")
	- Usage:
	```c#
	// Request returns end-of-day data for US stocks in bulk for a particular day.
	List<Bulk> response = await _api.GetBulksAsync("US");
	// Request the latest dividends for the companies that trade in NYSE.
	List<Bulk> response = await _api.GetBulksAsync("NYSE", "dividends");
	```
	- Extented Bulk: if you need an extended dataset, which includes company name, EMA 50 and EMA 200 and average volumes for 14, 50 and 200 days. 
	```c#
	// Request returns end-of-day data for selected US symbols.
	List<ExtendedBulk> response = await _api.GetExtendedBulksAsync("US", null, null, "MSFT, AAPL");
	```
- **Exchanges API. Get List of Tickers**: Request available exchanges, and instruments for each exchange or market.
	- Parameters:
		- ```code```(string): Required - Name of the exchange or market to request symbols. This parameter is only valid for particular exchanges, check the usage for details.
	- Usage:
```c#
// Request list of available exchanges, this method does not allow any parameter.
List<Exchange> response = _api.GetExchangeAsync();
// Request list of Tickers for Borsa Italiana Certificates
List<ExchangeSymbol> response = _api.GetExchangeSymbolsAsync("ETLX");
```
- **Exchanges API. Trading Hours and Market Holidays**
	- Parameters:
		- ```code```(string): Required - Name of the exchange.
		- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates. If ```from``` is not provided, 6 months before the current date will be used. If ```to``` is not provided, 6 months after the current date will be used.
	- Usage:
```c#
// Request the London Stock Exchange details
ExchangeDetail response = await _api.GetExchangeDetailsAsync("LSE");
```
- **Financial News API**: The Financial News method is a powerful tool that helps you get company news and filter out them by date, type of news, and specific tickers according to the given parameters. Despite that all parameters are optional, you need to input at least one of them. See the usage for guidance.
	- Parameters:
		- ```s```(string): REQUIRED if parameter ```t``` not set. The ticker code to get news for.
		- ```t```(string): REQUIRED if parameter ```s``` not set. The tag to get news on a given topic. You can find the list of supported tags by following [the link](https://eodhistoricaldata.com/financial-apis/financial-news-api/)
		- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
		- ```limit```(int): Optional - The number of results should be returned with the query. Default value: 50, minimum value: 1, maximum value: 1000.
		- ```offset```(int): Optional - The offset of the data. Default value: 0, minimum value: 0, maximum value: 100.
		
	- Usage:
```c#
// Request the news from Anglo American
List<FinancialNews> response = await _api.GetFinancialNewsAsync("AAL.LSE");
// Request data for the selected tag
List<FinancialNews> response = await _api.GetFinancialNewsAsync(null, "net income");
```
- **Stock Market Screener API**: is a powerful tool that helps you filter out tickers with the given parameters.
	- Parameters:
		- ```filters```(List<(Field, Operation, string)>): Optional - Filters out tickers by different fields.
		- ```signals```(List<'Signal>): Optional - Filters out tickers by signals, the calculated fields.
		- ```sort```((Field, Order)): Optional - sorts all fields with type Number in ascending/descending order. Usage: ```field_name.(asc|desc)```.
		- ```limit```(int): Optional - the number of results should be returned with the query. Default value: 50, minimum value: 1, maximum value: 100.
		- ```offset```(int): Optional - the offset of the data. Default value: 0, minimum value: 0, maximum value: 100.
	- Usage:
```c#
// Example of using filters and limit
var filters = new List<(Field, Operation, string)>
            {
                (Field.MarketCapitalization, Operation.More, "1000"),
                (Field.Name, Operation.Matches, "apple"),
                (Field.Code, Operation.Equals, "AAPL"),
                (Field.Exchange, Operation.Equals, "us"),
                (Field.Sector, Operation.Equals, "Technology")
            };
            
StockMarkerScreener response = await _api.GetStockMarketScreenerAsync(filters, null, null, 10);
```
## Disclaimer [:arrow_up:](#EODHistoricalData.Wrapper)
This document is not an offer to buy or sell financial instruments. Never invest more than you can afford to lose. You should consult a registered professional advisor before making any investment.
