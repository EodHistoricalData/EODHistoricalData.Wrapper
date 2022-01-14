﻿namespace EOD.APIs.Abstract
{
    internal interface IExchangesAPI
    {
        /// <summary>
        /// To get the full list of supported exchanges with names, codes, operating MICs, country, and currency
        /// </summary>
        Task<List<Exchange>> GetExchangeAsync();
    }
}
