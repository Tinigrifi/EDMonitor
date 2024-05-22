using System.Collections.Generic;
using System.Linq;

namespace EDMonitor.Business
{
    public class MaterialsItems
    {
        public List<CategoryMaterials> Categories { get; set; } = new List<CategoryMaterials>();

        public void Sort()
        {
            Categories = Categories.OrderBy(c => c.Name).ToList();
            Categories.ForEach(c =>
            {
                c.Sort();
            });
        }
    }
}