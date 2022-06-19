namespace RosUI
{
    partial class TableControl
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
            this.btnOccupy = new System.Windows.Forms.Button();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.btnDishServed = new System.Windows.Forms.Button();
            this.btnDrinkServed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOccupy
            // 
            this.btnOccupy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOccupy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOccupy.Location = new System.Drawing.Point(176, 200);
            this.btnOccupy.Name = "btnOccupy";
            this.btnOccupy.Size = new System.Drawing.Size(110, 40);
            this.btnOccupy.TabIndex = 0;
            this.btnOccupy.Text = "Occupy";
            this.btnOccupy.UseVisualStyleBackColor = false;
            this.btnOccupy.Click += new System.EventHandler(this.btnOccupy_Click);
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTakeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakeOrder.Location = new System.Drawing.Point(176, 280);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(110, 40);
            this.btnTakeOrder.TabIndex = 1;
            this.btnTakeOrder.Text = "Take Order";
            this.btnTakeOrder.UseVisualStyleBackColor = false;
            this.btnTakeOrder.Click += new System.EventHandler(this.btnTakeOrder_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Location = new System.Drawing.Point(176, 520);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(110, 40);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Payment";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::RosUI.Properties.Resources.BackIcon;
            this.btnBack.Location = new System.Drawing.Point(0, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTable.Location = new System.Drawing.Point(192, 110);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(73, 31);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "Table ";
            // 
            // lblWaiter
            // 
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWaiter.Location = new System.Drawing.Point(325, 9);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(73, 28);
            this.lblWaiter.TabIndex = 6;
            this.lblWaiter.Text = "Waiter:";
            // 
            // btnDishServed
            // 
            this.btnDishServed.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDishServed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDishServed.Location = new System.Drawing.Point(176, 440);
            this.btnDishServed.Name = "btnDishServed";
            this.btnDishServed.Size = new System.Drawing.Size(110, 40);
            this.btnDishServed.TabIndex = 7;
            this.btnDishServed.Text = "Dish Served";
            this.btnDishServed.UseVisualStyleBackColor = false;
            this.btnDishServed.Click += new System.EventHandler(this.btnDishServed_Click);
            // 
            // btnDrinkServed
            // 
            this.btnDrinkServed.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDrinkServed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrinkServed.Location = new System.Drawing.Point(176, 360);
            this.btnDrinkServed.Name = "btnDrinkServed";
            this.btnDrinkServed.Size = new System.Drawing.Size(110, 40);
            this.btnDrinkServed.TabIndex = 8;
            this.btnDrinkServed.Text = "Drink Served";
            this.btnDrinkServed.UseVisualStyleBackColor = false;
            this.btnDrinkServed.Click += new System.EventHandler(this.btnDrinkServed_Click);
            // 
            // TableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 753);
            this.Controls.Add(this.btnDrinkServed);
            this.Controls.Add(this.btnDishServed);
            this.Controls.Add(this.lblWaiter);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnTakeOrder);
            this.Controls.Add(this.btnOccupy);
            this.Name = "TableControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOccupy;
        private System.Windows.Forms.Button btnTakeOrder;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Button btnDishServed;
        private System.Windows.Forms.Button btnDrinkServed;
    }
}