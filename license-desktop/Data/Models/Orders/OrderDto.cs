using license_desktop.Data.Models.Customers;
using license_desktop.Data.Models.Keys;
using license_desktop.Data.Models.PaymentsTypes;
using license_desktop.Data.Models.Products;
using license_desktop.Data.Models.Sources;
using Newtonsoft.Json;
using System.ComponentModel;

namespace license_desktop.Data.Models.Orders
{
    public class OrderDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("purchase_id")]
        public int PurchaseId { get; set; }

        [DefaultValue(null)]
        [JsonProperty("internal_order_type_id")]
        public int? InternalOrderTypeId { get; set; }

        [DefaultValue(null)]
        [JsonProperty("previous_order_id")]
        public int? PreviousOrderId { get; set; }

        [DefaultValue(null)]
        [JsonProperty("num_license")]
        public int? NumLicense { get; set; }

        [DefaultValue(null)]
        [JsonProperty("comments")]
        public string? Comments { get; set; }

        [DefaultValue(null)]
        [JsonProperty("addtional1")]
        public string? Addtional1 { get; set; }

        [DefaultValue(null)]
        [JsonProperty("addtional2")]
        public string? Addtional2 { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("creating_date")]
        public DateTime CreatingDate { get; set; }

        [DefaultValue(null)]
        [JsonProperty("last_modified_date")]
        public DateTime? LastModifiedDate { get; set; }

        [JsonProperty("product")]
        public ProductDto Product { get; set; }

        [JsonProperty("payment_type")]
        public PaymentTypeDto PaymentType { get; set; }

        [JsonProperty("customer")]
        public CustomerDto Customer { get; set; }

        [JsonProperty("source")]
        public SourceDto Source { get; set; }

        [JsonProperty("key")]
        public KeyDto Key { get; set; }
    }
}
