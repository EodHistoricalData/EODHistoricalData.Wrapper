using EOD;

using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using static EOD.API;

namespace EODHistoricalData.Wrapper.NetCore.Tests
{
    public class APITest
    {
        private readonly API _api;
        private readonly API _apiProxy;
        private readonly API _apiSource;

        public APITest()
        {
            string apiKey = "OeAFFmMliFG5orCUuwAKQ8l4WWFQ67YX";
            System.Net.WebProxy proxy = new("localhost:80");
            _api = new API(apiKey);
            _apiProxy = new API(apiKey, proxy);
            _apiSource = new API(apiKey, null, "EODHistoricalData.Downloader");
        }

        [Test]
        public async Task GetIntadayDataAsyncTest_ErrorTicker()
        {
            try
            {
                var result = await _api.GetIntradayHistoricalStockPriceAsync("AAPLUS", new DateTime(2021, 12, 10), new DateTime(2021, 12, 11), API.IntradayHistoricalInterval.OneHour);
            }
            catch (ArgumentException ex)
            {
                Assert.IsTrue(1 == 1, ex.Message);

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }

        }

        [Test]
        public async Task GetIntadayDataAsyncTest_1h()
        {
            var result = await _api.GetIntradayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 12, 10), new DateTime(2021, 12, 11), API.IntradayHistoricalInterval.OneHour);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetIntadayDataAsyncTest_1m()
        {
            var result = await _api.GetIntradayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 12, 10), new DateTime(2021, 12, 11), API.IntradayHistoricalInterval.OneMinute);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetIntadayDataAsyncTest_5m()
        {
            var result = await _api.GetIntradayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 12, 10), new DateTime(2021, 12, 11), API.IntradayHistoricalInterval.FiveMinutes);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetEndOfDayDataAsyncTest_1d()
        {
            var result = await _api.GetEndOfDayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), API.HistoricalPeriod.Daily);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetEndOfDayDataAsyncTest_Proxy()
        {
            var result = await _apiProxy.GetEndOfDayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), API.HistoricalPeriod.Daily);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetEndOfDayDataAsyncTest_1w()
        {
            var result = await _api.GetEndOfDayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), API.HistoricalPeriod.Weekly);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetEndOfDayDataAsyncTest_Source()
        {
            var result = await _apiSource.GetEndOfDayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), API.HistoricalPeriod.Weekly);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetEndOfDayDataAsyncTest_1m()
        {
            var result = await _api.GetEndOfDayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), API.HistoricalPeriod.Monthly);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetUserDataAsyncTest()
        {
            var result = await _api.GetUserDataAsync();
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetSearchResultAsyncTest()
        {
            var result = await _api.GetSearchResultAsync("AAP");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetFundamentalDataAsyncTest_AAPL()
        {
            var result = await _api.GetFundamentalDataAsync("AAPL.US");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetFundamentalDataAsyncTest_VTI()
        {
            var result = await _api.GetFundamentalDataAsync("VTI.US");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetFundamentalDataAsyncTest_SWPPX()
        {
            var result = await _api.GetFundamentalDataAsync("SWPPX.US");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetFundamentalDataAsyncTest_GSPC()
        {
            var result = await _api.GetFundamentalDataAsync("GSPC.INDX");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetBulkFundamentalDataAsyncTest_NASDAQ()
        {
            var result = await _api.GetBulkFundamentalsDataAsync("NASDAQ", 500, 5);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetLiveStockPricesAsyncTest()
        {
            var result = await _api.GetLiveStockPricesAsync("AAPL.US");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetExchangeAsyncTest()
        {
            var result = await _api.GetExchangeAsync();
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetHistoricalDividendsAsyncTest()
        {
            var result = await _api.GetHistoricalDividendsAsync("AAPL.US", new DateTime(2000, 1, 1), new DateTime(2021, 12, 1));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetHistoricalSplitsAsyncTest()
        {
            var result = await _api.GetHistoricalSplitsAsync("AAPL.US", new DateTime(2000, 1, 1), new DateTime(2022, 01, 1));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetMacroIndicatorsAsyncTest_NetMigrtion()
        {
            var result = await _api.GetMacroIndicatorsAsync("FRA", "net_migration");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetExchangeSymbolsAsyncTest_US()
        {
            var result = await _api.GetExchangeSymbolsAsync("US");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetOptionsDataAsyncTest()
        {
            var result = await _api.GetOptionsDataAsync("AAPL.US", null, null, null, null, null);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetEconomicEventsDataAsyncTest_US2021()
        {
            var result = await _api.GetEconomicEventsDataAsync(new DateTime(2021, 01, 1), new DateTime(2021, 12, 31), "US", null, null, null);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetInsiderTransactionsAsyncTest_AAPLUS2021()
        {
            var result = await _api.GetInsiderTransactionsAsync(null, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31), "AAPL.US");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetUpcomingEarningsAsyncTest_AAPL2022()
        {
            var result = await _api.GetUpcomingEarningsAsync(new DateTime(2019, 01, 1), new DateTime(2021, 12, 31), "AAPL.US");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetEarningTrendsAsyncTest_AAPLMS()
        {
            var result = await _api.GetEarningTrendsAsync("AAPL.US, MS");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetUpcomingIPOsAsyncTest_2018Dec()
        {
            var result = await _api.GetUpcomingIPOsAsync(new DateTime(2018, 12, 1), new DateTime(2018, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetUpcomingSplitsAsyncTest_2018Dec()
        {
            var result = await _api.GetUpcomingSplitsAsync(new DateTime(2018, 12, 1), new DateTime(2018, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetBondsFundamentalDataAsyncTest_910047AG4()
        {
            var result = await _api.GetBondsFundamentalDataAsync("910047AG4");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetBondHistoricalDataAsyncTest_US910047AG49()
        {
            var result = await _api.GetBondHistoricalDataAsync("US910047AG49.BOND", new DateTime(2017, 08, 1));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetMacroeconomicsDataAsyncTest_UK1Year()
        {
            var result = await _api.GetMacroeconomicsDataAsync("UK1Y.GBOND");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetMacroeconomicsDataAsyncTest_EURIBOR3M()
        {
            var result = await _api.GetMacroeconomicsDataAsync("EURIBOR3M.MONEY");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetMacroeconomicsDataAsyncTest_LIBOREUR2M()
        {
            var result = await _api.GetMacroeconomicsDataAsync("LIBOREUR2M.MONEY");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetMacroeconomicsDataAsyncTest_STIBOR1M()
        {
            var result = await _api.GetMacroeconomicsDataAsync("STIBOR1M.MONEY");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetBulksAsyncTest_USAPPLMSFT()
        {
            var result = await _api.GetBulksAsync("US", null, null, "MSFT, AAPL");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetExtendedBulksAsyncTest_USAPPLMSFT()
        {
            var result = await _api.GetExtendedBulksAsync("US", null, null, "MSFT, AAPL");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetExchangeDetailsAsyncTest_US()
        {
            var result = await _api.GetExchangeDetailsAsync("US");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetFinancialNewsAsyncTest_AAPLUS2021Dec()
        {
            var result = await _api.GetFinancialNewsAsync("AAPL.US", null, new DateTime(2021, 12, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
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
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetSMAAsyncTest_AAPL()
        {
            var result = await _api.GetSMAAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetEMAAsyncTest_AAPL()
        {
            var result = await _api.GetEMAAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetWMAAsyncTest_AAPL()
        {
            var result = await _api.GetWMAAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetSplitAdjustedDataAsyncTest_AAPL()
        {
            var result = await _api.GetSplitAdjustedDataAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetAverageVolumeAsyncTest_AAPL()
        {
            var result = await _api.GetAverageVolumeAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetAverageVolumebyPriceAsyncTest_AAPL()
        {
            var result = await _api.GetAverageVolumebyPriceAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetVolatilityAsyncTest_AAPL()
        {
            var result = await _api.GetVolatilityAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetStochasticAsyncTest_AAPL()
        {
            var result = await _api.GetStochasticAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetRelativeStrengthIndexAsyncTest_AAPL()
        {
            var result = await _api.GetRelativeStrengthIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetStandardDeviationAsyncTest_AAPL()
        {
            var result = await _api.GetStandardDeviationAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetStochasticRelativeStrengthIndexAsyncTest_AAPL()
        {
            var result = await _api.GetStochasticRelativeStrengthIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetSlopeAsyncTest_AAPL()
        {
            var result = await _api.GetSlopeAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetDirectionalMovementIndexAsyncTest_AAPL()
        {
            var result = await _api.GetDirectionalMovementIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetAverageDirectionalMovementIndexAsyncTest_AAPL()
        {
            var result = await _api.GetAverageDirectionalMovementIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetMovingAverageConvergenceAsyncTest_AAPL()
        {
            var result = await _api.GetMovingAverageConvergenceAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetAverageTrueRangeAsyncTest_AAPL()
        {
            var result = await _api.GetAverageTrueRangeAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetCommodityChannelIndexAsyncTest_AAPL()
        {
            var result = await _api.GetCommodityChannelIndexAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetParabolicSARAsyncTest_AAPL()
        {
            var result = await _api.GetParabolicSARAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetAmiBrokerDataAsyncTest_AAPL()
        {
            var result = await _api.GetAmiBrokerDataAsync("AAPL.US", 50, new DateTime(2021, 01, 1), new DateTime(2021, 12, 31));
            Assert.IsNotNull(result);
        }
    }
}