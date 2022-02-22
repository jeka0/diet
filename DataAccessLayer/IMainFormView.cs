using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public interface IMainFormView
    {
        IPresenter Presenter { get; set; }
        String GetWeight { get; }
        String GetHeight { get; }
        String GetAge { get; }
        TreeView GetTreeView1 { get; }
        TreeView GetTreeView2 { get; }
        int GetTrackBarValue { get; }
        ActivityTypes GetActivityTypes();
        String SetBMR { set; }
        String SetARM { set; }
        int SetCaloriesIntake { set; }
        int SetCalories { set; }
        String SetProductName { set; }
        String SetProductCalories { set; }
        String SetProductProteins { set; }
        String SetProductFats { set; }
        String SetProductCarbohydrates { set; }
        int SetProductWeight { set; }

    }
}
