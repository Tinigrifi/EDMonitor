using EDMonitor.DataClasses.LogEvents.StatisticsJsonTypes;
using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Statistics : LogEvent
    {
        [JsonProperty("Bank_Account")]
        public BankAccount BankAccount { get; set; }

        [JsonProperty("Combat")]
        public Combat Combat { get; set; }

        [JsonProperty("Crime")]
        public Crime Crime { get; set; }

        [JsonProperty("Smuggling")]
        public Smuggling Smuggling { get; set; }

        [JsonProperty("Trading")]
        public Trading Trading { get; set; }

        [JsonProperty("Mining")]
        public Mining Mining { get; set; }

        [JsonProperty("Exploration")]
        public Exploration Exploration { get; set; }

        [JsonProperty("Passengers")]
        public Passengers Passengers { get; set; }

        [JsonProperty("Search_And_Rescue")]
        public SearchAndRescue SearchAndRescue { get; set; }

        [JsonProperty("Crafting")]
        public Crafting Crafting { get; set; }

        [JsonProperty("Crew")]
        public Crew Crew { get; set; }

        [JsonProperty("Multicrew")]
        public Multicrew Multicrew { get; set; }

        [JsonProperty("Material_Trader_Stats")]
        public MaterialTraderStats MaterialTraderStats { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Statistics Loaded");
            return sb.ToString();
        }
    }
}