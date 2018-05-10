using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarERPv2.Models
{
    public class Request
    {
        public int RequestID { get; set; }

        public int ServicesID { get; set; }
        public int CustomerID { get; set; }
        public int ItemID { get; set; }

        public string Vehicle { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public Services service { get; set; }
        public Customer customer { get; set; }
        public Item items { get; set; }
    }
}
