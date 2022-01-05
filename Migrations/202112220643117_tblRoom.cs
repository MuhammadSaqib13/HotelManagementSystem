namespace Hotel_MS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblRoom : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Room_Id = c.Int(nullable: false, identity: true),
                        Room_No = c.Int(nullable: false),
                        Room_Status = c.String(),
                        IsClean = c.String(),
                    })
                .PrimaryKey(t => t.Room_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rooms");
        }
    }
}
