
namespace RosUI
{
    partial class FormOrder
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
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.listviewOrder = new System.Windows.Forms.ListView();
            this.nameOrder = new System.Windows.Forms.ColumnHeader();
            this.priceOrder = new System.Windows.Forms.ColumnHeader();
            this.amountOrder = new System.Windows.Forms.ColumnHeader();
            this.btnOrderRemove = new System.Windows.Forms.Button();
            this.btnOrderAddNote = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.pnlFoodDrink = new System.Windows.Forms.Panel();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnStarter = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.pnlLunchStarters = new System.Windows.Forms.Panel();
            this.lblFoodStarter = new System.Windows.Forms.Label();
            this.listviewLunchFood = new System.Windows.Forms.ListView();
            this.columNameFood = new System.Windows.Forms.ColumnHeader();
            this.columnPriceFood = new System.Windows.Forms.ColumnHeader();
            this.pnlDinnerStarter = new System.Windows.Forms.Panel();
            this.lblDinnerFood = new System.Windows.Forms.Label();
            this.listviewDinnerStarter = new System.Windows.Forms.ListView();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.listviewDrinks = new System.Windows.Forms.ListView();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.pnlDessert = new System.Windows.Forms.Panel();
            this.listviewDessert = new System.Windows.Forms.ListView();
            this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader20 = new System.Windows.Forms.ColumnHeader();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblLunchMain = new System.Windows.Forms.Label();
            this.listivewLunchMain = new System.Windows.Forms.ListView();
            this.columnHeader21 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader22 = new System.Windows.Forms.ColumnHeader();
            this.pnlDinnerMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listviewDinnerMain = new System.Windows.Forms.ListView();
            this.columnHeader23 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader24 = new System.Windows.Forms.ColumnHeader();
            this.pnlDinnerDessert = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listviewDinnerDessert = new System.Windows.Forms.ListView();
            this.columnHeader25 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader26 = new System.Windows.Forms.ColumnHeader();
            this.pnlFoodDrink.SuspendLayout();
            this.pnlLunchStarters.SuspendLayout();
            this.pnlDinnerStarter.SuspendLayout();
            this.pnlDrinks.SuspendLayout();
            this.pnlDessert.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlDinnerMain.SuspendLayout();
            this.pnlDinnerDessert.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDrinks
            // 
            this.btnDrinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrinks.Location = new System.Drawing.Point(355, 13);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(95, 41);
            this.btnDrinks.TabIndex = 7;
            this.btnDrinks.Text = "DRINKS";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.BackColor = System.Drawing.Color.Green;
            this.btnSendOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSendOrder.ForeColor = System.Drawing.Color.White;
            this.btnSendOrder.Location = new System.Drawing.Point(18, 700);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(138, 39);
            this.btnSendOrder.TabIndex = 8;
            this.btnSendOrder.Text = "SEND ORDER";
            this.btnSendOrder.UseVisualStyleBackColor = false;
            this.btnSendOrder.Visible = false;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.Red;
            this.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrder.Location = new System.Drawing.Point(212, 700);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(138, 39);
            this.btnCancelOrder.TabIndex = 9;
            this.btnCancelOrder.Text = "CANCEL";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Visible = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(367, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 29);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(16, 12);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(56, 20);
            this.lblTableNumber.TabIndex = 12;
            this.lblTableNumber.Text = "table #";
            // 
            // listviewOrder
            // 
            this.listviewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameOrder,
            this.priceOrder,
            this.amountOrder});
            this.listviewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listviewOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listviewOrder.FullRowSelect = true;
            this.listviewOrder.HideSelection = false;
            this.listviewOrder.Location = new System.Drawing.Point(21, 458);
            this.listviewOrder.Name = "listviewOrder";
            this.listviewOrder.Size = new System.Drawing.Size(329, 209);
            this.listviewOrder.TabIndex = 13;
            this.listviewOrder.UseCompatibleStateImageBehavior = false;
            this.listviewOrder.View = System.Windows.Forms.View.Details;
            // 
            // nameOrder
            // 
            this.nameOrder.Text = "NAME";
            this.nameOrder.Width = 155;
            // 
            // priceOrder
            // 
            this.priceOrder.Text = "PRICE";
            this.priceOrder.Width = 65;
            // 
            // amountOrder
            // 
            this.amountOrder.Text = "AMOUNT";
            this.amountOrder.Width = 85;
            // 
            // btnOrderRemove
            // 
            this.btnOrderRemove.BackColor = System.Drawing.Color.Red;
            this.btnOrderRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderRemove.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrderRemove.ForeColor = System.Drawing.Color.White;
            this.btnOrderRemove.Location = new System.Drawing.Point(366, 458);
            this.btnOrderRemove.Name = "btnOrderRemove";
            this.btnOrderRemove.Size = new System.Drawing.Size(104, 44);
            this.btnOrderRemove.TabIndex = 15;
            this.btnOrderRemove.Text = "-";
            this.btnOrderRemove.UseVisualStyleBackColor = false;
            this.btnOrderRemove.Visible = false;
            this.btnOrderRemove.Click += new System.EventHandler(this.btnOrderRemove_Click);
            // 
            // btnOrderAddNote
            // 
            this.btnOrderAddNote.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOrderAddNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderAddNote.Location = new System.Drawing.Point(372, 630);
            this.btnOrderAddNote.Name = "btnOrderAddNote";
            this.btnOrderAddNote.Size = new System.Drawing.Size(98, 37);
            this.btnOrderAddNote.TabIndex = 16;
            this.btnOrderAddNote.Text = "Add Note";
            this.btnOrderAddNote.UseVisualStyleBackColor = false;
            this.btnOrderAddNote.Visible = false;
            this.btnOrderAddNote.Click += new System.EventHandler(this.btnOrderAddNote_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(372, 532);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(98, 92);
            this.txtNote.TabIndex = 18;
            this.txtNote.Text = "";
            this.txtNote.Visible = false;
            // 
            // pnlFoodDrink
            // 
            this.pnlFoodDrink.Controls.Add(this.btnMain);
            this.pnlFoodDrink.Controls.Add(this.btnStarter);
            this.pnlFoodDrink.Controls.Add(this.btnDessert);
            this.pnlFoodDrink.Controls.Add(this.btnDrinks);
            this.pnlFoodDrink.Location = new System.Drawing.Point(16, 39);
            this.pnlFoodDrink.Name = "pnlFoodDrink";
            this.pnlFoodDrink.Size = new System.Drawing.Size(454, 66);
            this.pnlFoodDrink.TabIndex = 34;
            // 
            // btnMain
            // 
            this.btnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMain.Location = new System.Drawing.Point(121, 13);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(95, 41);
            this.btnMain.TabIndex = 8;
            this.btnMain.Text = "Mains";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnStarter
            // 
            this.btnStarter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStarter.Location = new System.Drawing.Point(8, 13);
            this.btnStarter.Name = "btnStarter";
            this.btnStarter.Size = new System.Drawing.Size(95, 41);
            this.btnStarter.TabIndex = 0;
            this.btnStarter.Text = "Starters";
            this.btnStarter.UseVisualStyleBackColor = true;
            this.btnStarter.Click += new System.EventHandler(this.btnStarter_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDessert.Location = new System.Drawing.Point(238, 13);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(95, 41);
            this.btnDessert.TabIndex = 39;
            this.btnDessert.Text = "Desserts";
            this.btnDessert.UseVisualStyleBackColor = true;
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
            // 
            // pnlLunchStarters
            // 
            this.pnlLunchStarters.Controls.Add(this.lblFoodStarter);
            this.pnlLunchStarters.Controls.Add(this.listviewLunchFood);
            this.pnlLunchStarters.Location = new System.Drawing.Point(9, 120);
            this.pnlLunchStarters.Name = "pnlLunchStarters";
            this.pnlLunchStarters.Size = new System.Drawing.Size(459, 327);
            this.pnlLunchStarters.TabIndex = 35;
            // 
            // lblFoodStarter
            // 
            this.lblFoodStarter.AutoSize = true;
            this.lblFoodStarter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFoodStarter.ForeColor = System.Drawing.Color.White;
            this.lblFoodStarter.Location = new System.Drawing.Point(19, 13);
            this.lblFoodStarter.Name = "lblFoodStarter";
            this.lblFoodStarter.Size = new System.Drawing.Size(59, 20);
            this.lblFoodStarter.TabIndex = 18;
            this.lblFoodStarter.Text = "Starters";
            // 
            // listviewLunchFood
            // 
            this.listviewLunchFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columNameFood,
            this.columnPriceFood});
            this.listviewLunchFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listviewLunchFood.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listviewLunchFood.FullRowSelect = true;
            this.listviewLunchFood.HideSelection = false;
            this.listviewLunchFood.Location = new System.Drawing.Point(12, 47);
            this.listviewLunchFood.Name = "listviewLunchFood";
            this.listviewLunchFood.Size = new System.Drawing.Size(404, 262);
            this.listviewLunchFood.TabIndex = 0;
            this.listviewLunchFood.UseCompatibleStateImageBehavior = false;
            this.listviewLunchFood.View = System.Windows.Forms.View.Details;
            this.listviewLunchFood.SelectedIndexChanged += new System.EventHandler(this.listviewLunchFood_SelectedIndexChanged);
            // 
            // columNameFood
            // 
            this.columNameFood.Text = "NAME";
            this.columNameFood.Width = 300;
            // 
            // columnPriceFood
            // 
            this.columnPriceFood.Text = "PRICE";
            this.columnPriceFood.Width = 70;
            // 
            // pnlDinnerStarter
            // 
            this.pnlDinnerStarter.Controls.Add(this.lblDinnerFood);
            this.pnlDinnerStarter.Controls.Add(this.listviewDinnerStarter);
            this.pnlDinnerStarter.Location = new System.Drawing.Point(9, 120);
            this.pnlDinnerStarter.Name = "pnlDinnerStarter";
            this.pnlDinnerStarter.Size = new System.Drawing.Size(459, 327);
            this.pnlDinnerStarter.TabIndex = 36;
            // 
            // lblDinnerFood
            // 
            this.lblDinnerFood.AutoSize = true;
            this.lblDinnerFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDinnerFood.ForeColor = System.Drawing.Color.White;
            this.lblDinnerFood.Location = new System.Drawing.Point(19, 13);
            this.lblDinnerFood.Name = "lblDinnerFood";
            this.lblDinnerFood.Size = new System.Drawing.Size(59, 20);
            this.lblDinnerFood.TabIndex = 19;
            this.lblDinnerFood.Text = "Starters";
            // 
            // listviewDinnerStarter
            // 
            this.listviewDinnerStarter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16});
            this.listviewDinnerStarter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listviewDinnerStarter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listviewDinnerStarter.FullRowSelect = true;
            this.listviewDinnerStarter.HideSelection = false;
            this.listviewDinnerStarter.Location = new System.Drawing.Point(12, 47);
            this.listviewDinnerStarter.Name = "listviewDinnerStarter";
            this.listviewDinnerStarter.Size = new System.Drawing.Size(404, 262);
            this.listviewDinnerStarter.TabIndex = 0;
            this.listviewDinnerStarter.UseCompatibleStateImageBehavior = false;
            this.listviewDinnerStarter.View = System.Windows.Forms.View.Details;
            this.listviewDinnerStarter.SelectedIndexChanged += new System.EventHandler(this.listviewFoodDinner_SelectedIndexChanged);
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "NAME";
            this.columnHeader15.Width = 300;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "PRICE";
            this.columnHeader16.Width = 70;
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.Controls.Add(this.listviewDrinks);
            this.pnlDrinks.Location = new System.Drawing.Point(9, 120);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Size = new System.Drawing.Size(459, 327);
            this.pnlDrinks.TabIndex = 37;
            // 
            // listviewDrinks
            // 
            this.listviewDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18});
            this.listviewDrinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listviewDrinks.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listviewDrinks.FullRowSelect = true;
            this.listviewDrinks.HideSelection = false;
            this.listviewDrinks.Location = new System.Drawing.Point(12, 3);
            this.listviewDrinks.Name = "listviewDrinks";
            this.listviewDrinks.Size = new System.Drawing.Size(404, 321);
            this.listviewDrinks.TabIndex = 0;
            this.listviewDrinks.UseCompatibleStateImageBehavior = false;
            this.listviewDrinks.View = System.Windows.Forms.View.Details;
            this.listviewDrinks.SelectedIndexChanged += new System.EventHandler(this.listviewDrinks_SelectedIndexChanged);
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "NAME";
            this.columnHeader17.Width = 300;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "PRICE";
            this.columnHeader18.Width = 70;
            // 
            // pnlDessert
            // 
            this.pnlDessert.Controls.Add(this.listviewDessert);
            this.pnlDessert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDessert.Location = new System.Drawing.Point(9, 120);
            this.pnlDessert.Name = "pnlDessert";
            this.pnlDessert.Size = new System.Drawing.Size(459, 327);
            this.pnlDessert.TabIndex = 38;
            // 
            // listviewDessert
            // 
            this.listviewDessert.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20});
            this.listviewDessert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listviewDessert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listviewDessert.FullRowSelect = true;
            this.listviewDessert.HideSelection = false;
            this.listviewDessert.Location = new System.Drawing.Point(12, 3);
            this.listviewDessert.Name = "listviewDessert";
            this.listviewDessert.Size = new System.Drawing.Size(404, 306);
            this.listviewDessert.TabIndex = 0;
            this.listviewDessert.UseCompatibleStateImageBehavior = false;
            this.listviewDessert.View = System.Windows.Forms.View.Details;
            this.listviewDessert.SelectedIndexChanged += new System.EventHandler(this.listviewDessert_SelectedIndexChanged);
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "NAME";
            this.columnHeader19.Width = 300;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "PRICE";
            this.columnHeader20.Width = 70;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblLunchMain);
            this.pnlMain.Controls.Add(this.listivewLunchMain);
            this.pnlMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMain.Location = new System.Drawing.Point(9, 120);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(459, 327);
            this.pnlMain.TabIndex = 39;
            // 
            // lblLunchMain
            // 
            this.lblLunchMain.AutoSize = true;
            this.lblLunchMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLunchMain.ForeColor = System.Drawing.Color.White;
            this.lblLunchMain.Location = new System.Drawing.Point(19, 13);
            this.lblLunchMain.Name = "lblLunchMain";
            this.lblLunchMain.Size = new System.Drawing.Size(48, 20);
            this.lblLunchMain.TabIndex = 17;
            this.lblLunchMain.Text = "Mains";
            // 
            // listivewLunchMain
            // 
            this.listivewLunchMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader21,
            this.columnHeader22});
            this.listivewLunchMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listivewLunchMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listivewLunchMain.FullRowSelect = true;
            this.listivewLunchMain.HideSelection = false;
            this.listivewLunchMain.Location = new System.Drawing.Point(12, 47);
            this.listivewLunchMain.Name = "listivewLunchMain";
            this.listivewLunchMain.Size = new System.Drawing.Size(404, 262);
            this.listivewLunchMain.TabIndex = 0;
            this.listivewLunchMain.UseCompatibleStateImageBehavior = false;
            this.listivewLunchMain.View = System.Windows.Forms.View.Details;
            this.listivewLunchMain.SelectedIndexChanged += new System.EventHandler(this.listivewLunchMain_SelectedIndexChanged);
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "NAME";
            this.columnHeader21.Width = 300;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "PRICE";
            this.columnHeader22.Width = 70;
            // 
            // pnlDinnerMain
            // 
            this.pnlDinnerMain.Controls.Add(this.label1);
            this.pnlDinnerMain.Controls.Add(this.listviewDinnerMain);
            this.pnlDinnerMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDinnerMain.Location = new System.Drawing.Point(9, 120);
            this.pnlDinnerMain.Name = "pnlDinnerMain";
            this.pnlDinnerMain.Size = new System.Drawing.Size(459, 327);
            this.pnlDinnerMain.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mains";
            // 
            // listviewDinnerMain
            // 
            this.listviewDinnerMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader23,
            this.columnHeader24});
            this.listviewDinnerMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listviewDinnerMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listviewDinnerMain.FullRowSelect = true;
            this.listviewDinnerMain.HideSelection = false;
            this.listviewDinnerMain.Location = new System.Drawing.Point(12, 47);
            this.listviewDinnerMain.Name = "listviewDinnerMain";
            this.listviewDinnerMain.Size = new System.Drawing.Size(404, 262);
            this.listviewDinnerMain.TabIndex = 0;
            this.listviewDinnerMain.UseCompatibleStateImageBehavior = false;
            this.listviewDinnerMain.View = System.Windows.Forms.View.Details;
            this.listviewDinnerMain.SelectedIndexChanged += new System.EventHandler(this.listviewDinnerMain_SelectedIndexChanged);
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "NAME";
            this.columnHeader23.Width = 300;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "PRICE";
            this.columnHeader24.Width = 70;
            // 
            // pnlDinnerDessert
            // 
            this.pnlDinnerDessert.Controls.Add(this.label2);
            this.pnlDinnerDessert.Controls.Add(this.listviewDinnerDessert);
            this.pnlDinnerDessert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDinnerDessert.Location = new System.Drawing.Point(9, 120);
            this.pnlDinnerDessert.Name = "pnlDinnerDessert";
            this.pnlDinnerDessert.Size = new System.Drawing.Size(459, 327);
            this.pnlDinnerDessert.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Desserts";
            // 
            // listviewDinnerDessert
            // 
            this.listviewDinnerDessert.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader25,
            this.columnHeader26});
            this.listviewDinnerDessert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listviewDinnerDessert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listviewDinnerDessert.FullRowSelect = true;
            this.listviewDinnerDessert.HideSelection = false;
            this.listviewDinnerDessert.Location = new System.Drawing.Point(12, 47);
            this.listviewDinnerDessert.Name = "listviewDinnerDessert";
            this.listviewDinnerDessert.Size = new System.Drawing.Size(404, 262);
            this.listviewDinnerDessert.TabIndex = 0;
            this.listviewDinnerDessert.UseCompatibleStateImageBehavior = false;
            this.listviewDinnerDessert.View = System.Windows.Forms.View.Details;
            this.listviewDinnerDessert.SelectedIndexChanged += new System.EventHandler(this.listviewDinnerDessert_SelectedIndexChanged);
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "NAME";
            this.columnHeader25.Width = 300;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "PRICE";
            this.columnHeader26.Width = 70;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 753);
            this.Controls.Add(this.pnlFoodDrink);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnOrderAddNote);
            this.Controls.Add(this.btnOrderRemove);
            this.Controls.Add(this.listviewOrder);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnSendOrder);
            this.Controls.Add(this.pnlDrinks);
            this.Controls.Add(this.pnlLunchStarters);
            this.Controls.Add(this.pnlDinnerStarter);
            this.Controls.Add(this.pnlDinnerMain);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlDinnerDessert);
            this.Controls.Add(this.pnlDessert);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.pnlFoodDrink.ResumeLayout(false);
            this.pnlLunchStarters.ResumeLayout(false);
            this.pnlLunchStarters.PerformLayout();
            this.pnlDinnerStarter.ResumeLayout(false);
            this.pnlDinnerStarter.PerformLayout();
            this.pnlDrinks.ResumeLayout(false);
            this.pnlDessert.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlDinnerMain.ResumeLayout(false);
            this.pnlDinnerMain.PerformLayout();
            this.pnlDinnerDessert.ResumeLayout(false);
            this.pnlDinnerDessert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnSendOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.ListView listviewOrder;
        private System.Windows.Forms.Button btnOrderRemove;
        private System.Windows.Forms.Button btnOrderAddNote;
        private System.Windows.Forms.ColumnHeader nameOrder;
        private System.Windows.Forms.ColumnHeader priceOrder;
        private System.Windows.Forms.ColumnHeader amountOrder;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Panel pnlFoodDrink;
        private System.Windows.Forms.Button btnStarter;
        private System.Windows.Forms.Panel pnlLunchStarters;
        private System.Windows.Forms.ListView listviewLunchFood;
        private System.Windows.Forms.ColumnHeader columNameFood;
        private System.Windows.Forms.ColumnHeader columnPriceFood;
        private System.Windows.Forms.Panel pnlDinnerStarter;
        private System.Windows.Forms.ListView listviewDinnerStarter;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.ListView listviewDrinks;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Label lblFoodStarter;
        private System.Windows.Forms.Label lblDinnerFood;
        private System.Windows.Forms.Panel pnlDessert;
        private System.Windows.Forms.ListView listviewDessert;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblLunchMain;
        private System.Windows.Forms.ListView listivewLunchMain;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.Panel pnlDinnerMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listviewDinnerMain;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.Panel pnlDinnerDessert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listviewDinnerDessert;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
    }
}