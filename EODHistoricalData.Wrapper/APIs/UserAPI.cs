namespace EOD.APIs
{
    internal class UserAPI : BaseAPI, IUserAPI
    {
        private const string source = "https://eodhistoricaldata.com/api/user";
        public UserAPI(string apiKey, bool useProxy) : base(apiKey, useProxy) { }
        public async Task<User> GetUserAsync()
        {
            return await ExecuteQueryAsync<User>(source);
        }

    }
}
