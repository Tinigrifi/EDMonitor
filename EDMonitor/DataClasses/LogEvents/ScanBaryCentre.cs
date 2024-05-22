using EDMonitor.DataClasses.LogEvents.BountyJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ScanBaryCentre : LogEvent
    {

        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        [JsonProperty("SystemAddress")]
        public long? SystemAddress { get; set; }

        [JsonProperty("BodyID")]
        public long? BodyID { get; set; }

        [JsonProperty("SemiMajorAxis")]
        public long? SemiMajorAxis { get; set; }

        [JsonProperty("Eccentricity")]
        public double? Eccentricity { get; set; }

        [JsonProperty("OrbitalInclination")]
        public double? OrbitalInclination { get; set; }

        [JsonProperty("Periapsis")]
        public double? Periapsis { get; set; }

        [JsonProperty("OrbitalPeriod")]
        public double? OrbitalPeriod { get; set; }

        [JsonProperty("AscendingNode")]
        public double? AscendingNode { get; set; }

        [JsonProperty("MeanAnomaly")]
        public double? MeanAnomaly { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Solar Anomaly : Scan BaryCentre of the system");
            return sb.ToString();
        }
    }
}
