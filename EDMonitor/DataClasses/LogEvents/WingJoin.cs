using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class WingJoin : LogEvent
    {
        [JsonProperty("Others")]
        public List<string> Others { get; set; } = new List<string>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("You Joined a Wing");
            string peoples = " with ";
            bool first = true;
            foreach (string s in Others)
            {
                if (!first)
                {
                    peoples += ", ";
                }
                first = false;
                peoples += s;
            }
            sb.Append((Others.Count > 0) ? peoples : "");
            return sb.ToString();
        }
    }
}