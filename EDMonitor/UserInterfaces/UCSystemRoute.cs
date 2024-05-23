using EDMonitor.Properties;
using System.Windows.Forms;

namespace EDMonitor.UserInterfaces
{
    public partial class UCSystemRoute : UserControl
    {
        public UCSystemRoute(int cpt, Business.SolarSystem system, string currentSystem)
        {
            InitializeComponent();
            LabelStarSystem.Text = "[" + cpt.ToString("00") + "] " + system.StarSystem.ToUpper();
            switch (system.StarClass)
            {
                case "K":
                case "G":
                case "B":
                case "F":
                case "O":
                case "A":
                case "M":
                case "NEUTRON_STAR":
                    PictureBoxStarClass.Image = Resources.bullet_green;
                    break;
                default:
                    PictureBoxStarClass.Image = Resources.bullet_red;
                    break;
            }
            if (currentSystem == system.StarSystem)
            {
                PictureBoxCurrent.Image = Resources.bullet_go;
            }
            else
            {
                PictureBoxCurrent.Image = null;
            }
        }
    }
}