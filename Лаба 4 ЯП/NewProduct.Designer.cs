
namespace Лаба_4_ЯП
{
    partial class NewProduct
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.labelWeightValue = new System.Windows.Forms.Label();
            this.labelCarbohydratesValue = new System.Windows.Forms.Label();
            this.labelFatsValue = new System.Windows.Forms.Label();
            this.labelProteinsValue = new System.Windows.Forms.Label();
            this.labelCaloriesValue = new System.Windows.Forms.Label();
            this.labelCarbohydrates = new System.Windows.Forms.Label();
            this.labelFats = new System.Windows.Forms.Label();
            this.labelProteins = new System.Windows.Forms.Label();
            this.labelCalories = new System.Windows.Forms.Label();
            this.labelNewProduct = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCalories = new System.Windows.Forms.TextBox();
            this.textBoxProteins = new System.Windows.Forms.TextBox();
            this.textBoxFats = new System.Windows.Forms.TextBox();
            this.textBoxCarbohydrates = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(146, 61);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(143, 22);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(98, 211);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(164, 33);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Добвить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // labelWeightValue
            // 
            this.labelWeightValue.AutoSize = true;
            this.labelWeightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeightValue.ForeColor = System.Drawing.Color.Green;
            this.labelWeightValue.Location = new System.Drawing.Point(112, 212);
            this.labelWeightValue.Name = "labelWeightValue";
            this.labelWeightValue.Size = new System.Drawing.Size(0, 18);
            this.labelWeightValue.TabIndex = 25;
            // 
            // labelCarbohydratesValue
            // 
            this.labelCarbohydratesValue.AutoSize = true;
            this.labelCarbohydratesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCarbohydratesValue.ForeColor = System.Drawing.Color.Green;
            this.labelCarbohydratesValue.Location = new System.Drawing.Point(112, 190);
            this.labelCarbohydratesValue.Name = "labelCarbohydratesValue";
            this.labelCarbohydratesValue.Size = new System.Drawing.Size(0, 18);
            this.labelCarbohydratesValue.TabIndex = 24;
            // 
            // labelFatsValue
            // 
            this.labelFatsValue.AutoSize = true;
            this.labelFatsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFatsValue.ForeColor = System.Drawing.Color.Black;
            this.labelFatsValue.Location = new System.Drawing.Point(31, 168);
            this.labelFatsValue.Name = "labelFatsValue";
            this.labelFatsValue.Size = new System.Drawing.Size(0, 18);
            this.labelFatsValue.TabIndex = 23;
            // 
            // labelProteinsValue
            // 
            this.labelProteinsValue.AutoSize = true;
            this.labelProteinsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProteinsValue.ForeColor = System.Drawing.Color.Black;
            this.labelProteinsValue.Location = new System.Drawing.Point(60, 142);
            this.labelProteinsValue.Name = "labelProteinsValue";
            this.labelProteinsValue.Size = new System.Drawing.Size(0, 18);
            this.labelProteinsValue.TabIndex = 22;
            // 
            // labelCaloriesValue
            // 
            this.labelCaloriesValue.AutoSize = true;
            this.labelCaloriesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaloriesValue.ForeColor = System.Drawing.Color.Black;
            this.labelCaloriesValue.Location = new System.Drawing.Point(60, 116);
            this.labelCaloriesValue.Name = "labelCaloriesValue";
            this.labelCaloriesValue.Size = new System.Drawing.Size(0, 18);
            this.labelCaloriesValue.TabIndex = 21;
            // 
            // labelCarbohydrates
            // 
            this.labelCarbohydrates.AutoSize = true;
            this.labelCarbohydrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCarbohydrates.ForeColor = System.Drawing.Color.Black;
            this.labelCarbohydrates.Location = new System.Drawing.Point(44, 173);
            this.labelCarbohydrates.Name = "labelCarbohydrates";
            this.labelCarbohydrates.Size = new System.Drawing.Size(98, 20);
            this.labelCarbohydrates.TabIndex = 19;
            this.labelCarbohydrates.Text = "Углеводы:";
            // 
            // labelFats
            // 
            this.labelFats.AutoSize = true;
            this.labelFats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFats.ForeColor = System.Drawing.Color.Black;
            this.labelFats.Location = new System.Drawing.Point(44, 145);
            this.labelFats.Name = "labelFats";
            this.labelFats.Size = new System.Drawing.Size(60, 20);
            this.labelFats.TabIndex = 18;
            this.labelFats.Text = "Жиры:";
            // 
            // labelProteins
            // 
            this.labelProteins.AutoSize = true;
            this.labelProteins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProteins.ForeColor = System.Drawing.Color.Black;
            this.labelProteins.Location = new System.Drawing.Point(44, 117);
            this.labelProteins.Name = "labelProteins";
            this.labelProteins.Size = new System.Drawing.Size(99, 20);
            this.labelProteins.TabIndex = 17;
            this.labelProteins.Text = "Протеины:";
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCalories.ForeColor = System.Drawing.Color.Black;
            this.labelCalories.Location = new System.Drawing.Point(44, 89);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(86, 20);
            this.labelCalories.TabIndex = 16;
            this.labelCalories.Text = "Калории:";
            // 
            // labelNewProduct
            // 
            this.labelNewProduct.AutoSize = true;
            this.labelNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewProduct.Location = new System.Drawing.Point(12, 22);
            this.labelNewProduct.Name = "labelNewProduct";
            this.labelNewProduct.Size = new System.Drawing.Size(331, 20);
            this.labelNewProduct.TabIndex = 26;
            this.labelNewProduct.Text = "Заполните характеристики продукта:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(44, 61);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(96, 20);
            this.labelName.TabIndex = 27;
            this.labelName.Text = "Название:";
            // 
            // textBoxCalories
            // 
            this.textBoxCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCalories.Location = new System.Drawing.Point(146, 89);
            this.textBoxCalories.Name = "textBoxCalories";
            this.textBoxCalories.Size = new System.Drawing.Size(143, 22);
            this.textBoxCalories.TabIndex = 28;
            this.textBoxCalories.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCalories_KeyPress);
            // 
            // textBoxProteins
            // 
            this.textBoxProteins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProteins.Location = new System.Drawing.Point(146, 117);
            this.textBoxProteins.Name = "textBoxProteins";
            this.textBoxProteins.Size = new System.Drawing.Size(143, 22);
            this.textBoxProteins.TabIndex = 29;
            this.textBoxProteins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProteins_KeyPress);
            // 
            // textBoxFats
            // 
            this.textBoxFats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFats.Location = new System.Drawing.Point(146, 145);
            this.textBoxFats.Name = "textBoxFats";
            this.textBoxFats.Size = new System.Drawing.Size(143, 22);
            this.textBoxFats.TabIndex = 30;
            this.textBoxFats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFats_KeyPress);
            // 
            // textBoxCarbohydrates
            // 
            this.textBoxCarbohydrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCarbohydrates.Location = new System.Drawing.Point(146, 173);
            this.textBoxCarbohydrates.Name = "textBoxCarbohydrates";
            this.textBoxCarbohydrates.Size = new System.Drawing.Size(143, 22);
            this.textBoxCarbohydrates.TabIndex = 31;
            this.textBoxCarbohydrates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCarbohydrates_KeyPress);
            // 
            // labelError
            // 
            this.labelError.BackColor = System.Drawing.Color.Red;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.White;
            this.labelError.Location = new System.Drawing.Point(30, 254);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(296, 43);
            this.labelError.TabIndex = 32;
            this.labelError.Text = "Название не введино или элемент с таким названием уже существует !!!";
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 302);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxCarbohydrates);
            this.Controls.Add(this.textBoxFats);
            this.Controls.Add(this.textBoxProteins);
            this.Controls.Add(this.textBoxCalories);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelNewProduct);
            this.Controls.Add(this.labelWeightValue);
            this.Controls.Add(this.labelCarbohydratesValue);
            this.Controls.Add(this.labelFatsValue);
            this.Controls.Add(this.labelProteinsValue);
            this.Controls.Add(this.labelCaloriesValue);
            this.Controls.Add(this.labelCarbohydrates);
            this.Controls.Add(this.labelFats);
            this.Controls.Add(this.labelProteins);
            this.Controls.Add(this.labelCalories);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textBoxName);
            this.MaximizeBox = false;
            this.Name = "NewProduct";
            this.Text = "NewProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewProduct_FormClosed);
            this.Load += new System.EventHandler(this.NewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label labelWeightValue;
        private System.Windows.Forms.Label labelCarbohydratesValue;
        private System.Windows.Forms.Label labelFatsValue;
        private System.Windows.Forms.Label labelProteinsValue;
        private System.Windows.Forms.Label labelCaloriesValue;
        private System.Windows.Forms.Label labelCarbohydrates;
        private System.Windows.Forms.Label labelFats;
        private System.Windows.Forms.Label labelProteins;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.Label labelNewProduct;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxCalories;
        private System.Windows.Forms.TextBox textBoxProteins;
        private System.Windows.Forms.TextBox textBoxFats;
        private System.Windows.Forms.TextBox textBoxCarbohydrates;
        private System.Windows.Forms.Label labelError;
    }
}