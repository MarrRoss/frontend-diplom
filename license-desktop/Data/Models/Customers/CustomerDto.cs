using license_desktop.Data.Models.Cities;
using license_desktop.Data.Models.Companies;
using license_desktop.Data.Models.Countries;
using license_desktop.Data.Models.Phones;
using license_desktop.Data.Models.Streets;
using license_desktop.Data.Models.ZipCodes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using license_desktop.Data.Models.States;

namespace license_desktop.Data.Models.Customers
{
    public class CustomerDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("register_name")]
        public string RegisterName { get; set; }

        [JsonProperty("creating_date")]
        public DateTime CreatingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("last_modified_date")]
        public DateTime LastModifiedDate { get; set; }

        [JsonProperty("company")]
        public CompanyDto Company { get; set; }

        [JsonProperty("country")]
        public CountryDto Country { get; set; }

        [JsonProperty("street")]
        public StreetDto Street { get; set; }

        [JsonProperty("city")]
        public CityDto City { get; set; }

        [JsonProperty("zip")]
        public ZipCodeDto Zip { get; set; }

        [JsonProperty("state")]
        public StateDto State { get; set; }

        [JsonProperty("phone")]
        public PhoneDto Phone { get; set; }
    }

    public class SmallCustomerDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("register_name")]
        public string RegisterName { get; set; }

        [JsonProperty("creating_date")]
        public DateTime CreatingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("last_modified_date")]
        public DateTime LastModifiedDate { get; set; }

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
