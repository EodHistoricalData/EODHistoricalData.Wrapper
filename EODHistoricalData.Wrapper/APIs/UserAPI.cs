namespace EOD.APIs
{
    internal class UserAPI : BaseAPI, IUserAPI
    {
        private const string source = "https://eodhistoricaldata.com/api/user";
        public UserAPI(string apiKey, System.Net.IWebProxy? proxy) : base(apiKey, proxy) { }
        public async Task<User> GetUserAsync()
        {
            return await ExecuteQueryAsync<User>(source);
        }

    }
}
