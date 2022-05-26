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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOccupy
            // 
            this.btnOccupy.Location = new System.Drawing.Point(181, 200);
            this.btnOccupy.Name = "btnOccupy";
            this.btnOccupy.Size = new System.Drawing.Size(100, 40);
            this.btnOccupy.TabIndex = 0;
            this.btnOccupy.Text = "Occupy";
            this.btnOccupy.UseVisualStyleBackColor = true;
            this.btnOccupy.Click += new System.EventHandler(this.btnOccupy_Click);
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.Location = new System.Drawing.Point(181, 280);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(100, 40);
            this.btnTakeOrder.TabIndex = 1;
            this.btnTakeOrder.Text = "Take Order";
            this.btnTakeOrder.UseVisualStyleBackColor = true;
            this.btnTakeOrder.Click += new System.EventHandler(this.btnTakeOrder_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(181, 360);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 40);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(383, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(181, 480);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.lblWaiter.Location = new System.Drawing.Point(12, 9);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(73, 28);
            this.lblWaiter.TabIndex = 6;
            this.lblWaiter.Text = "Waiter:";
            // 
            // TableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 753);
            this.Controls.Add(this.lblWaiter);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnTakeOrder);
            this.Controls.Add(this.btnOccupy);
            this.Name = "TableControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOccupy;
        private System.Windows.Forms.Button btnTakeOrder;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblWaiter;
    }
}