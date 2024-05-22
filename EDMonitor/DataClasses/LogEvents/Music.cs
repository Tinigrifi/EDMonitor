using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Music : LogEvent
    {
        [JsonProperty("MusicTrack")]
        public string MusicTrack { get; set; }

        public override string ToString()
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Music");
            //sb.Append(" - " + MusicTrack);
            //return sb.ToString();
            return string.Empty;
        }
    }
}