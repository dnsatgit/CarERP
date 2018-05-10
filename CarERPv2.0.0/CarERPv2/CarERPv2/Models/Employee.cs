using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarERPv2.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string FirstNameMI { get; set; }
        public string LastName { get; set; }

        public Request requests { get; set; }
        public bool RequestValidation { get; set; }


        public ICollection<Request> Requests { get; set; }

    }
}
