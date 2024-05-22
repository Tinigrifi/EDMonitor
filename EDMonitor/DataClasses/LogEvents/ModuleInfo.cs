using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ModuleInfo : LogEvent
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Module Info Loaded");
            return sb.ToString();
        }
    }
}