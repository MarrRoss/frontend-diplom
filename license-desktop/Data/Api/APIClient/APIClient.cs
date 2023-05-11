using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using license_desktop.Data.Models;

namespace license_desktop.Data.Api.APIClient
{
    public class APIClient
    {
        public static readonly string BaseURL = "https://license.mrn.shitposting.team";

        public static async Task<HttpResponseMessage> BaseRequestAsync(
            string method,
            string address,
            string data = ""
            )
        {

            HttpClient client = new();

            var JSONStringContent = new StringContent(data, Encoding.UTF8, "application/json");

            try
            {
                switch (method)
                {
                    case "POST":
                        return await client.PostAsync(address, JSONStringContent);
                    case "PUT":
                        return await client.PutAsync(address, JSONStringContent);
                    case "GET":
                        return await client.GetAsync(address);
                    case "PATCH":
                        return await client.PatchAsync(address, JSONStringContent);
                    case "DELETE":
                        return await client.DeleteAsync(address);
                }
            }

            catch (Exception exc)
            {
                Debug.WriteLine("Error" + exc.ToString());
            }
            finally
            {
                client.Dispose();
            }

            throw new Exception("Error API Client!");
        }

        public static async Task<WebResult<T>> RequestAsync<T, TData>(
            string method,
            string address,
            TData data
    )
        {
            HttpResponseMessage result;

            if (data != null)
            {
                string jsonData = JsonConvert.SerializeObject(data);
                result = await BaseRequestAsync(method, address, jsonData);
            }
            else
            {
                result = await BaseRequestAsync(method, address);
            }
            var responseContent = await result.Content.ReadAsStringAsync();
            if ((int)result.StatusCode >= 300)
            {
                Error detail = null;
                try
                {
                    detail = JsonConvert.DeserializeObject<Error>(responseContent);
                }
                catch
                {
                }

                if (detail?.Detail != null)
                {
                    return new WebResult<T>(error:detail.Detail);
                }
                return new WebResult<T>(success:false);

            }
            return new WebResult<T>(JsonConvert.DeserializeObject<T>(responseContent));
        }
    }


}
