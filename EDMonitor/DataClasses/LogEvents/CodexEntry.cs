using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class CodexEntry : LogEvent
    {
        [JsonProperty("EntryID")]
        public int? EntryID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }

        [JsonProperty("SubCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("SubCategory_Localised")]
        public string SubCategoryLocalised { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("Category_Localised")]
        public string CategoryLocalised { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }

        [JsonProperty("Region_Localised")]
        public string RegionLocalised { get; set; }

        [JsonProperty("System")]
        public string System { get; set; }

        [JsonProperty("SystemAddress")]
        public long? SystemAddress { get; set; }

        [JsonProperty("IsNewEntry")]
        public bool? IsNewEntry { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Codex");
            if (IsNewEntry != null && IsNewEntry == true)
            {
                sb.Append(" NEW");
            }
            sb.Append(" Entry: ");
            sb.Append(string.IsNullOrEmpty(NameLocalised) ? Name : NameLocalised);
            return sb.ToString();
        }
    }
}