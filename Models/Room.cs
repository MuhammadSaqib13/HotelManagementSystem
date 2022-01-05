using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotel_MS.Models
{
    public class Room
    {
        [Key]
        public int Room_Id { get; set; }
        [Required]
        public int Room_No { get; set; }
        [Required]
        public string Room_Status { get; set; }
        [Required]
        public string IsClean { get; set; }
        [Required]
        public string Room_type { get; set; }
        [Required]
        public string No_Of_Persons { get; set; }
    }
}