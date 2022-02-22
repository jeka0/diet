using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public interface INewProductView
    {
        IAddPresenter Presenter { get; set; }
        String GetProductName { get; }
        String GetProductCalories { get; }
        String GetProductProteins { get; }
        String GetProductFats { get; }
        String GetProductCarbohydrates { get; }
        TreeView GetTreeView { get; }
    }
}
