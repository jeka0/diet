using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Product: Validation
    {
        public String Name;
        private int gramms;
        private double protein;
        private double fats;
        private double carbs;
        private double calories;
        public int Gramms { get { return gramms; } set { if (ValidateRange(value)) gramms = value; } }
        public double Protein { get { return protein; } set { if (ValidateRange(value)) protein = value; } }
        public double Fats { get { return fats; } set { if (ValidateRange(value)) fats = value; } }
        public double Carbs { get { return carbs; } set { if (ValidateRange(value)) carbs = value; } }
        public double Calories { get { return calories; } set { if (ValidateRange(value)) calories = value; } }
        public void SetGrammsFromString(String value){ Gramms = ConvertToInt32(value);}
        public void SetProteinFromString(String value) { Protein = ConvertToDouble(value); }
        public void SetFatsFromString(String value) { Fats = ConvertToDouble(value); }
        public void SetCarbsFromString(String value) { Carbs = ConvertToDouble(value); }
        public void SetCaloriesFromString(String value) { Calories = ConvertToDouble(value); }
        public Product Copy()
        {
            Product newProduct = new Product();
            newProduct.Name = Name;
            newProduct.gramms = gramms;
            newProduct.protein = protein;
            newProduct.fats = fats;
            newProduct.carbs = carbs;
            newProduct.calories = calories;
        return newProduct;
        }
    }
}
