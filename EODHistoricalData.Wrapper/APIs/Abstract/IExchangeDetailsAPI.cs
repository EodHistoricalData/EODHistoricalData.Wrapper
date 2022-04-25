using EOD.Model.ExchangeDetails;

using System;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
    internal interface IExchangeDetailsAPI
    {
        /// <summary>
        /// To get details on each exchange
        /// </summary>
        Task<ExchangeDetail> GetExchangeDetailsAsync(string code, DateTime? from = null, DateTime? to = null);
    }
}
