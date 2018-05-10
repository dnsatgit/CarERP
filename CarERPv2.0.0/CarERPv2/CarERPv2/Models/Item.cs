using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarERPv2.Models
{
    public class Item
    {
        public int ItemID { get; set; }

        public string ItemName { get; set; }
        public decimal Price { get; set; }

        public ICollection<Request> Requests { get; set; }
    }
}
