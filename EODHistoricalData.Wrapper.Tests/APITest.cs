using EOD;
using EODHistoricalData.Wrapper.Model.TechnicalIndicators;
using EODHistoricalData.Wrapper.Utils;
using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using static EOD.API;

namespace EODHistoricalData.Wrapper.NetCore.Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass()]
    public class APITest
    {
        private readonly API _api;
        private readonly API _apiProxy;
        private readonly API _apiSource;

        public APITest()
        {
            string apiKey = null;
            try
            {
                apiKey = File.ReadAllText(@"D:\EOD files\apikey.txt");
            }
            catch
            {
                throw;
            }
            finally
            {
                apiKey ??= "demo";
            }
            System.Net.WebProxy proxy = new("localhost:80");
            _api = new API(apiKey);
            _apiProxy = new API(apiKey, proxy);
            _apiSource = new API(apiKey, null, "EODHistoricalData.Downloader");
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetTechnicalsDataAsyncTest()
        {
            var param = new List<IndicatorParameters>()
            {
                new IndicatorParameters("function", "bbands")
            };
            var result = await _api.GetTechnicalIndicatorsAsync("AAPL.US", new DateTime(2023, 1, 1), new DateTime(2023, 6, 1), Order.Descending, param);
            Assert.IsNotNull(result); // (22.09.2023) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetFundamentalDataAsyncTest_LSE()
        {
            var result = await _api.GetFundamentalDataAsync("0R2T.LSE");
            Assert.IsNotNull(result); // (28.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetDivErr()
        {
            try
            {
                var result = await _api.GetHistoricalDividendsAsync("!BCOMF3T.US", new DateTime(2020, 1, 1), new DateTime(2022, 1, 1));
                Assert.Fail("No exception was thrown");
            }
            catch (HttpRequestExceptionExtended ex)
            {
                Assert.AreEqual(System.Net.HttpStatusCode.UnprocessableEntity, ex.StatusCode); // (29.09.2022) ok
            }
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetETFDataAsyncTest()
        {
            var result = await _api.GetFundamentalDataAsync("VTI.US");
            var susratio = result.ETF_Data.MorningStar.Sustainability_Ratio;
            Assert.IsNotNull(result); // (19.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetETFDataAsyncTest_BIS()
        {
            var result = await _api.GetFundamentalDataAsync("BIS.US");
            Assert.IsNotNull(result); // (10.10.2024) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetETFDataAsyncTest_CMDT()
        {
            var result = await _api.GetFundamentalDataAsync("CMDT.US");
            Assert.IsNotNull(result); // (10.10.2024) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetMutualFundDataAsyncTest_AAIDX()
        {
            var result = await _api.GetFundamentalDataAsync("AAIDX.US");
            double? percentage = result.MutualFund_Data.Top_Holdings[0].Weight;
            Assert.IsNotNull(result); // (18.10.2024) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetFundamentalDataAsyncTest()
        {
            var result = await _api.GetFundamentalDataAsync("AAPL.US");
            DateTime? IPO_Date = result.General.IPODate;
            Assert.IsNotNull(result); // (19.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetFundamentalDataAsyncTest_GN()
        {
            var result = await _api.GetFundamentalDataAsync("GN1.IR");
            DateTime? mrq = result.Highlights.MostRecentQuarter;
            Assert.IsNull(mrq); // (19.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetFundamentalDataAsyncTest_Crypto()
        {
            var result = await _api.GetFundamentalDataAsync("BTC-USD.CC");
            string doc = result.Statistics.TechnicalDoc;
            Assert.IsNotNull(doc); // (10.03.2023) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetBulkFundamentalExtendedDataAsyncTest_Nasdaq()
        {
            var result = await _api.GetBulkFundamentalsExtendedDataAsync("NASDAQ", 500, 5);
            Assert.IsNotNull(result); // (31.07.2023) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetFundamentalDataAsyncTest_BNT()
        {
            var result = await _api.GetFundamentalDataAsync("BNT1.f");
            Assert.IsNotNull(result); // (23.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetBulkFundamentalDataAsyncTest_NASDAQ()
        {
            var result = await _api.GetBulkFundamentalsDataAsync("NASDAQ", 500, 5);
            Assert.IsNotNull(result); // (06.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetExchangeDetailsAsyncTest_US()
        {
            var result = await _api.GetExchangeDetailsAsync("US");
            var holidaysDictionary = result.ExchangeHolidays;
            List<(DateTime?, string, string)> holidaysList = new();
            foreach (var holiday in holidaysDictionary)
            {
                DateTime? holidayDate = holiday.Value.Date;
                string holidayName = holiday.Value.Holiday;
                string holidayType = holiday.Value.Type;
                holidaysList.Add((holidayDate, holidayName, holidayType));
            }
            Assert.IsNotNull(result); // (06.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetStockMarketScreenerAsyncTest_AAPL()
        {
            var filters = new List<(Field, Operation, string)>
            {
                (Field.MarketCapitalization, Operation.More, "1000"),
                (Field.Name, Operation.Matches, "apple"),
                (Field.Code, Operation.Equals, "AAPL"),
                (Field.Exchange, Operation.Equals, "us"),
                (Field.Sector, Operation.Equals, "Technology")
            };

            var result = await _api.GetStockMarketScreenerAsync(filters, null, null, 10, 0);
            Assert.IsNotNull(result); // (06.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetStockMarketScreenerAsyncTest_USSignals()
        {
            var filters = new List<(Field, Operation, string)>
            {
                (Field.MarketCapitalization, Operation.More, "1000"),
                (Field.Exchange, Operation.Equals, "us")
            };

            var signals = new List<Signal>
            {
                Signal.Wallstreet_hi
            };

            (Field, Order) sort = (Field.Name, Order.Descending);

            var result = await _api.GetStockMarketScreenerAsync(filters, signals, sort, 10, 10);
            Assert.IsNotNull(result);
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetIntadayDataAsyncTest_ErrorTicker()
        {
            const string BAD_TICKER = "AAPLUS";
            try
            {
                var result = await _api.GetIntradayHistoricalStockPriceAsync(BAD_TICKER,
                    new DateTime(2021, 12, 10), new DateTime(2021, 12, 11), API.IntradayHistoricalInterval.OneHour);
                Assert.Fail("No exception was thrown");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Ticker is empty or has no splitter. (Parameter 'ticker')", ex.Message);
            }
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetIntadayDataAsyncTest_1h()
        {
            var result = await _api.GetIntradayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 12, 10), new DateTime(2021, 12, 11), IntradayHistoricalInterval.OneHour);
            Assert.IsNotNull(result);
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetIntadayDataAsyncTest_1m()
        {
            var result = await _api.GetIntradayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 12, 10), new DateTime(2021, 12, 11), IntradayHistoricalInterval.OneMinute);
            Assert.IsNotNull(result);
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetIntadayDataAsyncTest_5m()
        {
            var result = await _api.GetIntradayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 12, 10), new DateTime(2021, 12, 11), IntradayHistoricalInterval.FiveMinutes);
            Assert.IsNotNull(result);
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetEndOfDayDataAsyncTest_1d()
        {
            var result = await _api.GetEndOfDayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), HistoricalPeriod.Daily);
            Assert.IsNotNull(result);
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetEndOfDayDataAsyncTest_INDVLSE()
        {
            var result = await _api.GetEndOfDayHistoricalStockPriceAsync("INDV.LSE", new DateTime(2021, 12, 20), new DateTime(2022, 3, 11), HistoricalPeriod.Daily);
            Assert.IsNotNull(result);
        }

        //[Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        //public async Task GetEndOfDayDataAsyncTest_Proxy()
        //{
        //    var result = await _apiProxy.GetEndOfDayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), HistoricalPeriod.Daily);
        //    Assert.IsNotNull(result); // TODO find proxy to check
        //}

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetEndOfDayDataAsyncTest_1w()
        {
            var result = await _api.GetEndOfDayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), HistoricalPeriod.Weekly);
            Assert.IsNotNull(result); // (06.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetEndOfDayDataAsyncTest_Source()
        {
            var result = await _apiSource.GetEndOfDayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), HistoricalPeriod.Weekly);
            Assert.IsNotNull(result); // (06.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetEndOfDayDataAsyncTest_1m()
        {
            var result = await _api.GetEndOfDayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), API.HistoricalPeriod.Monthly);
            Assert.IsNotNull(result); // (06.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetUserDataAsyncTest()
        {
            var result = await _api.GetUserDataAsync();
            Assert.IsNotNull(result); // (06.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetSearchResultAsyncTest()
        {
            var result = await _api.GetSearchResultAsync("AAP");
            Assert.IsNotNull(result); // (06.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetFundamentalDataAsyncTest_AAPL()
        {
            // TODO add sub fundamentals?
            var result = await _api.GetFundamentalDataAsync("AAPL.US");
            Assert.IsNotNull(result); // (06.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetFundamentalDataAsyncTest_VTI_ETF()
        {
            var result = await _api.GetFundamentalDataAsync("VTI.US");
            Assert.IsNotNull(result); // (06.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetFundamentalDataAsyncTest_SWPPX_MutualFund()
        {
            var result = await _api.GetFundamentalDataAsync("SWPPX.US");
            Assert.IsNotNull(result); // (06.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetFundamentalDataAsyncTest_GSPC_IndexConstituents()
        {
            var result = await _api.GetFundamentalDataAsync("GSPC.INDX");
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetLiveStockPricesAsyncTest()
        {
            var result = await _api.GetLiveStockPricesAsync("APETNQ.JSE");
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetManyLiveStockPricesAsyncTest()
        {
            var result = await _api.GetLiveStockPricesAsync("AAPL.US", new List<string> { "VTI", "EUR.FOREX" });
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetExchangeAsyncTest()
        {
            var result = await _api.GetExchangeAsync();
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetHistoricalDividendsAsyncTest()
        {
            var result = await _api.GetHistoricalDividendsAsync("AAPL.US", new DateTime(2000, 1, 1), new DateTime(2021, 12, 1));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetHistoricalSplitsAsyncTest()
        {
            var result = await _api.GetHistoricalSplitsAsync("AAPL.US", new DateTime(2000, 1, 1), new DateTime(2022, 01, 1));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetMacroIndicatorsAsyncTest_NetMigrtion()
        {
            var result = await _api.GetMacroIndicatorsAsync("FRA", "net_migration");
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetExchangeSymbolsAsyncTest_US()
        {
            var result = await _api.GetExchangeSymbolsAsync("US");
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetOptionsDataAsyncTest()
        {
            var result = await _api.GetOptionsDataAsync("AAPL.US", null, null, null, null, null);
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetEconomicEventsDataAsyncTest_US2021()
        {
            var result = await _api.GetEconomicEventsDataAsync(new DateTime(2021, 01, 1), new DateTime(2022, 12, 31), "US", null, null, null);
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetInsiderTransactionsAsyncTest_AAPLUS2021()
        {
            var result = await _api.GetInsiderTransactionsAsync(null, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31), "AAPL.US");
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetUpcomingEarningsAsyncTest_AAPL2022()
        {
            var result = await _api.GetUpcomingEarningsAsync(new DateTime(2019, 01, 1), new DateTime(2021, 12, 31), "AAPL.US");
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetEarningTrendsAsyncTest_AAPLMS()
        {
            var result = await _api.GetEarningTrendsAsync("AAPL.US, MS");
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetUpcomingIPOsAsyncTest_2018Dec()
        {
            var result = await _api.GetUpcomingIPOsAsync(new DateTime(2018, 12, 1), new DateTime(2018, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetUpcomingSplitsAsyncTest_2018Dec()
        {
            var result = await _api.GetUpcomingSplitsAsync(new DateTime(2018, 12, 1), new DateTime(2018, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetBondsFundamentalDataAsyncTest_910047AG4()
        {
            var result = await _api.GetBondsFundamentalDataAsync("910047AG4");
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetBondHistoricalDataAsyncTest_US910047AG49()
        {
            var result = await _api.GetBondHistoricalDataAsync("US910047AG49.BOND", new DateTime(2017, 08, 1));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetMacroeconomicsDataAsyncTest_UK1Year()
        {
            var result = await _api.GetMacroeconomicsDataAsync("UK1Y.GBOND");
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetMacroeconomicsDataAsyncTest_EURIBOR3M()
        {
            var result = await _api.GetMacroeconomicsDataAsync("EURIBOR3M.MONEY");
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetMacroeconomicsDataAsyncTest_LIBOREUR2M()
        {
            var result = await _api.GetMacroeconomicsDataAsync("LIBOREUR2M.MONEY");
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetMacroeconomicsDataAsyncTest_STIBOR1M()
        {
            var result = await _api.GetMacroeconomicsDataAsync("STIBOR1M.MONEY");
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetBulksAsyncTest_USAPPLMSFT()
        {
            var result = await _api.GetBulksAsync("US",  Model.Bulks.BulkQueryTypes.EndOfDay, null, "MSFT, AAPL");
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetExtendedBulksAsyncTest_USAPPLMSFT()
        {
            var result = await _api.GetExtendedBulksAsync("US", Model.Bulks.BulkQueryTypes.EndOfDay, null, "MSFT, AAPL");
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetBulksAsyncTest_standart()
        {
            var result = await _api.GetBulksAsync("BA", Model.Bulks.BulkQueryTypes.EndOfDay, new DateTime(2024,2,14), "LOMA.BA");
            Assert.IsNotNull(result); 
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetBulksAsyncTest_splits()
        {
            var result = await _api.GetBulksAsync("US",  Model.Bulks.BulkQueryTypes.Splits, null, null);
            Assert.IsNotNull(result); // (07.09.2022) not ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetBulksAsyncTest_dividends()
        {
            var result = await _api.GetBulksAsync("US",  Model.Bulks.BulkQueryTypes.Dividents, null, null);
            Assert.IsNotNull(result); // (07.09.2022) not ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetFinancialNewsAsyncTest_AAPLUS2021Dec()
        {
            var result = await _api.GetFinancialNewsAsync("AAPL.US", null, new DateTime(2021, 12, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetSMAAsyncTest_AAPL()
        {
            var result = await _api.GetSMAAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetEMAAsyncTest_AAPL()
        {
            var result = await _api.GetEMAAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetWMAAsyncTest_AAPL()
        {
            var result = await _api.GetWMAAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetSplitAdjustedDataAsyncTest_AAPL()
        {
            var result = await _api.GetSplitAdjustedDataAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetAverageVolumeAsyncTest_AAPL()
        {
            var result = await _api.GetAverageVolumeAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetAverageVolumebyPriceAsyncTest_AAPL()
        {
            var result = await _api.GetAverageVolumebyPriceAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetVolatilityAsyncTest_AAPL()
        {
            var result = await _api.GetVolatilityAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetStochasticAsyncTest_AAPL()
        {
            var result = await _api.GetStochasticAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetRelativeStrengthIndexAsyncTest_AAPL()
        {
            var result = await _api.GetRelativeStrengthIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetStandardDeviationAsyncTest_AAPL()
        {
            var result = await _api.GetStandardDeviationAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetStochasticRelativeStrengthIndexAsyncTest_AAPL()
        {
            var result = await _api.GetStochasticRelativeStrengthIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetSlopeAsyncTest_AAPL()
        {
            var result = await _api.GetSlopeAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetDirectionalMovementIndexAsyncTest_AAPL()
        {
            var result = await _api.GetDirectionalMovementIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetAverageDirectionalMovementIndexAsyncTest_AAPL()
        {
            var result = await _api.GetAverageDirectionalMovementIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetMovingAverageConvergenceAsyncTest_AAPL()
        {
            var result = await _api.GetMovingAverageConvergenceAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetAverageTrueRangeAsyncTest_AAPL()
        {
            var result = await _api.GetAverageTrueRangeAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetCommodityChannelIndexAsyncTest_AAPL()
        {
            var result = await _api.GetCommodityChannelIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetParabolicSARAsyncTest_AAPL()
        {
            var result = await _api.GetParabolicSARAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetAmiBrokerDataAsyncTest_AAPL()
        {
            var result = await _api.GetAmiBrokerDataAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetSentimentsAsyncTest_DEMO()
        {
            List<string> symbols = new() { "btc-usd.cc", "aapl" };
            var result = await _api.GetSentimentsAsync(symbols, new DateTime(2022, 01, 1), new DateTime(2022, 04, 22));
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetTweetsSentimentsAsyncTest_DEMO()
        {
            List<string> symbols = new() { "tsla", "aapl" };
            var result = await _api.GetSentimentsAsync(symbols, new DateTime(2022, 01, 1), new DateTime(2022, 04, 22), true);
            Assert.IsNotNull(result); // (07.09.2022) ok
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        public async Task GetBollingerBandsAsyncTest_AAPL()
        {
            var result = await _api.GetBollingerBandsAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result); // (07.24.2023) ok
        }
    }
}