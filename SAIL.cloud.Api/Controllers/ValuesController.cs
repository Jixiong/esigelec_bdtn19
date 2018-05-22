using SAIL.cloud.DAL;
using SAIL.cloud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SAIL.cloud.Api.Controllers
{
    public class TelemetryController : ApiController
    {
        // GET api/telemetry
        public IEnumerable<Telemetry> Get()
        {
            SailCloudContext context = new SailCloudContext();
            return context.Telemetries;
        }

        // GET api/telemetry
        public IEnumerable<Telemetry> Get(int id)
        {
            SailCloudContext context = new SailCloudContext();
            return context.Telemetries.Where(telem => telem.BoatId == id);
        }

        public void Post([FromBody]Telemetry telemetry)
        {
            if (telemetry != default(Telemetry))
            {
                SailCloudContext context = new SailCloudContext();
                if (telemetry.BoatId > 0)
                {
                    if(!context.Boats.Any(b => b.Id == telemetry.BoatId))
                    {
                        var boat = new Boat() { Id = telemetry.BoatId };
                        context.Boats.Add(boat);
                    }
                }
                telemetry.t = DateTime.Now;
                context.Telemetries.Add(telemetry);
                context.SaveChanges();
            }
        }
    }
}
