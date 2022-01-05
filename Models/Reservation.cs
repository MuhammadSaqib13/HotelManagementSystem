using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hotel_MS.Models
{
    public class Reservation
    {
        [Key]
        public int Reservation_Id { get; set; }
        [Required]
        public int Customer_id { get; set; }
        [ForeignKey("Customer_id")]
        public Customer Customers { get; set; }
        [Required]
        public DateTime Departure_Date { get; set; }
        [Required]
        public DateTime Arrival_Date { get; set; }
        [Required]
        public int Room_No { get; set; }
        [ForeignKey("Room_No")]
        public Room Rooms { get; set; }
        [Required]
        public int No_of_Persons { get; set; }

    }
}