using EDMonitor.DataClasses.LogEvents.TechnologyBrokerJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class TechnologyBroker : LogEvent
    {
        [JsonProperty("BrokerType")]
        public string BrokerType { get; set; }

        [JsonProperty("MarketID")]
        public int MarketID { get; set; }

        [JsonProperty("ItemsUnlocked")]
        public List<ItemsUnlocked> ItemsUnlocked { get; set; } = new List<ItemsUnlocked>();

        [JsonProperty("Commodities")]
        public List<Commodity> Commodities { get; set; } = new List<Commodity>();

        [JsonProperty("Materials")]
        public List<Material> Materials { get; set; } = new List<Material>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Technology Broker");
            sb.Append(" - Broker Type: " + BrokerType);
            sb.Append(" - Items Unlocked: ");
            ItemsUnlocked.ForEach(i =>
            {
                if (!((string.IsNullOrEmpty(i.NameLocalised) ? i.Name : i.NameLocalised).StartsWith("$")))
                {
                    sb.Append(string.IsNullOrEmpty(i.NameLocalised) ? i.Name : i.NameLocalised + ", ");
                }
            });
            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }
    }
}