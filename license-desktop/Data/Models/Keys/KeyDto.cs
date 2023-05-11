using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace license_desktop.Data.Models.Keys
{
    public class KeyDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("creating_date")]
        public DateTime CreatingDate { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("last_modified_date")]
        public DateTime LastModifiedDate { get; set; }

        [JsonProperty("expiration_date")]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty("count_license")]
        public int CountLicense { get; set; }

        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        [JsonProperty("is_beta_key")]
        public bool IsBetaKey { get; set; }

        [JsonProperty("register_name")]
        public string RegisterName { get; set; }
    }
}
