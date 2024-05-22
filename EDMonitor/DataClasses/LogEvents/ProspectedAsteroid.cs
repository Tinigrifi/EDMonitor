using EDMonitor.DataClasses.LogEvents.ProspectedAsteroidJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ProspectedAsteroid : LogEvent
    {

        [JsonProperty("Materials")]
        public List<Material> Materials { get; set; } = new List<Material>();

        [JsonProperty("MotherlodeMaterial")]
        public string MotherlodeMaterial { get; set; }

        [JsonProperty("MotherlodeMaterial_Localised")]
        public string MotherlodeMaterialLocalised { get; set; }

        [JsonProperty("Content")]
        public string Content { get; set; }

        [JsonProperty("Content_Localised")]
        public string ContentLocalised { get; set; }

        [JsonProperty("Remaining")]
        public double? Remaining { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Prospected Asteroid: ");
            sb.Append(string.IsNullOrEmpty(ContentLocalised) ? Content : ContentLocalised);
            return sb.ToString();
        }
    }
}