using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Screenshot : LogEvent
    {
        [JsonProperty("Filename")]
        public string Filename { get; set; }

        [JsonProperty("Width")]
        public long? Width { get; set; }

        [JsonProperty("Height")]
        public long? Height { get; set; }

        [JsonProperty("System")]
        public string System { get; set; }

        [JsonProperty("Body")]
        public string Body { get; set; }

        [JsonProperty("Latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("Heading")]
        public long? Heading { get; set; }

        [JsonProperty("Altitude")]
        public double? Altitude { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Screenshot: " + Filename + " [" + Width + "x" + Height + "]");
            return sb.ToString();
        }
    }
}