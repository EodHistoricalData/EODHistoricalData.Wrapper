using EOD.Model.Fundamental;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace EODHistoricalData.Wrapper.NetCore.Tests
{
    [TestClass]
    public class FundamentalDataDeserializationTests
    {
        [TestMethod]
        public void Deserialize_FundamentalDataWithNaObjectSections_ReturnsNullSections()
        {
            const string json = @"
{
  ""General"": {
    ""Code"": ""SPIEX"",
    ""Type"": ""INDEX"",
    ""Name"": ""Swiss Performance Extra"",
    ""Exchange"": ""INDX"",
    ""MarketCap"": null,
    ""CurrencyCode"": ""CHF"",
    ""CurrencyName"": ""Swiss Franc"",
    ""CurrencySymbol"": ""CHF"",
    ""CountryName"": ""Switzerland"",
    ""CountryISO"": ""CH"",
    ""OpenFigi"": null
  },
  ""SharesStats"": ""NA"",
  ""ESGScores"": ""NA""
}";

            FundamentalData result = JsonConvert.DeserializeObject<FundamentalData>(json);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.General);
            Assert.AreEqual("SPIEX", result.General.Code);
            Assert.AreEqual("Swiss Performance Extra", result.General.Name);
            Assert.IsNull(result.SharesStats);
            Assert.IsNull(result.ESGScores);
        }

        [TestMethod]
        public void Deserialize_FundamentalDataWithObjectSections_PopulatesSections()
        {
            const string json = @"
{
  ""SharesStats"": {
    ""SharesOutstanding"": 1000,
    ""SharesFloat"": 750
  },
  ""ESGScores"": {
    ""TotalEsg"": 12.3,
    ""EnvironmentScore"": 4.5
  }
}";

            FundamentalData result = JsonConvert.DeserializeObject<FundamentalData>(json);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.SharesStats);
            Assert.AreEqual(1000, result.SharesStats.SharesOutstanding);
            Assert.AreEqual(750, result.SharesStats.SharesFloat);
            Assert.IsNotNull(result.ESGScores);
            Assert.AreEqual(12.3, result.ESGScores.TotalEsg);
            Assert.AreEqual(4.5, result.ESGScores.EnvironmentScore);
        }
    }
}
