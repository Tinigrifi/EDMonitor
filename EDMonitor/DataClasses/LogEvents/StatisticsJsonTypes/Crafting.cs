using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.StatisticsJsonTypes
{
    public class Crafting
    {
        [JsonProperty("Spent_On_Crafting")]
        public long? SpentOnCrafting { get; set; }

        [JsonProperty("Count_Of_Used_Engineers")]
        public long? CountOfUsedEngineers { get; set; }

        [JsonProperty("Recipes_Generated")]
        public long? RecipesGenerated { get; set; }

        [JsonProperty("Recipes_Generated_Rank_1")]
        public long? RecipesGeneratedRank1 { get; set; }

        [JsonProperty("Recipes_Generated_Rank_2")]
        public long? RecipesGeneratedRank2 { get; set; }

        [JsonProperty("Recipes_Generated_Rank_3")]
        public long? RecipesGeneratedRank3 { get; set; }

        [JsonProperty("Recipes_Generated_Rank_4")]
        public long? RecipesGeneratedRank4 { get; set; }

        [JsonProperty("Recipes_Generated_Rank_5")]
        public long? RecipesGeneratedRank5 { get; set; }

        [JsonProperty("Recipes_Applied")]
        public long? RecipesApplied { get; set; }

        [JsonProperty("Recipes_Applied_Rank_1")]
        public long? RecipesAppliedRank1 { get; set; }

        [JsonProperty("Recipes_Applied_Rank_2")]
        public long? RecipesAppliedRank2 { get; set; }

        [JsonProperty("Recipes_Applied_Rank_3")]
        public long? RecipesAppliedRank3 { get; set; }

        [JsonProperty("Recipes_Applied_Rank_4")]
        public long? RecipesAppliedRank4 { get; set; }

        [JsonProperty("Recipes_Applied_Rank_5")]
        public long? RecipesAppliedRank5 { get; set; }

        [JsonProperty("Recipes_Applied_On_Previously_Modified_Modules")]
        public long? RecipesAppliedOnPreviouslyModifiedModules { get; set; }
    }
}