
namespace RosUI
{
    partial class FormPayment
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
            this.listViewPayment = new System.Windows.Forms.ListView();
            this.ColumnHeadings = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.Item = new System.Windows.Forms.ColumnHeader();
            this.VAT = new System.Windows.Forms.ColumnHeader();
            this.Subtotal = new System.Windows.Forms.ColumnHeader();
            this.Total = new System.Windows.Forms.ColumnHeader();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.radioBtnCash = new System.Windows.Forms.RadioButton();
            this.radioBtnVisa = new System.Windows.Forms.RadioButton();
            this.radioBtnDebit = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCompletePayment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtFeedback = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToPay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewPayment
            // 
            this.listViewPayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeadings,
            this.Amount,
            this.Item,
            this.VAT,
            this.Subtotal,
            this.Total});
            this.listViewPayment.HideSelection = false;
            this.listViewPayment.Location = new System.Drawing.Point(12, 49);
            this.listViewPayment.Name = "listViewPayment";
            this.listViewPayment.Size = new System.Drawing.Size(495, 215);
            this.listViewPayment.TabIndex = 0;
            this.listViewPayment.UseCompatibleStateImageBehavior = false;
            this.listViewPayment.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeadings
            // 
            this.ColumnHeadings.Text = "";
            this.ColumnHeadings.Width = 0;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 65;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 160;
            // 
            // VAT
            // 
            this.VAT.Text = "VAT";
            this.VAT.Width = 55;
            // 
            // Subtotal
            // 
            this.Subtotal.Text = "Subtotal";
            this.Subtotal.Width = 105;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 105;
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(71, 14);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(0, 20);
            this.lblTableNumber.TabIndex = 1;
            // 
            // radioBtnCash
            // 
            this.radioBtnCash.AutoSize = true;
            this.radioBtnCash.Location = new System.Drawing.Point(86, 406);
            this.radioBtnCash.Name = "radioBtnCash";
            this.radioBtnCash.Size = new System.Drawing.Size(68, 24);
            this.radioBtnCash.TabIndex = 2;
            this.radioBtnCash.TabStop = true;
            this.radioBtnCash.Text = "CASH";
            this.radioBtnCash.UseVisualStyleBackColor = true;
            this.radioBtnCash.CheckedChanged += new System.EventHandler(this.radioBtnCash_CheckedChanged);
            // 
            // radioBtnVisa
            // 
            this.radioBtnVisa.AutoSize = true;
            this.radioBtnVisa.Location = new System.Drawing.Point(214, 406);
            this.radioBtnVisa.Name = "radioBtnVisa";
            this.radioBtnVisa.Size = new System.Drawing.Size(61, 24);
            this.radioBtnVisa.TabIndex = 3;
            this.radioBtnVisa.TabStop = true;
            this.radioBtnVisa.Text = "VISA";
            this.radioBtnVisa.UseVisualStyleBackColor = true;
            this.radioBtnVisa.CheckedChanged += new System.EventHandler(this.radioBtnVisa_CheckedChanged);
            // 
            // radioBtnDebit
            // 
            this.radioBtnDebit.AutoSize = true;
            this.radioBtnDebit.Location = new System.Drawing.Point(343, 406);
            this.radioBtnDebit.Name = "radioBtnDebit";
            this.radioBtnDebit.Size = new System.Drawing.Size(70, 24);
            this.radioBtnDebit.TabIndex = 4;
            this.radioBtnDebit.TabStop = true;
            this.radioBtnDebit.Text = "DEBIT";
            this.radioBtnDebit.UseVisualStyleBackColor = true;
            this.radioBtnDebit.CheckedChanged += new System.EventHandler(this.radioBtnDebit_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "BILL AMOUNT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "TIP AMOUNT:";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(147, 344);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(89, 27);
            this.txtTip.TabIndex = 7;
            this.txtTip.TextChanged += new System.EventHandler(this.txtTip_TextChanged);
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBillAmount.Location = new System.Drawing.Point(147, 296);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(50, 20);
            this.lblBillAmount.TabIndex = 8;
            this.lblBillAmount.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "TO PAY:";
            // 
            // btnCompletePayment
            // 
            this.btnCompletePayment.BackColor = System.Drawing.Color.Lime;
            this.btnCompletePayment.Location = new System.Drawing.Point(282, 619);
            this.btnCompletePayment.Name = "btnCompletePayment";
            this.btnCompletePayment.Size = new System.Drawing.Size(225, 75);
            this.btnCompletePayment.TabIndex = 12;
            this.btnCompletePayment.Text = "COMPLETE PAYMENT";
            this.btnCompletePayment.UseVisualStyleBackColor = false;
            this.btnCompletePayment.Click += new System.EventHandler(this.btnCompletePayment_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(409, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 29);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(12, 496);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(495, 81);
            this.txtFeedback.TabIndex = 14;
            this.txtFeedback.Text = "";
            this.txtFeedback.TextChanged += new System.EventHandler(this.txtFeedback_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "FEEDBACK:";
            // 
            // txtToPay
            // 
            this.txtToPay.Location = new System.Drawing.Point(409, 344);
            this.txtToPay.Name = "txtToPay";
            this.txtToPay.Size = new System.Drawing.Size(89, 27);
            this.txtToPay.TabIndex = 16;
            this.txtToPay.TextChanged += new System.EventHandler(this.txtToPay_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Table #";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 731);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtToPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCompletePayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBillAmount);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnDebit);
            this.Controls.Add(this.radioBtnVisa);
            this.Controls.Add(this.radioBtnCash);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.listViewPayment);
            this.Name = "FormPayment";
            this.Text = " Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPayment;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.RadioButton radioBtnCash;
        private System.Windows.Forms.RadioButton radioBtnVisa;
        private System.Windows.Forms.RadioButton radioBtnDebit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCompletePayment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox txtFeedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToPay;
        private System.Windows.Forms.ColumnHeader ColumnHeadings;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader VAT;
        private System.Windows.Forms.ColumnHeader Subtotal;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label label5;
    }
}