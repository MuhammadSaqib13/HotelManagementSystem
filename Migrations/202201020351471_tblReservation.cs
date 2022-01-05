namespace Hotel_MS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblReservation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Reservation_Id = c.Int(nullable: false, identity: true),
                        Customer_id = c.Int(nullable: false),
                        Departure_Date = c.DateTime(nullable: false),
                        Arrival_Date = c.DateTime(nullable: false),
                        Room_No = c.Int(nullable: false),
                        No_of_Persons = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Reservation_Id)
                .ForeignKey("dbo.Customers", t => t.Customer_id, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.Room_No, cascadeDelete: true)
                .Index(t => t.Customer_id)
                .Index(t => t.Room_No);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Room_No", "dbo.Rooms");
            DropForeignKey("dbo.Reservations", "Customer_id", "dbo.Customers");
            DropIndex("dbo.Reservations", new[] { "Room_No" });
            DropIndex("dbo.Reservations", new[] { "Customer_id" });
            DropTable("dbo.Reservations");
        }
    }
}
