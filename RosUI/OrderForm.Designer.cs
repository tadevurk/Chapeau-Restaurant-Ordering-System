
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
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.btnOrderRemove = new System.Windows.Forms.Button();
            this.btnOrderAddNote = new System.Windows.Forms.Button();
            this.pnlStarters = new System.Windows.Forms.Panel();
            this.btnAddStarter = new System.Windows.Forms.Button();
            this.lblStartersHead = new System.Windows.Forms.Label();
            this.listviewStarters = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pnlStarters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStarters
            // 
            this.btnStarters.Location = new System.Drawing.Point(16, 283);
            this.btnStarters.Name = "btnStarters";
            this.btnStarters.Size = new System.Drawing.Size(122, 67);
            this.btnStarters.TabIndex = 1;
            this.btnStarters.Text = "STARTERS";
            this.btnStarters.UseVisualStyleBackColor = true;
            this.btnStarters.Click += new System.EventHandler(this.btnStarters_Click);
            // 
            // btnMains
            // 
            this.btnMains.Location = new System.Drawing.Point(185, 283);
            this.btnMains.Name = "btnMains";
            this.btnMains.Size = new System.Drawing.Size(109, 67);
            this.btnMains.TabIndex = 5;
            this.btnMains.Text = "MAINS";
            this.btnMains.UseVisualStyleBackColor = true;
            // 
            // btnDesserts
            // 
            this.btnDesserts.Location = new System.Drawing.Point(350, 283);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Size = new System.Drawing.Size(117, 67);
            this.btnDesserts.TabIndex = 6;
            this.btnDesserts.Text = "DESSERTS";
            this.btnDesserts.UseVisualStyleBackColor = true;
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(519, 283);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(109, 67);
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
            this.listviewOrder.Location = new System.Drawing.Point(16, 55);
            this.listviewOrder.Name = "listviewOrder";
            this.listviewOrder.Size = new System.Drawing.Size(612, 222);
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
            // btnOrderAdd
            // 
            this.btnOrderAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrderAdd.Location = new System.Drawing.Point(663, 67);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(151, 45);
            this.btnOrderAdd.TabIndex = 14;
            this.btnOrderAdd.Text = "+";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
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
            this.pnlStarters.Controls.Add(this.numericUpDown1);
            this.pnlStarters.Controls.Add(this.btnAddStarter);
            this.pnlStarters.Controls.Add(this.lblStartersHead);
            this.pnlStarters.Controls.Add(this.listviewStarters);
            this.pnlStarters.Location = new System.Drawing.Point(25, 385);
            this.pnlStarters.Name = "pnlStarters";
            this.pnlStarters.Size = new System.Drawing.Size(816, 299);
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
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(674, 213);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 27);
            this.numericUpDown1.TabIndex = 16;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 766);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnOrderAddNote);
            this.Controls.Add(this.btnOrderRemove);
            this.Controls.Add(this.btnOrderAdd);
            this.Controls.Add(this.listviewOrder);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnSendOrder);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnDesserts);
            this.Controls.Add(this.btnMains);
            this.Controls.Add(this.btnStarters);
            this.Controls.Add(this.pnlStarters);
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.pnlStarters.ResumeLayout(false);
            this.pnlStarters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Button btnOrderAdd;
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}