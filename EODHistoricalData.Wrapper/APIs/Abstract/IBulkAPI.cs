using EOD.Model.Bulks;

using EODHistoricalData.Wrapper.Model.Bulks;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
    internal interface IBulkAPI
    {
        /// <summary>
        /// To get the full list of supported exchanges with names, codes, operating MICs, country, and currency
        /// </summary>
        Task<List<Bulk>> GetBulksAsync(string code, BulkQueryTypes type, DateTime? date, string symbols);

        /// <summary>
        /// To get the full list of supported exchanges with names, codes, operating MICs, country, and currency
        /// </summary>
        Task<List<ExtendedBulk>> GetExtendedBulksAsync(string code, BulkQueryTypes type, DateTime? date, string symbols);
    }
}
