namespace Hotel_MS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblSysAdmin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.System_Admin",
                c => new
                    {
                        Admin_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Admin_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.System_Admin");
        }
    }
}
