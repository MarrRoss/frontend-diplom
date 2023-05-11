using license_desktop.Data.Models;
using license_desktop.Data.Models.Orders;

namespace license_desktop.Data.Api
{
    public class OrderClient
    {
        public static async Task<WebResult<List<OrderDto>>> GetOrders(int account_id)
        {
            var uriBuilder = new UriBuilder(APIClient.APIClient.BaseURL);
            uriBuilder.Path = $"/accounts/{account_id}/orders";
            var outURL = uriBuilder.ToString();

            return await APIClient.APIClient.RequestAsync<List<OrderDto>, object?>(
                method: "GET",
                address: outURL,
                data: null
                );
        }

        public static async Task<WebResult<OrderDto>> GetOrder(int account_id, int order_id)
        {
            var uriBuilder = new UriBuilder(APIClient.APIClient.BaseURL);
            uriBuilder.Path = $"/accounts/{account_id}/orders/{order_id}";
            var outURL = uriBuilder.ToString();

            return await APIClient.APIClient.RequestAsync<OrderDto, object?>(
                method: "GET",
                address: outURL,
                data: null
                );
        }

        public static async Task<WebResult<List<OrderDto>>> GetOrderUpgrades(int account_id, int order_id)
        {
            var uriBuilder = new UriBuilder(APIClient.APIClient.BaseURL);
            uriBuilder.Path = $"/accounts/{account_id}/orders/{order_id}/upgrades";
            var outURL = uriBuilder.ToString();

            return await APIClient.APIClient.RequestAsync<List<OrderDto>, object?>(
                method: "GET",
                address: outURL,
                data: null
                );
        }
    }
}