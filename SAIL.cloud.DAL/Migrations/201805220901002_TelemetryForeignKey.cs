namespace SAIL.cloud.DAL02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TelemetryForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Telemetries", "Boat_Id", "dbo.Boats");
            DropIndex("dbo.Telemetries", new[] { "Boat_Id" });
            AlterColumn("dbo.Telemetries", "Boat_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Telemetries", "Boat_Id");
            AddForeignKey("dbo.Telemetries", "Boat_Id", "dbo.Boats", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telemetries", "Boat_Id", "dbo.Boats");
            DropIndex("dbo.Telemetries", new[] { "Boat_Id" });
            AlterColumn("dbo.Telemetries", "Boat_Id", c => c.Int());
            CreateIndex("dbo.Telemetries", "Boat_Id");
            AddForeignKey("dbo.Telemetries", "Boat_Id", "dbo.Boats", "Id");
        }
    }
}
