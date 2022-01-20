# EODHistoricalData.Wrapper

> Made with Microsoft Visual Studio

[![.NET Version](https://img.shields.io/badge/.NET-6.0+-blue.svg)](https://shields.io/)

# Contents

1. [General description](#general-description-arrow_up)
2. [Requirements](#requirements-arrow_up)
3. [Installation](#installation-arrow_up)
4. [Demo](#demo-arrow_up)
5. [Documentation](#documentation-arrow_up)
	- [Historical Prices, Splits and Dividends Data APIs](#historical-prices-splits-and-dividends-data-apis-arrow_up)
6. [Disclaimer](#disclaimer-arrow_up)

## General description [:arrow_up:](#eod-historical-data-sdk)
This library is the C# .NET SDK for the EOD Historical data REST API. It's intended to be used for data extraction for financial valuations, macroeconomic analyses, sentiment analysis, option strategies, technical analysis, development of machine learning models, and more!

## Requirements [:arrow_up:](#eod-historical-data-sdk)
- You need to request an API key with the EOD team. Create your account at the following [link](https://eodhistoricaldata.com/)
	- ***Please be aware of the pricing plans and policies. Different plans have different data accesses.***
- ```C#``` >= 6.0

## Installation [:arrow_up:](#eod-historical-data-sdk)

## Demo [:arrow_up:](#eod-historical-data-sdk)

## Documentation [:arrow_up:](#eod-historical-data-sdk)

Please be aware that some descriptions will come directly from the API's documentation because no further explanations were needed for the specific method. Additionally, for the sake of simplicity, I will use the following convention along with the whole document: 

```c#
using EOD;
// create the instance of the SDK
apiToken = "YOUR_API_KEY_GOES_HERE";
var _api = new API(apiToken);
```

### Historical Prices, Splits and Dividends Data APIs [:arrow_up:](#eod-historical-data-sdk)

- **Stock Price Data API (End-Of-Day Historical Data)**: Retrieve end-of-day data for Stocks, ETFs, Mutual Funds, Bonds (Government and Corporate), Cryptocurrencies, and FOREX pairs.
	- Parameters:
		- ```tiker```(string): Required - ticker consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example, AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ.
		- ```from```(DateTime) and ```to```(DateTime): the beginning and end of the desired dates
		- ```period```(HistricalPeriod): search data interval. By default, daily prices will be shown.
		- ```order```(Order): Optional - sorting data by dates. By default, dates are shown in ascending order.
	- Usage:
```c#
// AngloAmerican stock that trades from January 1 to December 11 in the London Stock Exchange
List<HistoricalStockPrice>? response = _api.GetEndOfDayHistoricalStockPriceAsync('AAL.LSE', new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), HistoricalPeriod.Daily, Order.Ascending);
```
- **Live (Delayed) Stock Prices API**: The method supports almost all symbols and exchanges worldwide, and the prices provided have a 15-20 minutes delay. The method also offers combinations of multiple tickers with just one request. The only supported interval is the 1-minute interval. **The UNIX standard is used for the timestamp**.
	- Parameters:
		- ```tiker```(string): Required - ticker consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example, AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ.
	- Usage:
```c#
// An example of live (delayed) stock prices API for AAPL (Apple Inc)
List<HistoricalStockPrice>? response = _api.GetLiveStockPricesAsync("AAPL.US");
```
- **Historical Splits and Dividends API**: Get the historical dividends, splits for any stock.
	- Parameters:
		- ```tiker```(string): Required - ticker consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example, AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ.
		- ```from```(DateTime) and ```to```(DateTime): the beginning and end of the desired dates
	- Usage:
```c#
// An example of historical dividends for AAPL (Apple Inc)
List<HistoricalDividend>? response = _api.GetHistoricalDividendsAsync("AAPL.US", new DateTime(2000, 1, 1), new DateTime(2021, 12, 1));
//  An example of historical splits for AAPL (Apple Inc)
List<HistoricalSplit>? response = _api.GetHistoricalSplitsAsync("AAPL.US", new DateTime(2000, 1, 1), new DateTime(2022, 01, 1));
```
- **Intraday Historical Data API**: Get intraday historical stock price data for US (NYSE and NASDAQ), Canada, and MOEX tickers. The 1-minute interval includes the pre-market and after-hours trading data from 2004 (more than 15 years of the data), and for the 5-minute intervals, the data starts from October 2020. For other tickers (mainly for international instruments), it is only available the 5-minute intervals and only from October 2020.
	- Parameters:
		- ```symbol```(string): Required - Name of the instrument to retrieve data.
		- ```interval```(IntradayHistoricalInterval): Required - the possible intervals: 5-minutes, 1 hour and 1-minute
		- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates. The maximum periods between ‘from’ and ‘to’ are 120 days for 1-minute interval, 600 days for 5-minute interval and 7200 days for 1 hour interval.
	- Usage:
```c#
// An example of every hour intraday historical stock price data for AAPL (Apple Inc)
List<IntradayHistoricalStockPrice>? response = _api.GetIntradayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 12, 01), new DateTime(2021, 12, 31), IntradayHistoricalInterval.OneHour);
```
- **Options Data API**:  Stock options data for top US stocks from NYSE and NASDAQ, the data for Options starts from April 2018. Options data is updated daily; however, the API does not provide a history for options contracts prices or other related data. That means: for each contract, there is only the current price, bid/ask, etc. 
1. **IMPORTANT!** For backward compatibility, you should use the ```from``` parameter with any value before the expiration date, the API recommends '2000-01-01'. 
2. **Note**: option greeks and some additional value are available only for options with expiration date Feb 15, 2019, or later.

	- Parameters:
		- ```ticker```(string): Required - Could be any supported symbol. No default value.
		- ```from```(DateTime) and ```to```(DateTime): Optional - the beginning and end of the desired dates.
		- ```trade_date_from```(DateTime): Optional - filters OPTIONS by ```lastTradeDateTime```. Default value: is blank.
		- ```trade_date_to```(DateTime): Optional - filters OPTIONS by ```lastTradeDateTime```. Default value: is blank.
		- ```contract_name```(string): Optional - Name of a particular contract.
	- Usage:
```c#
// An example of Stock options data for AAPL (Apple Inc)
List<IntradayHistoricalStockPrice>? response = _api.GetOptionsDataAsync("AAPL.US");
```
## Disclaimer [:arrow_up:](#eod-historical-data-sdk)
