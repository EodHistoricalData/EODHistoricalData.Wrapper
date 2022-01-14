namespace EOD.APIs.Abstract
{
    internal interface IInsiderTransactionsAPI
    {
        Task<List<InsiderTransaction>> GetInsiderTransactionsAsync(int? limit = null, DateTime? from = null, DateTime? to = null, string? ticker = null);
    }
}
