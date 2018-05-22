using System;
using System.Collections.Generic;
using System.Text;

namespace SAIL.cloud.Model
{
    public class Boat : Entity
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public virtual ICollection<User> Skippers { get; set; } = new HashSet<User>();
        public virtual ICollection<Telemetry> Telemetries { get; set; } = new HashSet<Telemetry>();
    }
}
