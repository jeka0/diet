using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace ServiceLayer
{
    public static class DailyRationAccess
    {
        internal static DailyRation dailyRation = new DailyRation();
        public static void SetBMR(double value)
        {
            if (dailyRation.ValidateRange(value)) dailyRation.bmr = value;
        }
        public static void SetARM(double value)
        {
            if (dailyRation.ValidateRange(value)) dailyRation.arm = value;
        }
        public static double GetBMR(){return dailyRation.bmr;}
        public static double GetARM(){return dailyRation.arm;}
        public static double GetCalories() { return dailyRation.calories; }
    }
}
