using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Shutdown : LogEvent
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Shutdown - You Quitted the Game");
            return sb.ToString();
        }
    }
}