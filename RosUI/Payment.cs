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

namespace RosUI
{
    public partial class FormPayment : Form
    {
        Order order = new Order();
        Table table;
        List<Dish> dishes;
        //List<Drink> drinks;
        DishLogic dishLogic = new DishLogic();
        BillLogic billLogic = new BillLogic();
        Bill bill = new Bill();
        Employee employee;

        public FormPayment(Table table, List<Dish> dishes)
        {
            InitializeComponent();
            this.table = table;
            this.dishes = dishes;
            lblTableNumber.Text = $"{lblTableNumber.Text} {table.TableNumber}";
            btnCompletePayment.Enabled = false;
            
            DisplayBill();
        }
        
        
        private void DisplayBill()
        {

            try
            {
                listViewPayment.Items.Clear();
                
                foreach (Dish d in dishes)
                {
                    ListViewItem li = new ListViewItem();
                    li.SubItems.Add(d.OrderedAmount.ToString());
                    li.SubItems.Add(d.ItemName.ToString());
                    d.Vat = calculateVat(d.ItemID);
                    li.SubItems.Add(d.Vat.ToString());
                    d.SubPrice = calculateSubtotal(d);
                    li.SubItems.Add((d.SubPrice * d.OrderedAmount).ToString());
                    li.SubItems.Add((d.ItemPrice * d.Amount).ToString());
                    li.Tag = (Dish)d;
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

        private decimal calculateSubtotal(Dish d)
        {
            return (d.ItemPrice * (d.Vat / 100));
        }

        
        private void btnCompletePayment_Click(object sender, EventArgs e)
        {
            
           

            // when complete payment is clicked, the bill is stored in the database
            billLogic.CreateBills(bill);


            // return to the table overview through the RosMain form or Restaurant overview form
            this.Hide();
            RosMain ros = new RosMain(employee);

            //if RosMAin form, show the Tableview panel 
            // change the protection level to public?

            //ros.ShowPanel("TableView");
            this.Close();

        }

        private void txtFeedback_TextChanged(object sender, EventArgs e)
        {
            bill.Feedback = txtFeedback.Text;
        }

        private void radioBtnCash_CheckedChanged(object sender, EventArgs e)
        {
            // check if payment method was selected in order to activate the complete payment button
                btnCompletePayment.Enabled = true;
        }
    }
}
