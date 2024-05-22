using System.Collections.Generic;
using System.Linq;

namespace EDMonitor.Business
{
    public class CategoryMaterials
    {
        public string Name { get; set; }

        public bool CanBeExpandable
        {
            get
            {
                return (Materials.Count > 0);
            }
        }

        internal void Sort() => Materials = Materials.OrderBy(m => m.Name).ToList();

        public List<Material> Materials = new List<Material>();
    }
}