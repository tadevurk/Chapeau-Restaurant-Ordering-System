
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
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCompletePayment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtToPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSubTotalAmount = new System.Windows.Forms.Label();
            this.pnlFeedback = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.pnlSplit = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitSplit = new System.Windows.Forms.Button();
            this.radioBtnSplitDebit = new System.Windows.Forms.RadioButton();
            this.radioBtnSplitVisa = new System.Windows.Forms.RadioButton();
            this.radioBtnSplitCash = new System.Windows.Forms.RadioButton();
            this.txtTipSplit = new System.Windows.Forms.TextBox();
            this.txtToPaySplit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlFeedback.SuspendLayout();
            this.pnlSplit.SuspendLayout();
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
            this.listViewPayment.FullRowSelect = true;
            this.listViewPayment.HideSelection = false;
            this.listViewPayment.Location = new System.Drawing.Point(12, 65);
            this.listViewPayment.Name = "listViewPayment";
            this.listViewPayment.Size = new System.Drawing.Size(458, 264);
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
            this.Item.Width = 150;
            // 
            // VAT
            // 
            this.VAT.Text = "VAT";
            this.VAT.Width = 55;
            // 
            // Subtotal
            // 
            this.Subtotal.Text = "Subtotal";
            this.Subtotal.Width = 95;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 105;
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTableNumber.Location = new System.Drawing.Point(82, 23);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(0, 23);
            this.lblTableNumber.TabIndex = 1;
            // 
            // radioBtnCash
            // 
            this.radioBtnCash.AutoSize = true;
            this.radioBtnCash.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnCash.Location = new System.Drawing.Point(47, 514);
            this.radioBtnCash.Name = "radioBtnCash";
            this.radioBtnCash.Size = new System.Drawing.Size(79, 29);
            this.radioBtnCash.TabIndex = 2;
            this.radioBtnCash.TabStop = true;
            this.radioBtnCash.Text = "CASH";
            this.radioBtnCash.UseVisualStyleBackColor = true;
            this.radioBtnCash.CheckedChanged += new System.EventHandler(this.radioBtnCash_CheckedChanged);
            // 
            // radioBtnVisa
            // 
            this.radioBtnVisa.AutoSize = true;
            this.radioBtnVisa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnVisa.Location = new System.Drawing.Point(175, 514);
            this.radioBtnVisa.Name = "radioBtnVisa";
            this.radioBtnVisa.Size = new System.Drawing.Size(71, 29);
            this.radioBtnVisa.TabIndex = 3;
            this.radioBtnVisa.TabStop = true;
            this.radioBtnVisa.Text = "VISA";
            this.radioBtnVisa.UseVisualStyleBackColor = true;
            this.radioBtnVisa.CheckedChanged += new System.EventHandler(this.radioBtnVisa_CheckedChanged);
            // 
            // radioBtnDebit
            // 
            this.radioBtnDebit.AutoSize = true;
            this.radioBtnDebit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnDebit.Location = new System.Drawing.Point(304, 514);
            this.radioBtnDebit.Name = "radioBtnDebit";
            this.radioBtnDebit.Size = new System.Drawing.Size(79, 29);
            this.radioBtnDebit.TabIndex = 4;
            this.radioBtnDebit.TabStop = true;
            this.radioBtnDebit.Text = "DEBIT";
            this.radioBtnDebit.UseVisualStyleBackColor = true;
            this.radioBtnDebit.CheckedChanged += new System.EventHandler(this.radioBtnDebit_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(303, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "TOTAL:";
            // 
            // txtTip
            // 
            this.txtTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTip.Location = new System.Drawing.Point(91, 441);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(87, 27);
            this.txtTip.TabIndex = 7;
            this.txtTip.TextChanged += new System.EventHandler(this.txtTip_TextChanged);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAmount.Location = new System.Drawing.Point(377, 361);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(44, 22);
            this.lblTotalAmount.TabIndex = 8;
            this.lblTotalAmount.Text = "total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(260, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "TO PAY:";
            // 
            // btnCompletePayment
            // 
            this.btnCompletePayment.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCompletePayment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompletePayment.Location = new System.Drawing.Point(12, 657);
            this.btnCompletePayment.Name = "btnCompletePayment";
            this.btnCompletePayment.Size = new System.Drawing.Size(458, 59);
            this.btnCompletePayment.TabIndex = 12;
            this.btnCompletePayment.Text = "CLOSE BILL";
            this.btnCompletePayment.UseVisualStyleBackColor = false;
            this.btnCompletePayment.Click += new System.EventHandler(this.btnCompletePayment_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(361, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 29);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtToPay
            // 
            this.txtToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToPay.Location = new System.Drawing.Point(340, 441);
            this.txtToPay.Name = "txtToPay";
            this.txtToPay.Size = new System.Drawing.Size(87, 27);
            this.txtToPay.TabIndex = 16;
            this.txtToPay.TextChanged += new System.EventHandler(this.txtToPay_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "SUBTOTAL:";
            // 
            // lblSubTotalAmount
            // 
            this.lblSubTotalAmount.AutoSize = true;
            this.lblSubTotalAmount.BackColor = System.Drawing.Color.White;
            this.lblSubTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotalAmount.Location = new System.Drawing.Point(110, 363);
            this.lblSubTotalAmount.Name = "lblSubTotalAmount";
            this.lblSubTotalAmount.Size = new System.Drawing.Size(68, 20);
            this.lblSubTotalAmount.TabIndex = 19;
            this.lblSubTotalAmount.Text = "subtotal";
            // 
            // pnlFeedback
            // 
            this.pnlFeedback.Controls.Add(this.btnSubmit);
            this.pnlFeedback.Controls.Add(this.txtFeedback);
            this.pnlFeedback.Location = new System.Drawing.Point(12, 414);
            this.pnlFeedback.Name = "pnlFeedback";
            this.pnlFeedback.Size = new System.Drawing.Size(458, 222);
            this.pnlFeedback.TabIndex = 20;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubmit.Location = new System.Drawing.Point(125, 145);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(209, 47);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(16, 15);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(419, 107);
            this.txtFeedback.TabIndex = 0;
            this.txtFeedback.TextChanged += new System.EventHandler(this.txtFeedback_TextChanged);
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSplit.Location = new System.Drawing.Point(137, 589);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(209, 47);
            this.btnSplit.TabIndex = 2;
            this.btnSplit.Text = "SPLIT";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // pnlSplit
            // 
            this.pnlSplit.Controls.Add(this.label9);
            this.pnlSplit.Controls.Add(this.label8);
            this.pnlSplit.Controls.Add(this.label7);
            this.pnlSplit.Controls.Add(this.label1);
            this.pnlSplit.Controls.Add(this.btnSubmitSplit);
            this.pnlSplit.Controls.Add(this.radioBtnSplitDebit);
            this.pnlSplit.Controls.Add(this.radioBtnSplitVisa);
            this.pnlSplit.Controls.Add(this.radioBtnSplitCash);
            this.pnlSplit.Controls.Add(this.txtTipSplit);
            this.pnlSplit.Controls.Add(this.txtToPaySplit);
            this.pnlSplit.Location = new System.Drawing.Point(12, 65);
            this.pnlSplit.Name = "pnlSplit";
            this.pnlSplit.Size = new System.Drawing.Size(458, 656);
            this.pnlSplit.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(310, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "€";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(310, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "€";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(85, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tip:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "To Pay:";
            // 
            // btnSubmitSplit
            // 
            this.btnSubmitSplit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubmitSplit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitSplit.Location = new System.Drawing.Point(73, 488);
            this.btnSubmitSplit.Name = "btnSubmitSplit";
            this.btnSubmitSplit.Size = new System.Drawing.Size(298, 61);
            this.btnSubmitSplit.TabIndex = 25;
            this.btnSubmitSplit.Text = "SUBMIT";
            this.btnSubmitSplit.UseVisualStyleBackColor = false;
            this.btnSubmitSplit.Click += new System.EventHandler(this.btnSubmitSplit_Click);
            // 
            // radioBtnSplitDebit
            // 
            this.radioBtnSplitDebit.AutoSize = true;
            this.radioBtnSplitDebit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnSplitDebit.Location = new System.Drawing.Point(280, 383);
            this.radioBtnSplitDebit.Name = "radioBtnSplitDebit";
            this.radioBtnSplitDebit.Size = new System.Drawing.Size(79, 29);
            this.radioBtnSplitDebit.TabIndex = 24;
            this.radioBtnSplitDebit.TabStop = true;
            this.radioBtnSplitDebit.Text = "DEBIT";
            this.radioBtnSplitDebit.UseVisualStyleBackColor = true;
            this.radioBtnSplitDebit.CheckedChanged += new System.EventHandler(this.radioBtnSplitDebit_CheckedChanged);
            // 
            // radioBtnSplitVisa
            // 
            this.radioBtnSplitVisa.AutoSize = true;
            this.radioBtnSplitVisa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnSplitVisa.Location = new System.Drawing.Point(180, 328);
            this.radioBtnSplitVisa.Name = "radioBtnSplitVisa";
            this.radioBtnSplitVisa.Size = new System.Drawing.Size(71, 29);
            this.radioBtnSplitVisa.TabIndex = 23;
            this.radioBtnSplitVisa.TabStop = true;
            this.radioBtnSplitVisa.Text = "VISA";
            this.radioBtnSplitVisa.UseVisualStyleBackColor = true;
            this.radioBtnSplitVisa.CheckedChanged += new System.EventHandler(this.radioBtnSplitVisa_CheckedChanged);
            // 
            // radioBtnSplitCash
            // 
            this.radioBtnSplitCash.AutoSize = true;
            this.radioBtnSplitCash.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnSplitCash.Location = new System.Drawing.Point(73, 270);
            this.radioBtnSplitCash.Name = "radioBtnSplitCash";
            this.radioBtnSplitCash.Size = new System.Drawing.Size(79, 29);
            this.radioBtnSplitCash.TabIndex = 22;
            this.radioBtnSplitCash.TabStop = true;
            this.radioBtnSplitCash.Text = "CASH";
            this.radioBtnSplitCash.UseVisualStyleBackColor = true;
            this.radioBtnSplitCash.CheckedChanged += new System.EventHandler(this.radioBtnSplitCash_CheckedChanged);
            // 
            // txtTipSplit
            // 
            this.txtTipSplit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipSplit.Location = new System.Drawing.Point(163, 148);
            this.txtTipSplit.Multiline = true;
            this.txtTipSplit.Name = "txtTipSplit";
            this.txtTipSplit.Size = new System.Drawing.Size(141, 44);
            this.txtTipSplit.TabIndex = 21;
            // 
            // txtToPaySplit
            // 
            this.txtToPaySplit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToPaySplit.Location = new System.Drawing.Point(163, 65);
            this.txtToPaySplit.Multiline = true;
            this.txtToPaySplit.Name = "txtToPaySplit";
            this.txtToPaySplit.Size = new System.Drawing.Size(141, 44);
            this.txtToPaySplit.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(47, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "TIP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Table #";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(175, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "€";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(432, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "€";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(175, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 25);
            this.label12.TabIndex = 31;
            this.label12.Text = "€";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(423, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "€";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 753);
            this.Controls.Add(this.pnlSplit);
            this.Controls.Add(this.pnlFeedback);
            this.Controls.Add(this.txtToPay);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnDebit);
            this.Controls.Add(this.radioBtnVisa);
            this.Controls.Add(this.radioBtnCash);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnCompletePayment);
            this.Controls.Add(this.lblSubTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.listViewPayment);
            this.Name = "FormPayment";
            this.Text = " Payment";
            this.pnlFeedback.ResumeLayout(false);
            this.pnlFeedback.PerformLayout();
            this.pnlSplit.ResumeLayout(false);
            this.pnlSplit.PerformLayout();
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
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCompletePayment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtToPay;
        private System.Windows.Forms.ColumnHeader ColumnHeadings;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader VAT;
        private System.Windows.Forms.ColumnHeader Subtotal;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubTotalAmount;
        private System.Windows.Forms.Panel pnlFeedback;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Panel pnlSplit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitSplit;
        private System.Windows.Forms.RadioButton radioBtnSplitDebit;
        private System.Windows.Forms.RadioButton radioBtnSplitVisa;
        private System.Windows.Forms.RadioButton radioBtnSplitCash;
        private System.Windows.Forms.TextBox txtTipSplit;
        private System.Windows.Forms.TextBox txtToPaySplit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}