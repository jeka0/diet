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
    public partial class NewCategory : Form, INewCategory
    {
        public Point point;
        public TreeView treeView;
        public IAddPresenter Presenter { get; set; }
        public String GetCategoryName { get { return textBoxAdd.Text; } }
        public TreeView GetTreeView { get { return treeView; } }
        public NewCategory()
        {
            InitializeComponent();
        }

        private void NewCategory_Load(object sender, EventArgs e)
        {
            labelError.Hide();
            point.X += 350;
            point.Y += 180;
            this.Location = point;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            labelError.Hide();
            if (textBoxAdd.Text != "" && !Presenter.IsContains(textBoxAdd.Text,true))
            {
                Presenter.AddCategory();
                treeView.Nodes.Add(textBoxAdd.Text);
                textBoxAdd.Text = "";treeView = null;
                this.Close();
            }
            else labelError.Show();
        }

        private void textBoxAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                AddButton.PerformClick();
            }
        }

        private void NewCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBoxAdd.Text = ""; treeView = null;
        }
    }
}
