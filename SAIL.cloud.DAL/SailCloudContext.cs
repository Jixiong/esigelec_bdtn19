using SAIL.cloud.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace SAIL.cloud.DAL
{
    public class SailCloudContext : DbContext
    {
        public DbSet<Boat> Boats { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
