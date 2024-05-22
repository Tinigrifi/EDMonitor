using EDMonitor.DataClasses.LogEvents.CargoJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Cargo : LogEvent
    {
        [JsonProperty("Inventory")]
        public List<Inventory> Inventories { get; set; } = new List<Inventory>();

        [JsonProperty("Vessel")]
        public string Vessel { get; set; }

        [JsonProperty("Count")]
        public long? Count { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Inventories.Count != 0)
            {
                long sum = 0;
                foreach (Inventory i in Inventories)
                {
                    sum += (long)i.Count;
                }
                sb.Append("Cargo: ");
                sb.Append(sum);
            }
            else
            {
                sb.Append("Cargo of " + Vessel + ": " + Count);
            }
            return sb.ToString();
        }
    }
}