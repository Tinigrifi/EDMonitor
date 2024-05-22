using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.StoredShipsJsonTypes
{
    public class ShipsHere
    {
        [JsonProperty("ShipID")]
        public int? ShipID { get; set; }

        [JsonProperty("ShipType")]
        public string ShipType { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Value")]
        public int? Value { get; set; }

        [JsonProperty("Hot")]
        public bool? Hot { get; set; }

        [JsonProperty("ShipType_Localised")]
        public string ShipTypeLocalised { get; set; }
    }
}