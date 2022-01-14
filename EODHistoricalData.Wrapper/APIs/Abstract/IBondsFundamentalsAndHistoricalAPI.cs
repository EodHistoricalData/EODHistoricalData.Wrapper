using EOD.Model.BondsFundamentalData;

namespace EOD.APIs.Abstract
{
    internal interface IBondsFundamentalsAndHistoricalAPI
    {
        /// <summary>
        /// To get the full list of supported exchanges with names, codes, operating MICs, country, and currency
        /// </summary>
        Task<BondsFundamentalData> GetBondsFundamendalDataAsync(string cusip);

        /// <summary>
        /// To get the full list of supported exchanges with names, codes, operating MICs, country, and currency
        /// </summary>
        Task<List<BondHistoricalData>> GetBondHistoricalDataAsync(string code, DateTime? from = null, DateTime? to = null, string? order = null, string? period = null);
    }
}
