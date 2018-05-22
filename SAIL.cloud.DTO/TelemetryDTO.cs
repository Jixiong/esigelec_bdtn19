using Newtonsoft.Json;
using System;

namespace SAIL.cloud.DTO
{

    public class TelemetryDTO
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
        public float WTd { get; set; }
        public float WTD { get; set; }
        public float WTs { get; set; }
        public float BS { get; set; }
        [JsonProperty("$v")]
        public int v { get; set; }
        [JsonProperty("$s")]
        public int s { get; set; }
        [JsonProperty("$b")]
        public int b { get; set; }
        [JsonProperty("$f")]
        public string f { get; set; }
        [JsonProperty("$e")]
        public int e { get; set; }
        [JsonProperty("$t")]
        public DateTime t { get; set; }
    }

}
