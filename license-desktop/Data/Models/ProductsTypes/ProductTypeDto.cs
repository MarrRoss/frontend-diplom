using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace license_desktop.Data.Models.ProductsTypes
{
    public class ProductTypeDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_main_product")]
        public bool IsMainProduct { get; set; }

        [JsonProperty("lifetime")]
        public bool Lifetime { get; set; }

        [JsonProperty("versioned")]
        public bool Versioned { get; set; }

        [JsonProperty("upgradable")]
        public bool Upgradable { get; set; }
    }
}
