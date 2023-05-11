using license_desktop.Data.Models.Accounts;
using license_desktop.Data.Models.Customers;
using System.Web;
using license_desktop.Data.Models;

namespace license_desktop.Data.Api
{
    public class CustomerClient
    {
        public static async Task<WebResult<CustomerDto>> GetCustomer(int customer_id)
        {
            var uriBuilder = new UriBuilder(APIClient.APIClient.BaseURL);
            uriBuilder.Path = $"/customers/{customer_id}";
            var outURL = uriBuilder.ToString();

            return await APIClient.APIClient.RequestAsync<CustomerDto, object?>(
                method: "GET",
                address: outURL,
                data: null
                );
        }

        public static async Task<WebResult<SmallCustomerDto>> UpdateCustomer(int customer_id, UpdateCustomerDto data)
        {
            var uriBuilder = new UriBuilder(APIClient.APIClient.BaseURL);
            uriBuilder.Path = $"/customers/{customer_id}";
            var outURL = uriBuilder.ToString();

            return await APIClient.APIClient.RequestAsync<SmallCustomerDto, UpdateCustomerDto>(
                method: "PATCH",
                address: outURL,
                data: data
                );
        }
    }
}