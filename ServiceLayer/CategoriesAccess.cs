using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataAccessLayer;

namespace ServiceLayer
{
    public static class CategoriesAccess
    {
        internal static Categories categories = new Categories();
        internal static Categories mealTimes = new Categories();
        internal static Product selectedProduct;
        public static void LoadCategories() 
        {
            categories.categories = Db.ReadXml("FoodProducts.xml");
        }
        /// /
        public static void CreateTreeViewFromCategories(TreeView treeView){categories.CreateTreeView(treeView);}
        public static void CreateTreeViewFromMealTimes(TreeView treeView) { mealTimes.CreateTreeView(treeView); }
        public static int GetGrammsSelectedProduct()
        {
            return selectedProduct.gramms;
        }
        //
        public static void SetSelectedProductInCategories(TreeNode node)
        {
            selectedProduct = categories.FindProduct(node);
        }
        public static void SetSelectedProductInMealTimes(TreeNode node)
        {
            selectedProduct = mealTimes.FindProduct(node);
        }
        public static List<String> GetSelectedProductValues()
        {
            if (selectedProduct != null)
            {
                List<String> values = new List<String>();
                values.Add(selectedProduct.name); values.Add(selectedProduct.gramms.ToString()); values.Add(selectedProduct.protein.ToString()); values.Add(selectedProduct.fats.ToString()); values.Add(selectedProduct.carbs.ToString()); values.Add(selectedProduct.calories.ToString());
                return values;
            }
            else return null;
        }
        //
        public static void AddProductInMealTime(Product product,String category){mealTimes.AddProductInCategory(product, category);}
        public static void AddProductInCategories(Product product, String category) { categories.AddProductInCategory(product, category); }
        //
        public static void CreateMealTimes()
        {
            mealTimes.categories = new List<Category>();
            mealTimes.categories.Add(new Category() { description = "", name = "Завтрак" });
            mealTimes.categories.Add(new Category() { description = "", name = "Обед" });
            mealTimes.categories.Add(new Category() { description = "", name = "Ужин" });
        }
        //
        public static void TransferProduct(TreeNode newNode, TreeNode parentNode)
        {
            AddProductInMealTime(categories.FindProduct(newNode), parentNode.Text);
        }
        public static void ClearMealTimes()
        {
            mealTimes.categories.Clear();
            CreateMealTimes();
        }

    }
}
