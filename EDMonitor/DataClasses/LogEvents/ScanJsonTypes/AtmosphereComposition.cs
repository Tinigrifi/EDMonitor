using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.ScanJsonTypes
{
    public class AtmosphereComposition
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Percent")]
        public double? Percent { get; set; }
    }
}