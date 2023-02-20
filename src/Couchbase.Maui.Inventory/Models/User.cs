using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couchbase.Maui.Inventory.Models
{
    internal record User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Team { get; set; }
    }
}
