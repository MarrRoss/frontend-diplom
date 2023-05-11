using license_desktop.Data.Models.Customers;
using license_desktop.Data.Models.Keys;
using license_desktop.Data.Models.PaymentsTypes;
using license_desktop.Data.Models.Products;
using license_desktop.Data.Models.Sources;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using license_desktop.Data.Models.Orders;

namespace license_desktop.Data.TablesModels
{
    public class OrderTM
    {
        public string ProductName { get; set; }
        public string ProductGroupName { get; set; }
        public string ProductType { get; set; }
        public string FIO { get; set; }
        public string Key { get; set; }
        public string CreatingDate { get; set; }

        public static explicit operator OrderTM(OrderDto order)
        {
            return new OrderTM
            {
                ProductName = order.Product.Name,
                ProductGroupName = order.Product.ProductGroup.Name,
                ProductType = order.Product.ProductType.Name,
                FIO = $"{order.Customer.FirstName} {order.Customer.LastName}",
                Key = order.Key.Key,
                CreatingDate = order.CreatingDate.ToString()
            };
        }
    }
}
