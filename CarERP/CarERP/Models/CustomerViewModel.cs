using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarERP.Models
{
    public class CustomerViewModel
    {

        [DisplayName("First Name:")]
        [Required]
        [StringLength(15)]
        public string first_name { get; set; }

        [DisplayName("Last Name:")]
        [Required]
        [StringLength(20)]
        public string last_name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public Int64 phone { get; set; }

        [DisplayName("Email ID:")]
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        [StringLength(20)]
        public string email { get; set; }

        [DisplayName("Address:")]
        [Required]
        [StringLength(20)]
        public string address { get; set; }

        [DisplayName("Relational ID")]
        [Required]
        [Range(1, 99999)]
        public int id { get; set; }

        [DisplayName("Acknowledgment")]
        [Required]
        public bool IAcknowledge { get; set; }
    }
}