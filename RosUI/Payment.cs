﻿using RosModel;
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
        Table table;
        List<Dish> dishes;
        //List<Drink> drinks;
        DishLogic dishLogic = new DishLogic();
        BillLogic billLogic = new BillLogic();
        Bill bill = new Bill();
        Employee employee;
        FormOrder formOrder;

        decimal toPay;
        decimal tip;

        public FormPayment(Table table, Employee emp, List<Dish> dishes, FormOrder formOrder)
        {
            InitializeComponent();
            this.table = table;
            this.dishes = dishes;
            this.formOrder = formOrder;
            this.employee = emp;
            lblTableNumber.Text = $"{lblTableNumber.Text} {table.TableNumber}";
            bill.TableNumber = int.Parse(lblTableNumber.Text);
            btnCompletePayment.Enabled = false;
            
            DisplayBill();
            // calculate the bill amount
            //..
            bill.SubTotalAmount = calculateSubTotalAmount();
            bill.TotalAmount = calculateTotalAmount();
            lblBillAmount.Text = bill.TotalAmount.ToString();
            txtToPay.Text = lblBillAmount.Text;
        }


        private void DisplayBill()
        {
            // Display the billed item with necessary fields (can be either printed or shown to the customer)
            try
            {
                listViewPayment.Items.Clear();
                
                foreach (Dish d in dishes)
                {
                    ListViewItem li = new ListViewItem();
                    li.SubItems.Add(d.Amount.ToString());
                    li.SubItems.Add(d.ItemName.ToString());

                    d.Vat = calculateVat(d.DishID);
                    li.SubItems.Add(d.Vat.ToString());

                    d.SubPrice = calculateSubtotal(d.ItemPrice, d.Vat);
                    li.SubItems.Add((d.SubPrice * d.Amount).ToString());

                    li.SubItems.Add((d.ItemPrice * d.Amount).ToString());

                    li.Tag = d;
                    listViewPayment.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not load the bill: " + e.Message);
            }
        }

        private int calculateVat(int id)
        {
            return dishLogic.RetrieveVatByID(id);
        }

        // calculate subtotal per product unit
        private decimal calculateSubtotal(decimal itemPrice, int vat)
        {
            return itemPrice - (itemPrice * vat/100);
        }

        // calculate the bill amount that will be displayed ini the payment form and stored in the database bill table
        private decimal calculateTotalAmount()
        {
            decimal billAmount = 0;

            foreach (Dish d in dishes)
            {
                billAmount += d.ItemPrice * d.Amount;
            }

            return billAmount;
        }

        // calculate the subtotal amount that will be stored  in the database bill table
        private decimal calculateSubTotalAmount()
        {
            decimal subAmount = 0;

            foreach (Dish d in dishes)
            {
                subAmount += calculateSubtotal(d.ItemPrice, d.Vat) * d.Amount;
            }

            return subAmount;
        }


        private void btnCompletePayment_Click(object sender, EventArgs e)
        {
            
            // when complete payment is clicked, the bill is stored in the database
            billLogic.CreateBill(bill);
            // clear up the order list view
            SetItemsPaid(dishes);
            this.Hide();

            // return to the table overview through the RosMain form or Restaurant overview form
            RosMain ros = new RosMain(employee);
            ros.Show();
            //if RosMAin form, show the Tableview panel 
            // change the protection level to public?
            //ros.ShowPanel("TableView");

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
            bill.PaymentMethod = "Cash";
        }

        private void radioBtnVisa_CheckedChanged(object sender, EventArgs e)
        {
            btnCompletePayment.Enabled = true;
            bill.PaymentMethod = "Visa";

        }

        private void radioBtnDebit_CheckedChanged(object sender, EventArgs e)
        {
            btnCompletePayment.Enabled = true;
            bill.PaymentMethod = "Debit";

        }

        private void txtTip_TextChanged(object sender, EventArgs e)
        {
            // add a tip and adjust the amount to be paid
            // ..
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
            formOrder.Show();
            this.Close();

        }

        // remove all items from a table that the payment is completed
        public void SetItemsPaid(List<Dish> dishes)
        {
            billLogic.SetItemsPaid(dishes);
        }
    }
}