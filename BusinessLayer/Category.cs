using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Category : Validation
    {
        public String name;
        public String description;
        public List<Product> products = new List<Product>();
        public void RemoveProduct(String name)
        {
            products.Remove(products.Find(a => a.Name == name));
        }
        public Product FindProduct(String product)
        {
            return products.Find(a => a.Name == product);
        }
    }
}
