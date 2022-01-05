namespace Hotel_MS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmptyMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pays", "Customer_id", "dbo.Customers");
            DropForeignKey("dbo.Pays", "Reservation_Id", "dbo.Reservations");
            DropIndex("dbo.Pays", new[] { "Customer_id" });
            DropIndex("dbo.Pays", new[] { "Reservation_Id" });
            DropTable("dbo.Pays");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Pays",
                c => new
                    {
                        Payment_id = c.Int(nullable: false, identity: true),
                        Customer_id = c.Int(nullable: false),
                        Reservation_Id = c.Int(nullable: false),
                        Stay = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Payment_id);
            
            CreateIndex("dbo.Pays", "Reservation_Id");
            CreateIndex("dbo.Pays", "Customer_id");
            AddForeignKey("dbo.Pays", "Reservation_Id", "dbo.Reservations", "Reservation_Id", cascadeDelete: true);
            AddForeignKey("dbo.Pays", "Customer_id", "dbo.Customers", "Customer_id", cascadeDelete: true);
        }
    }
}
