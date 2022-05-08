
namespace RosUI
{
    partial class Starters
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
            this.btnSandvich = new System.Windows.Forms.Button();
            this.btnSoup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSandvich
            // 
            this.btnSandvich.Location = new System.Drawing.Point(45, 365);
            this.btnSandvich.Name = "btnSandvich";
            this.btnSandvich.Size = new System.Drawing.Size(183, 59);
            this.btnSandvich.TabIndex = 0;
            this.btnSandvich.Text = "Sandvich";
            this.btnSandvich.UseVisualStyleBackColor = true;
            this.btnSandvich.Click += new System.EventHandler(this.btnSandvich_Click);
            // 
            // btnSoup
            // 
            this.btnSoup.Location = new System.Drawing.Point(381, 365);
            this.btnSoup.Name = "btnSoup";
            this.btnSoup.Size = new System.Drawing.Size(183, 59);
            this.btnSoup.TabIndex = 2;
            this.btnSoup.Text = "Fish Soup";
            this.btnSoup.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(401, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(11, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(582, 264);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Starters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSoup);
            this.Controls.Add(this.btnSandvich);
            this.Name = "Starters";
            this.Text = "Starters";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSandvich;
        private System.Windows.Forms.Button btnSoup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
    }
}