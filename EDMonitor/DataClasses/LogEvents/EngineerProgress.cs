using EDMonitor.DataClasses.LogEvents.EngineerProgressJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class EngineerProgress : LogEvent
    {
        [JsonProperty("Engineers")]
        public List<Engineer> Engineers { get; set; } = new List<Engineer>();

        [JsonProperty("Engineer")]
        public string Name { get; set; }

        [JsonProperty("EngineerID")]
        public int? EngineerID { get; set; }

        [JsonProperty("Progress")]
        public string Progress { get; set; }

        [JsonProperty("RankProgress")]
        public int? RankProgress { get; set; }

        [JsonProperty("Rank")]
        public int? Rank { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Engineers.Count > 0)
            {
                sb.Append("Engineers");
                sb.Append(" - ");
                string eng = "";
                for (int i = 0; i < Engineers.Count; i++)
                {
                    if (i != 0)
                    {
                        eng += ", ";
                    }
                    eng += Engineers[i].Name + ":" + (Engineers[i].Rank ?? 0);
                }
                sb.Append(eng);
            }
            else
            {
                sb.Append("Engineer " + Name);
                sb.Append(Rank != null ? " - Rank: " + Rank.ToString() : "");
                sb.Append(Progress != null ? " - Progress: " + Progress.ToString() : "");
                sb.Append(RankProgress != null ? " - RankProgress: " + RankProgress.ToString() : "");
            }
            return sb.ToString();
        }
    }
}