using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace license_desktop.Data.Models.Accounts
{
    public class AccountDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [DefaultValue(null)]
        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [DefaultValue(null)]
        [JsonProperty("last_name")]
        public string? LastName { get; set; }

        [DefaultValue(null)]
        [JsonProperty("register_name")]
        public string? RegisterName { get; set; }

        [DefaultValue(null)]
        [JsonProperty("comment")]
        public string? Comment { get; set; }
    }
}
