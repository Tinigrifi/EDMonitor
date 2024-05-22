using EDMonitor.DataClasses.LogEvents.CommunityGoalJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class CommunityGoal : LogEvent
    {
        [JsonProperty("CurrentGoals")]
        public List<CurrentGoal> CurrentGoals { get; set; } = new List<CurrentGoal>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Community Goals: ");
            sb.Append(CurrentGoals.Count);
            return sb.ToString();
        }
    }
}