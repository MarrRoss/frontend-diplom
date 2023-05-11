using license_desktop.Data.Models.Accounts;
using license_desktop.Data.Models.Orders;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace license_desktop.Data.TablesModels
{
    public class AccountTM
    {
        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }

        public string? RegisterName { get; set; }
        
        public string? Comment { get; set; }

        public static explicit operator AccountTM(AccountDto account)
        {
            return new AccountTM
            {
                FirstName = account.FirstName,
                LastName = account.LastName,
                RegisterName = account.RegisterName,
                Comment = account.Comment
            };
        }
    }
}
