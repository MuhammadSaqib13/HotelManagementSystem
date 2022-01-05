namespace Hotel_MS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Customer_id = c.Int(nullable: false, identity: true),
                        First_name = c.String(nullable: false),
                        Last_name = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        CNIC = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Customer_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
