namespace Hotel_MS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblRooms : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "Room_type", c => c.String(nullable: false));
            AddColumn("dbo.Rooms", "No_Of_Persons", c => c.String(nullable: false));
            AlterColumn("dbo.Rooms", "Room_Status", c => c.String(nullable: false));
            AlterColumn("dbo.Rooms", "IsClean", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "IsClean", c => c.String());
            AlterColumn("dbo.Rooms", "Room_Status", c => c.String());
            DropColumn("dbo.Rooms", "No_Of_Persons");
            DropColumn("dbo.Rooms", "Room_type");
        }
    }
}
