using SAIL.cloud.DAL;
using SAIL.cloud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIL.cloud.Utils.DALTests
{
    class Program
    {
        static void Main(string[] args)
        {
            SailCloudContext context = new SailCloudContext();
            Console.WriteLine(context.Database.Connection.ConnectionString);
            context.Users.Add(new User() { LastName = "Blons", FirstName = "Pierrick" });
            context.SaveChanges();
        }
    }
}
