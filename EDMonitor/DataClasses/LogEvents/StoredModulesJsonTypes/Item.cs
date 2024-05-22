using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.StoredModulesJsonTypes
{
    public class Item
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }

        [JsonProperty("StorageSlot")]
        public int? StorageSlot { get; set; }

        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        [JsonProperty("TransferCost")]
        public int? TransferCost { get; set; }

        [JsonProperty("TransferTime")]
        public int? TransferTime { get; set; }

        [JsonProperty("BuyPrice")]
        public int? BuyPrice { get; set; }

        [JsonProperty("Hot")]
        public bool? Hot { get; set; }
    }
}