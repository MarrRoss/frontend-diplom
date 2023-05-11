using license_desktop.Data.Models;

namespace license_desktop.Data.Api
{
    public class IdNameClient
    {
        public static async Task<WebResult<List<T>>> Get<T>(string path)
        {
            var uriBuilder = new UriBuilder(APIClient.APIClient.BaseURL);
            uriBuilder.Path = $"{path}";
            var outURL = uriBuilder.ToString();

            return await APIClient.APIClient.RequestAsync<List<T>, object?>(
                method: "GET",
                address: outURL,
                data: null
                );
        }
    }
}