﻿using EOD.Model.Bulks;

namespace EOD.APIs.Abstract
{
    internal interface IBulkAPI
    {
        /// <summary>
        /// To get the full list of supported exchanges with names, codes, operating MICs, country, and currency
        /// </summary>
        Task<List<Bulk>> GetBulksAsync(string code, string? type, DateTime? date, string? symbols);

        /// <summary>
        /// To get the full list of supported exchanges with names, codes, operating MICs, country, and currency
        /// </summary>
        Task<List<ExtendedBulk>> GetExtendedBulksAsync(string code, string? type, DateTime? date, string? symbols);
    }
}
