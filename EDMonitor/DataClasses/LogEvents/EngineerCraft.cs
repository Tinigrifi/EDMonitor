using EDMonitor.DataClasses.LogEvents.EngineerCraftJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class EngineerCraft : LogEvent
    {
        [JsonProperty("Slot")]
        public string Slot { get; set; }

        [JsonProperty("Module")]
        public string Module { get; set; }

        [JsonProperty("Ingredients")]
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        [JsonProperty("Engineer")]
        public string Engineer { get; set; }

        [JsonProperty("EngineerID")]
        public int? EngineerID { get; set; }

        [JsonProperty("BlueprintID")]
        public int? BlueprintID { get; set; }

        [JsonProperty("BlueprintName")]
        public string BlueprintName { get; set; }

        [JsonProperty("Level")]
        public int? Level { get; set; }

        [JsonProperty("Quality")]
        public double? Quality { get; set; }

        [JsonProperty("Modifiers")]
        public List<Modifier> Modifiers { get; set; } = new List<Modifier>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Engineer: ");
            sb.Append(Engineer);
            sb.Append(" - Craft: " + BlueprintName);
            sb.Append(" (Level: " + Level + ", Quality: " + ((double)Quality).ToString("P", CultureInfo.InvariantCulture) + ")");
            return sb.ToString();
        }
    }
}