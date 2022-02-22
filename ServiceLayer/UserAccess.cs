using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace ServiceLayer
{
    public static class UserAccess
    {
        internal static User user = new User();
        static public void SetWeight(String str) 
        {
            double weight;
            if (Double.TryParse(str, out weight)) SetWeight(weight);
        }
        static public void SetWeight(double value)
        {
            if(user.ValidateRange(value)) user.Weight = value;
        }
        static public void SetHeight(String str) 
        {
            double height;
            if(Double.TryParse(str, out height)) SetHeight(height); 
        }
        static public void SetHeight(double value)
        {
            if (user.ValidateRange(value)) user.Height = value;
        }
        static public void SetAge(String str) 
        {
            int age;
            if(Int32.TryParse(str, out age)) SetAge(age); 
        }
        static public void SetAge(int value)
        {
            if (user.ValidateRange(value)) user.Age = value;
        }
        static public void SetActivityTypes(ActivityTypes value)
        {
            user.activityType = value;
        }
        static public ActivityTypes GetActivityTypes { get { return user.activityType; } }
        static public double GetWeight { get { return user.Weight; } }
        static public double GetHeight { get { return user.Height; } }
        static public int GetAge { get { return user.Age; } }
    }
}
