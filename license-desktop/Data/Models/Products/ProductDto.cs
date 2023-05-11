using license_desktop.Data.Models.Editions;
using license_desktop.Data.Models.ProductsGroups;
using license_desktop.Data.Models.ProductsTypes;
using license_desktop.Data.Models.Vendors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace license_desktop.Data.Models.Products
{
    public class ProductDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("external_product_id")]
        public int ExternalProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("platform_id")]
        public int PlatformId { get; set; }

        [JsonProperty("edition_id")]
        public int EditionId { get; set; }

        [JsonProperty("previous_edition_id")]
        public int? PreviousEditionId { get; set; }

        [JsonProperty("previous_version")]
        public int? PreviousVersion { get; set; }

        [JsonProperty("previous_platform_id")]
        public int? PreviousPlatformId { get; set; }

        [JsonProperty("is_released")]
        public bool IsReleased { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("product_type")]
        public ProductTypeDto ProductType { get; set; }

        [JsonProperty("product_group")]
        public ProductGroupDto ProductGroup { get; set; }

        [JsonProperty("edition")]
        public EditionDto Edition { get; set; }

        [JsonProperty("vendor")]
        public VendorDto Vendor { get; set; }
    }
}
