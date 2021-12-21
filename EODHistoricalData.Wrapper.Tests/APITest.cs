using EOD;

using NUnit.Framework;

using System;
using System.Threading.Tasks;

namespace EODHistoricalData.Wrapper.NetCore.Tests
{
    public class APITest
    {
        private readonly API _api;

        public APITest()
        {
            string apiKey = "OeAFFmMliFG5orCUuwAKQ8l4WWFQ67YX";
            _api = new API(apiKey);
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
            var result = await _api.GetEndOfDayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), API.EndOfDayHistoricalPeriod.Daily);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetEndOfDayDataAsyncTest_1w()
        {
            var result = await _api.GetEndOfDayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), API.EndOfDayHistoricalPeriod.Weekly);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetEndOfDayDataAsyncTest_1m()
        {
            var result = await _api.GetEndOfDayHistoricalStockPriceAsync("AAPL.US", new DateTime(2021, 1, 10), new DateTime(2021, 12, 11), API.EndOfDayHistoricalPeriod.Monthly);
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
        public async Task GetFundamentalDataAsyncTest()
        {
            var result = await _api.GetFundamentalDataAsync("AAPL.US");
            Assert.IsNotNull(result);
        }
    }
}