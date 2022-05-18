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
            WritesContainedDishes();
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
            HidePanels();
        }

        void HidePanels()
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
            Dish dish = (Dish)listviewOrder.SelectedItems[0].Tag; // Remove the ORDERED STARTER FROM ORDER LIST
            ListViewItem li = listviewOrder.SelectedItems[0];

            if (listviewOrder.Items.Count > 0)
            {
                if (dish.ItemName == li.SubItems[0].Text )
                {
                    MessageBox.Show("You cannot edit old items");
                }
            }

            if (dish.Amount==1)
            {
                listviewOrder.Items.RemoveAt(listviewOrder.SelectedItems[0].Index);
            }
            else
            {
                dish.Amount--;
                listviewOrder.SelectedItems[0].SubItems[2].Text = dish.Amount.ToString();
            }
            // Increase stock
        }

        private void AddStarterFunction() // Add starters to the orderedlist - if there is already one, just increase the amount
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
                ListViewItem item = new ListViewItem(starter.ItemName);
                item.SubItems.Add(starter.ItemPrice.ToString());
                starter.Amount = 1;
                item.SubItems.Add(starter.Amount.ToString());
                item.Tag = starter;
                item.ForeColor = Color.Red; // Change color for the new ordered item
                listviewOrder.Items.Add(item);                
            }

            dishLogic.DecreaseDishStock(starter); // Decrease the stock
        }

        private void WritesContainedDishes() // Getting the ordered list
        {
            alreadyOrdered = dishLogic.WriteContainedDishes(table, order);
            listviewOrder.Items.Clear();

            foreach (Dish dish in alreadyOrdered)
            {
                ListViewItem item = new ListViewItem(dish.ItemName.ToString());
                item.SubItems.Add(dish.ItemPrice.ToString());
                item.SubItems.Add(dish.Amount.ToString());
                item.ForeColor = Color.Green; // Change color from previous orders
                item.Tag = (Dish)dish;
                listviewOrder.Items.Add(item);
            }
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            int ordID = 0;

            if (alreadyOrdered.Count == 0)
            {
                ordLogic.AddOrder(order); // Create new order
                ordID = order.OrderID; // the new orderId will be the orderID from parameter
            }
            else
            {
                ordID = alreadyOrdered[0].Order; // Else still same orderID
            }

            //getting Items from listView
            List<Dish> dishes = new List<Dish>();
            List<Dish> contained = new List<Dish>();



            for (int i = 0; i < listviewOrder.Items.Count; i++)
            {
                int toAdd = 1;

                Dish orderedDish = (Dish)listviewOrder.Items[i].Tag;
                ListViewItem li = listviewOrder.Items[i];
                foreach (Dish dish in alreadyOrdered)
                {

                    if (dish.ItemName == orderedDish.ItemName && dish.Amount != int.Parse(li.SubItems[2].Text))
                    {
                        orderedDish.OrderedAmount = int.Parse(li.SubItems[2].Text) - dish.Amount;
                        orderedDish.Amount = int.Parse(li.SubItems[2].Text);
                        toAdd = 2;
                    }
                    else if (dish.ItemName == orderedDish.ItemName)
                    {
                        toAdd = 0;
                    }
                }
                order.OrderID = ordID; // Dish.Order ID

                if (toAdd == 2)
                {
                    contained.Add(orderedDish);
                }
                else if (toAdd == 1)
                {
                    dishes.Add(orderedDish);
                }
            }

            orderedDishLogic.IncreaseAmount(contained, order);

            //pass the contained dishes to Main
            rosMain.Contained = contained;


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
            Dish dish = (Dish)listviewOrder.Items[0].Tag;

            if (txtNote.Text == "")
            {
                MessageBox.Show("There is no note!");
            }
            else
            {
                dish.Note = txtNote.Text;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
