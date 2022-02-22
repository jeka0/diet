using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataAccessLayer;
using System.Windows.Forms;

namespace ServiceLayer
{
    public class ProgramCalculations
    {
        public static IModel model;
        public static void CalculateBMR()
        {
           Presenter.dailyRation.Bmr =Presenter.user.CalculateBMR();
        }
        public static void CalculateARM()
        {
            Presenter.dailyRation.Arm = Presenter.user.CalculateARM();
        }
        public static void CalculateCalories()
        {
            Presenter.dailyRation.CalculateCalories();
        }
        public static void CalculateQuantity(double value)
        {
            if (Presenter.selectedProduct != null)
            {
                value /= Presenter.selectedProduct.Gramms;
                Presenter.selectedProduct.Gramms = (int)(Presenter.selectedProduct.Gramms * value);
                Presenter.selectedProduct.Protein *= value;
                Presenter.selectedProduct.Fats *= value;
                Presenter.selectedProduct.Carbs *= value;
                Presenter.selectedProduct.Calories *= value;
            }
        }
        public static double CalculateCaloriesMealTimes()
        {
           return model.MealTimes.categories.Sum<Category>(a => a.products.Sum<Product>(b => b.Calories));
        }

    }
}
