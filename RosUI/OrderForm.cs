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
        DrinkLogic drinkLogic;
        Order order;
        OrderLogic orderLogic;
        List<Dish> alreadyOrdered = new List<Dish>();
        List<Dish> DishesInOrderProcess = new List<Dish>(); // For the orders that are in process (between order- will be ordered)
        List<Dish> DishesInOrderedList = new List<Dish>(); // For the orders that are already in the listviewOrder
        OrderedDishLogic orderedDishLogic = new OrderedDishLogic();
        RosMain rosMain;
        Employee emp;
        int ordID = 0;
        int toAdd = 1; // variable to decide if it had to be edited or not
        public FormOrder(Table table, Employee emp, RosMain rosMain)
        {
            InitializeComponent();
            this.rosMain = rosMain;
            this.emp = emp;
            this.table = table;
            order = new Order(emp, table);
            orderLogic = new OrderLogic();
            dishLogic = new DishLogic();
            drinkLogic = new DrinkLogic();
            lblTableNumber.Text = $"{lblTableNumber.Text} {table.TableNumber.ToString()}";

            WritesContainedDishes();
        }


        private void showPanel(string panelName)
        {
            HidePanels();
            switch (panelName)
            {
                case "Starters":
                    pnlStarters.Show();
                    pnlStarters.Visible = true;
                    ReadStarters();
                    break;
                case "Mains":
                    pnlMains.Show();
                    pnlMains.Visible = true;
                    ReadMains();
                    break;
                case "Drinks":
                    pnlDrinkCategories.Show();
                    pnlDrinkCategories.Visible = true;
                    break;
                case "SoftDrinks":
                    pnlSoftDrinks.Show();
                    pnlSoftDrinks.Visible = true;
                    ReadSoftDrinks();
                    break;
                case "Desserts":
                    pnlDesserts.Show();
                    pnlDesserts.Visible = true;
                    ReadDesserts();
                    break;
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            HidePanels();
            btnSendOrder.Visible = false;
            btnCancelOrder.Visible = false;
        }

        private void btnStarters_Click(object sender, EventArgs e)
        {
            showPanel("Starters");
            SendCancelButtonsVisible();
        }

        private void btnMains_Click(object sender, EventArgs e)
        {
            showPanel("Mains");
            SendCancelButtonsVisible();
        }
        private void btnDesserts_Click(object sender, EventArgs e)
        {
            showPanel("Desserts");
            SendCancelButtonsVisible();
        }
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            showPanel("Drinks");
            SendCancelButtonsVisible();
        }

        private void btnSoftDrink_Click(object sender, EventArgs e)
        {
            showPanel("SoftDrinks");
            SendCancelButtonsVisible();
        }

        private void SendCancelButtonsVisible()
        {
            btnSendOrder.Visible = true;
            btnCancelOrder.Visible = true;
        }
        void HidePanels()
        {
            pnlStarters.Hide();
            listviewOrder.FullRowSelect = true;

            pnlDrinkCategories.Hide();

            pnlSoftDrinks.Hide();
            listviewSoftDrinks.FullRowSelect = true;

            pnlMains.Hide();
            listviewMains.FullRowSelect = true;

            pnlDesserts.Hide();
            listviewDesserts.FullRowSelect = true;
        }

        private void ReadSoftDrinks()
        {
            List<Drink> softDrinks = drinkLogic.GetAllSoftDrinks();

            listviewSoftDrinks.Items.Clear();
            listviewSoftDrinks.FullRowSelect = true;

            foreach (Drink softDrink in softDrinks)
            {
                ListViewItem li = new ListViewItem(softDrink.ItemName.ToString());
                li.SubItems.Add(softDrink.ItemPrice.ToString());
                li.Tag = softDrink; // Tagging the object
                listviewSoftDrinks.Items.Add(li);
            }
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

        private void ReadMains()
        {
            List<Dish> mains = dishLogic.GetAllMains();
            listviewMains.Items.Clear();
            listviewMains.FullRowSelect = true;

            foreach (Dish main in mains)
            {
                ListViewItem li = new ListViewItem(main.ItemName.ToString());
                li.SubItems.Add(main.ItemPrice.ToString());
                li.Tag = main;
                listviewMains.Items.Add(li);
            }
        }

        private void ReadDesserts()
        {
            List<Dish> desserts = dishLogic.GetAllDesserts();
            listviewDesserts.Items.Clear();
            listviewDesserts.FullRowSelect = true;

            foreach (Dish dessert in desserts)
            {
                ListViewItem li = new ListViewItem(dessert.ItemName.ToString());
                li.SubItems.Add(dessert.ItemPrice.ToString());
                li.Tag = dessert;
                listviewDesserts.Items.Add(li);
            }
        }

        private void btnAddStarter_Click(object sender, EventArgs e)
        {
            AddStarter();
        }
        private void btnAddMains_Click(object sender, EventArgs e)
        {
            AddMain();
        }
        private void btnAddDessert_Click(object sender, EventArgs e)
        {
            AddDessert();
        }
        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            SendCancelButtonsVisible();
            // Increase the amount of the selected item from ordered list
            listviewOrder.FullRowSelect = true;
            ListViewItem item = listviewOrder.SelectedItems[0];
            Dish selectedStarter = (Dish)listviewOrder.SelectedItems[0].Tag;

            selectedStarter.Amount++;
            item.SubItems[2].Text = selectedStarter.Amount.ToString();
            DishesInOrderedList.Add(selectedStarter); // Adding selected item to again dishesInOrdered with its updated amount
            dishLogic.DecreaseDishStock(selectedStarter); //Decrease from stock

        }

        private void btnOrderRemove_Click(object sender, EventArgs e)
        {
            Dish dish = (Dish)listviewOrder.SelectedItems[0].Tag; // Remove the ORDERED STARTER FROM ORDER LIST
            ListViewItem li = listviewOrder.SelectedItems[0];

            if (dish.ItemName == li.SubItems[0].Text && li.SubItems[0].ForeColor == Color.Green)
            {
                //!! It should be POSSIBLE to decrease the items amount which comes with (+) button !!
                MessageBox.Show("You cannot edit old items");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to remove this item?", "Remove Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (dish.Amount == 1)
                    {
                        listviewOrder.Items.RemoveAt(listviewOrder.SelectedItems[0].Index);
                        dishLogic.IncreaseDishStock(dish);

                    }
                    else
                    {
                        dish.Amount--;
                        listviewOrder.SelectedItems[0].SubItems[2].Text = dish.Amount.ToString();
                        dishLogic.IncreaseDishStock(dish);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }
        }

        private void AddStarter() // Add starters to the orderedlist - if there is already one, just increase the amount
        {
            listviewStarters.FullRowSelect = true;
            ListViewItem selectedStarter = listviewStarters.SelectedItems[0];
            Dish starter = (Dish)selectedStarter.Tag;
            ListViewItem currentItem = null;

            foreach (ListViewItem item in listviewOrder.Items)
            {
                if (starter.ItemName == item.SubItems[0].Text && item.ForeColor != Color.Green)
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

        private void AddMain() // Add starters to the orderedlist - if there is already one, just increase the amount
        {
            listviewMains.FullRowSelect = true;
            ListViewItem selectedMain = listviewMains.SelectedItems[0];
            Dish main = (Dish)selectedMain.Tag;
            ListViewItem currentItem = null;

            foreach (ListViewItem item in listviewOrder.Items)
            {
                if (main.ItemName == item.SubItems[0].Text && item.ForeColor != Color.Green)
                {
                    currentItem = item;
                    main.Amount = int.Parse(item.SubItems[2].Text);
                    main.Amount++;
                    item.SubItems[2].Text = main.Amount.ToString();
                }
            }

            if (currentItem == null)
            {
                ListViewItem item = new ListViewItem(main.ItemName);
                item.SubItems.Add(main.ItemPrice.ToString());
                main.Amount = 1;
                item.SubItems.Add(main.Amount.ToString());
                item.Tag = main;
                item.ForeColor = Color.Red; // Change color for the new ordered item
                listviewOrder.Items.Add(item);
            }

            dishLogic.DecreaseDishStock(main); // Decrease the stock
        }

        private void AddDessert() // Add starters to the orderedlist - if there is already one, just increase the amount
        {
            listviewDesserts.FullRowSelect = true;
            ListViewItem selectedDessert = listviewDesserts.SelectedItems[0];
            Dish dessert = (Dish)selectedDessert.Tag;
            ListViewItem currentItem = null;

            foreach (ListViewItem item in listviewOrder.Items)
            {
                if (dessert.ItemName == item.SubItems[0].Text && item.ForeColor != Color.Green)
                {
                    currentItem = item;
                    dessert.Amount = int.Parse(item.SubItems[2].Text);
                    dessert.Amount++;
                    item.SubItems[2].Text = dessert.Amount.ToString();
                }
            }

            if (currentItem == null)
            {
                ListViewItem item = new ListViewItem(dessert.ItemName);
                item.SubItems.Add(dessert.ItemPrice.ToString());
                dessert.Amount = 1;
                item.SubItems.Add(dessert.Amount.ToString());
                item.Tag = dessert;
                item.ForeColor = Color.Red; // Change color for the new ordered item
                listviewOrder.Items.Add(item);
            }

            dishLogic.DecreaseDishStock(dessert); // Decrease the stock
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

        private void OrderCheck()
        {
            if (alreadyOrdered.Count == 0)
            {
                orderLogic.AddOrder(order); // Create new order
                ordID = order.OrderID; // the new orderId will be the orderID from parameter
            }
            else
            {
                ordID = alreadyOrdered[0].Order; // Else still same orderID
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e) // Clear the order list
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to cancel new order?", "Cancel Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (ListViewItem lvOrderInProcess in listviewOrder.Items) // Remove the new orders at once
                {
                    if (lvOrderInProcess.ForeColor == Color.Red)
                    {
                        listviewOrder.Items.Remove(lvOrderInProcess);
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to send this order?", "Send Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Check the order whether exists or not
                OrderCheck();

                // send order - ( and grouping the old items' amount by adding the new items' amount)
                SendOrder();

                //icreasing amount on db and setting back status to toBePrepared
                orderedDishLogic.IncreaseAmount(DishesInOrderedList, order);

                //pass the contained dishes to Main
                rosMain.Contained = DishesInOrderedList;

                //Adding compleeteley new dish dish to Order_Dish table
                orderedDishLogic.AddDishes(DishesInOrderProcess, order);

                WritesContainedDishes();

                //Update KitchenView
                rosMain.UpdateDishes();

                //Update TableView
                rosMain.OrderRecieved(table.TableNumber);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }


        private void SendOrder()
        {
            for (int i = 0; i < listviewOrder.Items.Count; i++)
            {
                //int toAdd = 1; // variable to decide if it had to be edited or not
                Dish dishInOrderList = (Dish)listviewOrder.Items[i].Tag; // Tag all the item as Dish in listview
                ListViewItem lvItemInOrderList = listviewOrder.Items[i];

                foreach (ListViewItem lvItemInOrderProcess in listviewOrder.Items)
                {
                    //check if it is new one
                    if (lvItemInOrderProcess.SubItems[0].Text == dishInOrderList.ItemName && lvItemInOrderProcess.ForeColor != lvItemInOrderList.ForeColor)
                    {
                        //calculate how many have been added and store it into dish.OrderAmount
                        dishInOrderList.OrderedAmount = int.Parse(lvItemInOrderProcess.SubItems[2].Text); // This is for the kitchen.
                        // If they have same name, but one is olde
                        dishInOrderList.Amount = int.Parse(lvItemInOrderList.SubItems[2].Text) + int.Parse(lvItemInOrderProcess.SubItems[2].Text);
                        toAdd = 2;
                        break;
                    }

                    if (alreadyOrdered.Contains(dishInOrderList))
                    {
                        toAdd = 0; //check if it is not modified then ignore
                    }
                    else
                    {
                        toAdd = 1; // if this is 1, then add to dishes(list)
                    }
                }
                order.OrderID = ordID; // Dish.Order ID

                //if new add than edit
                if (toAdd == 2)
                {
                    DishesInOrderedList.Add(dishInOrderList);
                }
                //if unique than add
                else if (toAdd == 1)
                {
                    DishesInOrderProcess.Add(dishInOrderList);
                }
            }
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

            txtNote.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
