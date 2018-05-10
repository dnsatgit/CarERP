using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarERPv2.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [DisplayName("First Name:")]
        [Required]
        [StringLength(20)]
        public string FirstNameMI { get; set; }

        [DisplayName("Last Name:")]
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [DisplayName("Date of Birth:")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [DisplayName("Address:")]
        public string Address { get; set; }

        [DisplayName("Email ID:")]
        [Required]
        [StringLength(20)]
        public string email { get; set; }

        [DisplayName("Contact:")]
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [DisplayName("Username:")]
        [Required]
        public string UserName { get; set; }

        [DisplayName("Password:")]
        [Required]
        [PasswordPropertyText]
        public string password { get; set; }

        ICollection<Request> Requests { get; set; }
    }
}
