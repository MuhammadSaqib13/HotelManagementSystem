namespace Hotel_MS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblGuest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        Guest_Id = c.Int(nullable: false, identity: true),
                        Members = c.Int(nullable: false),
                        Adults = c.Int(nullable: false),
                        Children = c.Int(nullable: false),
                        Phone_Number = c.String(nullable: false),
                        Customer_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Guest_Id)
                .ForeignKey("dbo.Customers", t => t.Customer_id, cascadeDelete: true)
                .Index(t => t.Customer_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Guests", "Customer_id", "dbo.Customers");
            DropIndex("dbo.Guests", new[] { "Customer_id" });
            DropTable("dbo.Guests");
        }
    }
}
