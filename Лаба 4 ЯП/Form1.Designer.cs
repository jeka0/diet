
namespace Лаба_4_ЯП
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenu2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelYears = new System.Windows.Forms.Label();
            this.labelCm = new System.Windows.Forms.Label();
            this.labelKg = new System.Windows.Forms.Label();
            this.labelBMR = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.bmr = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.labelUserData = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HighActivity = new System.Windows.Forms.RadioButton();
            this.NormalActivity = new System.Windows.Forms.RadioButton();
            this.AverageActivity = new System.Windows.Forms.RadioButton();
            this.LowActivity = new System.Windows.Forms.RadioButton();
            this.labelARM = new System.Windows.Forms.Label();
            this.arm = new System.Windows.Forms.TextBox();
            this.labelActivity = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.calories = new System.Windows.Forms.TextBox();
            this.proteins = new System.Windows.Forms.TextBox();
            this.fats = new System.Windows.Forms.TextBox();
            this.labelCarbohydrates = new System.Windows.Forms.Label();
            this.labelFats = new System.Windows.Forms.Label();
            this.labelProteins = new System.Windows.Forms.Label();
            this.labelCalories = new System.Windows.Forms.Label();
            this.carbohydrates = new System.Windows.Forms.TextBox();
            this.labelDailyRate = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelWeightValue = new System.Windows.Forms.Label();
            this.labelCarbohydratesValue = new System.Windows.Forms.Label();
            this.labelFatsValue = new System.Windows.Forms.Label();
            this.labelProteinsValue = new System.Windows.Forms.Label();
            this.labelCaloriesValue = new System.Windows.Forms.Label();
            this.labelProduct2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelWeight2 = new System.Windows.Forms.Label();
            this.labelCarbohydrates2 = new System.Windows.Forms.Label();
            this.labelFats2 = new System.Windows.Forms.Label();
            this.labelProteins2 = new System.Windows.Forms.Label();
            this.labelCalories2 = new System.Windows.Forms.Label();
            this.labelCPFC = new System.Windows.Forms.Label();
            this.labelDailyRate2 = new System.Windows.Forms.Label();
            this.progressBarDailyRate = new System.Windows.Forms.ProgressBar();
            this.labelCaloriesIntake = new System.Windows.Forms.Label();
            this.progressBarCaloriesIntake = new System.Windows.Forms.ProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonSaveDirectory = new System.Windows.Forms.Button();
            this.buttonSaveRcion = new System.Windows.Forms.Button();
            this.buttonClearRcion = new System.Windows.Forms.Button();
            this.labelDailyRateValue = new System.Windows.Forms.Label();
            this.labelCaloriesIntakeValue = new System.Windows.Forms.Label();
            this.labelSuccessMessage = new System.Windows.Forms.Label();
            this.contextMenu2.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.ContextMenuStrip = this.contextMenu2;
            this.treeView1.Location = new System.Drawing.Point(292, 51);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(263, 480);
            this.treeView1.TabIndex = 0;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // contextMenu2
            // 
            this.contextMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.AddCategoryToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.contextMenu2.Name = "contextMenu";
            this.contextMenu2.Size = new System.Drawing.Size(146, 70);
            this.contextMenu2.Text = "Delete";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addProductToolStripMenuItem.Text = "Add product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // AddCategoryToolStripMenuItem
            // 
            this.AddCategoryToolStripMenuItem.Name = "AddCategoryToolStripMenuItem";
            this.AddCategoryToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.AddCategoryToolStripMenuItem.Text = "Add category";
            this.AddCategoryToolStripMenuItem.Click += new System.EventHandler(this.AddCategoryToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // treeView2
            // 
            this.treeView2.AllowDrop = true;
            this.treeView2.ContextMenuStrip = this.contextMenu;
            this.treeView2.Location = new System.Drawing.Point(580, 51);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(263, 480);
            this.treeView2.TabIndex = 1;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            this.treeView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView2_DragDrop);
            this.treeView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView2_DragEnter);
            this.treeView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView2_MouseClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(146, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addToolStripMenuItem.Text = "Add category";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(292, 25);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(263, 20);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search...";
            this.Search.Enter += new System.EventHandler(this.Search_Enter);
            this.Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_KeyPress);
            this.Search.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelYears);
            this.panel1.Controls.Add(this.labelCm);
            this.panel1.Controls.Add(this.labelKg);
            this.panel1.Controls.Add(this.labelBMR);
            this.panel1.Controls.Add(this.labelAge);
            this.panel1.Controls.Add(this.labelHeight);
            this.panel1.Controls.Add(this.labelWeight);
            this.panel1.Controls.Add(this.bmr);
            this.panel1.Controls.Add(this.age);
            this.panel1.Controls.Add(this.height);
            this.panel1.Controls.Add(this.weight);
            this.panel1.Location = new System.Drawing.Point(13, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 138);
            this.panel1.TabIndex = 3;
            // 
            // labelYears
            // 
            this.labelYears.AutoSize = true;
            this.labelYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYears.Location = new System.Drawing.Point(210, 72);
            this.labelYears.Name = "labelYears";
            this.labelYears.Size = new System.Drawing.Size(42, 16);
            this.labelYears.TabIndex = 10;
            this.labelYears.Text = "years";
            // 
            // labelCm
            // 
            this.labelCm.AutoSize = true;
            this.labelCm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCm.Location = new System.Drawing.Point(210, 46);
            this.labelCm.Name = "labelCm";
            this.labelCm.Size = new System.Drawing.Size(26, 16);
            this.labelCm.TabIndex = 9;
            this.labelCm.Text = "cm";
            // 
            // labelKg
            // 
            this.labelKg.AutoSize = true;
            this.labelKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKg.Location = new System.Drawing.Point(210, 20);
            this.labelKg.Name = "labelKg";
            this.labelKg.Size = new System.Drawing.Size(23, 16);
            this.labelKg.TabIndex = 8;
            this.labelKg.Text = "kg";
            // 
            // labelBMR
            // 
            this.labelBMR.AutoSize = true;
            this.labelBMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBMR.ForeColor = System.Drawing.Color.DimGray;
            this.labelBMR.Location = new System.Drawing.Point(12, 96);
            this.labelBMR.Name = "labelBMR";
            this.labelBMR.Size = new System.Drawing.Size(46, 18);
            this.labelBMR.TabIndex = 7;
            this.labelBMR.Text = "BMR:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.Location = new System.Drawing.Point(12, 70);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(37, 18);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Age:";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight.Location = new System.Drawing.Point(12, 44);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(54, 18);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "Height:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeight.Location = new System.Drawing.Point(12, 18);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(58, 18);
            this.labelWeight.TabIndex = 4;
            this.labelWeight.Text = "Weight:";
            // 
            // bmr
            // 
            this.bmr.BackColor = System.Drawing.SystemColors.Control;
            this.bmr.ForeColor = System.Drawing.Color.DimGray;
            this.bmr.Location = new System.Drawing.Point(81, 97);
            this.bmr.Name = "bmr";
            this.bmr.Size = new System.Drawing.Size(123, 20);
            this.bmr.TabIndex = 3;
            this.bmr.TextChanged += new System.EventHandler(this.bmr_TextChanged);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(81, 71);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(123, 20);
            this.age.TabIndex = 2;
            this.age.TextChanged += new System.EventHandler(this.age_TextChanged);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(81, 45);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(123, 20);
            this.height.TabIndex = 1;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(81, 19);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(123, 20);
            this.weight.TabIndex = 0;
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // labelUserData
            // 
            this.labelUserData.AutoSize = true;
            this.labelUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserData.Location = new System.Drawing.Point(17, 39);
            this.labelUserData.Name = "labelUserData";
            this.labelUserData.Size = new System.Drawing.Size(72, 18);
            this.labelUserData.TabIndex = 4;
            this.labelUserData.Text = "User data";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.HighActivity);
            this.panel2.Controls.Add(this.NormalActivity);
            this.panel2.Controls.Add(this.AverageActivity);
            this.panel2.Controls.Add(this.LowActivity);
            this.panel2.Controls.Add(this.labelARM);
            this.panel2.Controls.Add(this.arm);
            this.panel2.Location = new System.Drawing.Point(13, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 168);
            this.panel2.TabIndex = 5;
            // 
            // HighActivity
            // 
            this.HighActivity.AutoSize = true;
            this.HighActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HighActivity.Location = new System.Drawing.Point(35, 97);
            this.HighActivity.Name = "HighActivity";
            this.HighActivity.Size = new System.Drawing.Size(104, 22);
            this.HighActivity.TabIndex = 11;
            this.HighActivity.Text = "High activity";
            this.HighActivity.UseVisualStyleBackColor = true;
            this.HighActivity.CheckedChanged += new System.EventHandler(this.HighActivity_CheckedChanged);
            // 
            // NormalActivity
            // 
            this.NormalActivity.AutoSize = true;
            this.NormalActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NormalActivity.Location = new System.Drawing.Point(35, 43);
            this.NormalActivity.Name = "NormalActivity";
            this.NormalActivity.Size = new System.Drawing.Size(123, 22);
            this.NormalActivity.TabIndex = 10;
            this.NormalActivity.Text = "Normal activity";
            this.NormalActivity.UseVisualStyleBackColor = true;
            this.NormalActivity.CheckedChanged += new System.EventHandler(this.NormalActivity_CheckedChanged);
            // 
            // AverageActivity
            // 
            this.AverageActivity.AutoSize = true;
            this.AverageActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AverageActivity.Location = new System.Drawing.Point(35, 69);
            this.AverageActivity.Name = "AverageActivity";
            this.AverageActivity.Size = new System.Drawing.Size(127, 22);
            this.AverageActivity.TabIndex = 9;
            this.AverageActivity.Text = "Average activity";
            this.AverageActivity.UseVisualStyleBackColor = true;
            this.AverageActivity.CheckedChanged += new System.EventHandler(this.AverageActivity_CheckedChanged);
            // 
            // LowActivity
            // 
            this.LowActivity.AutoSize = true;
            this.LowActivity.Checked = true;
            this.LowActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LowActivity.Location = new System.Drawing.Point(35, 15);
            this.LowActivity.Name = "LowActivity";
            this.LowActivity.Size = new System.Drawing.Size(102, 22);
            this.LowActivity.TabIndex = 8;
            this.LowActivity.TabStop = true;
            this.LowActivity.Text = "Low activity";
            this.LowActivity.UseVisualStyleBackColor = true;
            this.LowActivity.CheckedChanged += new System.EventHandler(this.LowActivity_CheckedChanged);
            // 
            // labelARM
            // 
            this.labelARM.AutoSize = true;
            this.labelARM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelARM.ForeColor = System.Drawing.Color.DimGray;
            this.labelARM.Location = new System.Drawing.Point(12, 129);
            this.labelARM.Name = "labelARM";
            this.labelARM.Size = new System.Drawing.Size(45, 18);
            this.labelARM.TabIndex = 7;
            this.labelARM.Text = "ARM:";
            // 
            // arm
            // 
            this.arm.BackColor = System.Drawing.SystemColors.Control;
            this.arm.ForeColor = System.Drawing.Color.DimGray;
            this.arm.Location = new System.Drawing.Point(81, 130);
            this.arm.Name = "arm";
            this.arm.Size = new System.Drawing.Size(123, 20);
            this.arm.TabIndex = 3;
            this.arm.Text = "1.2";
            this.arm.TextChanged += new System.EventHandler(this.arm_TextChanged);
            // 
            // labelActivity
            // 
            this.labelActivity.AutoSize = true;
            this.labelActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActivity.Location = new System.Drawing.Point(17, 192);
            this.labelActivity.Name = "labelActivity";
            this.labelActivity.Size = new System.Drawing.Size(53, 18);
            this.labelActivity.TabIndex = 8;
            this.labelActivity.Text = "Activity";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.calories);
            this.panel3.Controls.Add(this.proteins);
            this.panel3.Controls.Add(this.fats);
            this.panel3.Controls.Add(this.labelCarbohydrates);
            this.panel3.Controls.Add(this.labelFats);
            this.panel3.Controls.Add(this.labelProteins);
            this.panel3.Controls.Add(this.labelCalories);
            this.panel3.Controls.Add(this.carbohydrates);
            this.panel3.Location = new System.Drawing.Point(13, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 138);
            this.panel3.TabIndex = 11;
            // 
            // calories
            // 
            this.calories.BackColor = System.Drawing.SystemColors.Control;
            this.calories.ForeColor = System.Drawing.Color.DimGray;
            this.calories.Location = new System.Drawing.Point(85, 17);
            this.calories.Name = "calories";
            this.calories.Size = new System.Drawing.Size(123, 20);
            this.calories.TabIndex = 10;
            // 
            // proteins
            // 
            this.proteins.BackColor = System.Drawing.SystemColors.Control;
            this.proteins.ForeColor = System.Drawing.Color.DimGray;
            this.proteins.Location = new System.Drawing.Point(85, 43);
            this.proteins.Name = "proteins";
            this.proteins.Size = new System.Drawing.Size(123, 20);
            this.proteins.TabIndex = 9;
            // 
            // fats
            // 
            this.fats.BackColor = System.Drawing.SystemColors.Control;
            this.fats.ForeColor = System.Drawing.Color.DimGray;
            this.fats.Location = new System.Drawing.Point(85, 68);
            this.fats.Name = "fats";
            this.fats.Size = new System.Drawing.Size(123, 20);
            this.fats.TabIndex = 8;
            // 
            // labelCarbohydrates
            // 
            this.labelCarbohydrates.AutoSize = true;
            this.labelCarbohydrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCarbohydrates.Location = new System.Drawing.Point(12, 96);
            this.labelCarbohydrates.Name = "labelCarbohydrates";
            this.labelCarbohydrates.Size = new System.Drawing.Size(100, 16);
            this.labelCarbohydrates.TabIndex = 7;
            this.labelCarbohydrates.Text = "Carbohydrates:";
            // 
            // labelFats
            // 
            this.labelFats.AutoSize = true;
            this.labelFats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFats.Location = new System.Drawing.Point(38, 68);
            this.labelFats.Name = "labelFats";
            this.labelFats.Size = new System.Drawing.Size(41, 18);
            this.labelFats.TabIndex = 6;
            this.labelFats.Text = "Fats:";
            // 
            // labelProteins
            // 
            this.labelProteins.AutoSize = true;
            this.labelProteins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProteins.Location = new System.Drawing.Point(12, 43);
            this.labelProteins.Name = "labelProteins";
            this.labelProteins.Size = new System.Drawing.Size(67, 18);
            this.labelProteins.TabIndex = 5;
            this.labelProteins.Text = "Proteins:";
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCalories.Location = new System.Drawing.Point(12, 15);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(67, 18);
            this.labelCalories.TabIndex = 4;
            this.labelCalories.Text = "Calories:";
            // 
            // carbohydrates
            // 
            this.carbohydrates.BackColor = System.Drawing.SystemColors.Control;
            this.carbohydrates.ForeColor = System.Drawing.Color.DimGray;
            this.carbohydrates.Location = new System.Drawing.Point(113, 95);
            this.carbohydrates.Name = "carbohydrates";
            this.carbohydrates.Size = new System.Drawing.Size(123, 20);
            this.carbohydrates.TabIndex = 3;
            // 
            // labelDailyRate
            // 
            this.labelDailyRate.AutoSize = true;
            this.labelDailyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDailyRate.Location = new System.Drawing.Point(17, 377);
            this.labelDailyRate.Name = "labelDailyRate";
            this.labelDailyRate.Size = new System.Drawing.Size(69, 18);
            this.labelDailyRate.TabIndex = 12;
            this.labelDailyRate.Text = "Daily rate";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelMax);
            this.panel4.Controls.Add(this.labelMin);
            this.panel4.Controls.Add(this.labelWeightValue);
            this.panel4.Controls.Add(this.labelCarbohydratesValue);
            this.panel4.Controls.Add(this.labelFatsValue);
            this.panel4.Controls.Add(this.labelProteinsValue);
            this.panel4.Controls.Add(this.labelCaloriesValue);
            this.panel4.Controls.Add(this.labelProduct2);
            this.panel4.Controls.Add(this.trackBar1);
            this.panel4.Controls.Add(this.labelWeight2);
            this.panel4.Controls.Add(this.labelCarbohydrates2);
            this.panel4.Controls.Add(this.labelFats2);
            this.panel4.Controls.Add(this.labelProteins2);
            this.panel4.Controls.Add(this.labelCalories2);
            this.panel4.Location = new System.Drawing.Point(864, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 221);
            this.panel4.TabIndex = 13;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMax.ForeColor = System.Drawing.Color.Red;
            this.labelMax.Location = new System.Drawing.Point(263, 170);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(32, 16);
            this.labelMax.TabIndex = 17;
            this.labelMax.Text = "500";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMin.ForeColor = System.Drawing.Color.Red;
            this.labelMin.Location = new System.Drawing.Point(0, 170);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 16);
            this.labelMin.TabIndex = 16;
            this.labelMin.Text = "50";
            // 
            // labelWeightValue
            // 
            this.labelWeightValue.AutoSize = true;
            this.labelWeightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeightValue.ForeColor = System.Drawing.Color.Green;
            this.labelWeightValue.Location = new System.Drawing.Point(149, 140);
            this.labelWeightValue.Name = "labelWeightValue";
            this.labelWeightValue.Size = new System.Drawing.Size(0, 18);
            this.labelWeightValue.TabIndex = 15;
            // 
            // labelCarbohydratesValue
            // 
            this.labelCarbohydratesValue.AutoSize = true;
            this.labelCarbohydratesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCarbohydratesValue.ForeColor = System.Drawing.Color.Green;
            this.labelCarbohydratesValue.Location = new System.Drawing.Point(149, 118);
            this.labelCarbohydratesValue.Name = "labelCarbohydratesValue";
            this.labelCarbohydratesValue.Size = new System.Drawing.Size(0, 18);
            this.labelCarbohydratesValue.TabIndex = 14;
            // 
            // labelFatsValue
            // 
            this.labelFatsValue.AutoSize = true;
            this.labelFatsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFatsValue.ForeColor = System.Drawing.Color.Green;
            this.labelFatsValue.Location = new System.Drawing.Point(68, 96);
            this.labelFatsValue.Name = "labelFatsValue";
            this.labelFatsValue.Size = new System.Drawing.Size(0, 18);
            this.labelFatsValue.TabIndex = 13;
            // 
            // labelProteinsValue
            // 
            this.labelProteinsValue.AutoSize = true;
            this.labelProteinsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProteinsValue.ForeColor = System.Drawing.Color.Green;
            this.labelProteinsValue.Location = new System.Drawing.Point(97, 70);
            this.labelProteinsValue.Name = "labelProteinsValue";
            this.labelProteinsValue.Size = new System.Drawing.Size(0, 18);
            this.labelProteinsValue.TabIndex = 12;
            // 
            // labelCaloriesValue
            // 
            this.labelCaloriesValue.AutoSize = true;
            this.labelCaloriesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaloriesValue.ForeColor = System.Drawing.Color.Green;
            this.labelCaloriesValue.Location = new System.Drawing.Point(97, 44);
            this.labelCaloriesValue.Name = "labelCaloriesValue";
            this.labelCaloriesValue.Size = new System.Drawing.Size(0, 18);
            this.labelCaloriesValue.TabIndex = 11;
            // 
            // labelProduct2
            // 
            this.labelProduct2.AutoSize = true;
            this.labelProduct2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProduct2.ForeColor = System.Drawing.Color.Green;
            this.labelProduct2.Location = new System.Drawing.Point(12, 16);
            this.labelProduct2.Name = "labelProduct2";
            this.labelProduct2.Size = new System.Drawing.Size(182, 18);
            this.labelProduct2.TabIndex = 10;
            this.labelProduct2.Text = "Product is not selected";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 50;
            this.trackBar1.Location = new System.Drawing.Point(16, 170);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Minimum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(245, 45);
            this.trackBar1.SmallChange = 50;
            this.trackBar1.TabIndex = 9;
            this.trackBar1.TickFrequency = 50;
            this.trackBar1.Value = 100;
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // labelWeight2
            // 
            this.labelWeight2.AutoSize = true;
            this.labelWeight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeight2.ForeColor = System.Drawing.Color.Blue;
            this.labelWeight2.Location = new System.Drawing.Point(12, 138);
            this.labelWeight2.Name = "labelWeight2";
            this.labelWeight2.Size = new System.Drawing.Size(136, 20);
            this.labelWeight2.TabIndex = 8;
            this.labelWeight2.Text = "Weight (grams):";
            // 
            // labelCarbohydrates2
            // 
            this.labelCarbohydrates2.AutoSize = true;
            this.labelCarbohydrates2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCarbohydrates2.ForeColor = System.Drawing.Color.Blue;
            this.labelCarbohydrates2.Location = new System.Drawing.Point(12, 117);
            this.labelCarbohydrates2.Name = "labelCarbohydrates2";
            this.labelCarbohydrates2.Size = new System.Drawing.Size(131, 20);
            this.labelCarbohydrates2.TabIndex = 7;
            this.labelCarbohydrates2.Text = "Carbohydrates:";
            // 
            // labelFats2
            // 
            this.labelFats2.AutoSize = true;
            this.labelFats2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFats2.ForeColor = System.Drawing.Color.Blue;
            this.labelFats2.Location = new System.Drawing.Point(12, 94);
            this.labelFats2.Name = "labelFats2";
            this.labelFats2.Size = new System.Drawing.Size(50, 20);
            this.labelFats2.TabIndex = 6;
            this.labelFats2.Text = "Fats:";
            // 
            // labelProteins2
            // 
            this.labelProteins2.AutoSize = true;
            this.labelProteins2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProteins2.ForeColor = System.Drawing.Color.Blue;
            this.labelProteins2.Location = new System.Drawing.Point(12, 69);
            this.labelProteins2.Name = "labelProteins2";
            this.labelProteins2.Size = new System.Drawing.Size(80, 20);
            this.labelProteins2.TabIndex = 5;
            this.labelProteins2.Text = "Proteins:";
            // 
            // labelCalories2
            // 
            this.labelCalories2.AutoSize = true;
            this.labelCalories2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCalories2.ForeColor = System.Drawing.Color.Blue;
            this.labelCalories2.Location = new System.Drawing.Point(12, 42);
            this.labelCalories2.Name = "labelCalories2";
            this.labelCalories2.Size = new System.Drawing.Size(79, 20);
            this.labelCalories2.TabIndex = 4;
            this.labelCalories2.Text = "Calories:";
            // 
            // labelCPFC
            // 
            this.labelCPFC.AutoSize = true;
            this.labelCPFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPFC.ForeColor = System.Drawing.Color.Red;
            this.labelCPFC.Location = new System.Drawing.Point(868, 39);
            this.labelCPFC.Name = "labelCPFC";
            this.labelCPFC.Size = new System.Drawing.Size(53, 18);
            this.labelCPFC.TabIndex = 14;
            this.labelCPFC.Text = "CPFC";
            // 
            // labelDailyRate2
            // 
            this.labelDailyRate2.AutoSize = true;
            this.labelDailyRate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDailyRate2.Location = new System.Drawing.Point(861, 280);
            this.labelDailyRate2.Name = "labelDailyRate2";
            this.labelDailyRate2.Size = new System.Drawing.Size(151, 16);
            this.labelDailyRate2.TabIndex = 15;
            this.labelDailyRate2.Text = "Daily rate (Calories):";
            // 
            // progressBarDailyRate
            // 
            this.progressBarDailyRate.ForeColor = System.Drawing.Color.Blue;
            this.progressBarDailyRate.Location = new System.Drawing.Point(864, 304);
            this.progressBarDailyRate.Maximum = 4000;
            this.progressBarDailyRate.Name = "progressBarDailyRate";
            this.progressBarDailyRate.Size = new System.Drawing.Size(296, 23);
            this.progressBarDailyRate.TabIndex = 16;
            // 
            // labelCaloriesIntake
            // 
            this.labelCaloriesIntake.AutoSize = true;
            this.labelCaloriesIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaloriesIntake.Location = new System.Drawing.Point(861, 336);
            this.labelCaloriesIntake.Name = "labelCaloriesIntake";
            this.labelCaloriesIntake.Size = new System.Drawing.Size(126, 18);
            this.labelCaloriesIntake.TabIndex = 17;
            this.labelCaloriesIntake.Text = "Calories intake:";
            // 
            // progressBarCaloriesIntake
            // 
            this.progressBarCaloriesIntake.Location = new System.Drawing.Point(864, 360);
            this.progressBarCaloriesIntake.Maximum = 4000;
            this.progressBarCaloriesIntake.Name = "progressBarCaloriesIntake";
            this.progressBarCaloriesIntake.Size = new System.Drawing.Size(296, 23);
            this.progressBarCaloriesIntake.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.buttonSaveDirectory);
            this.panel5.Controls.Add(this.buttonSaveRcion);
            this.panel5.Controls.Add(this.buttonClearRcion);
            this.panel5.Location = new System.Drawing.Point(864, 409);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 122);
            this.panel5.TabIndex = 19;
            // 
            // buttonSaveDirectory
            // 
            this.buttonSaveDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveDirectory.Location = new System.Drawing.Point(15, 41);
            this.buttonSaveDirectory.Name = "buttonSaveDirectory";
            this.buttonSaveDirectory.Size = new System.Drawing.Size(267, 23);
            this.buttonSaveDirectory.TabIndex = 2;
            this.buttonSaveDirectory.Text = "Save directory";
            this.buttonSaveDirectory.UseVisualStyleBackColor = true;
            this.buttonSaveDirectory.Click += new System.EventHandler(this.buttonSaveDirectory_Click);
            // 
            // buttonSaveRcion
            // 
            this.buttonSaveRcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveRcion.Location = new System.Drawing.Point(16, 70);
            this.buttonSaveRcion.Name = "buttonSaveRcion";
            this.buttonSaveRcion.Size = new System.Drawing.Size(267, 23);
            this.buttonSaveRcion.TabIndex = 1;
            this.buttonSaveRcion.Text = "Save Rcion";
            this.buttonSaveRcion.UseVisualStyleBackColor = true;
            this.buttonSaveRcion.Click += new System.EventHandler(this.buttonSaveRcion_Click);
            // 
            // buttonClearRcion
            // 
            this.buttonClearRcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearRcion.Location = new System.Drawing.Point(16, 12);
            this.buttonClearRcion.Name = "buttonClearRcion";
            this.buttonClearRcion.Size = new System.Drawing.Size(267, 23);
            this.buttonClearRcion.TabIndex = 0;
            this.buttonClearRcion.Text = "Clear Rcion";
            this.buttonClearRcion.UseVisualStyleBackColor = true;
            this.buttonClearRcion.Click += new System.EventHandler(this.buttonClearRcion_Click);
            // 
            // labelDailyRateValue
            // 
            this.labelDailyRateValue.AutoSize = true;
            this.labelDailyRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDailyRateValue.Location = new System.Drawing.Point(1014, 280);
            this.labelDailyRateValue.Name = "labelDailyRateValue";
            this.labelDailyRateValue.Size = new System.Drawing.Size(16, 16);
            this.labelDailyRateValue.TabIndex = 20;
            this.labelDailyRateValue.Text = "0";
            // 
            // labelCaloriesIntakeValue
            // 
            this.labelCaloriesIntakeValue.AutoSize = true;
            this.labelCaloriesIntakeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaloriesIntakeValue.ForeColor = System.Drawing.Color.Green;
            this.labelCaloriesIntakeValue.Location = new System.Drawing.Point(993, 338);
            this.labelCaloriesIntakeValue.Name = "labelCaloriesIntakeValue";
            this.labelCaloriesIntakeValue.Size = new System.Drawing.Size(16, 16);
            this.labelCaloriesIntakeValue.TabIndex = 21;
            this.labelCaloriesIntakeValue.Text = "0";
            // 
            // labelSuccessMessage
            // 
            this.labelSuccessMessage.AutoSize = true;
            this.labelSuccessMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSuccessMessage.ForeColor = System.Drawing.Color.Green;
            this.labelSuccessMessage.Location = new System.Drawing.Point(897, 388);
            this.labelSuccessMessage.Name = "labelSuccessMessage";
            this.labelSuccessMessage.Size = new System.Drawing.Size(229, 18);
            this.labelSuccessMessage.TabIndex = 18;
            this.labelSuccessMessage.Text = "Данные успешно сохранены";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 543);
            this.Controls.Add(this.labelSuccessMessage);
            this.Controls.Add(this.labelCaloriesIntakeValue);
            this.Controls.Add(this.labelDailyRateValue);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.progressBarCaloriesIntake);
            this.Controls.Add(this.labelCaloriesIntake);
            this.Controls.Add(this.progressBarDailyRate);
            this.Controls.Add(this.labelDailyRate2);
            this.Controls.Add(this.labelCPFC);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelDailyRate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelActivity);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelUserData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenu2.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBMR;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox bmr;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label labelYears;
        private System.Windows.Forms.Label labelCm;
        private System.Windows.Forms.Label labelKg;
        private System.Windows.Forms.Label labelUserData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelARM;
        private System.Windows.Forms.TextBox arm;
        private System.Windows.Forms.RadioButton HighActivity;
        private System.Windows.Forms.RadioButton NormalActivity;
        private System.Windows.Forms.RadioButton AverageActivity;
        private System.Windows.Forms.RadioButton LowActivity;
        private System.Windows.Forms.Label labelActivity;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox calories;
        private System.Windows.Forms.TextBox proteins;
        private System.Windows.Forms.TextBox fats;
        private System.Windows.Forms.Label labelCarbohydrates;
        private System.Windows.Forms.Label labelFats;
        private System.Windows.Forms.Label labelProteins;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.TextBox carbohydrates;
        private System.Windows.Forms.Label labelDailyRate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelWeight2;
        private System.Windows.Forms.Label labelCarbohydrates2;
        private System.Windows.Forms.Label labelFats2;
        private System.Windows.Forms.Label labelProteins2;
        private System.Windows.Forms.Label labelCalories2;
        private System.Windows.Forms.Label labelProduct2;
        private System.Windows.Forms.Label labelCPFC;
        private System.Windows.Forms.Label labelDailyRate2;
        private System.Windows.Forms.ProgressBar progressBarDailyRate;
        private System.Windows.Forms.Label labelCaloriesIntake;
        private System.Windows.Forms.ProgressBar progressBarCaloriesIntake;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonSaveRcion;
        private System.Windows.Forms.Button buttonClearRcion;
        private System.Windows.Forms.Label labelWeightValue;
        private System.Windows.Forms.Label labelCarbohydratesValue;
        private System.Windows.Forms.Label labelFatsValue;
        private System.Windows.Forms.Label labelProteinsValue;
        private System.Windows.Forms.Label labelCaloriesValue;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelDailyRateValue;
        private System.Windows.Forms.Label labelCaloriesIntakeValue;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu2;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.Button buttonSaveDirectory;
        private System.Windows.Forms.Label labelSuccessMessage;
    }
}

