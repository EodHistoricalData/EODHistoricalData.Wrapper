using EOD.Model;

using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
	/// <summary>
	/// User API
	/// </summary>
	internal interface IUserAPI
	{
		/// <summary>
		/// To get user details
		/// </summary>
		Task<User> GetUserAsync();

	}
}
