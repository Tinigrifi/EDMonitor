using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class FighterDestroyed : LogEvent
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Fighter Destroyed");
            return sb.ToString();
        }
    }
}