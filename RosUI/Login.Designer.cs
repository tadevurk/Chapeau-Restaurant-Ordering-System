namespace RosUI
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.lblPinCode = new System.Windows.Forms.Label();
            this.pbChapeauLogo = new System.Windows.Forms.PictureBox();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbChapeauLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(190, 450);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Location = new System.Drawing.Point(190, 530);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 40);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(178, 230);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(125, 27);
            this.txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(177, 207);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // txtPinCode
            // 
            this.txtPinCode.Location = new System.Drawing.Point(178, 330);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(125, 27);
            this.txtPinCode.TabIndex = 5;
            this.txtPinCode.UseSystemPasswordChar = true;
            // 
            // lblPinCode
            // 
            this.lblPinCode.AutoSize = true;
            this.lblPinCode.Location = new System.Drawing.Point(177, 307);
            this.lblPinCode.Name = "lblPinCode";
            this.lblPinCode.Size = new System.Drawing.Size(64, 20);
            this.lblPinCode.TabIndex = 7;
            this.lblPinCode.Text = "PinCode";
            // 
            // pbChapeauLogo
            // 
            this.pbChapeauLogo.Image = global::RosUI.Properties.Resources.ChapeauLogo;
            this.pbChapeauLogo.Location = new System.Drawing.Point(140, 37);
            this.pbChapeauLogo.Name = "pbChapeauLogo";
            this.pbChapeauLogo.Size = new System.Drawing.Size(198, 103);
            this.pbChapeauLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChapeauLogo.TabIndex = 8;
            this.pbChapeauLogo.TabStop = false;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblForgotPassword.Location = new System.Drawing.Point(179, 367);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(125, 20);
            this.lblForgotPassword.TabIndex = 9;
            this.lblForgotPassword.Text = "Forgot Password?";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 753);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.pbChapeauLogo);
            this.Controls.Add(this.lblPinCode);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbChapeauLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.Label lblPinCode;
        private System.Windows.Forms.PictureBox pbChapeauLogo;
        private System.Windows.Forms.Label lblForgotPassword;
    }
}