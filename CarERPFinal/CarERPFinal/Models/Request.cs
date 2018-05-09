using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarERPFinal.Models
{
    public class Request
    {
        public int RequestID { get; set; }
        public string ServiceID { get; set; }
        public string CustomerID { get; set; }
        public string Vehicle { get; set; }
        public string Description { get; set; }
        public string Cost { get; set; }
        
        public Services service { get; set; }
        public Customer customer { get; set; }
    }
}
