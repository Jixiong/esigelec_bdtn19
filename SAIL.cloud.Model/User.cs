using System;
using System.Collections.Generic;
using System.Text;

namespace SAIL.cloud.Model
{
    public class User : Entity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public virtual ICollection<Boat> Boats { get; set; } = new HashSet<Boat>();
    }
}
