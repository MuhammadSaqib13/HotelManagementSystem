using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hotel_MS.Models
{
    public class Registered_Customer
    {
        [Key]
        public int UR_Id { get; set; }
        public int Admin_Id { get; set; }
        [ForeignKey("Admin_Id")]
        public System_Admin System_Admins { get; set; }
        public int Customer_id { get; set; }
        [ForeignKey("Customer_id")]
        public Customer Customers { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int CreditCard_No { get; set; }

    }
}