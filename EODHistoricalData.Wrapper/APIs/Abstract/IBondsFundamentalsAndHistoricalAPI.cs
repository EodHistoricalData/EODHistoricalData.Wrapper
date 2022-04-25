using EOD.Model;
using EOD.Model.BondsFundamentalData;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        Task<List<BondHistoricalData>> GetBondHistoricalDataAsync(string code, DateTime? from = null, DateTime? to = null, string order = null, string period = null);
    }
}
