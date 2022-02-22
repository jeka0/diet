
namespace Лаба_4_ЯП
{
    partial class NewCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.labelNewCategory = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(135, 116);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(164, 33);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добвить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAdd.Location = new System.Drawing.Point(89, 73);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(252, 22);
            this.textBoxAdd.TabIndex = 1;
            this.textBoxAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAdd_KeyPress);
            // 
            // labelNewCategory
            // 
            this.labelNewCategory.AutoSize = true;
            this.labelNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewCategory.Location = new System.Drawing.Point(55, 28);
            this.labelNewCategory.Name = "labelNewCategory";
            this.labelNewCategory.Size = new System.Drawing.Size(319, 20);
            this.labelNewCategory.TabIndex = 2;
            this.labelNewCategory.Text = "Введите название новой категории:";
            // 
            // labelError
            // 
            this.labelError.BackColor = System.Drawing.Color.Red;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.White;
            this.labelError.Location = new System.Drawing.Point(69, 152);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(290, 47);
            this.labelError.TabIndex = 3;
            this.labelError.Text = "Название не введино или элемент с таким названием уже существует !!!";
            // 
            // NewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 205);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelNewCategory);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.AddButton);
            this.MaximizeBox = false;
            this.Name = "NewCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewCategory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewCategory_FormClosed);
            this.Load += new System.EventHandler(this.NewCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Label labelNewCategory;
        private System.Windows.Forms.Label labelError;
    }
}