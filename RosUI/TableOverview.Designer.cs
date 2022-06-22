namespace RosUI
{
    partial class TableOverview
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer tmrTimer;
            this.btnMoreInfo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTableOverview = new System.Windows.Forms.Label();
            this.lblOrderReady = new System.Windows.Forms.Label();
            this.pbOrderReady = new System.Windows.Forms.PictureBox();
            this.pbOrderServed = new System.Windows.Forms.PictureBox();
            this.lblOrderServed = new System.Windows.Forms.Label();
            this.pbEmpty = new System.Windows.Forms.PictureBox();
            this.lblTableFree = new System.Windows.Forms.Label();
            this.pbOccupied = new System.Windows.Forms.PictureBox();
            this.lblTableOccupied = new System.Windows.Forms.Label();
            this.pbRunningOrder = new System.Windows.Forms.PictureBox();
            this.lblRunningOrder = new System.Windows.Forms.Label();
            this.lblDrinkOrder = new System.Windows.Forms.Label();
            this.pbDrinkIcon = new System.Windows.Forms.PictureBox();
            this.pbDishOrder = new System.Windows.Forms.PictureBox();
            this.lblDishOrder = new System.Windows.Forms.Label();
            this.lblShowInfo = new System.Windows.Forms.Label();
            tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrderReady)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrderServed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOccupied)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunningOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrinkIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDishOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrTimer
            // 
            tmrTimer.Enabled = true;
            tmrTimer.Interval = 60000;
            tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMoreInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoreInfo.Location = new System.Drawing.Point(-1, 714);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(100, 40);
            this.btnMoreInfo.TabIndex = 43;
            this.btnMoreInfo.Text = "Table Guide";
            this.btnMoreInfo.UseVisualStyleBackColor = false;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 33);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.userToolStripMenuItem.Text = "User";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lblTableOverview
            // 
            this.lblTableOverview.AutoSize = true;
            this.lblTableOverview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTableOverview.Location = new System.Drawing.Point(166, 33);
            this.lblTableOverview.Name = "lblTableOverview";
            this.lblTableOverview.Size = new System.Drawing.Size(143, 28);
            this.lblTableOverview.TabIndex = 45;
            this.lblTableOverview.Text = "Table Overview";
            // 
            // lblOrderReady
            // 
            this.lblOrderReady.AutoSize = true;
            this.lblOrderReady.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderReady.Location = new System.Drawing.Point(346, 102);
            this.lblOrderReady.Name = "lblOrderReady";
            this.lblOrderReady.Size = new System.Drawing.Size(124, 25);
            this.lblOrderReady.TabIndex = 46;
            this.lblOrderReady.Text = "Order is ready";
            this.lblOrderReady.Visible = false;
            // 
            // pbOrderReady
            // 
            this.pbOrderReady.BackColor = System.Drawing.Color.LightGreen;
            this.pbOrderReady.Location = new System.Drawing.Point(326, 104);
            this.pbOrderReady.Name = "pbOrderReady";
            this.pbOrderReady.Size = new System.Drawing.Size(20, 20);
            this.pbOrderReady.TabIndex = 47;
            this.pbOrderReady.TabStop = false;
            this.pbOrderReady.Visible = false;
            // 
            // pbOrderServed
            // 
            this.pbOrderServed.BackColor = System.Drawing.Color.Yellow;
            this.pbOrderServed.Location = new System.Drawing.Point(326, 130);
            this.pbOrderServed.Name = "pbOrderServed";
            this.pbOrderServed.Size = new System.Drawing.Size(20, 20);
            this.pbOrderServed.TabIndex = 48;
            this.pbOrderServed.TabStop = false;
            this.pbOrderServed.Visible = false;
            // 
            // lblOrderServed
            // 
            this.lblOrderServed.AutoSize = true;
            this.lblOrderServed.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderServed.Location = new System.Drawing.Point(346, 128);
            this.lblOrderServed.Name = "lblOrderServed";
            this.lblOrderServed.Size = new System.Drawing.Size(132, 25);
            this.lblOrderServed.TabIndex = 49;
            this.lblOrderServed.Text = "Order is served";
            this.lblOrderServed.Visible = false;
            // 
            // pbEmpty
            // 
            this.pbEmpty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbEmpty.Location = new System.Drawing.Point(154, 78);
            this.pbEmpty.Name = "pbEmpty";
            this.pbEmpty.Size = new System.Drawing.Size(20, 20);
            this.pbEmpty.TabIndex = 50;
            this.pbEmpty.TabStop = false;
            this.pbEmpty.Visible = false;
            // 
            // lblTableFree
            // 
            this.lblTableFree.AutoSize = true;
            this.lblTableFree.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTableFree.Location = new System.Drawing.Point(174, 76);
            this.lblTableFree.Name = "lblTableFree";
            this.lblTableFree.Size = new System.Drawing.Size(104, 25);
            this.lblTableFree.TabIndex = 51;
            this.lblTableFree.Text = "Table is free";
            this.lblTableFree.Visible = false;
            // 
            // pbOccupied
            // 
            this.pbOccupied.BackColor = System.Drawing.Color.Red;
            this.pbOccupied.Location = new System.Drawing.Point(154, 104);
            this.pbOccupied.Name = "pbOccupied";
            this.pbOccupied.Size = new System.Drawing.Size(20, 20);
            this.pbOccupied.TabIndex = 52;
            this.pbOccupied.TabStop = false;
            this.pbOccupied.Visible = false;
            // 
            // lblTableOccupied
            // 
            this.lblTableOccupied.AutoSize = true;
            this.lblTableOccupied.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTableOccupied.Location = new System.Drawing.Point(174, 102);
            this.lblTableOccupied.Name = "lblTableOccupied";
            this.lblTableOccupied.Size = new System.Drawing.Size(146, 25);
            this.lblTableOccupied.TabIndex = 53;
            this.lblTableOccupied.Text = "Table is occupied";
            this.lblTableOccupied.Visible = false;
            // 
            // pbRunningOrder
            // 
            this.pbRunningOrder.BackColor = System.Drawing.Color.LightBlue;
            this.pbRunningOrder.Location = new System.Drawing.Point(326, 78);
            this.pbRunningOrder.Name = "pbRunningOrder";
            this.pbRunningOrder.Size = new System.Drawing.Size(20, 20);
            this.pbRunningOrder.TabIndex = 54;
            this.pbRunningOrder.TabStop = false;
            this.pbRunningOrder.Visible = false;
            // 
            // lblRunningOrder
            // 
            this.lblRunningOrder.AutoSize = true;
            this.lblRunningOrder.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRunningOrder.Location = new System.Drawing.Point(346, 76);
            this.lblRunningOrder.Name = "lblRunningOrder";
            this.lblRunningOrder.Size = new System.Drawing.Size(129, 25);
            this.lblRunningOrder.TabIndex = 55;
            this.lblRunningOrder.Text = "Running Order";
            this.lblRunningOrder.Visible = false;
            // 
            // lblDrinkOrder
            // 
            this.lblDrinkOrder.AutoSize = true;
            this.lblDrinkOrder.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDrinkOrder.Location = new System.Drawing.Point(37, 102);
            this.lblDrinkOrder.Name = "lblDrinkOrder";
            this.lblDrinkOrder.Size = new System.Drawing.Size(105, 25);
            this.lblDrinkOrder.TabIndex = 56;
            this.lblDrinkOrder.Text = "Drink Order";
            this.lblDrinkOrder.Visible = false;
            // 
            // pbDrinkIcon
            // 
            this.pbDrinkIcon.BackColor = System.Drawing.SystemColors.Control;
            this.pbDrinkIcon.Image = global::RosUI.Properties.Resources.icons8_martini_glass_32;
            this.pbDrinkIcon.Location = new System.Drawing.Point(4, 98);
            this.pbDrinkIcon.Name = "pbDrinkIcon";
            this.pbDrinkIcon.Size = new System.Drawing.Size(32, 28);
            this.pbDrinkIcon.TabIndex = 57;
            this.pbDrinkIcon.TabStop = false;
            this.pbDrinkIcon.Visible = false;
            // 
            // pbDishOrder
            // 
            this.pbDishOrder.BackColor = System.Drawing.SystemColors.Control;
            this.pbDishOrder.Image = global::RosUI.Properties.Resources.icons8_dinner_32;
            this.pbDishOrder.Location = new System.Drawing.Point(5, 65);
            this.pbDishOrder.Name = "pbDishOrder";
            this.pbDishOrder.Size = new System.Drawing.Size(32, 32);
            this.pbDishOrder.TabIndex = 58;
            this.pbDishOrder.TabStop = false;
            this.pbDishOrder.Visible = false;
            // 
            // lblDishOrder
            // 
            this.lblDishOrder.AutoSize = true;
            this.lblDishOrder.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDishOrder.Location = new System.Drawing.Point(37, 75);
            this.lblDishOrder.Name = "lblDishOrder";
            this.lblDishOrder.Size = new System.Drawing.Size(98, 25);
            this.lblDishOrder.TabIndex = 59;
            this.lblDishOrder.Text = "Dish Order";
            this.lblDishOrder.Visible = false;
            // 
            // lblShowInfo
            // 
            this.lblShowInfo.AutoSize = true;
            this.lblShowInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowInfo.Location = new System.Drawing.Point(392, 53);
            this.lblShowInfo.Name = "lblShowInfo";
            this.lblShowInfo.Size = new System.Drawing.Size(86, 23);
            this.lblShowInfo.TabIndex = 60;
            this.lblShowInfo.Text = "Show Info";
            this.lblShowInfo.Click += new System.EventHandler(this.lblShowInfo_Click);
            // 
            // TableOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 753);
            this.Controls.Add(this.lblShowInfo);
            this.Controls.Add(this.lblDishOrder);
            this.Controls.Add(this.pbDishOrder);
            this.Controls.Add(this.pbDrinkIcon);
            this.Controls.Add(this.lblDrinkOrder);
            this.Controls.Add(this.lblRunningOrder);
            this.Controls.Add(this.pbRunningOrder);
            this.Controls.Add(this.lblTableOccupied);
            this.Controls.Add(this.pbOccupied);
            this.Controls.Add(this.lblTableFree);
            this.Controls.Add(this.pbEmpty);
            this.Controls.Add(this.lblOrderServed);
            this.Controls.Add(this.pbOrderServed);
            this.Controls.Add(this.pbOrderReady);
            this.Controls.Add(this.lblOrderReady);
            this.Controls.Add(this.lblTableOverview);
            this.Controls.Add(this.btnMoreInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableOverview";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrderReady)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrderServed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOccupied)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunningOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrinkIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDishOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMoreInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label lblTableOverview;
        private System.Windows.Forms.Label lblOrderReady;
        private System.Windows.Forms.PictureBox pbOrderReady;
        private System.Windows.Forms.PictureBox pbOrderServed;
        private System.Windows.Forms.Label lblOrderServed;
        private System.Windows.Forms.PictureBox pbEmpty;
        private System.Windows.Forms.Label lblTableFree;
        private System.Windows.Forms.PictureBox pbOccupied;
        private System.Windows.Forms.Label lblTableOccupied;
        private System.Windows.Forms.PictureBox pbRunningOrder;
        private System.Windows.Forms.Label lblRunningOrder;
        private System.Windows.Forms.Label lblDrinkOrder;
        private System.Windows.Forms.PictureBox pbDrinkIcon;
        private System.Windows.Forms.PictureBox pbDishOrder;
        private System.Windows.Forms.Label lblDishOrder;
        private System.Windows.Forms.Label lblShowInfo;
    }
}