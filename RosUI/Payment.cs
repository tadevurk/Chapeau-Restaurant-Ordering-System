using RosModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RosLogic;
using System.Globalization;

namespace RosUI
{
    public partial class FormPayment : Form
    {
        //Order order = new Order();
        RosMain rosMain;
        Table table;
        Bill bill = new Bill();
        BillLogic billLogic = new BillLogic();
        TableLogic tableLogic = new TableLogic();
        Employee employee;
        FormOrder formOrder;
        List<Item> orderedItems;

        decimal toPay;
        decimal tip;

        public FormPayment(Table table, Employee emp, FormOrder formOrder, RosMain rosMain)
        {
            InitializeComponent();
            this.table = table;
            this.formOrder = formOrder;
            this.employee = emp;
            this.rosMain = rosMain;
            orderedItems = new List<Item>();
            lblTableNumber.Text = $"{lblTableNumber.Text} {table.TableNumber}";
            bill.TableNumber = int.Parse(lblTableNumber.Text);
            btnCompletePayment.Enabled = false;
            btnCompletePayment.BackColor = Color.LightGray;

            DisplayBill();
            // calculate the bill amount
            //..
            bill.SubTotalAmount = CalculateSubTotalAmount();
            bill.TotalAmount = CalculateTotalAmount();
            lblBillAmount.Text = bill.TotalAmount.ToString();
            txtToPay.Text = lblBillAmount.Text;     
        }


        private void DisplayBill()
        {
            // Display the billed item with necessary fields (can either printed or shown to the customer)
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
                    li.SubItems.Add(item.ItemName.ToString());

                    //item.Vat = calculateVat(item.Vat);
                    li.SubItems.Add(item.ItemVat.ToString());

                    item.SubPrice = CalculateItemSubtotal(item.ItemPrice, item.ItemVat);
                    li.SubItems.Add((item.SubPrice * item.ItemAmount).ToString());

                    li.SubItems.Add((item.ItemPrice * item.ItemAmount).ToString());

                    li.Tag = item;
                    listViewPayment.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not load the bill: " + e.Message);
            }
        }


        // calculate subtotal per product unit
        private decimal CalculateItemSubtotal(decimal itemPrice, int vat)
        {
            return itemPrice - (itemPrice * vat/100);
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


        private void btnCompletePayment_Click(object sender, EventArgs e)
        {

            // when complete payment is clicked, the bill is stored in the database
            billLogic.CreateBill(bill);

            // change ordered items status to paid
            SetItemsPaid(orderedItems);

            this.Hide();

            // return to the table overview through the RosMain form or Restaurant overview form
            TableOverview tableOverview = new TableOverview(employee, rosMain);
            tableOverview.Show();
            
            this.Close();

        }

        private void txtFeedback_TextChanged(object sender, EventArgs e)
        {
            bill.Feedback = txtFeedback.Text;
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
            tip = Convert.ToDecimal(txtTip.Text);
            toPay = tip + bill.TotalAmount;

            txtToPay.Text = toPay.ToString();
        }

        private void txtToPay_TextChanged(object sender, EventArgs e)
        {
            // calculate the amount that will be paid
            if (txtToPay.Text == "")
            {
                MessageBox.Show("This value can not be empty!!!");
                txtToPay.Text = "0.0";
            }
            else
            {
                toPay = Convert.ToDecimal(txtToPay.Text);
                tip = toPay - bill.TotalAmount;
                bill.TipAmount = tip;

                txtTip.Text = tip.ToString();

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // get back to the table overview
            this.Hide();
            new TableOverview(employee, rosMain).Show();
            this.Close();

        }

        // remove all items from a table that the payment is completed
        public void SetItemsPaid(List<Item> orderedItems)
        {
            foreach (Item item in orderedItems)
            {
                if (item is OrderedDish)
                {
                    SetDishPaid((OrderedDish)item);
                }
                
                if (item is OrderedDrink)
                {
                    SetDrinkPaid((OrderedDrink)item);
                }
            }
        }

        public void SetDishPaid(OrderedDish item)
        {
            billLogic.SetDishPaid(item);
        }

        public void SetDrinkPaid(OrderedDrink item)
        {
            billLogic.SetDrinkPaid(item);
        }
    }
}
