using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAIL.cloud.Model
{
    public class Telemetry : Entity
    {
        public float Et { get; set; }
        public float Ap { get; set; }
        public float PLt { get; set; }
        public float PLg { get; set; }
        public float PH { get; set; }
        public float PHm { get; set; }
        public float PS { get; set; }
        public int PSr { get; set; }
        public float PC { get; set; }
        public float WAs { get; set; }
        public float WAa { get; set; }
        public float WTa { get; set; }
        [JsonProperty("WTd")]
        public float MagneticWindSpeed { get; set; }
        [JsonProperty("WTD")]
        public float TrueWindSpeed { get; set; }

        public float WTs { get; set; }
        public float BS { get; set; }
        public DateTime t { get; set; }

        [Column("Boat_Id")]
        public int BoatId { get; set; }
    }
}
