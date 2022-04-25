using EOD.APIs.Abstract;
using EOD.Model;

using System.Threading.Tasks;

namespace EOD.APIs
{
    internal class UserAPI : BaseAPI, IUserAPI
    {
        private const string source = "https://eodhistoricaldata.com/api/user";
        public UserAPI(string apiKey, System.Net.IWebProxy proxy, string source) : base(apiKey, proxy, source) { }
        public async Task<User> GetUserAsync()
        {
            return await ExecuteQueryAsync<User>(source);
        }

    }
}
