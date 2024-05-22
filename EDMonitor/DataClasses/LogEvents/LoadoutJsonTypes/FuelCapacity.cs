using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.LoadoutJsonTypes
{
    public class FuelCapacity
    {
        [JsonProperty("Main")]
        public double Main { get; set; }

        [JsonProperty("Reserve")]
        public double Reserve { get; set; }
    }
}