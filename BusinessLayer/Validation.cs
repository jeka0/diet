using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Validation
    {
        public virtual bool ValidateRange(double value)
        {
            return value >= 0;
        }
        public virtual int ConvertToInt32(String value)
        {
            int result;
            Int32.TryParse(value, out result);
            return result;
        }
        public virtual double ConvertToDouble(String value)
        {
            double result;
            Double.TryParse(value, out result);
            return result;
        }
    }
}
