using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataAccessLayer
{
    public interface IModel
    {
        Categories Categories { get; }
        Categories MealTimes { get; }
        void SaveInXml(Categories categories, String file);
    }
}
