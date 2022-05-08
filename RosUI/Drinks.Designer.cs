
namespace RosUI
{
    partial class Drinks
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
            this.btnHeineken = new System.Windows.Forms.Button();
            this.btnJupiler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHeineken
            // 
            this.btnHeineken.Location = new System.Drawing.Point(46, 63);
            this.btnHeineken.Name = "btnHeineken";
            this.btnHeineken.Size = new System.Drawing.Size(207, 87);
            this.btnHeineken.TabIndex = 0;
            this.btnHeineken.Text = "Heineken Beer";
            this.btnHeineken.UseVisualStyleBackColor = true;
            // 
            // btnJupiler
            // 
            this.btnJupiler.Location = new System.Drawing.Point(384, 63);
            this.btnJupiler.Name = "btnJupiler";
            this.btnJupiler.Size = new System.Drawing.Size(207, 87);
            this.btnJupiler.TabIndex = 1;
            this.btnJupiler.Text = "Jupiler Beer";
            this.btnJupiler.UseVisualStyleBackColor = true;
            // 
            // Drinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJupiler);
            this.Controls.Add(this.btnHeineken);
            this.Name = "Drinks";
            this.Text = "Drinks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHeineken;
        private System.Windows.Forms.Button btnJupiler;
    }
}