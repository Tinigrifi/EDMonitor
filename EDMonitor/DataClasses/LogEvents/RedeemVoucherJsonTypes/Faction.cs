using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.RedeemVoucherJsonTypes
{
    public class Faction
    {
        [JsonProperty("Faction")]
        public string Name { get; set; }

        [JsonProperty("Amount")]
        public int? Amount { get; set; }
    }
}