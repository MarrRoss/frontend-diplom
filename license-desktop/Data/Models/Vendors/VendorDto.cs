using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace license_desktop.Data.Models.Vendors
{
    public class VendorDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("external_vendor_id")]
        public int ExternalVendorId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("creating_date")]
        public DateTime CreatingDate { get; set; }

        [JsonProperty("last_modified_date")]
        public DateTime LastModifiedDate { get; set; }
    }
}
