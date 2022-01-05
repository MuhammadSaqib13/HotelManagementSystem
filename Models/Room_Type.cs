using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel_MS.Models
{
    public class Room_Type
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Capacity { get; set; }
        public string Price { get; set; }
        public string Max_Guest { get; set; }
    }
}