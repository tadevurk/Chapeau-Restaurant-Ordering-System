
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.listViewPayment = new System.Windows.Forms.ListView();
            this.ColumnHeadings = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Item = new System.Windows.Forms.ColumnHeader();
            this.VAT = new System.Windows.Forms.ColumnHeader();
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
            this.txtToPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSubTotalAmount = new System.Windows.Forms.Label();
            this.pnlFeedback = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.pnlSplit = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSplitVat21 = new System.Windows.Forms.Label();
            this.lblSplitVat6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtToPaySplit = new System.Windows.Forms.TextBox();
            this.txtTipSplit = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.radioBtnSplitDebit = new System.Windows.Forms.RadioButton();
            this.radioBtnSplitVisa = new System.Windows.Forms.RadioButton();
            this.radioBtnSplitCash = new System.Windows.Forms.RadioButton();
            this.btnSplitPay = new System.Windows.Forms.Button();
            this.lblSplitSub = new System.Windows.Forms.Label();
            this.lblSplitTotal = new System.Windows.Forms.Label();
            this.btnBackSplit = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblVat6 = new System.Windows.Forms.Label();
            this.lblVat21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.pnlFeedback.SuspendLayout();
            this.pnlSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewPayment
            // 
            this.listViewPayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeadings,
            this.Quantity,
            this.Item,
            this.VAT,
            this.Total});
            this.listViewPayment.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewPayment.FullRowSelect = true;
            this.listViewPayment.HideSelection = false;
            this.listViewPayment.Location = new System.Drawing.Point(12, 65);
            this.listViewPayment.Name = "listViewPayment";
            this.listViewPayment.Size = new System.Drawing.Size(458, 283);
            this.listViewPayment.TabIndex = 0;
            this.listViewPayment.UseCompatibleStateImageBehavior = false;
            this.listViewPayment.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeadings
            // 
            this.ColumnHeadings.Text = "";
            this.ColumnHeadings.Width = 0;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Qnt";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.Width = 65;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 185;
            // 
            // VAT
            // 
            this.VAT.Text = "VAT";
            this.VAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VAT.Width = 85;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Total.Width = 115;
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
            this.radioBtnCash.Location = new System.Drawing.Point(67, 547);
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
            this.radioBtnVisa.Location = new System.Drawing.Point(195, 547);
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
            this.radioBtnDebit.Location = new System.Drawing.Point(324, 547);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(280, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "TOTAL: €";
            // 
            // txtTip
            // 
            this.txtTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTip.Location = new System.Drawing.Point(101, 496);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(87, 28);
            this.txtTip.TabIndex = 7;
            this.txtTip.TextChanged += new System.EventHandler(this.txtTip_TextChanged);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.White;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAmount.Location = new System.Drawing.Point(376, 411);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(44, 22);
            this.lblTotalAmount.TabIndex = 8;
            this.lblTotalAmount.Text = "total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(241, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "TO PAY: €";
            // 
            // btnCompletePayment
            // 
            this.btnCompletePayment.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCompletePayment.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompletePayment.Location = new System.Drawing.Point(290, 648);
            this.btnCompletePayment.Name = "btnCompletePayment";
            this.btnCompletePayment.Size = new System.Drawing.Size(180, 55);
            this.btnCompletePayment.TabIndex = 12;
            this.btnCompletePayment.Text = "PAY";
            this.btnCompletePayment.UseVisualStyleBackColor = false;
            this.btnCompletePayment.Click += new System.EventHandler(this.btnCompletePayment_Click);
            // 
            // txtToPay
            // 
            this.txtToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToPay.Location = new System.Drawing.Point(344, 496);
            this.txtToPay.Name = "txtToPay";
            this.txtToPay.Size = new System.Drawing.Size(87, 28);
            this.txtToPay.TabIndex = 16;
            this.txtToPay.TextChanged += new System.EventHandler(this.txtToPay_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(292, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Subtotal: €";
            // 
            // lblSubTotalAmount
            // 
            this.lblSubTotalAmount.AutoSize = true;
            this.lblSubTotalAmount.BackColor = System.Drawing.Color.White;
            this.lblSubTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotalAmount.Location = new System.Drawing.Point(376, 374);
            this.lblSubTotalAmount.Name = "lblSubTotalAmount";
            this.lblSubTotalAmount.Size = new System.Drawing.Size(68, 20);
            this.lblSubTotalAmount.TabIndex = 19;
            this.lblSubTotalAmount.Text = "subtotal";
            // 
            // pnlFeedback
            // 
            this.pnlFeedback.Controls.Add(this.btnSubmit);
            this.pnlFeedback.Controls.Add(this.txtFeedback);
            this.pnlFeedback.Location = new System.Drawing.Point(12, 437);
            this.pnlFeedback.Name = "pnlFeedback";
            this.pnlFeedback.Size = new System.Drawing.Size(454, 186);
            this.pnlFeedback.TabIndex = 20;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubmit.Location = new System.Drawing.Point(130, 128);
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
            // pnlSplit
            // 
            this.pnlSplit.Controls.Add(this.label10);
            this.pnlSplit.Controls.Add(this.label11);
            this.pnlSplit.Controls.Add(this.lblSplitVat21);
            this.pnlSplit.Controls.Add(this.lblSplitVat6);
            this.pnlSplit.Controls.Add(this.label18);
            this.pnlSplit.Controls.Add(this.label19);
            this.pnlSplit.Controls.Add(this.txtToPaySplit);
            this.pnlSplit.Controls.Add(this.txtTipSplit);
            this.pnlSplit.Controls.Add(this.label20);
            this.pnlSplit.Controls.Add(this.label21);
            this.pnlSplit.Controls.Add(this.label22);
            this.pnlSplit.Controls.Add(this.label23);
            this.pnlSplit.Controls.Add(this.radioBtnSplitDebit);
            this.pnlSplit.Controls.Add(this.radioBtnSplitVisa);
            this.pnlSplit.Controls.Add(this.radioBtnSplitCash);
            this.pnlSplit.Controls.Add(this.btnSplitPay);
            this.pnlSplit.Controls.Add(this.lblSplitSub);
            this.pnlSplit.Controls.Add(this.lblSplitTotal);
            this.pnlSplit.Controls.Add(this.btnBackSplit);
            this.pnlSplit.Location = new System.Drawing.Point(12, 66);
            this.pnlSplit.Name = "pnlSplit";
            this.pnlSplit.Size = new System.Drawing.Size(458, 638);
            this.pnlSplit.TabIndex = 21;
            this.pnlSplit.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSplit_Paint);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(25, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(394, 2);
            this.label10.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(26, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(394, 2);
            this.label11.TabIndex = 56;
            // 
            // lblSplitVat21
            // 
            this.lblSplitVat21.AutoSize = true;
            this.lblSplitVat21.BackColor = System.Drawing.Color.White;
            this.lblSplitVat21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSplitVat21.Location = new System.Drawing.Point(108, 124);
            this.lblSplitVat21.Name = "lblSplitVat21";
            this.lblSplitVat21.Size = new System.Drawing.Size(49, 20);
            this.lblSplitVat21.TabIndex = 55;
            this.lblSplitVat21.Text = "vat21";
            // 
            // lblSplitVat6
            // 
            this.lblSplitVat6.AutoSize = true;
            this.lblSplitVat6.BackColor = System.Drawing.Color.White;
            this.lblSplitVat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSplitVat6.Location = new System.Drawing.Point(108, 74);
            this.lblSplitVat6.Name = "lblSplitVat6";
            this.lblSplitVat6.Size = new System.Drawing.Size(40, 20);
            this.lblSplitVat6.TabIndex = 54;
            this.lblSplitVat6.Text = "vat6";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(26, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 18);
            this.label18.TabIndex = 53;
            this.label18.Text = "VAT 21% :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(34, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 18);
            this.label19.TabIndex = 52;
            this.label19.Text = "VAT 6% :";
            // 
            // txtToPaySplit
            // 
            this.txtToPaySplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToPaySplit.Location = new System.Drawing.Point(332, 232);
            this.txtToPaySplit.Multiline = true;
            this.txtToPaySplit.Name = "txtToPaySplit";
            this.txtToPaySplit.Size = new System.Drawing.Size(87, 27);
            this.txtToPaySplit.TabIndex = 48;
            // 
            // txtTipSplit
            // 
            this.txtTipSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipSplit.Location = new System.Drawing.Point(89, 232);
            this.txtTipSplit.Multiline = true;
            this.txtTipSplit.Name = "txtTipSplit";
            this.txtTipSplit.Size = new System.Drawing.Size(87, 27);
            this.txtTipSplit.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(278, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 18);
            this.label20.TabIndex = 49;
            this.label20.Text = "Subtotal: €";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(25, 235);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 22);
            this.label21.TabIndex = 51;
            this.label21.Text = "TIP: €";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(229, 236);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 22);
            this.label22.TabIndex = 46;
            this.label22.Text = "TO PAY: €";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(268, 123);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 22);
            this.label23.TabIndex = 43;
            this.label23.Text = "TOTAL: €";
            // 
            // radioBtnSplitDebit
            // 
            this.radioBtnSplitDebit.AutoSize = true;
            this.radioBtnSplitDebit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnSplitDebit.Location = new System.Drawing.Point(312, 328);
            this.radioBtnSplitDebit.Name = "radioBtnSplitDebit";
            this.radioBtnSplitDebit.Size = new System.Drawing.Size(79, 29);
            this.radioBtnSplitDebit.TabIndex = 42;
            this.radioBtnSplitDebit.TabStop = true;
            this.radioBtnSplitDebit.Text = "DEBIT";
            this.radioBtnSplitDebit.UseVisualStyleBackColor = true;
            this.radioBtnSplitDebit.CheckedChanged += new System.EventHandler(this.radioBtnSplitDebit_CheckedChanged_1);
            // 
            // radioBtnSplitVisa
            // 
            this.radioBtnSplitVisa.AutoSize = true;
            this.radioBtnSplitVisa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnSplitVisa.Location = new System.Drawing.Point(183, 328);
            this.radioBtnSplitVisa.Name = "radioBtnSplitVisa";
            this.radioBtnSplitVisa.Size = new System.Drawing.Size(71, 29);
            this.radioBtnSplitVisa.TabIndex = 41;
            this.radioBtnSplitVisa.TabStop = true;
            this.radioBtnSplitVisa.Text = "VISA";
            this.radioBtnSplitVisa.UseVisualStyleBackColor = true;
            this.radioBtnSplitVisa.CheckedChanged += new System.EventHandler(this.radioBtnSplitVisa_CheckedChanged_1);
            // 
            // radioBtnSplitCash
            // 
            this.radioBtnSplitCash.AutoSize = true;
            this.radioBtnSplitCash.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnSplitCash.Location = new System.Drawing.Point(55, 328);
            this.radioBtnSplitCash.Name = "radioBtnSplitCash";
            this.radioBtnSplitCash.Size = new System.Drawing.Size(79, 29);
            this.radioBtnSplitCash.TabIndex = 40;
            this.radioBtnSplitCash.TabStop = true;
            this.radioBtnSplitCash.Text = "CASH";
            this.radioBtnSplitCash.UseVisualStyleBackColor = true;
            this.radioBtnSplitCash.CheckedChanged += new System.EventHandler(this.radioBtnSplitCash_CheckedChanged_1);
            // 
            // btnSplitPay
            // 
            this.btnSplitPay.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSplitPay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSplitPay.Location = new System.Drawing.Point(255, 480);
            this.btnSplitPay.Name = "btnSplitPay";
            this.btnSplitPay.Size = new System.Drawing.Size(164, 55);
            this.btnSplitPay.TabIndex = 47;
            this.btnSplitPay.Text = "PAY";
            this.btnSplitPay.UseVisualStyleBackColor = false;
            this.btnSplitPay.Click += new System.EventHandler(this.btnSplitPay_Click);
            // 
            // lblSplitSub
            // 
            this.lblSplitSub.AutoSize = true;
            this.lblSplitSub.BackColor = System.Drawing.Color.White;
            this.lblSplitSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSplitSub.Location = new System.Drawing.Point(364, 74);
            this.lblSplitSub.Name = "lblSplitSub";
            this.lblSplitSub.Size = new System.Drawing.Size(68, 20);
            this.lblSplitSub.TabIndex = 50;
            this.lblSplitSub.Text = "subtotal";
            // 
            // lblSplitTotal
            // 
            this.lblSplitTotal.AutoSize = true;
            this.lblSplitTotal.BackColor = System.Drawing.Color.White;
            this.lblSplitTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSplitTotal.Location = new System.Drawing.Point(364, 122);
            this.lblSplitTotal.Name = "lblSplitTotal";
            this.lblSplitTotal.Size = new System.Drawing.Size(44, 22);
            this.lblSplitTotal.TabIndex = 45;
            this.lblSplitTotal.Text = "total";
            // 
            // btnBackSplit
            // 
            this.btnBackSplit.BackColor = System.Drawing.Color.Salmon;
            this.btnBackSplit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackSplit.Location = new System.Drawing.Point(26, 480);
            this.btnBackSplit.Name = "btnBackSplit";
            this.btnBackSplit.Size = new System.Drawing.Size(164, 55);
            this.btnBackSplit.TabIndex = 33;
            this.btnBackSplit.Text = "Cancel";
            this.btnBackSplit.UseVisualStyleBackColor = false;
            this.btnBackSplit.Click += new System.EventHandler(this.btnBackSplit_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSplit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSplit.Location = new System.Drawing.Point(12, 649);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(179, 55);
            this.btnSplit.TabIndex = 2;
            this.btnSplit.Text = "SPLIT";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "TIP: €";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(38, 376);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 18);
            this.label14.TabIndex = 33;
            this.label14.Text = "VAT 6% :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(30, 415);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 18);
            this.label15.TabIndex = 34;
            this.label15.Text = "VAT 21% :";
            // 
            // lblVat6
            // 
            this.lblVat6.AutoSize = true;
            this.lblVat6.BackColor = System.Drawing.Color.White;
            this.lblVat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVat6.Location = new System.Drawing.Point(112, 374);
            this.lblVat6.Name = "lblVat6";
            this.lblVat6.Size = new System.Drawing.Size(40, 20);
            this.lblVat6.TabIndex = 35;
            this.lblVat6.Text = "vat6";
            // 
            // lblVat21
            // 
            this.lblVat21.AutoSize = true;
            this.lblVat21.BackColor = System.Drawing.Color.White;
            this.lblVat21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVat21.Location = new System.Drawing.Point(112, 413);
            this.lblVat21.Name = "lblVat21";
            this.lblVat21.Size = new System.Drawing.Size(49, 20);
            this.lblVat21.TabIndex = 36;
            this.lblVat21.Text = "vat21";
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(38, 460);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(394, 2);
            this.label16.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(38, 593);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(394, 2);
            this.label17.TabIndex = 38;
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(438, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBack.TabIndex = 39;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 753);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlSplit);
            this.Controls.Add(this.pnlFeedback);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblVat21);
            this.Controls.Add(this.lblVat6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtToPay);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnDebit);
            this.Controls.Add(this.radioBtnVisa);
            this.Controls.Add(this.radioBtnCash);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnCompletePayment);
            this.Controls.Add(this.lblSubTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.listViewPayment);
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Payment";
            this.pnlFeedback.ResumeLayout(false);
            this.pnlFeedback.PerformLayout();
            this.pnlSplit.ResumeLayout(false);
            this.pnlSplit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
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
        private System.Windows.Forms.TextBox txtToPay;
        private System.Windows.Forms.ColumnHeader ColumnHeadings;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader VAT;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubTotalAmount;
        private System.Windows.Forms.Panel pnlFeedback;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Panel pnlSplit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBackSplit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblVat6;
        private System.Windows.Forms.Label lblVat21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSplitVat21;
        private System.Windows.Forms.Label lblSplitVat6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtToPaySplit;
        private System.Windows.Forms.TextBox txtTipSplit;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RadioButton radioBtnSplitDebit;
        private System.Windows.Forms.RadioButton radioBtnSplitVisa;
        private System.Windows.Forms.RadioButton radioBtnSplitCash;
        private System.Windows.Forms.Button btnSplitPay;
        private System.Windows.Forms.Label lblSplitSub;
        private System.Windows.Forms.Label lblSplitTotal;
        private System.Windows.Forms.PictureBox btnBack;
    }
}