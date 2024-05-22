using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.StatisticsJsonTypes
{
    public class BankAccount
    {
        [JsonProperty("Current_Wealth")]
        public long? CurrentWealth { get; set; }

        [JsonProperty("Spent_On_Ships")]
        public long? SpentOnShips { get; set; }

        [JsonProperty("Spent_On_Outfitting")]
        public long? SpentOnOutfitting { get; set; }

        [JsonProperty("Spent_On_Repairs")]
        public long? SpentOnRepairs { get; set; }

        [JsonProperty("Spent_On_Fuel")]
        public long? SpentOnFuel { get; set; }

        [JsonProperty("Spent_On_Ammo_Consumables")]
        public long? SpentOnAmmoConsumables { get; set; }

        [JsonProperty("Insurance_Claims")]
        public long? InsuranceClaims { get; set; }

        [JsonProperty("Spent_On_Insurance")]
        public long? SpentOnInsurance { get; set; }
    }
}