using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class SRVDestroyed : LogEvent
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SRV Destroyed");
            return sb.ToString();
        }
    }
}