namespace RosUI
{
    partial class RosMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitchenViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlKitchenView = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDishReady = new System.Windows.Forms.Button();
            this.lvOrderedDishes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.pnlBarView = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.brnDrinkReady = new System.Windows.Forms.Button();
            this.lvOrderedDrinks = new System.Windows.Forms.ListView();
            this.clTable = new System.Windows.Forms.ColumnHeader();
            this.clDrinks = new System.Windows.Forms.ColumnHeader();
            this.clOrderTime = new System.Windows.Forms.ColumnHeader();
            this.pnlTableView = new System.Windows.Forms.Panel();
            this.btnTableTen = new System.Windows.Forms.Button();
            this.btnTableNine = new System.Windows.Forms.Button();
            this.btnTableEight = new System.Windows.Forms.Button();
            this.btnTableSeven = new System.Windows.Forms.Button();
            this.btnTableSix = new System.Windows.Forms.Button();
            this.btnTableFive = new System.Windows.Forms.Button();
            this.btnTableFour = new System.Windows.Forms.Button();
            this.btnTableThree = new System.Windows.Forms.Button();
            this.btnTableTwo = new System.Windows.Forms.Button();
            this.btnTableOne = new System.Windows.Forms.Button();
            this.btnViewNote = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlKitchenView.SuspendLayout();
            this.pnlBarView.SuspendLayout();
            this.pnlTableView.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.barViewToolStripMenuItem,
            this.kitchenViewToolStripMenuItem,
            this.tableViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1216, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // barViewToolStripMenuItem
            // 
            this.barViewToolStripMenuItem.Name = "barViewToolStripMenuItem";
            this.barViewToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.barViewToolStripMenuItem.Text = "Bar View";
            this.barViewToolStripMenuItem.Click += new System.EventHandler(this.barViewToolStripMenuItem_Click);
            // 
            // kitchenViewToolStripMenuItem
            // 
            this.kitchenViewToolStripMenuItem.Name = "kitchenViewToolStripMenuItem";
            this.kitchenViewToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.kitchenViewToolStripMenuItem.Text = "Kitchen view";
            this.kitchenViewToolStripMenuItem.Click += new System.EventHandler(this.kitchenViewToolStripMenuItem_Click);
            // 
            // tableViewToolStripMenuItem
            // 
            this.tableViewToolStripMenuItem.Name = "tableViewToolStripMenuItem";
            this.tableViewToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.tableViewToolStripMenuItem.Text = "Table view";
            this.tableViewToolStripMenuItem.Click += new System.EventHandler(this.tableViewToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Location = new System.Drawing.Point(0, 31);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1216, 578);
            this.pnlDashboard.TabIndex = 1;
            // 
            // pnlKitchenView
            // 
            this.pnlKitchenView.Controls.Add(this.btnViewNote);
            this.pnlKitchenView.Controls.Add(this.label1);
            this.pnlKitchenView.Controls.Add(this.btnDishReady);
            this.pnlKitchenView.Controls.Add(this.lvOrderedDishes);
            this.pnlKitchenView.Location = new System.Drawing.Point(0, 28);
            this.pnlKitchenView.Name = "pnlKitchenView";
            this.pnlKitchenView.Size = new System.Drawing.Size(1216, 578);
            this.pnlKitchenView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitchen View";
            // 
            // btnDishReady
            // 
            this.btnDishReady.Location = new System.Drawing.Point(1031, 518);
            this.btnDishReady.Name = "btnDishReady";
            this.btnDishReady.Size = new System.Drawing.Size(149, 30);
            this.btnDishReady.TabIndex = 3;
            this.btnDishReady.Text = "Ready!";
            this.btnDishReady.UseVisualStyleBackColor = true;
            this.btnDishReady.Click += new System.EventHandler(this.btnDishReady_Click);
            // 
            // lvOrderedDishes
            // 
            this.lvOrderedDishes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvOrderedDishes.FullRowSelect = true;
            this.lvOrderedDishes.HideSelection = false;
            this.lvOrderedDishes.Location = new System.Drawing.Point(43, 58);
            this.lvOrderedDishes.MultiSelect = false;
            this.lvOrderedDishes.Name = "lvOrderedDishes";
            this.lvOrderedDishes.Size = new System.Drawing.Size(1137, 428);
            this.lvOrderedDishes.TabIndex = 0;
            this.lvOrderedDishes.UseCompatibleStateImageBehavior = false;
            this.lvOrderedDishes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Table";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dishes";
            this.columnHeader2.Width = 600;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Order Time";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Course";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Note";
            this.columnHeader8.Width = 80;
            // 
            // pnlBarView
            // 
            this.pnlBarView.Controls.Add(this.label2);
            this.pnlBarView.Controls.Add(this.brnDrinkReady);
            this.pnlBarView.Controls.Add(this.lvOrderedDrinks);
            this.pnlBarView.Location = new System.Drawing.Point(0, 34);
            this.pnlBarView.Name = "pnlBarView";
            this.pnlBarView.Size = new System.Drawing.Size(1216, 572);
            this.pnlBarView.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bar View";
            // 
            // brnDrinkReady
            // 
            this.brnDrinkReady.Location = new System.Drawing.Point(1031, 518);
            this.brnDrinkReady.Name = "brnDrinkReady";
            this.brnDrinkReady.Size = new System.Drawing.Size(149, 30);
            this.brnDrinkReady.TabIndex = 3;
            this.brnDrinkReady.Text = "Ready!";
            this.brnDrinkReady.UseVisualStyleBackColor = true;
            this.brnDrinkReady.Click += new System.EventHandler(this.btnDrinkReady_Click);
            // 
            // lvOrderedDrinks
            // 
            this.lvOrderedDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clTable,
            this.clDrinks,
            this.clOrderTime});
            this.lvOrderedDrinks.FullRowSelect = true;
            this.lvOrderedDrinks.HideSelection = false;
            this.lvOrderedDrinks.Location = new System.Drawing.Point(43, 58);
            this.lvOrderedDrinks.Name = "lvOrderedDrinks";
            this.lvOrderedDrinks.Size = new System.Drawing.Size(1137, 428);
            this.lvOrderedDrinks.TabIndex = 0;
            this.lvOrderedDrinks.UseCompatibleStateImageBehavior = false;
            this.lvOrderedDrinks.View = System.Windows.Forms.View.Details;
            // 
            // clTable
            // 
            this.clTable.Text = "Table";
            // 
            // clDrinks
            // 
            this.clDrinks.Text = "Drinks";
            this.clDrinks.Width = 800;
            // 
            // clOrderTime
            // 
            this.clOrderTime.Text = "Order Time";
            this.clOrderTime.Width = 200;
            // 
            // pnlTableView
            // 
            this.pnlTableView.Controls.Add(this.btnTableTen);
            this.pnlTableView.Controls.Add(this.btnTableNine);
            this.pnlTableView.Controls.Add(this.btnTableEight);
            this.pnlTableView.Controls.Add(this.btnTableSeven);
            this.pnlTableView.Controls.Add(this.btnTableSix);
            this.pnlTableView.Controls.Add(this.btnTableFive);
            this.pnlTableView.Controls.Add(this.btnTableFour);
            this.pnlTableView.Controls.Add(this.btnTableThree);
            this.pnlTableView.Controls.Add(this.btnTableTwo);
            this.pnlTableView.Controls.Add(this.btnTableOne);
            this.pnlTableView.Location = new System.Drawing.Point(0, 28);
            this.pnlTableView.Name = "pnlTableView";
            this.pnlTableView.Size = new System.Drawing.Size(1216, 567);
            this.pnlTableView.TabIndex = 4;
            // 
            // btnTableTen
            // 
            this.btnTableTen.Location = new System.Drawing.Point(646, 164);
            this.btnTableTen.Name = "btnTableTen";
            this.btnTableTen.Size = new System.Drawing.Size(94, 29);
            this.btnTableTen.TabIndex = 9;
            this.btnTableTen.Text = "Table 10";
            this.btnTableTen.UseVisualStyleBackColor = true;
            this.btnTableTen.Click += new System.EventHandler(this.btnTableTen_Click);
            // 
            // btnTableNine
            // 
            this.btnTableNine.Location = new System.Drawing.Point(521, 164);
            this.btnTableNine.Name = "btnTableNine";
            this.btnTableNine.Size = new System.Drawing.Size(94, 29);
            this.btnTableNine.TabIndex = 8;
            this.btnTableNine.Text = "Table 9";
            this.btnTableNine.UseVisualStyleBackColor = true;
            this.btnTableNine.Click += new System.EventHandler(this.btnTableNine_Click);
            // 
            // btnTableEight
            // 
            this.btnTableEight.Location = new System.Drawing.Point(402, 165);
            this.btnTableEight.Name = "btnTableEight";
            this.btnTableEight.Size = new System.Drawing.Size(94, 29);
            this.btnTableEight.TabIndex = 7;
            this.btnTableEight.Text = "Table 8";
            this.btnTableEight.UseVisualStyleBackColor = true;
            this.btnTableEight.Click += new System.EventHandler(this.btnTableEight_Click);
            // 
            // btnTableSeven
            // 
            this.btnTableSeven.Location = new System.Drawing.Point(274, 165);
            this.btnTableSeven.Name = "btnTableSeven";
            this.btnTableSeven.Size = new System.Drawing.Size(94, 29);
            this.btnTableSeven.TabIndex = 6;
            this.btnTableSeven.Text = "Table 7";
            this.btnTableSeven.UseVisualStyleBackColor = true;
            this.btnTableSeven.Click += new System.EventHandler(this.btnTableSeven_Click);
            // 
            // btnTableSix
            // 
            this.btnTableSix.Location = new System.Drawing.Point(147, 165);
            this.btnTableSix.Name = "btnTableSix";
            this.btnTableSix.Size = new System.Drawing.Size(94, 29);
            this.btnTableSix.TabIndex = 5;
            this.btnTableSix.Text = "Table 6";
            this.btnTableSix.UseVisualStyleBackColor = true;
            this.btnTableSix.Click += new System.EventHandler(this.btnTableSix_Click);
            // 
            // btnTableFive
            // 
            this.btnTableFive.Location = new System.Drawing.Point(646, 67);
            this.btnTableFive.Name = "btnTableFive";
            this.btnTableFive.Size = new System.Drawing.Size(94, 29);
            this.btnTableFive.TabIndex = 4;
            this.btnTableFive.Text = "Table 5";
            this.btnTableFive.UseVisualStyleBackColor = true;
            this.btnTableFive.Click += new System.EventHandler(this.btnTableFive_Click);
            // 
            // btnTableFour
            // 
            this.btnTableFour.Location = new System.Drawing.Point(521, 67);
            this.btnTableFour.Name = "btnTableFour";
            this.btnTableFour.Size = new System.Drawing.Size(94, 29);
            this.btnTableFour.TabIndex = 3;
            this.btnTableFour.Text = "Table 4";
            this.btnTableFour.UseVisualStyleBackColor = true;
            this.btnTableFour.Click += new System.EventHandler(this.btnTableFour_Click);
            // 
            // btnTableThree
            // 
            this.btnTableThree.Location = new System.Drawing.Point(402, 67);
            this.btnTableThree.Name = "btnTableThree";
            this.btnTableThree.Size = new System.Drawing.Size(94, 29);
            this.btnTableThree.TabIndex = 2;
            this.btnTableThree.Text = "Table 3";
            this.btnTableThree.UseVisualStyleBackColor = true;
            this.btnTableThree.Click += new System.EventHandler(this.btnTableThree_Click);
            // 
            // btnTableTwo
            // 
            this.btnTableTwo.Location = new System.Drawing.Point(274, 67);
            this.btnTableTwo.Name = "btnTableTwo";
            this.btnTableTwo.Size = new System.Drawing.Size(94, 29);
            this.btnTableTwo.TabIndex = 1;
            this.btnTableTwo.Text = "Table 2";
            this.btnTableTwo.UseVisualStyleBackColor = true;
            this.btnTableTwo.Click += new System.EventHandler(this.btnTableTwo_Click);
            // 
            // btnTableOne
            // 
            this.btnTableOne.Location = new System.Drawing.Point(147, 67);
            this.btnTableOne.Name = "btnTableOne";
            this.btnTableOne.Size = new System.Drawing.Size(94, 29);
            this.btnTableOne.TabIndex = 0;
            this.btnTableOne.Text = "Table 1";
            this.btnTableOne.UseVisualStyleBackColor = true;
            this.btnTableOne.Click += new System.EventHandler(this.btnTableOne_Click);
            // 
            // btnViewNote
            // 
            this.btnViewNote.Location = new System.Drawing.Point(685, 518);
            this.btnViewNote.Name = "btnViewNote";
            this.btnViewNote.Size = new System.Drawing.Size(135, 30);
            this.btnViewNote.TabIndex = 4;
            this.btnViewNote.Text = "view note";
            this.btnViewNote.UseVisualStyleBackColor = true;
            this.btnViewNote.Click += new System.EventHandler(this.btnViewNote_Click);
            // 
            // RosMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 607);
            this.Controls.Add(this.pnlKitchenView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlTableView);
            this.Controls.Add(this.pnlBarView);
            this.Controls.Add(this.pnlDashboard);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RosMain";
            this.Text = "Ordering System";
            this.Load += new System.EventHandler(this.RosMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlKitchenView.ResumeLayout(false);
            this.pnlKitchenView.PerformLayout();
            this.pnlBarView.ResumeLayout(false);
            this.pnlBarView.PerformLayout();
            this.pnlTableView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitchenViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableViewToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlKitchenView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDishReady;
        private System.Windows.Forms.ListView lvOrderedDishes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel pnlBarView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button brnDrinkReady;
        private System.Windows.Forms.ListView lvOrderedDrinks;
        private System.Windows.Forms.ColumnHeader clTable;
        private System.Windows.Forms.ColumnHeader clDrinks;
        private System.Windows.Forms.ColumnHeader clOrderTime;
        private System.Windows.Forms.Panel pnlTableView;
        private System.Windows.Forms.Button btnTableOne;
        private System.Windows.Forms.Button btnTableTwo;
        private System.Windows.Forms.Button btnTableTen;
        private System.Windows.Forms.Button btnTableNine;
        private System.Windows.Forms.Button btnTableEight;
        private System.Windows.Forms.Button btnTableSeven;
        private System.Windows.Forms.Button btnTableSix;
        private System.Windows.Forms.Button btnTableFive;
        private System.Windows.Forms.Button btnTableFour;
        private System.Windows.Forms.Button btnTableThree;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnViewNote;
    }
}