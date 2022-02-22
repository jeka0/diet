using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
     public class Categories : Validation
    {
        public List<Category> categories;
        public void CreateTreeView(TreeView treeView)
        {
            int index = 0;
            foreach (Category category in categories)
            {
                treeView.Nodes.Add(category.name, category.name);
                foreach (Product product in category.products)
                {
                    treeView.Nodes[index].Nodes.Add(product.Name, product.Name);
                }
                index++;
            }
        }
        public Category FindCategory(String category)
        {
            return categories.Find(a => a.name == category);
        }
        public void AddProductInCategory(Product product, String category)
        {
            categories.Find(a => a.name == category).products.Add(product.Copy());
        }
        public void RemoveCategory(String name)
        {
            categories.Remove(FindCategory(name));
        }
    }
}
