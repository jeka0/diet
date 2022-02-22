using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DailyRation: Validation
    {
        public double bmr;
        public double arm;
        public double calories;
        public double protein;
        public double fats;
        public double carbs;
        public double Bmr { get { return bmr; } set { if (ValidateRange(value)) bmr = value; } }
        public double Arm { get { return arm; } set { if (ValidateRange(value)) arm = value; } }
        public double Calories { get { return calories; } }
        public void CalculateCalories()
        {
            calories = bmr * arm;
        }
    }
}
