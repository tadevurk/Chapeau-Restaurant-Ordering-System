
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.listviewOrder = new System.Windows.Forms.ListView();
            this.nameOrder = new System.Windows.Forms.ColumnHeader();
            this.priceOrder = new System.Windows.Forms.ColumnHeader();
            this.amountOrder = new System.Windows.Forms.ColumnHeader();
            this.btnOrderAddNote = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.pnlFoodDrink = new System.Windows.Forms.Panel();
            this.btnDinner = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.listviewLunch = new System.Windows.Forms.ListView();
            this.columNameFood = new System.Windows.Forms.ColumnHeader();
            this.columnPriceFood = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.listviewDinner = new System.Windows.Forms.ListView();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.listviewDrinks = new System.Windows.Forms.ListView();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.pnlFoodDrink.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDrinks
            // 
            this.btnDrinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrinks.Location = new System.Drawing.Point(322, 9);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(132, 41);
            this.btnDrinks.TabIndex = 7;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.BackColor = System.Drawing.Color.Green;
            this.btnSendOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSendOrder.ForeColor = System.Drawing.Color.White;
            this.btnSendOrder.Location = new System.Drawing.Point(269, 700);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(201, 47);
            this.btnSendOrder.TabIndex = 8;
            this.btnSendOrder.Text = "ORDER";
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
            this.btnCancelOrder.Location = new System.Drawing.Point(16, 700);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(201, 47);
            this.btnCancelOrder.TabIndex = 9;
            this.btnCancelOrder.Text = "CANCEL";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Visible = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(16, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 41);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(402, 17);
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
            this.listviewOrder.Location = new System.Drawing.Point(16, 504);
            this.listviewOrder.Name = "listviewOrder";
            this.listviewOrder.Size = new System.Drawing.Size(454, 190);
            this.listviewOrder.TabIndex = 13;
            this.listviewOrder.UseCompatibleStateImageBehavior = false;
            this.listviewOrder.View = System.Windows.Forms.View.Details;
            this.listviewOrder.SelectedIndexChanged += new System.EventHandler(this.listviewOrder_SelectedIndexChanged);
            // 
            // nameOrder
            // 
            this.nameOrder.Text = "Name";
            this.nameOrder.Width = 270;
            // 
            // priceOrder
            // 
            this.priceOrder.Text = "Price";
            this.priceOrder.Width = 75;
            // 
            // amountOrder
            // 
            this.amountOrder.Text = "Amount";
            this.amountOrder.Width = 85;
            // 
            // btnOrderAddNote
            // 
            this.btnOrderAddNote.BackColor = System.Drawing.SystemColors.Control;
            this.btnOrderAddNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderAddNote.FlatAppearance.BorderSize = 0;
            this.btnOrderAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderAddNote.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderAddNote.Image")));
            this.btnOrderAddNote.Location = new System.Drawing.Point(379, 454);
            this.btnOrderAddNote.Name = "btnOrderAddNote";
            this.btnOrderAddNote.Size = new System.Drawing.Size(91, 44);
            this.btnOrderAddNote.TabIndex = 16;
            this.btnOrderAddNote.UseVisualStyleBackColor = false;
            this.btnOrderAddNote.Visible = false;
            this.btnOrderAddNote.Click += new System.EventHandler(this.btnOrderAddNote_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(16, 454);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(354, 44);
            this.txtNote.TabIndex = 18;
            this.txtNote.Text = "";
            this.txtNote.Visible = false;
            // 
            // pnlFoodDrink
            // 
            this.pnlFoodDrink.Controls.Add(this.btnDinner);
            this.pnlFoodDrink.Controls.Add(this.btnLunch);
            this.pnlFoodDrink.Controls.Add(this.btnDrinks);
            this.pnlFoodDrink.Location = new System.Drawing.Point(16, 52);
            this.pnlFoodDrink.Name = "pnlFoodDrink";
            this.pnlFoodDrink.Size = new System.Drawing.Size(454, 54);
            this.pnlFoodDrink.TabIndex = 34;
            // 
            // btnDinner
            // 
            this.btnDinner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDinner.Location = new System.Drawing.Point(164, 9);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(132, 41);
            this.btnDinner.TabIndex = 8;
            this.btnDinner.Text = "Dinner";
            this.btnDinner.UseVisualStyleBackColor = true;
            this.btnDinner.Click += new System.EventHandler(this.btnDinner_Click);
            // 
            // btnLunch
            // 
            this.btnLunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLunch.Location = new System.Drawing.Point(0, 9);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(132, 41);
            this.btnLunch.TabIndex = 0;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = true;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // listviewLunch
            // 
            this.listviewLunch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columNameFood,
            this.columnPriceFood,
            this.columnHeader2});
            this.listviewLunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listviewLunch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listviewLunch.FullRowSelect = true;
            this.listviewLunch.HideSelection = false;
            this.listviewLunch.Location = new System.Drawing.Point(16, 112);
            this.listviewLunch.Name = "listviewLunch";
            this.listviewLunch.Size = new System.Drawing.Size(454, 332);
            this.listviewLunch.TabIndex = 0;
            this.listviewLunch.UseCompatibleStateImageBehavior = false;
            this.listviewLunch.View = System.Windows.Forms.View.Details;
            this.listviewLunch.SelectedIndexChanged += new System.EventHandler(this.listviewLunch_SelectedIndexChanged);
            // 
            // columNameFood
            // 
            this.columNameFood.Text = "Item";
            this.columNameFood.Width = 220;
            // 
            // columnPriceFood
            // 
            this.columnPriceFood.Text = "Price";
            this.columnPriceFood.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 100;
            // 
            // listviewDinner
            // 
            this.listviewDinner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader3});
            this.listviewDinner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listviewDinner.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listviewDinner.FullRowSelect = true;
            this.listviewDinner.HideSelection = false;
            this.listviewDinner.Location = new System.Drawing.Point(16, 112);
            this.listviewDinner.Name = "listviewDinner";
            this.listviewDinner.Size = new System.Drawing.Size(454, 332);
            this.listviewDinner.TabIndex = 0;
            this.listviewDinner.UseCompatibleStateImageBehavior = false;
            this.listviewDinner.View = System.Windows.Forms.View.Details;
            this.listviewDinner.SelectedIndexChanged += new System.EventHandler(this.listviewDinner_SelectedIndexChanged);
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Item";
            this.columnHeader15.Width = 220;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Price";
            this.columnHeader16.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 100;
            // 
            // listviewDrinks
            // 
            this.listviewDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader1});
            this.listviewDrinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listviewDrinks.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listviewDrinks.FullRowSelect = true;
            this.listviewDrinks.HideSelection = false;
            this.listviewDrinks.Location = new System.Drawing.Point(16, 112);
            this.listviewDrinks.Name = "listviewDrinks";
            this.listviewDrinks.Size = new System.Drawing.Size(454, 332);
            this.listviewDrinks.TabIndex = 0;
            this.listviewDrinks.UseCompatibleStateImageBehavior = false;
            this.listviewDrinks.View = System.Windows.Forms.View.Details;
            this.listviewDrinks.SelectedIndexChanged += new System.EventHandler(this.listviewDrinks_SelectedIndexChanged);
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Item";
            this.columnHeader17.Width = 220;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Price";
            this.columnHeader18.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 100;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 753);
            this.Controls.Add(this.pnlFoodDrink);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnOrderAddNote);
            this.Controls.Add(this.listviewOrder);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnSendOrder);
            this.Controls.Add(this.listviewDrinks);
            this.Controls.Add(this.listviewDinner);
            this.Controls.Add(this.listviewLunch);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.pnlFoodDrink.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnOrderAddNote;
        private System.Windows.Forms.ColumnHeader nameOrder;
        private System.Windows.Forms.ColumnHeader priceOrder;
        private System.Windows.Forms.ColumnHeader amountOrder;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Panel pnlFoodDrink;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.ListView listviewLunch;
        private System.Windows.Forms.ColumnHeader columNameFood;
        private System.Windows.Forms.ColumnHeader columnPriceFood;
        private System.Windows.Forms.ListView listviewDinner;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ListView listviewDrinks;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Button btnDinner;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}