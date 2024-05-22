using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class NavRoute : LogEvent
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("NavRoute Loaded");
            return sb.ToString();
        }
    }
}