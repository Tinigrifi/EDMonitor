using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.StatisticsJsonTypes
{
    public class Exploration
    {
        [JsonProperty("Systems_Visited")]
        public long? SystemsVisited { get; set; }

        [JsonProperty("Fuel_Scooped")]
        public long? FuelScooped { get; set; }

        [JsonProperty("Fuel_Purchased")]
        public long? FuelPurchased { get; set; }

        [JsonProperty("Exploration_Profits")]
        public long? ExplorationProfits { get; set; }

        [JsonProperty("Planets_Scanned_To_Level_2")]
        public long? PlanetsScannedToLevel2 { get; set; }

        [JsonProperty("Planets_Scanned_To_Level_3")]
        public long? PlanetsScannedToLevel3 { get; set; }

        [JsonProperty("Highest_Payout")]
        public long? HighestPayout { get; set; }

        [JsonProperty("Total_Hyperspace_Distance")]
        public long? TotalHyperspaceDistance { get; set; }

        [JsonProperty("Total_Hyperspace_Jumps")]
        public long? TotalHyperspaceJumps { get; set; }

        [JsonProperty("Greatest_Distance_From_Start")]
        public double? GreatestDistanceFromStart { get; set; }

        [JsonProperty("Time_Played")]
        public long? TimePlayed { get; set; }
    }
}