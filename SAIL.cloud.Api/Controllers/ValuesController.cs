using Mapster;
using SAIL.cloud.DAL;
using SAIL.cloud.DTO;
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

        public void Post([FromBody]TelemetryDTO telemetrydto)
        {
            SailCloudContext context = new SailCloudContext();
            if (telemetrydto.s != default(int))
            {
                var user = new User() { Id = telemetrydto.s };
                context.Users.Add(user);
            }

            TypeAdapterConfig<TelemetryDTO, Telemetry>.NewConfig()
                .Map(dest => dest.BoatId, dto => dto.b);
            Telemetry telemetry = telemetrydto.Adapt<TelemetryDTO, Telemetry>();
            if (telemetry != default(Telemetry))
            {
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
