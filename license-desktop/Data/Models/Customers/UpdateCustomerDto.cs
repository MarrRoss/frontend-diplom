using Newtonsoft.Json;

namespace license_desktop.Data.Models.Customers
{
    public class UpdateCustomerDto
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("register_name")]
        public string RegisterName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        [JsonProperty("street_id")]
        public int StreetId { get; set; }

        [JsonProperty("city_id")]
        public int CityId { get; set; }

        [JsonProperty("zip_id")]
        public int ZipId { get; set; }

        [JsonProperty("state_id")]
        public int StateId { get; set; }

        [JsonProperty("phone_id")]
        public int PhoneId { get; set; }
    }

}
