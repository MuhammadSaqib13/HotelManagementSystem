using Hotel_MS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotel_MS.DBContext
{
    public class AppDBContext : DbContext 
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Room_Type> Room_Types { get; set; }
        public DbSet<System_Admin> System_Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Registered_Customer> Registered_Customers { get; set; }

       
    }
}