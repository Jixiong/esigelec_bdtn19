namespace SAIL.cloud.DAL02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BoatsUsers : DbMigration
    {
        public override void Up()
        {           
            CreateTable(
                "dbo.UserBoats",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Boat_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Boat_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Boats", t => t.Boat_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Boat_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserBoats", "Boat_Id", "dbo.Boats");
            DropForeignKey("dbo.UserBoats", "User_Id", "dbo.Users");
            DropIndex("dbo.UserBoats", new[] { "Boat_Id" });
            DropIndex("dbo.UserBoats", new[] { "User_Id" });
            DropTable("dbo.UserBoats");
        }
    }
}
