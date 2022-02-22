using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public interface IPresenter
    {
        void UpdateBmr();
        void UpdateArm();
        void UpdateCalories();
        void SetSelectedProduct();
        void UpdateCPFC();
        void UpdateCalorieIntake();
        void UpdateQuantity();
        bool IsContainsInRation(String category, String name);
        void TransferProduct(TreeNode newNode, TreeNode parentNode);
        void UpdateTreeViewDirectory();
        void UpdateTreeViewRation();
        void CreateRation();
        void ClearRation();
        void RemoveItem(TreeNode node);
        void SaveRation();
        void SaveDirectory();
        bool IsContains(String name, bool flag = false);
        INewProductView GetProductView { get; }
        INewCategory GetCategoryView { get; }
    }
}
