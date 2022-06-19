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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblOrderServed = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTableFree = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTableOccupied = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblRunningOrder = new System.Windows.Forms.Label();
            this.lblDrinkOrder = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblDishOrder = new System.Windows.Forms.Label();
            tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
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
            this.lblOrderReady.Location = new System.Drawing.Point(362, 104);
            this.lblOrderReady.Name = "lblOrderReady";
            this.lblOrderReady.Size = new System.Drawing.Size(102, 20);
            this.lblOrderReady.TabIndex = 46;
            this.lblOrderReady.Text = "Order is ready";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Location = new System.Drawing.Point(336, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox2.Location = new System.Drawing.Point(336, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // lblOrderServed
            // 
            this.lblOrderServed.AutoSize = true;
            this.lblOrderServed.Location = new System.Drawing.Point(362, 130);
            this.lblOrderServed.Name = "lblOrderServed";
            this.lblOrderServed.Size = new System.Drawing.Size(108, 20);
            this.lblOrderServed.TabIndex = 49;
            this.lblOrderServed.Text = "Order is served";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox3.Location = new System.Drawing.Point(160, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // lblTableFree
            // 
            this.lblTableFree.AutoSize = true;
            this.lblTableFree.Location = new System.Drawing.Point(186, 78);
            this.lblTableFree.Name = "lblTableFree";
            this.lblTableFree.Size = new System.Drawing.Size(88, 20);
            this.lblTableFree.TabIndex = 51;
            this.lblTableFree.Text = "Table is free";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Red;
            this.pictureBox4.Location = new System.Drawing.Point(160, 104);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            // 
            // lblTableOccupied
            // 
            this.lblTableOccupied.AutoSize = true;
            this.lblTableOccupied.Location = new System.Drawing.Point(186, 104);
            this.lblTableOccupied.Name = "lblTableOccupied";
            this.lblTableOccupied.Size = new System.Drawing.Size(123, 20);
            this.lblTableOccupied.TabIndex = 53;
            this.lblTableOccupied.Text = "Table is occupied";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox5.Location = new System.Drawing.Point(336, 78);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.TabIndex = 54;
            this.pictureBox5.TabStop = false;
            // 
            // lblRunningOrder
            // 
            this.lblRunningOrder.AutoSize = true;
            this.lblRunningOrder.Location = new System.Drawing.Point(362, 78);
            this.lblRunningOrder.Name = "lblRunningOrder";
            this.lblRunningOrder.Size = new System.Drawing.Size(105, 20);
            this.lblRunningOrder.TabIndex = 55;
            this.lblRunningOrder.Text = "Running Order";
            // 
            // lblDrinkOrder
            // 
            this.lblDrinkOrder.AutoSize = true;
            this.lblDrinkOrder.Location = new System.Drawing.Point(43, 106);
            this.lblDrinkOrder.Name = "lblDrinkOrder";
            this.lblDrinkOrder.Size = new System.Drawing.Size(86, 20);
            this.lblDrinkOrder.TabIndex = 56;
            this.lblDrinkOrder.Text = "Drink Order";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox6.Image = global::RosUI.Properties.Resources.icons8_martini_glass_32;
            this.pictureBox6.Location = new System.Drawing.Point(10, 98);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 28);
            this.pictureBox6.TabIndex = 57;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox7.Image = global::RosUI.Properties.Resources.icons8_dinner_32;
            this.pictureBox7.Location = new System.Drawing.Point(11, 65);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.TabIndex = 58;
            this.pictureBox7.TabStop = false;
            // 
            // lblDishOrder
            // 
            this.lblDishOrder.AutoSize = true;
            this.lblDishOrder.Location = new System.Drawing.Point(43, 77);
            this.lblDishOrder.Name = "lblDishOrder";
            this.lblDishOrder.Size = new System.Drawing.Size(80, 20);
            this.lblDishOrder.TabIndex = 59;
            this.lblDishOrder.Text = "Dish Order";
            // 
            // TableOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 753);
            this.Controls.Add(this.lblDishOrder);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblDrinkOrder);
            this.Controls.Add(this.lblRunningOrder);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblTableOccupied);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblTableFree);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblOrderServed);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblOrderServed;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTableFree;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblTableOccupied;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblRunningOrder;
        private System.Windows.Forms.Label lblDrinkOrder;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblDishOrder;
    }
}