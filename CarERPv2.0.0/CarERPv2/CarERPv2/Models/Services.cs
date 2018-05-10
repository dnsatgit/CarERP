using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarERPv2.Models
{
    public class Services
    {
        public int ServicesID { get; set; }

        public string ServiceName { get; set; }

        [Display(Name = "Listed Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ListedDate { get; set; }
        public string ServiceType { get; set; }
        public decimal Price { get; set; }
        public string CustomerRating { get; set; }

        public ICollection<Request> Requests { get; set; }
    }
}
