namespace SAIL.cloud.DAL02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTelemetry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Telemetries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Et = c.Single(nullable: false),
                        Ap = c.Single(nullable: false),
                        PLt = c.Single(nullable: false),
                        PLg = c.Single(nullable: false),
                        PH = c.Single(nullable: false),
                        PHm = c.Single(nullable: false),
                        PS = c.Single(nullable: false),
                        PSr = c.Int(nullable: false),
                        PC = c.Single(nullable: false),
                        WAs = c.Single(nullable: false),
                        WAa = c.Single(nullable: false),
                        WTa = c.Single(nullable: false),
                        MagneticWindSpeed = c.Single(nullable: false),
                        TrueWindSpeed = c.Single(nullable: false),
                        WTs = c.Single(nullable: false),
                        BS = c.Single(nullable: false),
                        t = c.DateTime(nullable: false),
                        Boat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Boats", t => t.Boat_Id)
                .Index(t => t.Boat_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telemetries", "Boat_Id", "dbo.Boats");
            DropIndex("dbo.Telemetries", new[] { "Boat_Id" });
            DropTable("dbo.Telemetries");
        }
    }
}
