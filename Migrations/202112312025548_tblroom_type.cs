namespace Hotel_MS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblroom_type : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Room_Type",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Capacity = c.String(),
                        Price = c.String(),
                        Max_Guest = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Room_Type");
        }
    }
}
