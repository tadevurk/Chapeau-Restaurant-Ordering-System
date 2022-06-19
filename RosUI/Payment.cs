 using RosModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RosLogic;

namespace RosUI
{
    public partial class FormPayment : Form
    {
        RosMain rosMain;
        Table table;
        Bill bill;
        BillLogic billLogic;
        TableLogic tableLogic;
        Employee employee;
        List<Item> orderedItems;

        decimal toPay;
        decimal tip;

        public FormPayment(Table table, Employee emp, RosMain rosMain)
        {
            InitializeComponent();
            this.table = table;
            this.employee = emp;
            this.rosMain = rosMain;

            billLogic = new BillLogic();
            tableLogic = new TableLogic();
            orderedItems = new List<Item>();
            bill = new Bill();

            lblTableNumber.Text += $" {table.TableNumber}";
            bill.TableNumber = table.TableNumber;
            btnCompletePayment.Enabled = false;
            btnCompletePayment.BackColor = Color.LightGray;
            pnlFeedback.Hide();
            pnlSplit.Hide();

            // display items on the bill
            DisplayBill();

            // display all different amounts (sum amounts , tip)
            ShowBillAmounts();

            // disable buttons and text boxes if a table has no items to be paid
            if (bill.TotalAmount == 0)
            {
                DisableButtons();
            }
        }

        private void DisplayBill()
        {
            // Display the ordered items with necessary fields 
            try
            {
                listViewPayment.Items.Clear();

                BillLogic dishes = new BillLogic();
                List<OrderedDish> orderedDishes = dishes.GetOrderedDishes(table);

                BillLogic drinks = new BillLogic();
                List<OrderedDrink> orderedDrinks = drinks.GetOrderedDrinks(table);

                orderedItems.AddRange(orderedDishes);
                orderedItems.AddRange(orderedDrinks);

                foreach (Item item in orderedItems)
                {
                    ListViewItem li = new ListViewItem();
                    li.SubItems.Add(item.ItemAmount.ToString());
                    li.SubItems.Add(item.ItemName);

                    item.SubPrice = CalculateItemSubtotal(item.ItemPrice, item.ItemVat);
                    decimal vatAmount = item.ItemPrice - item.SubPrice;

                    li.SubItems.Add((vatAmount * item.ItemAmount).ToString("0.00"));

                    //li.SubItems.Add((item.SubPrice * item.ItemAmount).ToString("0.00"));

                    li.SubItems.Add((item.ItemPrice * item.ItemAmount).ToString("0.00"));

                    li.Tag = item;
                    listViewPayment.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not load the bill: " + e.Message);
            }
        }

        private void ShowBillAmounts()
        {
            try
            {
                lblVat6.Text = CalculateLowVAT().ToString("0.00");
                lblVat21.Text = CalculateHighVAT().ToString("0.00");
                bill.SubTotalAmount = CalculateSubTotalAmount();
                lblSubTotalAmount.Text = bill.SubTotalAmount.ToString("0.00");
                bill.TotalAmount = CalculateTotalAmount();
                lblTotalAmount.Text = bill.TotalAmount.ToString("0.00");
                txtToPay.Text = lblTotalAmount.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load the amounts: " + ex.Message);
            }
        }

        private void DisableButtons()
        {
            btnSplit.Enabled = false;
            btnSplit.BackColor = Color.LightGray;

            radioBtnCash.Enabled = false;
            radioBtnVisa.Enabled = false;
            radioBtnDebit.Enabled = false;

            txtToPay.Enabled = false;
            txtTip.Enabled = false;
        }

        // calculate subtotal per product unit
        private decimal CalculateItemSubtotal(decimal itemPrice, int vat)
        {
            return itemPrice - (itemPrice * vat / 100);
        }

        // calculate the bill amount that will be displayed ini the payment form and stored in the database bill table
        private decimal CalculateTotalAmount()
        {
            decimal billAmount = 0;

            foreach (Item i in orderedItems)
            {
                billAmount += i.ItemPrice * i.ItemAmount;
            }

            return billAmount;
        }

        // calculate the subtotal amount that will be stored  in the database bill table
        private decimal CalculateSubTotalAmount()
        {
            decimal subAmount = 0;

            foreach (Item i in orderedItems)
            {
                subAmount += CalculateItemSubtotal(i.ItemPrice, i.ItemVat) * i.ItemAmount;
            }

            return subAmount;
        }

        private decimal CalculateLowVAT()
        {
            decimal lowVAT = 0;

            foreach (Item item in orderedItems)
            {
                if (item is OrderedDish dish)
                {
                    lowVAT += (dish.ItemPrice - dish.SubPrice) * dish.ItemAmount;
                }

                if (item is OrderedDrink drink && drink.DrinkTypeID == 1)
                {
                    lowVAT += (drink.ItemPrice - drink.SubPrice) * drink.ItemAmount;
                }
            }
            return lowVAT;
        }

        private decimal CalculateHighVAT()
        {
            decimal highVAT = 0;

            foreach (Item item in orderedItems)
            {
                if (item is OrderedDrink drink && drink.DrinkTypeID == 2)
                {
                    highVAT += (drink.ItemPrice - drink.SubPrice) * drink.ItemAmount;
                }
            }
            return highVAT;
        }

        private void btnCompletePayment_Click(object sender, EventArgs e)
        {
            try
            {
                // check if the inserted values are in numerical format
                decimal toPay;
                decimal tip;

                bool numericalToPay = decimal.TryParse(txtToPay.Text, out toPay);
                bool numericalTip = decimal.TryParse(txtTip.Text, out tip);

                if (toPay < bill.TotalAmount || toPay <= 0 || !numericalToPay || !numericalTip)
                {
                    throw new Exception("Please enter a  valid amount to be paid.");
                }

                DialogResult dialogResult = MessageBox.Show("Do you want to add feedback?", "Complete payment", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    // proceed with adding some feedback
                    pnlFeedback.Show();
                    btnCompletePayment.Visible = false;
                    btnSplit.Visible = false;
                }
                else
                {
                    CompletePayment();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Could not close the bill: " + ex.Message);
            }

        }

        // check if payment method was selected in order to activate the complete payment button
        private void radioBtnCash_CheckedChanged(object sender, EventArgs e)
        {
            btnCompletePayment.Enabled = true;
            btnCompletePayment.BackColor = Color.LightGreen;
            bill.PaymentMethod = "Cash";
        }

        private void radioBtnVisa_CheckedChanged(object sender, EventArgs e)
        {
            btnCompletePayment.Enabled = true;
            btnCompletePayment.BackColor = Color.LightGreen;
            bill.PaymentMethod = "Visa";

        }

        private void radioBtnDebit_CheckedChanged(object sender, EventArgs e)
        {
            btnCompletePayment.Enabled = true;
            btnCompletePayment.BackColor = Color.LightGreen;
            bill.PaymentMethod = "Debit";

        }

        private void txtTip_TextChanged(object sender, EventArgs e)
        {
            // add a tip and adjust the amount to be paid
            try
            {
                if (txtTip.Text == "" || tip < 0)
                {
                    txtTip.Text = "0.00";
                }
                else
                {
                    tip = Convert.ToDecimal(txtTip.Text);
                    toPay = tip + bill.TotalAmount;

                    txtToPay.Text = toPay.ToString("0.00");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Operation did not work: " + ex.Message);
            }

        }

        private void txtToPay_TextChanged(object sender, EventArgs e)
        {
            // adjust the amount that will be paid and consequently adjust the tip
            try
            {
                if (txtToPay.Text == "")
                {
                    MessageBox.Show("Add a value");
                }
                else
                {

                    toPay = Convert.ToDecimal(txtToPay.Text);
                    tip = toPay - bill.TotalAmount;
                    bill.TipAmount = tip;

                    txtTip.Text = tip.ToString("0.00");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Operation did not work: " + ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // go back to the table overview
            this.Hide();
            new TableOverview(employee, rosMain).Show();
            this.Close();
        }

        // set all ordered items to the paid status
        public void SetItemsPaid(List<Item> orderedItems)
        {
            foreach (Item item in orderedItems)
            {
                if (item is OrderedDish)
                {
                    billLogic.SetDishPaid((OrderedDish)item);
                }

                if (item is OrderedDrink)
                {
                    billLogic.SetDrinkPaid((OrderedDrink)item);
                }
            }
        }

        private void txtFeedback_TextChanged(object sender, EventArgs e)
        {
            bill.Feedback = txtFeedback.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CompletePayment();
        }

        public void CompletePayment()
        {
            try
            {
                // when complete payment is clicked, the bill is stored in the database
                billLogic.CreateBill(bill);

                // Pass billNumber to the order table in the database
                billLogic.UpdateOrderBillNumber(bill, orderedItems);

                // change ordered items status to paid
                SetItemsPaid(orderedItems);

                // Update kitchen and bar views
                rosMain.UpdateAllListViews();

                // change the table status 
                table.TableStatus = TableStatus.Occupied;
                tableLogic.Update(table);

                this.Hide();

                // return to the table overview 
                TableOverview tableOverview = new TableOverview(employee, rosMain);
                tableOverview.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation did not work: " + ex.Message);
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            try
            {
                pnlSplit.Show();
                btnSplitPay.Enabled = false;
                btnSplitPay.BackColor = Color.LightGray;
                btnBack.Visible = false;

                txtToPaySplit.Text = 0.ToString("0.00");
                txtTipSplit.Text = 0.ToString("0.00");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation did not work: " + ex.Message);
            }
        }

        private void pnlSplit_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                lblSplitVat6.Text = lblVat6.Text;
                lblSplitVat21.Text = lblVat21.Text;
                lblSplitSub.Text = lblSubTotalAmount.Text;
                lblSplitTotal.Text = lblTotalAmount.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation did not work: " + ex.Message);
            }
        }

        private decimal deductibleAmount = 0;

        // calculate amount to be stored in the database and display correct amounts
        private void btnSplitPay_Click(object sender, EventArgs e)
        {
            try
            {
                decimal splitAmount;
                decimal splitTip;

                bool numericalToPay = decimal.TryParse(txtToPaySplit.Text, out splitAmount);
                bool numericalTip = decimal.TryParse(txtTipSplit.Text, out splitTip);

                if (!numericalToPay || !numericalTip || txtToPaySplit.Text.Contains(',') || txtTipSplit.Text.Contains(','))
                {
                    throw new Exception("Input is not in the correct numerical format");
                }

                // do not let the user close a bill from the partial payment mode
                // complete a partial payment and update values for displaying purpose and
                // next partial payment if needed

                if (bill.TotalAmount <= splitAmount)
                {
                    MessageBox.Show("Complete payment in the main form!");
                }
                else
                {
                    deductibleAmount += splitAmount;

                    if (splitTip < 0 || splitAmount < 0)
                    {
                        throw new Exception("Please enter valid amounts.");
                    }
                    else
                    {
                        bill.TotalAmount = splitAmount;
                        bill.TipAmount = splitTip;

                        bill.SubTotalAmount = 0;

                        billLogic.CreateBill(bill);

                        bill.TotalAmount = CalculateTotalAmount() - deductibleAmount;
                        toPay = bill.TotalAmount;

                        lblTotalAmount.Text = CalculateTotalAmount().ToString();
                        txtTip.Text = 0.ToString();
                        txtToPay.Text = toPay.ToString();
                    }
                }

                pnlSplit.Hide();
                radioBtnSplitCash.Checked = false;
                radioBtnSplitVisa.Checked = false;
                radioBtnSplitDebit.Checked = false;
                btnBack.Visible = true;
            }
            catch (Exception exp)
            {

                MessageBox.Show( exp.Message, "Error");
            }
            // check if the inserted values are in numerical format
          
        }

        private void radioBtnSplitCash_CheckedChanged_1(object sender, EventArgs e)
        {
            if (txtToPaySplit.Text != null)
            {
                btnSplitPay.Enabled = true;
                btnSplitPay.BackColor = Color.LightGreen;
                bill.PaymentMethod = "Cash";
            }
            else
            {
                MessageBox.Show("Add the amount to be paid!");
            }
        }

        private void radioBtnSplitVisa_CheckedChanged_1(object sender, EventArgs e)
        {
            if (txtToPaySplit.Text != null)
            {
                btnSplitPay.Enabled = true;
                btnSplitPay.BackColor = Color.LightGreen;
                bill.PaymentMethod = "Visa";
            }
            else
            {
                MessageBox.Show("Add the amount to be paid!");
            }
        }

        private void radioBtnSplitDebit_CheckedChanged_1(object sender, EventArgs e)
        {
            if (txtToPaySplit.Text != null)
            {
                btnSplitPay.Enabled = true;
                btnSplitPay.BackColor = Color.LightGreen;
                bill.PaymentMethod = "Debit";
            }
            else
            {
                MessageBox.Show("Add the amount to be paid!");
            }
        }

        private void btnBackSplit_Click(object sender, EventArgs e)
        {
            pnlSplit.Hide();
            btnBack.Visible = true;
        }

    }      
}   


