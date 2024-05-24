using EDMonitor.DataClasses.LogEvents.MassModuleStoreJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EDMonitor.DataClasses.LogEvents
{
    public class MassModuleStore : LogEvent
    {
        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipId")]
        public long? ShipId { get; set; }

        [JsonProperty("Items")]
        public List<Item> Items { get; set; } = new List<Item>();
    }
}