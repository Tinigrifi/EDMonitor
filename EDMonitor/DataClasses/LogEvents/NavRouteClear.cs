using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class NavRouteClear : LogEvent
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("NavRoute Cleared");
            return sb.ToString();
        }
    }
}
