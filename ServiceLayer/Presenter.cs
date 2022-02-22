using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLayer;
using System.Windows.Forms;

namespace ServiceLayer
{
    public class Presenter: IPresenter, IAddPresenter
    {
        private IMainFormView mainView;
        private INewProductView productView;
        private INewCategory categoryView;
        private IModel model;
        private Categories mealTime;
        private Categories categories;
        internal static Product selectedProduct;
        internal static User user = new User();
        internal static DailyRation dailyRation = new DailyRation();
        public Presenter(IMainFormView view, INewProductView pview, INewCategory cview, IModel Imodel)
        {
            mainView = view;
            mainView.Presenter = this;
            productView = pview;
            productView.Presenter = this;
            categoryView = cview;
            categoryView.Presenter = this;
            model = Imodel;
            mealTime = model.MealTimes;
            categories = model.Categories;
            ProgramCalculations.model = model;
            CreateRation();
            UpdateBmr();
            UpdateArm();
            UpdateCalories();
        }
        public INewProductView GetProductView { get { return productView; } }
        public INewCategory GetCategoryView { get { return categoryView; } }
        public void UpdateBmr()
        {
            user.SetWeightFromString(mainView.GetWeight);
            user.SetHeightFromString(mainView.GetHeight);
            user.SetAgeFromString(mainView.GetAge);
            ProgramCalculations.CalculateBMR();
            mainView.SetBMR = dailyRation.Bmr.ToString();
        }
        public void UpdateArm()
        {
            user.activityType = mainView.GetActivityTypes();
            ProgramCalculations.CalculateARM();
            mainView.SetARM = dailyRation.Arm.ToString();
        }
        public void UpdateCalories()
        {
            ProgramCalculations.CalculateCalories();
            int value = (int)dailyRation.Calories;
            if (value >= int.MaxValue || value<0) mainView.SetCalories = int.MaxValue; else mainView.SetCalories = value;
        }
        public void SetSelectedProduct()
        {
            if (mainView.GetTreeView1.SelectedNode != null) selectedProduct = categories.FindCategory(mainView.GetTreeView1.SelectedNode.Parent.Text).FindProduct(mainView.GetTreeView1.SelectedNode.Text);
            else if (mainView.GetTreeView2.SelectedNode != null) selectedProduct = mealTime.FindCategory(mainView.GetTreeView2.SelectedNode.Parent.Text).FindProduct(mainView.GetTreeView2.SelectedNode.Text);
        }
        public void UpdateCPFC()
        {
            if (selectedProduct != null)
            {
                mainView.SetProductName = selectedProduct.Name;
                mainView.SetProductWeight = selectedProduct.Gramms;
                mainView.SetProductProteins = selectedProduct.Protein.ToString();
                mainView.SetProductFats = selectedProduct.Fats.ToString();
                mainView.SetProductCarbohydrates = selectedProduct.Carbs.ToString();
                mainView.SetProductCalories = selectedProduct.Calories.ToString();
            }
        }
        public void UpdateQuantity()
        {
            ProgramCalculations.CalculateQuantity(mainView.GetTrackBarValue);
        }
        public void UpdateCalorieIntake()
        {
            int value = (int)ProgramCalculations.CalculateCaloriesMealTimes();
            if (value >= int.MaxValue || value < 0) mainView.SetCaloriesIntake = int.MaxValue; else mainView.SetCaloriesIntake = value; 
        }
        public bool IsContainsInRation(String category, String name)
        {
            if (mealTime.FindCategory(category).FindProduct(name) != null) return true; else return false;
        }
        public bool IsContains(String name, bool flag = false)
        {
            Categories categor = null;
            TreeView treeView =productView.GetTreeView;
            if(treeView == null) treeView = categoryView.GetTreeView;
            if (treeView == mainView.GetTreeView1) categor = categories;
            else
                if (treeView == mainView.GetTreeView2) categor = mealTime;
            if (categor != null)
            {
                if (categor.FindCategory(name) != null) return true;
                else
                if (flag) { foreach (Category category1 in categor.categories) if (category1.FindProduct(name) != null) return true; }
            }
            return false;
        }
        public void TransferProduct(TreeNode newNode, TreeNode parentNode)
        {
            var product = categories.FindCategory(newNode.Parent.Text).FindProduct(newNode.Text);
            mealTime.AddProductInCategory(product, parentNode.Text);
        }
        public void UpdateTreeViewDirectory()
        {
            categories.CreateTreeView(mainView.GetTreeView1);
        }
        public void UpdateTreeViewRation()
        {
            mealTime.CreateTreeView(mainView.GetTreeView2);
        }
        public void CreateRation()
        {
            mealTime.categories = new List<Category>();
            mealTime.categories.Add(new Category() { description = "", name = "Завтрак" });
            mealTime.categories.Add(new Category() { description = "", name = "Обед" });
            mealTime.categories.Add(new Category() { description = "", name = "Ужин" });
        }
        public void ClearRation()
        {
            model.MealTimes.categories.Clear();
            CreateRation();
        }
        public void RemoveItem(TreeNode node)
        {
            Categories categor=null;
            if (node == mainView.GetTreeView1.SelectedNode) categor = categories;
            else
                if (node == mainView.GetTreeView2.SelectedNode) categor = mealTime;
            if (node != null && categor!=null)
            {
              if (node.Parent == null) categor.RemoveCategory(node.Text);
              else
              {
                    categor.FindCategory(node.Parent.Text).RemoveProduct(node.Text);
              }
            }
        }
        public void SaveRation()
        {
            model.SaveInXml(mealTime, "Meal Times.xml");
        }
        public void SaveDirectory()
        {
            model.SaveInXml(categories, "Products.xml");
        }
        public void AddProduct(String category)
        {
            Product product = new Product();
            product.Name = productView.GetProductName;
            product.Gramms = 100;
            product.SetCaloriesFromString(productView.GetProductCalories);
            product.SetProteinFromString(productView.GetProductProteins);
            product.SetFatsFromString(productView.GetProductFats);
            product.SetCarbsFromString(productView.GetProductCarbohydrates);
            categories.AddProductInCategory(product, category);
        }
        public void AddCategory()
        {
            Categories categor = null;
            TreeView treeView = categoryView.GetTreeView;
            if (treeView == mainView.GetTreeView1) categor = categories;
            else
                if (treeView == mainView.GetTreeView2) categor = mealTime;
            categor.categories.Add(new Category() { description = "", name = categoryView.GetCategoryName });
        }
    }
}
