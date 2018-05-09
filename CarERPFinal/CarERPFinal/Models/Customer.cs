using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarERPFinal.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstNameMI { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
        ICollection<Request> Requests { get; set; }
    }
}
