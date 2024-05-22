using EDMonitor.DataClasses.LogEvents.LoadoutJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Loadout : LogEvent
    {
        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public long? ShipID { get; set; }

        [JsonProperty("ShipName")]
        public string ShipName { get; set; }

        [JsonProperty("ShipIdent")]
        public string ShipIdent { get; set; }

        [JsonProperty("HullValue")]
        public long? HullValue { get; set; }

        [JsonProperty("ModulesValue")]
        public long? ModulesValue { get; set; }

        [JsonProperty("HullHealth")]
        public long? HullHealth { get; set; }

        [JsonProperty("UnladenMass")]
        public double? UnladenMass { get; set; }

        [JsonProperty("FuelCapacity")]
        public FuelCapacity FuelCapacity { get; set; }

        [JsonProperty("CargoCapacity")]
        public int CargoCapacity { get; set; }

        [JsonProperty("Rebuy")]
        public long? Rebuy { get; set; }

        [JsonProperty("Modules")]
        public List<Module> Modules { get; set; } = new List<Module>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Loadout");
            sb.Append(" - Ship: ");
            sb.Append(string.IsNullOrEmpty(ShipName) ? Ship.ToUpper() : Ship.ToUpper() + ": " + ShipName + " / " + ShipIdent);
            return sb.ToString();
        }
    }
}