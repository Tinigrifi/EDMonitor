using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class EngineerLegacyConvert : LogEvent
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Engineer Legacy Convert (converting a pre-2.4 engineered module)");
            return sb.ToString();
        }
    }
}