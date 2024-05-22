using EDMonitor.DataClasses.LogEvents.ScanJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Scan : LogEvent
    {
        [JsonProperty("ScanType")]
        public string ScanType { get; set; }

        [JsonProperty("BodyName")]
        public string BodyName { get; set; }

        [JsonProperty("BodyID")]
        public long? BodyID { get; set; }

        [JsonProperty("Parents")]
        public List<Parent> Parents { get; set; } = new List<Parent>();

        [JsonProperty("DistanceFromArrivalLS")]
        public double? DistanceFromArrivalLS { get; set; }

        [JsonProperty("TidalLock")]
        public bool? TidalLock { get; set; }

        [JsonProperty("TerraformState")]
        public string TerraformState { get; set; }

        [JsonProperty("PlanetClass")]
        public string PlanetClass { get; set; }

        [JsonProperty("Atmosphere")]
        public string Atmosphere { get; set; }

        [JsonProperty("AtmosphereType")]
        public string AtmosphereType { get; set; }

        [JsonProperty("Volcanism")]
        public string Volcanism { get; set; }

        [JsonProperty("MassEM")]
        public double? MassEM { get; set; }

        [JsonProperty("Radius")]
        public double? Radius { get; set; }

        [JsonProperty("SurfaceGravity")]
        public double? SurfaceGravity { get; set; }

        [JsonProperty("SurfaceTemperature")]
        public double? SurfaceTemperature { get; set; }

        [JsonProperty("SurfacePressure")]
        public double? SurfacePressure { get; set; }

        [JsonProperty("Landable")]
        public bool? Landable { get; set; }

        [JsonProperty("Materials")]
        public List<Material> Materials { get; set; } = new List<Material>();

        [JsonProperty("Composition")]
        public Composition Composition { get; set; }

        [JsonProperty("SemiMajorAxis")]
        public double? SemiMajorAxis { get; set; }

        [JsonProperty("Eccentricity")]
        public double? Eccentricity { get; set; }

        [JsonProperty("OrbitalInclination")]
        public double? OrbitalInclination { get; set; }

        [JsonProperty("Periapsis")]
        public double? Periapsis { get; set; }

        [JsonProperty("OrbitalPeriod")]
        public double? OrbitalPeriod { get; set; }

        [JsonProperty("RotationPeriod")]
        public double? RotationPeriod { get; set; }

        [JsonProperty("AxialTilt")]
        public double? AxialTilt { get; set; }

        [JsonProperty("Rings")]
        public List<Ring> Rings { get; set; } = new List<Ring>();

        [JsonProperty("StarType")]
        public string StarType { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Scan: " + ScanType);
            sb.Append(" - " + BodyName);
            sb.Append(" (" + ((double)DistanceFromArrivalLS).ToString("n2", CultureInfo.InvariantCulture) + " Ls)");
            return sb.ToString();
        }
    }
}