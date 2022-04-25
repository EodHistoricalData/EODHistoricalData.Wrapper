using EOD.Model;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
    internal interface IInsiderTransactionsAPI
    {
        Task<List<InsiderTransaction>> GetInsiderTransactionsAsync(int? limit = null, DateTime? from = null, DateTime? to = null, string ticker = null);
    }
}
