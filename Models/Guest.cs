using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hotel_MS.Models
{
    public class Guest
    {
        [Key]
        public int Guest_Id { get; set; }
        [Required]
        public int Members { get; set; }
        [Required]
        public int Adults { get; set; }
        [Required]
        public int Children { get; set; }
        [Required]
        public string Phone_Number { get; set; }
        public int Customer_id { get; set; }

        [ForeignKey("Customer_id")]
        public Customer Customers { get; set; }

    }
}