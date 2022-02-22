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
    public partial class NewProduct : Form, INewProductView
    {
        public Point point;
        public TreeView treeView;
        public IAddPresenter Presenter { get; set; }
        public String GetProductName { get { return textBoxName.Text; } }
        public String GetProductCalories { get { return textBoxCalories.Text; } }
        public String GetProductProteins { get { return textBoxProteins.Text; } }
        public String GetProductFats { get { return textBoxFats.Text; } }
        public String GetProductCarbohydrates { get { return textBoxCarbohydrates.Text; } }
        public TreeView GetTreeView { get { return treeView; } }
        public NewProduct()
        {
            InitializeComponent();
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {
            labelError.Hide();
            point.X += 390;
            point.Y += 140;
            this.Location = point;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            labelError.Hide();
            if (textBoxName.Text != "" && !Presenter.IsContains(textBoxName.Text,true))
            {
                if (treeView.Nodes.Contains(treeView.SelectedNode))
                {
                    Presenter.AddProduct(treeView.SelectedNode.Text);
                    treeView.SelectedNode.Nodes.Add(textBoxName.Text, textBoxName.Text);
                    treeView.SelectedNode.Expand();
                }else if(treeView.SelectedNode.Parent != null && treeView.Nodes.Contains(treeView.SelectedNode.Parent))
                {
                    Presenter.AddProduct(treeView.SelectedNode.Parent.Text);
                    treeView.SelectedNode.Parent.Nodes.Add(textBoxName.Text, textBoxName.Text);
                    treeView.SelectedNode.Parent.Expand();
                }
                textBoxName.Text = ""; textBoxCalories.Text = ""; textBoxProteins.Text = ""; textBoxFats.Text = ""; textBoxCarbohydrates.Text = "";
                treeView = null;
                this.Close();
            }else labelError.Show();
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                textBoxCalories.Focus();
            }
        }

        private void textBoxCalories_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                textBoxProteins.Focus();
            }
        }

        private void textBoxProteins_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                textBoxFats.Focus();
            }
        }

        private void textBoxFats_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                textBoxCarbohydrates.Focus();
            }
        }

        private void textBoxCarbohydrates_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                AddButton.PerformClick();
            }
        }

        private void NewProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBoxName.Text = ""; textBoxCalories.Text = ""; textBoxProteins.Text = ""; textBoxFats.Text = ""; textBoxCarbohydrates.Text = "";
            treeView = null;
        }
    }
}
