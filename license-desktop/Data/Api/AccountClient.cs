using license_desktop.Data.Models.Accounts;
using System.Web;
using license_desktop.Data.Models;

namespace license_desktop.Data.Api
{
    public class AccountClient
    {
        public static async Task<WebResult<List<AccountDto>>> GetAccounts(int limit = 1000, int offset = 0)
        {
            var uriBuilder = new UriBuilder(APIClient.APIClient.BaseURL);
            uriBuilder.Path = $"/accounts";

            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query.Add("limit", limit.ToString());
            query.Add("offset", offset.ToString());

            uriBuilder.Query = query.ToString();
            var outURL = uriBuilder.ToString();

            return await APIClient.APIClient.RequestAsync<List<AccountDto>, object?>(
                method: "GET",
                address: outURL,
                data: null
                );
        }
    }
}