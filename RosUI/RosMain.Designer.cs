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
            this.runningOrdersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.finishedOrdersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kitchenViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runningOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishedOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboardKitchen = new System.Windows.Forms.Panel();
            this.btnFinishKitDash = new System.Windows.Forms.Button();
            this.btnRunningKitDash = new System.Windows.Forms.Button();
            this.lblWelcomeKitDash = new System.Windows.Forms.Label();
            this.pnlKitchenView = new System.Windows.Forms.Panel();
            this.btnUndoKitView = new System.Windows.Forms.Button();
            this.btnServe = new System.Windows.Forms.Button();
            this.btnViewNote = new System.Windows.Forms.Button();
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
            this.btnUndoBarView = new System.Windows.Forms.Button();
            this.btnViewDrinkNote = new System.Windows.Forms.Button();
            this.btnDrinkServed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.brnDrinkReady = new System.Windows.Forms.Button();
            this.lvOrderedDrinks = new System.Windows.Forms.ListView();
            this.clTable = new System.Windows.Forms.ColumnHeader();
            this.clDrinks = new System.Windows.Forms.ColumnHeader();
            this.clAmount = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.pnlDashboardBar = new System.Windows.Forms.Panel();
            this.lblWelcomeBarDash = new System.Windows.Forms.Label();
            this.btnFinishBarDash = new System.Windows.Forms.Button();
            this.btnRunnningBarDash = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnlKitchenViewFinished = new System.Windows.Forms.Panel();
            this.btnUndoKitFin = new System.Windows.Forms.Button();
            this.btnViewNoteFinDish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lvFinishedDishes = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.pnlBarViewFinished = new System.Windows.Forms.Panel();
            this.btnViewNoteFinDrink = new System.Windows.Forms.Button();
            this.btnUndoFinDrink = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lvFinishedDrinks = new System.Windows.Forms.ListView();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboardKitchen.SuspendLayout();
            this.pnlKitchenView.SuspendLayout();
            this.pnlBarView.SuspendLayout();
            this.pnlDashboardBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnlKitchenViewFinished.SuspendLayout();
            this.pnlBarViewFinished.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
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
            this.barViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runningOrdersToolStripMenuItem1,
            this.finishedOrdersToolStripMenuItem1});
            this.barViewToolStripMenuItem.Name = "barViewToolStripMenuItem";
            this.barViewToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.barViewToolStripMenuItem.Text = "Bar View";
            this.barViewToolStripMenuItem.Click += new System.EventHandler(this.barViewToolStripMenuItem_Click);
            // 
            // runningOrdersToolStripMenuItem1
            // 
            this.runningOrdersToolStripMenuItem1.Name = "runningOrdersToolStripMenuItem1";
            this.runningOrdersToolStripMenuItem1.Size = new System.Drawing.Size(194, 26);
            this.runningOrdersToolStripMenuItem1.Text = "Running Orders";
            this.runningOrdersToolStripMenuItem1.Click += new System.EventHandler(this.runningOrdersToolStripMenuItem1_Click);
            // 
            // finishedOrdersToolStripMenuItem1
            // 
            this.finishedOrdersToolStripMenuItem1.Name = "finishedOrdersToolStripMenuItem1";
            this.finishedOrdersToolStripMenuItem1.Size = new System.Drawing.Size(194, 26);
            this.finishedOrdersToolStripMenuItem1.Text = "Finished Orders";
            this.finishedOrdersToolStripMenuItem1.Click += new System.EventHandler(this.finishedOrdersToolStripMenuItem1_Click);
            // 
            // kitchenViewToolStripMenuItem
            // 
            this.kitchenViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runningOrdersToolStripMenuItem,
            this.finishedOrdersToolStripMenuItem});
            this.kitchenViewToolStripMenuItem.Name = "kitchenViewToolStripMenuItem";
            this.kitchenViewToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.kitchenViewToolStripMenuItem.Text = "Kitchen view";
            this.kitchenViewToolStripMenuItem.Click += new System.EventHandler(this.kitchenViewToolStripMenuItem_Click);
            // 
            // runningOrdersToolStripMenuItem
            // 
            this.runningOrdersToolStripMenuItem.Name = "runningOrdersToolStripMenuItem";
            this.runningOrdersToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.runningOrdersToolStripMenuItem.Text = "Running Orders";
            this.runningOrdersToolStripMenuItem.Click += new System.EventHandler(this.runningOrdersToolStripMenuItem_Click);
            // 
            // finishedOrdersToolStripMenuItem
            // 
            this.finishedOrdersToolStripMenuItem.Name = "finishedOrdersToolStripMenuItem";
            this.finishedOrdersToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.finishedOrdersToolStripMenuItem.Text = "Finished Orders";
            this.finishedOrdersToolStripMenuItem.Click += new System.EventHandler(this.finishedOrdersToolStripMenuItem_Click);
            // 
            // tableViewToolStripMenuItem
            // 
            this.tableViewToolStripMenuItem.Name = "tableViewToolStripMenuItem";
            this.tableViewToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.tableViewToolStripMenuItem.Text = "Table view";
            this.tableViewToolStripMenuItem.Click += new System.EventHandler(this.tableViewToolStripMenuItem_Click);
            // 
            // pnlDashboardKitchen
            // 
            this.pnlDashboardKitchen.Controls.Add(this.btnFinishKitDash);
            this.pnlDashboardKitchen.Controls.Add(this.btnRunningKitDash);
            this.pnlDashboardKitchen.Controls.Add(this.lblWelcomeKitDash);
            this.pnlDashboardKitchen.Location = new System.Drawing.Point(0, 31);
            this.pnlDashboardKitchen.Name = "pnlDashboardKitchen";
            this.pnlDashboardKitchen.Size = new System.Drawing.Size(1216, 578);
            this.pnlDashboardKitchen.TabIndex = 1;
            // 
            // btnFinishKitDash
            // 
            this.btnFinishKitDash.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFinishKitDash.Location = new System.Drawing.Point(828, 294);
            this.btnFinishKitDash.Name = "btnFinishKitDash";
            this.btnFinishKitDash.Size = new System.Drawing.Size(153, 77);
            this.btnFinishKitDash.TabIndex = 2;
            this.btnFinishKitDash.Text = "Finished Orders";
            this.btnFinishKitDash.UseVisualStyleBackColor = false;
            // 
            // btnRunningKitDash
            // 
            this.btnRunningKitDash.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRunningKitDash.Location = new System.Drawing.Point(283, 294);
            this.btnRunningKitDash.Name = "btnRunningKitDash";
            this.btnRunningKitDash.Size = new System.Drawing.Size(151, 77);
            this.btnRunningKitDash.TabIndex = 1;
            this.btnRunningKitDash.Text = "Running Orders";
            this.btnRunningKitDash.UseVisualStyleBackColor = false;
            this.btnRunningKitDash.Click += new System.EventHandler(this.btnRunningKitDash_Click);
            // 
            // lblWelcomeKitDash
            // 
            this.lblWelcomeKitDash.AutoSize = true;
            this.lblWelcomeKitDash.Location = new System.Drawing.Point(580, 82);
            this.lblWelcomeKitDash.Name = "lblWelcomeKitDash";
            this.lblWelcomeKitDash.Size = new System.Drawing.Size(71, 20);
            this.lblWelcomeKitDash.TabIndex = 0;
            this.lblWelcomeKitDash.Text = "Welcome";
            // 
            // pnlKitchenView
            // 
            this.pnlKitchenView.Controls.Add(this.btnUndoKitView);
            this.pnlKitchenView.Controls.Add(this.btnServe);
            this.pnlKitchenView.Controls.Add(this.btnViewNote);
            this.pnlKitchenView.Controls.Add(this.label1);
            this.pnlKitchenView.Controls.Add(this.btnDishReady);
            this.pnlKitchenView.Controls.Add(this.lvOrderedDishes);
            this.pnlKitchenView.Location = new System.Drawing.Point(0, 28);
            this.pnlKitchenView.Name = "pnlKitchenView";
            this.pnlKitchenView.Size = new System.Drawing.Size(1216, 578);
            this.pnlKitchenView.TabIndex = 0;
            // 
            // btnUndoKitView
            // 
            this.btnUndoKitView.BackColor = System.Drawing.Color.Red;
            this.btnUndoKitView.Location = new System.Drawing.Point(125, 520);
            this.btnUndoKitView.Name = "btnUndoKitView";
            this.btnUndoKitView.Size = new System.Drawing.Size(94, 29);
            this.btnUndoKitView.TabIndex = 6;
            this.btnUndoKitView.Text = "Undo";
            this.btnUndoKitView.UseVisualStyleBackColor = false;
            this.btnUndoKitView.Click += new System.EventHandler(this.btnUndoKitView_Click);
            // 
            // btnServe
            // 
            this.btnServe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnServe.Location = new System.Drawing.Point(384, 521);
            this.btnServe.Name = "btnServe";
            this.btnServe.Size = new System.Drawing.Size(94, 29);
            this.btnServe.TabIndex = 5;
            this.btnServe.Text = "Serve";
            this.btnServe.UseVisualStyleBackColor = false;
            this.btnServe.Click += new System.EventHandler(this.btnServe_Click);
            // 
            // btnViewNote
            // 
            this.btnViewNote.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewNote.Location = new System.Drawing.Point(685, 518);
            this.btnViewNote.Name = "btnViewNote";
            this.btnViewNote.Size = new System.Drawing.Size(135, 30);
            this.btnViewNote.TabIndex = 4;
            this.btnViewNote.Text = "view note";
            this.btnViewNote.UseVisualStyleBackColor = false;
            this.btnViewNote.Click += new System.EventHandler(this.btnViewNote_Click);
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
            this.btnDishReady.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDishReady.Location = new System.Drawing.Point(1031, 518);
            this.btnDishReady.Name = "btnDishReady";
            this.btnDishReady.Size = new System.Drawing.Size(149, 30);
            this.btnDishReady.TabIndex = 3;
            this.btnDishReady.Text = "Ready!";
            this.btnDishReady.UseVisualStyleBackColor = false;
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
            this.lvOrderedDishes.Name = "lvOrderedDishes";
            this.lvOrderedDishes.Size = new System.Drawing.Size(1137, 428);
            this.lvOrderedDishes.TabIndex = 0;
            this.lvOrderedDishes.UseCompatibleStateImageBehavior = false;
            this.lvOrderedDishes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Amount";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dishes";
            this.columnHeader2.Width = 600;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Note";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Order Time";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Course";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Table";
            this.columnHeader8.Width = 80;
            // 
            // pnlBarView
            // 
            this.pnlBarView.Controls.Add(this.btnUndoBarView);
            this.pnlBarView.Controls.Add(this.btnViewDrinkNote);
            this.pnlBarView.Controls.Add(this.btnDrinkServed);
            this.pnlBarView.Controls.Add(this.label2);
            this.pnlBarView.Controls.Add(this.brnDrinkReady);
            this.pnlBarView.Controls.Add(this.lvOrderedDrinks);
            this.pnlBarView.Location = new System.Drawing.Point(0, 34);
            this.pnlBarView.Name = "pnlBarView";
            this.pnlBarView.Size = new System.Drawing.Size(1216, 572);
            this.pnlBarView.TabIndex = 4;
            // 
            // btnUndoBarView
            // 
            this.btnUndoBarView.BackColor = System.Drawing.Color.Red;
            this.btnUndoBarView.Location = new System.Drawing.Point(125, 514);
            this.btnUndoBarView.Name = "btnUndoBarView";
            this.btnUndoBarView.Size = new System.Drawing.Size(94, 29);
            this.btnUndoBarView.TabIndex = 6;
            this.btnUndoBarView.Text = "Undo";
            this.btnUndoBarView.UseVisualStyleBackColor = false;
            this.btnUndoBarView.Click += new System.EventHandler(this.btnUndoBarView_Click);
            // 
            // btnViewDrinkNote
            // 
            this.btnViewDrinkNote.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewDrinkNote.Location = new System.Drawing.Point(613, 512);
            this.btnViewDrinkNote.Name = "btnViewDrinkNote";
            this.btnViewDrinkNote.Size = new System.Drawing.Size(94, 29);
            this.btnViewDrinkNote.TabIndex = 5;
            this.btnViewDrinkNote.Text = "View Note";
            this.btnViewDrinkNote.UseVisualStyleBackColor = false;
            this.btnViewDrinkNote.Click += new System.EventHandler(this.btnViewDrinkNote_Click);
            // 
            // btnDrinkServed
            // 
            this.btnDrinkServed.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDrinkServed.Location = new System.Drawing.Point(360, 515);
            this.btnDrinkServed.Name = "btnDrinkServed";
            this.btnDrinkServed.Size = new System.Drawing.Size(94, 29);
            this.btnDrinkServed.TabIndex = 4;
            this.btnDrinkServed.Text = "Served";
            this.btnDrinkServed.UseVisualStyleBackColor = false;
            this.btnDrinkServed.Click += new System.EventHandler(this.btnDrinkServed_Click);
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
            this.brnDrinkReady.BackColor = System.Drawing.Color.LightSkyBlue;
            this.brnDrinkReady.Location = new System.Drawing.Point(1031, 518);
            this.brnDrinkReady.Name = "brnDrinkReady";
            this.brnDrinkReady.Size = new System.Drawing.Size(149, 30);
            this.brnDrinkReady.TabIndex = 3;
            this.brnDrinkReady.Text = "Ready!";
            this.brnDrinkReady.UseVisualStyleBackColor = false;
            this.brnDrinkReady.Click += new System.EventHandler(this.btnDrinkReady_Click);
            // 
            // lvOrderedDrinks
            // 
            this.lvOrderedDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clTable,
            this.clDrinks,
            this.clAmount,
            this.columnHeader4,
            this.columnHeader9});
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
            this.clTable.Text = "Amount";
            // 
            // clDrinks
            // 
            this.clDrinks.Text = "Drinks";
            this.clDrinks.Width = 750;
            // 
            // clAmount
            // 
            this.clAmount.Text = "Note";
            this.clAmount.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Order Time";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Table";
            this.columnHeader9.Width = 80;
            // 
            // pnlDashboardBar
            // 
            this.pnlDashboardBar.Controls.Add(this.lblWelcomeBarDash);
            this.pnlDashboardBar.Controls.Add(this.btnFinishBarDash);
            this.pnlDashboardBar.Controls.Add(this.btnRunnningBarDash);
            this.pnlDashboardBar.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboardBar.Name = "pnlDashboardBar";
            this.pnlDashboardBar.Size = new System.Drawing.Size(1216, 603);
            this.pnlDashboardBar.TabIndex = 3;
            // 
            // lblWelcomeBarDash
            // 
            this.lblWelcomeBarDash.AutoSize = true;
            this.lblWelcomeBarDash.Location = new System.Drawing.Point(580, 82);
            this.lblWelcomeBarDash.Name = "lblWelcomeBarDash";
            this.lblWelcomeBarDash.Size = new System.Drawing.Size(71, 20);
            this.lblWelcomeBarDash.TabIndex = 0;
            this.lblWelcomeBarDash.Text = "Welcome";
            // 
            // btnFinishBarDash
            // 
            this.btnFinishBarDash.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFinishBarDash.Location = new System.Drawing.Point(828, 294);
            this.btnFinishBarDash.Name = "btnFinishBarDash";
            this.btnFinishBarDash.Size = new System.Drawing.Size(153, 77);
            this.btnFinishBarDash.TabIndex = 2;
            this.btnFinishBarDash.Text = "Finished Orders";
            this.btnFinishBarDash.UseVisualStyleBackColor = false;
            // 
            // btnRunnningBarDash
            // 
            this.btnRunnningBarDash.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRunnningBarDash.Location = new System.Drawing.Point(283, 294);
            this.btnRunnningBarDash.Name = "btnRunnningBarDash";
            this.btnRunnningBarDash.Size = new System.Drawing.Size(151, 77);
            this.btnRunnningBarDash.TabIndex = 1;
            this.btnRunnningBarDash.Text = "Running Orders";
            this.btnRunnningBarDash.UseVisualStyleBackColor = false;
            this.btnRunnningBarDash.Click += new System.EventHandler(this.btnRunnningBarDash_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pnlKitchenViewFinished
            // 
            this.pnlKitchenViewFinished.Controls.Add(this.btnUndoKitFin);
            this.pnlKitchenViewFinished.Controls.Add(this.btnViewNoteFinDish);
            this.pnlKitchenViewFinished.Controls.Add(this.label3);
            this.pnlKitchenViewFinished.Controls.Add(this.lvFinishedDishes);
            this.pnlKitchenViewFinished.Location = new System.Drawing.Point(0, 30);
            this.pnlKitchenViewFinished.Name = "pnlKitchenViewFinished";
            this.pnlKitchenViewFinished.Size = new System.Drawing.Size(1216, 578);
            this.pnlKitchenViewFinished.TabIndex = 6;
            // 
            // btnUndoKitFin
            // 
            this.btnUndoKitFin.BackColor = System.Drawing.Color.Red;
            this.btnUndoKitFin.Location = new System.Drawing.Point(484, 519);
            this.btnUndoKitFin.Name = "btnUndoKitFin";
            this.btnUndoKitFin.Size = new System.Drawing.Size(94, 29);
            this.btnUndoKitFin.TabIndex = 5;
            this.btnUndoKitFin.Text = "Undo";
            this.btnUndoKitFin.UseVisualStyleBackColor = false;
            this.btnUndoKitFin.Click += new System.EventHandler(this.btnUndoKitFin_Click);
            // 
            // btnViewNoteFinDish
            // 
            this.btnViewNoteFinDish.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewNoteFinDish.Location = new System.Drawing.Point(685, 518);
            this.btnViewNoteFinDish.Name = "btnViewNoteFinDish";
            this.btnViewNoteFinDish.Size = new System.Drawing.Size(135, 30);
            this.btnViewNoteFinDish.TabIndex = 4;
            this.btnViewNoteFinDish.Text = "view note";
            this.btnViewNoteFinDish.UseVisualStyleBackColor = false;
            this.btnViewNoteFinDish.Click += new System.EventHandler(this.btnViewNoteFinDish_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitchen View";
            // 
            // lvFinishedDishes
            // 
            this.lvFinishedDishes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lvFinishedDishes.FullRowSelect = true;
            this.lvFinishedDishes.HideSelection = false;
            this.lvFinishedDishes.Location = new System.Drawing.Point(43, 58);
            this.lvFinishedDishes.Name = "lvFinishedDishes";
            this.lvFinishedDishes.Size = new System.Drawing.Size(1137, 428);
            this.lvFinishedDishes.TabIndex = 0;
            this.lvFinishedDishes.UseCompatibleStateImageBehavior = false;
            this.lvFinishedDishes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Dishes";
            this.columnHeader10.Width = 600;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Note";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Order Time";
            this.columnHeader12.Width = 150;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Course";
            this.columnHeader13.Width = 80;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Table";
            this.columnHeader14.Width = 80;
            // 
            // pnlBarViewFinished
            // 
            this.pnlBarViewFinished.Controls.Add(this.btnViewNoteFinDrink);
            this.pnlBarViewFinished.Controls.Add(this.btnUndoFinDrink);
            this.pnlBarViewFinished.Controls.Add(this.label4);
            this.pnlBarViewFinished.Controls.Add(this.lvFinishedDrinks);
            this.pnlBarViewFinished.Location = new System.Drawing.Point(0, 31);
            this.pnlBarViewFinished.Name = "pnlBarViewFinished";
            this.pnlBarViewFinished.Size = new System.Drawing.Size(1216, 572);
            this.pnlBarViewFinished.TabIndex = 6;
            // 
            // btnViewNoteFinDrink
            // 
            this.btnViewNoteFinDrink.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewNoteFinDrink.Location = new System.Drawing.Point(743, 512);
            this.btnViewNoteFinDrink.Name = "btnViewNoteFinDrink";
            this.btnViewNoteFinDrink.Size = new System.Drawing.Size(94, 29);
            this.btnViewNoteFinDrink.TabIndex = 5;
            this.btnViewNoteFinDrink.Text = "View Note";
            this.btnViewNoteFinDrink.UseVisualStyleBackColor = false;
            this.btnViewNoteFinDrink.Click += new System.EventHandler(this.btnViewNoteFinDrink_Click);
            // 
            // btnUndoFinDrink
            // 
            this.btnUndoFinDrink.BackColor = System.Drawing.Color.Red;
            this.btnUndoFinDrink.Location = new System.Drawing.Point(460, 512);
            this.btnUndoFinDrink.Name = "btnUndoFinDrink";
            this.btnUndoFinDrink.Size = new System.Drawing.Size(94, 29);
            this.btnUndoFinDrink.TabIndex = 4;
            this.btnUndoFinDrink.Text = "Undo";
            this.btnUndoFinDrink.UseVisualStyleBackColor = false;
            this.btnUndoFinDrink.Click += new System.EventHandler(this.btnUndoFinDrink_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bar View";
            // 
            // lvFinishedDrinks
            // 
            this.lvFinishedDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.lvFinishedDrinks.FullRowSelect = true;
            this.lvFinishedDrinks.HideSelection = false;
            this.lvFinishedDrinks.Location = new System.Drawing.Point(43, 58);
            this.lvFinishedDrinks.Name = "lvFinishedDrinks";
            this.lvFinishedDrinks.Size = new System.Drawing.Size(1137, 428);
            this.lvFinishedDrinks.TabIndex = 0;
            this.lvFinishedDrinks.UseCompatibleStateImageBehavior = false;
            this.lvFinishedDrinks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Amount";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Drinks";
            this.columnHeader16.Width = 750;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Note";
            this.columnHeader17.Width = 80;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Order Time";
            this.columnHeader18.Width = 170;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Table";
            this.columnHeader19.Width = 80;
            // 
            // RosMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 607);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlKitchenViewFinished);
            this.Controls.Add(this.pnlBarViewFinished);
            this.Controls.Add(this.pnlBarView);
            this.Controls.Add(this.pnlDashboardBar);
            this.Controls.Add(this.pnlKitchenView);
            this.Controls.Add(this.pnlDashboardKitchen);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RosMain";
            this.Text = "Ordering System";
            this.Load += new System.EventHandler(this.RosMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboardKitchen.ResumeLayout(false);
            this.pnlDashboardKitchen.PerformLayout();
            this.pnlKitchenView.ResumeLayout(false);
            this.pnlKitchenView.PerformLayout();
            this.pnlBarView.ResumeLayout(false);
            this.pnlBarView.PerformLayout();
            this.pnlDashboardBar.ResumeLayout(false);
            this.pnlDashboardBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnlKitchenViewFinished.ResumeLayout(false);
            this.pnlKitchenViewFinished.PerformLayout();
            this.pnlBarViewFinished.ResumeLayout(false);
            this.pnlBarViewFinished.PerformLayout();
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
        private System.Windows.Forms.Panel pnlDashboardKitchen;
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
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnViewNote;
        private System.Windows.Forms.Button btnServe;
        private System.Windows.Forms.Button btnViewDrinkNote;
        private System.Windows.Forms.Button btnDrinkServed;
        private System.Windows.Forms.ColumnHeader clAmount;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ToolStripMenuItem runningOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finishedOrdersToolStripMenuItem;
        private System.Windows.Forms.Button btnFinishKitDash;
        private System.Windows.Forms.Button btnRunningKitDash;
        private System.Windows.Forms.Label lblWelcomeKitDash;
        private System.Windows.Forms.ToolStripMenuItem runningOrdersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem finishedOrdersToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlDashboardBar;
        private System.Windows.Forms.Button btnFinishBarDash;
        private System.Windows.Forms.Button btnRunnningBarDash;
        private System.Windows.Forms.Label lblWelcomeBarDash;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel pnlBarViewFinished;
        private System.Windows.Forms.Button btnViewNoteFinDrink;
        private System.Windows.Forms.Button btnUndoFinDrink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvFinishedDrinks;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.Panel pnlKitchenViewFinished;
        private System.Windows.Forms.Button btnUndoKitFin;
        private System.Windows.Forms.Button btnViewNoteFinDish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvFinishedDishes;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button btnUndoBarView;
        private System.Windows.Forms.Button btnUndoKitView;
    }
}