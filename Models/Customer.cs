using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel_MS.Models
{
    public class Customer
    {
        [Key]
        public int Customer_id { get; set; }
        [Required]
        public string First_name { get; set; }
        [Required]
        public string Last_name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string CNIC { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
    }
}