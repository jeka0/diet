using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace Лаба_4_ЯП
{
    public partial class Form1 : Form, IMainFormView
    {
        public IPresenter Presenter { get; set; }
        public String GetWeight { get { return weight.Text; } }
        public String GetHeight { get { return height.Text; } }
        public String GetAge { get { return age.Text; } }
        public TreeView GetTreeView1 { get { return treeView1; } }
        public TreeView GetTreeView2 { get { return treeView2; } }
        public int GetTrackBarValue { get { return trackBar1.Value; } }
        public BusinessLayer.ActivityTypes GetActivityTypes() 
        {
            BusinessLayer.ActivityTypes type= BusinessLayer.ActivityTypes.Low;
                if (NormalActivity.Checked == true) type = BusinessLayer.ActivityTypes.Normal;
            else 
                if (AverageActivity.Checked == true) type = BusinessLayer.ActivityTypes.Average;
            else
                if (HighActivity.Checked == true) type = BusinessLayer.ActivityTypes.High;
            return type;
        }
        public String SetBMR { set { bmr.Text = value; } }
        public String SetARM { set { arm.Text = value; } }
        public int SetCaloriesIntake
        { 
            set 
            {
                if (value >= progressBarCaloriesIntake.Minimum && value <= progressBarCaloriesIntake.Maximum) progressBarCaloriesIntake.Value = value; else progressBarCaloriesIntake.Value = progressBarCaloriesIntake.Maximum;
                if (progressBarCaloriesIntake.Value > progressBarDailyRate.Value) labelCaloriesIntakeValue.ForeColor = Color.Red; else labelCaloriesIntakeValue.ForeColor = Color.Green;
                labelCaloriesIntakeValue.Text = value.ToString();
            } 
        }
        public int SetCalories 
        {
            set 
            {
                if (value >= progressBarDailyRate.Minimum && value <= progressBarDailyRate.Maximum) progressBarDailyRate.Value = value; else progressBarDailyRate.Value = progressBarDailyRate.Maximum;
                if (progressBarCaloriesIntake.Value > progressBarDailyRate.Value) labelCaloriesIntakeValue.ForeColor = Color.Red; else labelCaloriesIntakeValue.ForeColor = Color.Green;
                String str = value.ToString();
                labelDailyRateValue.Text = str;
                calories.Text = str;
            } 
        }
        public String SetProductName { set { labelProduct2.Text = value; } }
        public String SetProductCalories { set { labelCaloriesValue.Text = value; } }
        public String SetProductProteins { set { labelProteinsValue.Text = value; } }
        public String SetProductFats { set { labelFatsValue.Text = value; } }
        public String SetProductCarbohydrates { set { labelCarbohydratesValue.Text = value; } }
        public int SetProductWeight { set { labelWeightValue.Text = value.ToString(); trackBar1.Value = value; } }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelSuccessMessage.Hide();
            bmr.ReadOnly = true; calories.ReadOnly = true; proteins.ReadOnly = true;
            arm.ReadOnly = true; fats.ReadOnly = true; carbohydrates.ReadOnly = true;
            labelMin.Text = trackBar1.Minimum.ToString(); labelMax.Text = trackBar1.Maximum.ToString();
            Presenter.UpdateTreeViewDirectory();
            Presenter.UpdateTreeViewRation();
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (!treeView1.Nodes.Contains((TreeNode)e.Item))DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeView2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void treeView2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                TreeNode NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");
                TreeNode DestinationNode = ((TreeView)sender).GetNodeAt(((TreeView)sender).PointToClient(new Point(e.X, e.Y)));
                Predicate<TreeNode> predicate = (TreeNode treeNode) => { foreach (TreeNode node in treeView2.Nodes) if (node.Nodes.Contains(treeNode)) return true; return false; };
                if (treeView2.Nodes.Contains(DestinationNode)&&!Presenter.IsContainsInRation(DestinationNode.Text, NewNode.Text))
                {
                    DestinationNode.Nodes.Add((TreeNode)NewNode.Clone());
                    DestinationNode.Expand();
                    Presenter.TransferProduct(NewNode, DestinationNode);
                }
                else if (predicate(DestinationNode) && !Presenter.IsContainsInRation(DestinationNode.Parent.Text, NewNode.Text)) { DestinationNode.Parent.Nodes.Add((TreeNode)NewNode.Clone()); Presenter.TransferProduct(NewNode, DestinationNode.Parent); }
                Presenter.UpdateCalorieIntake();
            }
        }

        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                e.Handled = true;
                TreeNode[] treeNodes = treeView1.Nodes.Find(Search.Text, true);
                if (treeNodes.Length > 0)
                {
                    treeView1.SelectedNode = treeNodes[0];
                    treeView1.Focus();
                }
            }
        }

        private void Search_Enter(object sender, EventArgs e)
        {
            if (Search.Text == "Search...") Search.Text = "";
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            if (Search.Text == "") Search.Text = "Search...";
        }

        private void height_TextChanged(object sender, EventArgs e)
        {
            Presenter.UpdateBmr();
        }

        private void weight_TextChanged(object sender, EventArgs e)
        {
            Presenter.UpdateBmr();
        }

        private void age_TextChanged(object sender, EventArgs e)
        {
            Presenter.UpdateBmr();
        }

        private void LowActivity_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.UpdateArm();
        }

        private void NormalActivity_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.UpdateArm();
        }

        private void AverageActivity_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.UpdateArm();
        }

        private void HighActivity_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.UpdateArm();
        }

        private void bmr_TextChanged(object sender, EventArgs e)
        {
            Presenter.UpdateCalories();
        }

        private void arm_TextChanged(object sender, EventArgs e)
        {
            Presenter.UpdateCalories();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Parent != null)
            {
                treeView2.SelectedNode = null;
                Presenter.SetSelectedProduct();
                Presenter.UpdateCPFC();
            }
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView2.SelectedNode.Parent != null)
            {
                treeView1.SelectedNode = null;
                Presenter.SetSelectedProduct();
                Presenter.UpdateCPFC();
            }
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackBar1.Value % 50 > 25) trackBar1.Value += 50- trackBar1.Value % 50; else trackBar1.Value -= trackBar1.Value % 50;
            Presenter.UpdateQuantity();
            Presenter.UpdateCPFC();
            Presenter.UpdateCalorieIntake();
        }

        private void buttonClearRcion_Click(object sender, EventArgs e)
        {
            Presenter.ClearRation();
            Presenter.UpdateCalorieIntake();
            treeView2.Nodes.Clear();
            Presenter.UpdateTreeViewRation();
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            labelSuccessMessage.Hide();
            if (e.Button == MouseButtons.Right)
            {
                ((TreeView)sender).SelectedNode = ((TreeView)sender).GetNodeAt(e.X, e.Y);
                ((TreeView)sender).Focus();
            }
        }

        private void treeView2_MouseClick(object sender, MouseEventArgs e)
        {
            labelSuccessMessage.Hide();
            if (e.Button == MouseButtons.Right)
            {
                ((TreeView)sender).SelectedNode = ((TreeView)sender).GetNodeAt(e.X, e.Y);
                ((TreeView)sender).Focus();
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCategory newCategory = (NewCategory)Presenter.GetCategoryView;
            newCategory.point = this.Location;
            newCategory.treeView = treeView2;
            newCategory.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView2.SelectedNode != null)
            {
                Presenter.RemoveItem(treeView2.SelectedNode);
                Presenter.UpdateCalorieIntake();
                treeView2.SelectedNode.Remove();
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                Presenter.RemoveItem(treeView1.SelectedNode);
                treeView1.SelectedNode.Remove();
            }
        }

        private void AddCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCategory newCategory = (NewCategory)Presenter.GetCategoryView;
            newCategory.point = this.Location;
            newCategory.treeView = treeView1;
            newCategory.ShowDialog();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode!=null)
            {
                NewProduct newProduct = (NewProduct)Presenter.GetProductView;
                newProduct.point = this.Location;
                newProduct.treeView = treeView1;
                newProduct.ShowDialog();
            }
        }

        private void buttonSaveDirectory_Click(object sender, EventArgs e)
        {
            Presenter.SaveDirectory();
            labelSuccessMessage.Show();
        }

        private void buttonSaveRcion_Click(object sender, EventArgs e)
        {
            Presenter.SaveRation();
            labelSuccessMessage.Show();
        }

    }
}
