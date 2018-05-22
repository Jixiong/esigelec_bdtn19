namespace SAIL.cloud.DAL02.Migrations
{
    using SAIL.cloud.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SAIL.cloud.DAL.SailCloudContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SAIL.cloud.DAL.SailCloudContext context)
        {
            //  This method will be called after migrating to the latest version.
            Telemetry telemetry = new Telemetry() {
                 Et= 25.1f,
                 Ap= 1021.12f,
                 PLt= 18.209612f,
                 PLg= -51.400942f,
                 PH= 254.4f,
                 PHm= 272.0f,
                 PS= 5.05f,
                 PSr= 2,
                 PC= 268.6f,
                 WAs= 5.5f,
                 WAa= 147.0f,
                 WTa= 158.0f,
                 MagneticWindSpeed= 69.0f,
                 TrueWindSpeed= 52.4f,
                 WTs= 9.8f,
                 BS= 4.85f,
                 t = DateTime.Now
            };
            Boat boat = new Boat() { Id = 5, Name = "Team2Choc", Number = "FRA123" };
            boat.Telemetries.Add(telemetry);

            context.Boats.AddOrUpdate<Boat>(boat);
            context.SaveChanges();
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
