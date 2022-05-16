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
        List<Dish> alreadyOrdered = new List<Dish>();
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
            order = new Order(emp, table);
            dishLogic = new DishLogic();
            lblTableNumber.Text = $"{lblTableNumber.Text} {table.TableNumber.ToString()}";
            //pnlStarters.Hide();
            WritesContainedDishes();
        }

        public FormOrder(Table table)
        {
            return;
        }

        private void WritesContainedDishes()
        {
            alreadyOrdered = dishLogic.WriteContainedDishes(table, order);

            listviewOrder.Items.Clear();

            foreach (Dish d in alreadyOrdered)
            {
                ListViewItem li = new ListViewItem(d.ItemName.ToString());
                li.SubItems.Add(d.ItemPrice.ToString());
                li.SubItems.Add(d.OrderedAmount.ToString());
                li.Tag = (Dish)d;
                listviewOrder.Items.Add(li);
            }
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
            ListViewItem item = listviewOrder.SelectedItems[0];
            Dish selectedStarter = (Dish)listviewOrder.SelectedItems[0].Tag;

            selectedStarter.Amount++;

            item.SubItems[2].Text = selectedStarter.Amount.ToString();

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
            int ordID = 0;

            if (alreadyOrdered.Count == 0)
            {
                ordLogic.AddOrder(order);
                ordID = order.OrderID;
            }
            else
            {
                ordID = alreadyOrdered[0].Order;
            }

            //getting Items from listView
            List<Dish> dishes = new List<Dish>();
            List<Dish> contained = new List<Dish>();

            for (int i = 0; i < listviewOrder.Items.Count; i++)
            {
                bool unique = true;
                Dish d = (Dish)listviewOrder.Items[i].Tag;
                ListViewItem li = listviewOrder.Items[i] as ListViewItem;
                foreach (Dish dish in alreadyOrdered)
                {
                    if (dish.ItemName == d.ItemName)
                    {
                        d.OrderedAmount = int.Parse(li.SubItems[2].Text);
                        unique = false;
                    }
                }
                d.Order = ordID;

                if (!unique)
                {
                    contained.Add(d);
                }
                else
                {
                    dishes.Add(d);
                }

            }

            orderedDishLogic.IncreaseAmount(contained, order);

            //Adding dish to Order_Dish table
            orderedDishLogic.AddDishes(dishes, order);

            //Update KitchenView
            rosMain.UpdateDishes();

            //Update TableView
            rosMain.OrderRecieved(table.TableNumber);

            WritesContainedDishes();
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

        private void UpdateDishNote(string msg, OrderedDish dish)
        {       
            orderedDishLogic.UpdateDishNote(dish, msg);
        }
    }
}
