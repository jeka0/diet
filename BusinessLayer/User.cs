using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class User: Validation
    {
        private double weight=0;
        private double height=0;
        private int age=0;
        public ActivityTypes activityType = ActivityTypes.Low;
        public int Age { get { return age; } set { if (ValidateRange(value)) age = value; } }
        public double Weight { get { return weight; } set { if (ValidateRange(value)) weight = value; } }
        public double Height { get { return height; } set { if (ValidateRange(value)) height = value; } }        
        public void SetAgeFromString(String value) { Age = ConvertToInt32(value); }
        public void SetWeightFromString(String value) { Weight = ConvertToDouble(value); }
        public void SetHeightFromString(String value) { Height = ConvertToDouble(value); }
        public double CalculateBMR()
        {
            return 447.593 + 9.247 * Weight + 3.098 * Height - 4.330 * Age;
        }
        public double CalculateARM()
        {
            switch (activityType)
            {
                case ActivityTypes.Low: return 1.2;
                case ActivityTypes.Normal: return 1.375;
                case ActivityTypes.Average: return 1.55;
                case ActivityTypes.High: return 1.725;
                default: return 0.0;
            }
        }
    }
}
