namespace Hotel_MS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblReg_Customers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registered_Customer",
                c => new
                    {
                        UR_Id = c.Int(nullable: false, identity: true),
                        Admin_Id = c.Int(nullable: false),
                        Customer_id = c.Int(nullable: false),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        CreditCard_No = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UR_Id)
                .ForeignKey("dbo.Customers", t => t.Customer_id, cascadeDelete: true)
                .ForeignKey("dbo.System_Admin", t => t.Admin_Id, cascadeDelete: true)
                .Index(t => t.Admin_Id)
                .Index(t => t.Customer_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registered_Customer", "Admin_Id", "dbo.System_Admin");
            DropForeignKey("dbo.Registered_Customer", "Customer_id", "dbo.Customers");
            DropIndex("dbo.Registered_Customer", new[] { "Customer_id" });
            DropIndex("dbo.Registered_Customer", new[] { "Admin_Id" });
            DropTable("dbo.Registered_Customer");
        }
    }
}
