
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
            this.btnStarters = new System.Windows.Forms.Button();
            this.btnMains = new System.Windows.Forms.Button();
            this.btnDesserts = new System.Windows.Forms.Button();
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
            this.pnlStarters = new System.Windows.Forms.Panel();
            this.btnAddStarter = new System.Windows.Forms.Button();
            this.lblStartersHead = new System.Windows.Forms.Label();
            this.listviewStarters = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.pnlMains = new System.Windows.Forms.Panel();
            this.btnAddMains = new System.Windows.Forms.Button();
            this.lblMains = new System.Windows.Forms.Label();
            this.listviewMains = new System.Windows.Forms.ListView();
            this.columnMainName = new System.Windows.Forms.ColumnHeader();
            this.columnMainPrice = new System.Windows.Forms.ColumnHeader();
            this.pnlDesserts = new System.Windows.Forms.Panel();
            this.btnAddDessert = new System.Windows.Forms.Button();
            this.lblDesserts = new System.Windows.Forms.Label();
            this.listviewDesserts = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.pnlSoftDrinks = new System.Windows.Forms.Panel();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.lblSoftDrinks = new System.Windows.Forms.Label();
            this.listviewSoftDrinks = new System.Windows.Forms.ListView();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnPrice = new System.Windows.Forms.ColumnHeader();
            this.pnlDrinkCategories = new System.Windows.Forms.Panel();
            this.btnHotDrinks = new System.Windows.Forms.Button();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnSpirits = new System.Windows.Forms.Button();
            this.btnBeers = new System.Windows.Forms.Button();
            this.btnSoftDrink = new System.Windows.Forms.Button();
            this.pnlLunch = new System.Windows.Forms.Panel();
            this.pnlDinner = new System.Windows.Forms.Panel();
            this.btnStartersDinner = new System.Windows.Forms.Button();
            this.btnMainsDinners = new System.Windows.Forms.Button();
            this.btnDessertsDinner = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnDinner = new System.Windows.Forms.Button();
            this.pnlDinnerMains = new System.Windows.Forms.Panel();
            this.btnAddDinnerMains = new System.Windows.Forms.Button();
            this.lblDinnerMain = new System.Windows.Forms.Label();
            this.listviewDinnerMains = new System.Windows.Forms.ListView();
            this.MainName = new System.Windows.Forms.ColumnHeader();
            this.MainPrice = new System.Windows.Forms.ColumnHeader();
            this.pnlStarters.SuspendLayout();
            this.pnlMains.SuspendLayout();
            this.pnlDesserts.SuspendLayout();
            this.pnlSoftDrinks.SuspendLayout();
            this.pnlDrinkCategories.SuspendLayout();
            this.pnlLunch.SuspendLayout();
            this.pnlDinner.SuspendLayout();
            this.pnlDinnerMains.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStarters
            // 
            this.btnStarters.Location = new System.Drawing.Point(3, 13);
            this.btnStarters.Name = "btnStarters";
            this.btnStarters.Size = new System.Drawing.Size(148, 49);
            this.btnStarters.TabIndex = 1;
            this.btnStarters.Text = "STARTERS";
            this.btnStarters.UseVisualStyleBackColor = true;
            this.btnStarters.Click += new System.EventHandler(this.btnStarters_Click);
            // 
            // btnMains
            // 
            this.btnMains.Location = new System.Drawing.Point(208, 13);
            this.btnMains.Name = "btnMains";
            this.btnMains.Size = new System.Drawing.Size(198, 49);
            this.btnMains.TabIndex = 5;
            this.btnMains.Text = "MAINS";
            this.btnMains.UseVisualStyleBackColor = true;
            this.btnMains.Click += new System.EventHandler(this.btnMains_Click_1);
            // 
            // btnDesserts
            // 
            this.btnDesserts.Location = new System.Drawing.Point(436, 13);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Size = new System.Drawing.Size(158, 49);
            this.btnDesserts.TabIndex = 6;
            this.btnDesserts.Text = "DESSERTS";
            this.btnDesserts.UseVisualStyleBackColor = true;
            this.btnDesserts.Click += new System.EventHandler(this.btnDesserts_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(455, 217);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(154, 41);
            this.btnDrinks.TabIndex = 7;
            this.btnDrinks.Text = "DRINKS";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.BackColor = System.Drawing.Color.Green;
            this.btnSendOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSendOrder.ForeColor = System.Drawing.Color.White;
            this.btnSendOrder.Location = new System.Drawing.Point(16, 702);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(278, 52);
            this.btnSendOrder.TabIndex = 8;
            this.btnSendOrder.Text = "SEND ORDER";
            this.btnSendOrder.UseVisualStyleBackColor = false;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.Red;
            this.btnCancelOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrder.Location = new System.Drawing.Point(350, 702);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(278, 52);
            this.btnCancelOrder.TabIndex = 9;
            this.btnCancelOrder.Text = "CANCEL";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(710, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 29);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
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
            this.listviewOrder.HideSelection = false;
            this.listviewOrder.Location = new System.Drawing.Point(16, 35);
            this.listviewOrder.Name = "listviewOrder";
            this.listviewOrder.Size = new System.Drawing.Size(612, 171);
            this.listviewOrder.TabIndex = 13;
            this.listviewOrder.UseCompatibleStateImageBehavior = false;
            this.listviewOrder.View = System.Windows.Forms.View.Details;
            // 
            // nameOrder
            // 
            this.nameOrder.Text = "Name";
            this.nameOrder.Width = 450;
            // 
            // priceOrder
            // 
            this.priceOrder.Text = "Price";
            this.priceOrder.Width = 75;
            // 
            // amountOrder
            // 
            this.amountOrder.Text = "Amount";
            this.amountOrder.Width = 75;
            // 
            // btnOrderRemove
            // 
            this.btnOrderRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrderRemove.Location = new System.Drawing.Point(663, 132);
            this.btnOrderRemove.Name = "btnOrderRemove";
            this.btnOrderRemove.Size = new System.Drawing.Size(151, 45);
            this.btnOrderRemove.TabIndex = 15;
            this.btnOrderRemove.Text = "-";
            this.btnOrderRemove.UseVisualStyleBackColor = true;
            this.btnOrderRemove.Click += new System.EventHandler(this.btnOrderRemove_Click);
            // 
            // btnOrderAddNote
            // 
            this.btnOrderAddNote.Location = new System.Drawing.Point(663, 198);
            this.btnOrderAddNote.Name = "btnOrderAddNote";
            this.btnOrderAddNote.Size = new System.Drawing.Size(151, 60);
            this.btnOrderAddNote.TabIndex = 16;
            this.btnOrderAddNote.Text = "Add Note";
            this.btnOrderAddNote.UseVisualStyleBackColor = true;
            this.btnOrderAddNote.Click += new System.EventHandler(this.btnOrderAddNote_Click);
            // 
            // pnlStarters
            // 
            this.pnlStarters.Controls.Add(this.btnAddStarter);
            this.pnlStarters.Controls.Add(this.lblStartersHead);
            this.pnlStarters.Controls.Add(this.listviewStarters);
            this.pnlStarters.Location = new System.Drawing.Point(19, 380);
            this.pnlStarters.Name = "pnlStarters";
            this.pnlStarters.Size = new System.Drawing.Size(798, 318);
            this.pnlStarters.TabIndex = 17;
            // 
            // btnAddStarter
            // 
            this.btnAddStarter.Location = new System.Drawing.Point(628, 48);
            this.btnAddStarter.Name = "btnAddStarter";
            this.btnAddStarter.Size = new System.Drawing.Size(151, 112);
            this.btnAddStarter.TabIndex = 15;
            this.btnAddStarter.Text = "Add";
            this.btnAddStarter.UseVisualStyleBackColor = true;
            this.btnAddStarter.Click += new System.EventHandler(this.btnAddStarter_Click);
            // 
            // lblStartersHead
            // 
            this.lblStartersHead.AutoSize = true;
            this.lblStartersHead.Location = new System.Drawing.Point(14, 13);
            this.lblStartersHead.Name = "lblStartersHead";
            this.lblStartersHead.Size = new System.Drawing.Size(75, 20);
            this.lblStartersHead.TabIndex = 1;
            this.lblStartersHead.Text = "STARTERS";
            // 
            // listviewStarters
            // 
            this.listviewStarters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Price});
            this.listviewStarters.HideSelection = false;
            this.listviewStarters.Location = new System.Drawing.Point(14, 48);
            this.listviewStarters.Name = "listviewStarters";
            this.listviewStarters.Size = new System.Drawing.Size(571, 237);
            this.listviewStarters.TabIndex = 0;
            this.listviewStarters.UseCompatibleStateImageBehavior = false;
            this.listviewStarters.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 450;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 120;
            // 
            // pnlMains
            // 
            this.pnlMains.Controls.Add(this.btnAddMains);
            this.pnlMains.Controls.Add(this.lblMains);
            this.pnlMains.Controls.Add(this.listviewMains);
            this.pnlMains.Location = new System.Drawing.Point(19, 380);
            this.pnlMains.Name = "pnlMains";
            this.pnlMains.Size = new System.Drawing.Size(795, 315);
            this.pnlMains.TabIndex = 21;
            // 
            // btnAddMains
            // 
            this.btnAddMains.Location = new System.Drawing.Point(628, 48);
            this.btnAddMains.Name = "btnAddMains";
            this.btnAddMains.Size = new System.Drawing.Size(151, 112);
            this.btnAddMains.TabIndex = 15;
            this.btnAddMains.Text = "Add";
            this.btnAddMains.UseVisualStyleBackColor = true;
            // 
            // lblMains
            // 
            this.lblMains.AutoSize = true;
            this.lblMains.Location = new System.Drawing.Point(14, 13);
            this.lblMains.Name = "lblMains";
            this.lblMains.Size = new System.Drawing.Size(55, 20);
            this.lblMains.TabIndex = 1;
            this.lblMains.Text = "MAINS";
            // 
            // listviewMains
            // 
            this.listviewMains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMainName,
            this.columnMainPrice});
            this.listviewMains.HideSelection = false;
            this.listviewMains.Location = new System.Drawing.Point(14, 48);
            this.listviewMains.Name = "listviewMains";
            this.listviewMains.Size = new System.Drawing.Size(571, 237);
            this.listviewMains.TabIndex = 0;
            this.listviewMains.UseCompatibleStateImageBehavior = false;
            this.listviewMains.View = System.Windows.Forms.View.Details;
            // 
            // columnMainName
            // 
            this.columnMainName.Text = "Name";
            this.columnMainName.Width = 450;
            // 
            // columnMainPrice
            // 
            this.columnMainPrice.Text = "Price";
            this.columnMainPrice.Width = 120;
            // 
            // pnlDesserts
            // 
            this.pnlDesserts.Controls.Add(this.btnAddDessert);
            this.pnlDesserts.Controls.Add(this.lblDesserts);
            this.pnlDesserts.Controls.Add(this.listviewDesserts);
            this.pnlDesserts.Location = new System.Drawing.Point(16, 380);
            this.pnlDesserts.Name = "pnlDesserts";
            this.pnlDesserts.Size = new System.Drawing.Size(801, 315);
            this.pnlDesserts.TabIndex = 22;
            // 
            // btnAddDessert
            // 
            this.btnAddDessert.Location = new System.Drawing.Point(628, 48);
            this.btnAddDessert.Name = "btnAddDessert";
            this.btnAddDessert.Size = new System.Drawing.Size(151, 112);
            this.btnAddDessert.TabIndex = 15;
            this.btnAddDessert.Text = "Add";
            this.btnAddDessert.UseVisualStyleBackColor = true;
            this.btnAddDessert.Click += new System.EventHandler(this.btnAddDessert_Click);
            // 
            // lblDesserts
            // 
            this.lblDesserts.AutoSize = true;
            this.lblDesserts.Location = new System.Drawing.Point(14, 13);
            this.lblDesserts.Name = "lblDesserts";
            this.lblDesserts.Size = new System.Drawing.Size(76, 20);
            this.lblDesserts.TabIndex = 1;
            this.lblDesserts.Text = "DESSERTS";
            // 
            // listviewDesserts
            // 
            this.listviewDesserts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listviewDesserts.HideSelection = false;
            this.listviewDesserts.Location = new System.Drawing.Point(14, 48);
            this.listviewDesserts.Name = "listviewDesserts";
            this.listviewDesserts.Size = new System.Drawing.Size(571, 237);
            this.listviewDesserts.TabIndex = 0;
            this.listviewDesserts.UseCompatibleStateImageBehavior = false;
            this.listviewDesserts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 450;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 120;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(663, 264);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(151, 115);
            this.txtNote.TabIndex = 18;
            this.txtNote.Text = "";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(710, 714);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(94, 29);
            this.btnPayment.TabIndex = 19;
            this.btnPayment.Text = "pay";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // pnlSoftDrinks
            // 
            this.pnlSoftDrinks.Controls.Add(this.btnAddDrink);
            this.pnlSoftDrinks.Controls.Add(this.lblSoftDrinks);
            this.pnlSoftDrinks.Controls.Add(this.listviewSoftDrinks);
            this.pnlSoftDrinks.Location = new System.Drawing.Point(6, 385);
            this.pnlSoftDrinks.Name = "pnlSoftDrinks";
            this.pnlSoftDrinks.Size = new System.Drawing.Size(795, 315);
            this.pnlSoftDrinks.TabIndex = 20;
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Location = new System.Drawing.Point(628, 48);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(151, 112);
            this.btnAddDrink.TabIndex = 15;
            this.btnAddDrink.Text = "Add";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            // 
            // lblSoftDrinks
            // 
            this.lblSoftDrinks.AutoSize = true;
            this.lblSoftDrinks.Location = new System.Drawing.Point(14, 13);
            this.lblSoftDrinks.Name = "lblSoftDrinks";
            this.lblSoftDrinks.Size = new System.Drawing.Size(99, 20);
            this.lblSoftDrinks.TabIndex = 1;
            this.lblSoftDrinks.Text = "SOFT DRINKS";
            // 
            // listviewSoftDrinks
            // 
            this.listviewSoftDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPrice});
            this.listviewSoftDrinks.HideSelection = false;
            this.listviewSoftDrinks.Location = new System.Drawing.Point(14, 48);
            this.listviewSoftDrinks.Name = "listviewSoftDrinks";
            this.listviewSoftDrinks.Size = new System.Drawing.Size(571, 237);
            this.listviewSoftDrinks.TabIndex = 0;
            this.listviewSoftDrinks.UseCompatibleStateImageBehavior = false;
            this.listviewSoftDrinks.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 450;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 120;
            // 
            // pnlDrinkCategories
            // 
            this.pnlDrinkCategories.Controls.Add(this.btnHotDrinks);
            this.pnlDrinkCategories.Controls.Add(this.btnWine);
            this.pnlDrinkCategories.Controls.Add(this.btnSpirits);
            this.pnlDrinkCategories.Controls.Add(this.btnBeers);
            this.pnlDrinkCategories.Controls.Add(this.btnSoftDrink);
            this.pnlDrinkCategories.Location = new System.Drawing.Point(19, 279);
            this.pnlDrinkCategories.Name = "pnlDrinkCategories";
            this.pnlDrinkCategories.Size = new System.Drawing.Size(612, 89);
            this.pnlDrinkCategories.TabIndex = 20;
            // 
            // btnHotDrinks
            // 
            this.btnHotDrinks.Location = new System.Drawing.Point(503, 13);
            this.btnHotDrinks.Name = "btnHotDrinks";
            this.btnHotDrinks.Size = new System.Drawing.Size(94, 54);
            this.btnHotDrinks.TabIndex = 24;
            this.btnHotDrinks.Text = "HOT DRINKS";
            this.btnHotDrinks.UseVisualStyleBackColor = true;
            // 
            // btnWine
            // 
            this.btnWine.Location = new System.Drawing.Point(253, 13);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(94, 54);
            this.btnWine.TabIndex = 23;
            this.btnWine.Text = "WINES";
            this.btnWine.UseVisualStyleBackColor = true;
            // 
            // btnSpirits
            // 
            this.btnSpirits.Location = new System.Drawing.Point(377, 12);
            this.btnSpirits.Name = "btnSpirits";
            this.btnSpirits.Size = new System.Drawing.Size(94, 54);
            this.btnSpirits.TabIndex = 22;
            this.btnSpirits.Text = "SPIRITS";
            this.btnSpirits.UseVisualStyleBackColor = true;
            // 
            // btnBeers
            // 
            this.btnBeers.Location = new System.Drawing.Point(128, 12);
            this.btnBeers.Name = "btnBeers";
            this.btnBeers.Size = new System.Drawing.Size(94, 54);
            this.btnBeers.TabIndex = 21;
            this.btnBeers.Text = "BEERS";
            this.btnBeers.UseVisualStyleBackColor = true;
            // 
            // btnSoftDrink
            // 
            this.btnSoftDrink.Location = new System.Drawing.Point(3, 13);
            this.btnSoftDrink.Name = "btnSoftDrink";
            this.btnSoftDrink.Size = new System.Drawing.Size(94, 54);
            this.btnSoftDrink.TabIndex = 2;
            this.btnSoftDrink.Text = "SOFT DRINKS";
            this.btnSoftDrink.UseVisualStyleBackColor = true;
            this.btnSoftDrink.Click += new System.EventHandler(this.btnSoftDrink_Click);
            // 
            // pnlLunch
            // 
            this.pnlLunch.Controls.Add(this.btnStarters);
            this.pnlLunch.Controls.Add(this.btnMains);
            this.pnlLunch.Controls.Add(this.btnDesserts);
            this.pnlLunch.Location = new System.Drawing.Point(19, 279);
            this.pnlLunch.Name = "pnlLunch";
            this.pnlLunch.Size = new System.Drawing.Size(612, 78);
            this.pnlLunch.TabIndex = 23;
            // 
            // pnlDinner
            // 
            this.pnlDinner.Controls.Add(this.btnStartersDinner);
            this.pnlDinner.Controls.Add(this.btnMainsDinners);
            this.pnlDinner.Controls.Add(this.btnDessertsDinner);
            this.pnlDinner.Location = new System.Drawing.Point(12, 279);
            this.pnlDinner.Name = "pnlDinner";
            this.pnlDinner.Size = new System.Drawing.Size(612, 78);
            this.pnlDinner.TabIndex = 24;
            // 
            // btnStartersDinner
            // 
            this.btnStartersDinner.Location = new System.Drawing.Point(7, 13);
            this.btnStartersDinner.Name = "btnStartersDinner";
            this.btnStartersDinner.Size = new System.Drawing.Size(154, 41);
            this.btnStartersDinner.TabIndex = 1;
            this.btnStartersDinner.Text = "STARTERS";
            this.btnStartersDinner.UseVisualStyleBackColor = true;
            // 
            // btnMainsDinners
            // 
            this.btnMainsDinners.Location = new System.Drawing.Point(232, 13);
            this.btnMainsDinners.Name = "btnMainsDinners";
            this.btnMainsDinners.Size = new System.Drawing.Size(154, 41);
            this.btnMainsDinners.TabIndex = 5;
            this.btnMainsDinners.Text = "MAINS";
            this.btnMainsDinners.UseVisualStyleBackColor = true;
            this.btnMainsDinners.Click += new System.EventHandler(this.btnMainsDinners_Click);
            // 
            // btnDessertsDinner
            // 
            this.btnDessertsDinner.Location = new System.Drawing.Point(443, 13);
            this.btnDessertsDinner.Name = "btnDessertsDinner";
            this.btnDessertsDinner.Size = new System.Drawing.Size(154, 41);
            this.btnDessertsDinner.TabIndex = 6;
            this.btnDessertsDinner.Text = "DESSERTS";
            this.btnDessertsDinner.UseVisualStyleBackColor = true;
            // 
            // btnLunch
            // 
            this.btnLunch.Location = new System.Drawing.Point(16, 217);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(154, 41);
            this.btnLunch.TabIndex = 25;
            this.btnLunch.Text = "LUNCH";
            this.btnLunch.UseVisualStyleBackColor = true;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // btnDinner
            // 
            this.btnDinner.Location = new System.Drawing.Point(244, 217);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(154, 41);
            this.btnDinner.TabIndex = 26;
            this.btnDinner.Text = "DINNER";
            this.btnDinner.UseVisualStyleBackColor = true;
            this.btnDinner.Click += new System.EventHandler(this.btnDinner_Click);
            // 
            // pnlDinnerMains
            // 
            this.pnlDinnerMains.Controls.Add(this.btnAddDinnerMains);
            this.pnlDinnerMains.Controls.Add(this.lblDinnerMain);
            this.pnlDinnerMains.Controls.Add(this.listviewDinnerMains);
            this.pnlDinnerMains.Location = new System.Drawing.Point(9, 383);
            this.pnlDinnerMains.Name = "pnlDinnerMains";
            this.pnlDinnerMains.Size = new System.Drawing.Size(795, 315);
            this.pnlDinnerMains.TabIndex = 27;
            // 
            // btnAddDinnerMains
            // 
            this.btnAddDinnerMains.Location = new System.Drawing.Point(628, 48);
            this.btnAddDinnerMains.Name = "btnAddDinnerMains";
            this.btnAddDinnerMains.Size = new System.Drawing.Size(151, 112);
            this.btnAddDinnerMains.TabIndex = 15;
            this.btnAddDinnerMains.Text = "Add";
            this.btnAddDinnerMains.UseVisualStyleBackColor = true;
            this.btnAddDinnerMains.Click += new System.EventHandler(this.btnAddDinnerMains_Click);
            // 
            // lblDinnerMain
            // 
            this.lblDinnerMain.AutoSize = true;
            this.lblDinnerMain.Location = new System.Drawing.Point(14, 13);
            this.lblDinnerMain.Name = "lblDinnerMain";
            this.lblDinnerMain.Size = new System.Drawing.Size(55, 20);
            this.lblDinnerMain.TabIndex = 1;
            this.lblDinnerMain.Text = "MAINS";
            // 
            // listviewDinnerMains
            // 
            this.listviewDinnerMains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MainName,
            this.MainPrice});
            this.listviewDinnerMains.HideSelection = false;
            this.listviewDinnerMains.Location = new System.Drawing.Point(14, 48);
            this.listviewDinnerMains.Name = "listviewDinnerMains";
            this.listviewDinnerMains.Size = new System.Drawing.Size(571, 237);
            this.listviewDinnerMains.TabIndex = 0;
            this.listviewDinnerMains.UseCompatibleStateImageBehavior = false;
            this.listviewDinnerMains.View = System.Windows.Forms.View.Details;
            // 
            // MainName
            // 
            this.MainName.Text = "Name";
            this.MainName.Width = 450;
            // 
            // MainPrice
            // 
            this.MainPrice.Text = "Price";
            this.MainPrice.Width = 120;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 766);
            this.Controls.Add(this.btnDinner);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.pnlSoftDrinks);
            this.Controls.Add(this.pnlDinnerMains);
            this.Controls.Add(this.pnlDinner);
            this.Controls.Add(this.pnlMains);
            this.Controls.Add(this.pnlStarters);
            this.Controls.Add(this.pnlLunch);
            this.Controls.Add(this.pnlDesserts);
            this.Controls.Add(this.pnlDrinkCategories);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnOrderAddNote);
            this.Controls.Add(this.btnOrderRemove);
            this.Controls.Add(this.listviewOrder);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnSendOrder);
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.pnlStarters.ResumeLayout(false);
            this.pnlStarters.PerformLayout();
            this.pnlMains.ResumeLayout(false);
            this.pnlMains.PerformLayout();
            this.pnlDesserts.ResumeLayout(false);
            this.pnlDesserts.PerformLayout();
            this.pnlSoftDrinks.ResumeLayout(false);
            this.pnlSoftDrinks.PerformLayout();
            this.pnlDrinkCategories.ResumeLayout(false);
            this.pnlLunch.ResumeLayout(false);
            this.pnlDinner.ResumeLayout(false);
            this.pnlDinnerMains.ResumeLayout(false);
            this.pnlDinnerMains.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStarters;
        private System.Windows.Forms.Button btnMains;
        private System.Windows.Forms.Button btnDesserts;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnSendOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.ListView listviewOrder;
        private System.Windows.Forms.Button btnOrderRemove;
        private System.Windows.Forms.Button btnOrderAddNote;
        private System.Windows.Forms.Panel pnlStarters;
        private System.Windows.Forms.Button btnAddStarter;
        private System.Windows.Forms.Label lblStartersHead;
        private System.Windows.Forms.ListView listviewStarters;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader nameOrder;
        private System.Windows.Forms.ColumnHeader priceOrder;
        private System.Windows.Forms.ColumnHeader amountOrder;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Panel pnlSoftDrinks;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.Label lblSoftDrinks;
        private System.Windows.Forms.ListView listviewSoftDrinks;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.Panel pnlDrinkCategories;
        private System.Windows.Forms.Button btnHotDrinks;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnSpirits;
        private System.Windows.Forms.Button btnBeers;
        private System.Windows.Forms.Button btnSoftDrink;
        private System.Windows.Forms.Panel pnlMains;
        private System.Windows.Forms.Button btnAddMains;
        private System.Windows.Forms.Label lblMains;
        private System.Windows.Forms.ListView listviewMains;
        private System.Windows.Forms.ColumnHeader columnMainName;
        private System.Windows.Forms.ColumnHeader columnMainPrice;
        private System.Windows.Forms.Panel pnlDesserts;
        private System.Windows.Forms.Button btnAddDessert;
        private System.Windows.Forms.Label lblDesserts;
        private System.Windows.Forms.ListView listviewDesserts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel pnlLunch;
        private System.Windows.Forms.Panel pnlDinner;
        private System.Windows.Forms.Button btnStartersDinner;
        private System.Windows.Forms.Button btnMainsDinners;
        private System.Windows.Forms.Button btnDessertsDinner;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnDinner;
        private System.Windows.Forms.Panel pnlDinnerMains;
        private System.Windows.Forms.Button btnAddDinnerMains;
        private System.Windows.Forms.Label lblDinnerMain;
        private System.Windows.Forms.ListView listviewDinnerMains;
        private System.Windows.Forms.ColumnHeader MainName;
        private System.Windows.Forms.ColumnHeader MainPrice;
    }
}