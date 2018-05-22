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
    }
}
