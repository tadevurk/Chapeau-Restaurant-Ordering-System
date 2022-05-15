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
using RosModel;

namespace RosUI
{
    public partial class FormOrder : Form
    {
        Table table;
        DishLogic dishLogic;
        int amount = 1;
        public FormOrder(Table table)
        {
            InitializeComponent();
            this.table = table;
            dishLogic = new DishLogic();
            lblTableNumber.Text = $"{lblTableNumber.Text} {table.TableNumber.ToString()}";
            //pnlStarters.Hide();
        }

        private void showPanel(string panelName)
        {
            switch (panelName)
            {
                case "Starters":
                    pnlStarters.Show();
                    pnlStarters.Visible = true;
                    break;
            }
        }


        private void btnStarters_Click(object sender, EventArgs e)
        {
            showPanel("Starters");
            ReadStarters();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            //..
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            pnlStarters.Hide();
            listviewOrder.FullRowSelect = true;
        }

        private void ReadStarters()
        {
            List<Dish> starters = dishLogic.GetAllStarters();

            listviewStarters.Items.Clear();
            listviewStarters.FullRowSelect = true;

            foreach (Dish starter in starters)
            {
                ListViewItem li = new ListViewItem(starter.ItemName.ToString());
                li.SubItems.Add(starter.ItemPrice.ToString());
                li.Tag = starter; // Tagging the object
                listviewStarters.Items.Add(li);
            }
        }

        private void btnAddStarter_Click(object sender, EventArgs e)
        {
            listviewStarters.FullRowSelect = true;
            ListViewItem selectedStarter = listviewStarters.SelectedItems[0];
            Dish starter = (Dish)selectedStarter.Tag;
            ListViewItem currentItem = null;


            foreach (ListViewItem item in listviewOrder.Items)
            {
                if (starter.ItemName == item.SubItems[0].Text)
                {
                    currentItem = item;
                    int amount = int.Parse(item.SubItems[2].Text);
                    amount++;
                    item.SubItems[2].Text = amount.ToString();
                }
            }

            if (currentItem == null)
            {
                ListViewItem li = new ListViewItem(starter.ItemName);
                li.SubItems.Add(starter.ItemPrice.ToString());
                li.SubItems.Add(amount.ToString());
                listviewOrder.Items.Add(li);
            }

            // Decrese from stock
        }

        private void btnCancelOrder_Click(object sender, EventArgs e) // Clear the order list
        {
            listviewOrder.Items.Clear();
        }

        private void btnOrderRemove_Click(object sender, EventArgs e)
        {
            
            ListViewItem selectedOrderedStarter = listviewOrder.SelectedItems[0]; // Remove the ORDERED STARTER FROM ORDER LIST

            int amount = int.Parse(selectedOrderedStarter.SubItems[2].Text);
            if (amount == 1)
            {
                listviewOrder.Items.RemoveAt(selectedOrderedStarter.Index);
            }
            else
            {
                amount--;
                selectedOrderedStarter.SubItems[2].Text = amount.ToString();
            }

            

            // Increase stock
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            // Increase the amount of the selected item from ordered list
            ListViewItem selectedStarter = listviewOrder.SelectedItems[0];

            Dish orderedDish = (Dish)selectedStarter.Tag;
        }
    }
}
