
namespace RosUI
{
    partial class OrderForm
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
            this.lboxOrderList = new System.Windows.Forms.ListBox();
            this.btnStarters = new System.Windows.Forms.Button();
            this.btnMains = new System.Windows.Forms.Button();
            this.btnDesserts = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lboxOrderList
            // 
            this.lboxOrderList.FormattingEnabled = true;
            this.lboxOrderList.ItemHeight = 20;
            this.lboxOrderList.Location = new System.Drawing.Point(12, 56);
            this.lboxOrderList.Name = "lboxOrderList";
            this.lboxOrderList.Size = new System.Drawing.Size(616, 204);
            this.lboxOrderList.TabIndex = 0;
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
            // btnCheckOrder
            // 
            this.btnCheckOrder.BackColor = System.Drawing.Color.Green;
            this.btnCheckOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOrder.ForeColor = System.Drawing.Color.White;
            this.btnCheckOrder.Location = new System.Drawing.Point(16, 391);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(278, 52);
            this.btnCheckOrder.TabIndex = 8;
            this.btnCheckOrder.Text = "CHECK ORDER";
            this.btnCheckOrder.UseVisualStyleBackColor = false;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.Red;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(350, 391);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(278, 52);
            this.btnRemoveItem.TabIndex = 9;
            this.btnRemoveItem.Text = "REMOVE ITEM";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(624, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(103, 29);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(733, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(108, 29);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
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
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 490);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnCheckOrder);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnDesserts);
            this.Controls.Add(this.btnMains);
            this.Controls.Add(this.btnStarters);
            this.Controls.Add(this.lboxOrderList);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxOrderList;
        private System.Windows.Forms.Button btnStarters;
        private System.Windows.Forms.Button btnMains;
        private System.Windows.Forms.Button btnDesserts;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnCheckOrder;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblTableNumber;
    }
}