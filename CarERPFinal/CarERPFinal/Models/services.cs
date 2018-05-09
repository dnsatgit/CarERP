using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarERPFinal.Models
{
    public class Services
    {
        public int ID { get; set; }
        public string ServiceName { get; set; }

        [Display(Name ="Listed Date")]
        [DataType(DataType.Date)]
        public DateTime ListedDate { get; set; }
        public string ServiceType { get; set; }
        public decimal Price { get; set; }
        public string CustomerRating { get; set; }

        public ICollection<Request> Requests { get; set; }
    }
}
