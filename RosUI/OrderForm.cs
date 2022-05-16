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
        Order order;
        OrderLogic ordLogic = new OrderLogic();
        OrderedDishLogic orderedDishLogic = new OrderedDishLogic();
        RosMain rosMain;
        Employee emp;
        int starterAmount = 1;
        public FormOrder(Table table, Employee emp, RosMain rosMain)
        {
            InitializeComponent();
            this.rosMain = rosMain;
            this.emp = emp;
            this.table = table;
            dishLogic = new DishLogic();
            lblTableNumber.Text = $"{lblTableNumber.Text} {table.TableNumber.ToString()}";
            //pnlStarters.Hide();
        }

        public FormOrder(Table table)
        {
            return;
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
            AddStarterFunction();
            // Decrese from stock
        }
        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            // Increase the amount of the selected item from ordered list
            listviewOrder.FullRowSelect = true;
            ListViewItem selectedStarter = listviewOrder.SelectedItems[0];

            int amount = int.Parse(selectedStarter.SubItems[2].Text);
            amount++;
            selectedStarter.SubItems[2].Text = amount.ToString();

            //Decrease from stock
        }

        private void btnCancelOrder_Click(object sender, EventArgs e) // Clear the order list
        {
            listviewOrder.Items.Clear();
            
            // Everything should go again to database. (INCREASE STOCK AGAIN)
        }

        private void btnOrderRemove_Click(object sender, EventArgs e)
        {

            Dish d = (Dish)listviewOrder.SelectedItems[0].Tag; // Remove the ORDERED STARTER FROM ORDER LIST

            int amount = d.Amount;
            if (amount == 1)
            {
                listviewOrder.Items.RemoveAt(listviewOrder.SelectedItems[0].Index);
            }
            else
            {
                amount--;
                listviewOrder.SelectedItems[0].SubItems[2].Text = amount.ToString();
            }
            // Increase stock
        }

        private void AddStarterFunction()
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
                    starter.Amount = int.Parse(item.SubItems[2].Text);
                    starter.Amount++;
                    item.SubItems[2].Text = starter.Amount.ToString();
                }
            }

            if (currentItem == null)
            {
                ListViewItem li = new ListViewItem(starter.ItemName);
                li.SubItems.Add(starter.ItemPrice.ToString());
                starter.Amount = 1;
                li.SubItems.Add(starter.Amount.ToString());
                li.Tag = starter;
                listviewOrder.Items.Add(li);
            }
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            //create new Order
            order = new Order(emp, table);
            ordLogic.AddOrder(order);

            //getting Items from listView
            List<Dish> dishes = new List<Dish>();

            for (int i = 0; i < listviewOrder.Items.Count; i++)
            {  
                Dish d = (Dish)listviewOrder.Items[i].Tag;
                dishes.Add(d);
                
            }

            
            //Adding dish to Order_Dish table
            orderedDishLogic.AddDishes(dishes, order);

            //Update KitchenView
            rosMain.UpdateDishes();

            //Update TableView
            rosMain.OrderRecieved(table.TableNumber);
        }

        private void btnOrderAddNote_Click(object sender, EventArgs e)
        {
            Dish d = (Dish)listviewOrder.Items[0].Tag;

            if (txtNote.Text == "")
            {
                MessageBox.Show("Note is empty!");
            }
            else
            {
                d.Note = txtNote.Text;
            }
        }

        private void StoreNotes(string msg, OrderedDish dish)
        {       
            orderedDishLogic.UpdateDishNote(dish, msg);
        }
    }
}
