using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IAddPresenter
    {
        bool IsContains(String name, bool flag = false);
        void AddProduct(String category);
        void AddCategory();
    }
}
