using EDMonitor.DataClasses.LogEvents.ShipLockerJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ShipLocker : LogEvent
    {
        [JsonProperty("Items")]
        public List<ShipLockerObject> Items { get; set; } = new List<ShipLockerObject>();

        [JsonProperty("Components")]
        public List<ShipLockerObject> Components { get; set; } = new List<ShipLockerObject>();

        [JsonProperty("Consumables")]
        public List<ShipLockerObject> Consumables { get; set; } = new List<ShipLockerObject>();

        [JsonProperty("Data")]
        public List<ShipLockerObject> Data { get; set; } = new List<ShipLockerObject>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("ShipLocker");
            return sb.ToString();
        }
    }
}
