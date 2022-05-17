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
    public partial class Payment : Form
    {
        Order order = new Order();
        List<Dish> dishes;
        DishLogic dishLogic = new DishLogic();

        public Payment(Table table, List<Dish> dishes)
        {
            InitializeComponent();
            this.dishes = dishes;
            lblTableNumber.Text = $"{lblTableNumber.Text} {table.TableNumber.ToString()}";


        }

        private void DisplayBill()
        {

            listViewPayment.Items.Clear();

            foreach (Dish d in dishes)
            {
                ListViewItem li = new ListViewItem(d.ItemName.ToString());
                li.SubItems.Add(d.OrderedAmount.ToString());
                d.Vat = calculateVat(d.ItemID);
                li.SubItems.Add(d.Vat.ToString());
                d.SubPrice = calculateSubtotal(d);
                li.SubItems.Add((d.SubPrice*d.OrderedAmount).ToString());
                li.SubItems.Add((d.ItemPrice*d.Amount).ToString());
                li.Tag = (Dish)d;
                listViewPayment.Items.Add(li);
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

        private void listViewPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayBill();
        }
    }
}
