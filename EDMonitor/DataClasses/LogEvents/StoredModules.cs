using EDMonitor.DataClasses.LogEvents.StoredModulesJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class StoredModules : LogEvent
    {
        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        [JsonProperty("StationName")]
        public string StationName { get; set; }

        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        [JsonProperty("Items")]
        public List<Item> Items { get; set; } = new List<Item>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Stored Modules: ");
            sb.Append(Items.Count + " Items");
            return sb.ToString();
        }
    }
}