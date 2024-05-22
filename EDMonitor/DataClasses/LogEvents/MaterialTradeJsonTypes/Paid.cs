using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.MaterialTradeJsonTypes
{
    public class Paid
    {
        [JsonProperty("Material")]
        public string Material { get; set; }

        [JsonProperty("Material_Localised")]
        public string MaterialLocalised { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("Quantity")]
        public int? Quantity { get; set; }
    }
}