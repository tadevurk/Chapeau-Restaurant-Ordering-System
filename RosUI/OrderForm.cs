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
    /// <summary>
    
    /// </summary>
    ////// Vedat Türk --- 683343 --- GROUP1- IT1D - ///////////////////////
    ////// With help of Mirko Cuccurullo ////////
    public partial class FormOrder : Form
    {
        Table table;
        DishLogic dishLogic;
        DrinkLogic drinkLogic;
        Order order;
        OrderLogic orderLogic;
        List<Dish> DishesInOrderProcess = new List<Dish>(); // For the orders that are in process (between order- will be ordered)
        List<Drink> DrinkInOrderProcess = new List<Drink>();
        OrderedDishLogic orderedDishLogic = new OrderedDishLogic();
        OrderedDrinkLogic orderedDrinkLogic = new OrderedDrinkLogic();
        RosMain rosMain;
        Employee emp;
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
                case "Lunch":
                    pnlLunch.Show();
                    pnlLunch.Visible = true;
                    break;
                case "Starters":
                    pnlStarters.Show();
                    pnlStarters.Visible = true;
                    pnlLunch.Visible = true;
                    ReadStarters();
                    break;
                case "Mains":
                    pnlMains.Show();
                    pnlMains.Visible = true;
                    pnlLunch.Visible = true;
                    ReadLunchMains();
                    break;
                case "Desserts":
                    pnlDesserts.Show();
                    pnlDesserts.Visible = true;
                    pnlLunch.Visible = true;
                    ReadLunchDesserts();
                    break;
                case "Dinner":
                    pnlDinner.Show();
                    pnlDinner.Visible = true;
                    break;
                case "DinnerMains":
                    pnlDinnerMains.Show();
                    pnlDinnerMains.Visible = true;
                    pnlDinner.Visible = true;
                    ReadDinnerMains();
                    break;
                case "Drinks":
                    pnlDrinkCategories.Show();
                    pnlDrinkCategories.Visible = true;
                    break;
                case "SoftDrinks":
                    pnlSoftDrinks.Show();
                    pnlSoftDrinks.Visible = true;
                    pnlDrinkCategories.Visible = true;
                    ReadSoftDrinks();
                    break;

            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            HidePanels();
            btnSendOrder.Visible = false;
            btnCancelOrder.Visible = false;
        }
        private void btnLunch_Click(object sender, EventArgs e)
        {
            showPanel("Lunch");
            SendCancelButtonsVisible();
        }
        private void btnStarters_Click(object sender, EventArgs e)
        {
            showPanel("Starters");
            SendCancelButtonsVisible();
        }
        private void btnMains_Click_1(object sender, EventArgs e)
        {
            showPanel("Mains");
            SendCancelButtonsVisible();
        }
        private void btnDesserts_Click(object sender, EventArgs e)
        {
            showPanel("Desserts");
            SendCancelButtonsVisible();
        }
        private void btnDinner_Click(object sender, EventArgs e)
        {
            showPanel("Dinner");
            SendCancelButtonsVisible();
        }
        private void btnMainsDinners_Click(object sender, EventArgs e)
        {
            showPanel("DinnerMains");
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
            pnlLunch.Hide();
            pnlDinner.Hide();

            pnlStarters.Hide();

            pnlDrinkCategories.Hide();

            pnlSoftDrinks.Hide();

            pnlMains.Hide();

            pnlDesserts.Hide();

            pnlDinnerMains.Hide();
        }

        private void ReadSoftDrinks()
        {
            List<Drink> softDrinks = drinkLogic.GetAllSoftDrinks();

            listviewSoftDrinks.Items.Clear();
            DisplayDrinks(softDrinks);
        }

        private void DisplayDrinks(List<Drink> softDrinks)
        {
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
            List<Dish> starters = dishLogic.GetLunchStarters();
            listviewStarters.Items.Clear();

            DisplayDishes(starters);
        }

        private void DisplayDishes(List<Dish> starters)
        {
            foreach (Dish starter in starters)
            {
                ListViewItem li = new ListViewItem(starter.ItemName.ToString());
                li.SubItems.Add(starter.ItemPrice.ToString());
                li.Tag = starter; // Tagging the object
                listviewStarters.Items.Add(li);
            }
        }

        private void ReadLunchMains()
        {
            List<Dish> mains = dishLogic.GetLunchMains();
            listviewMains.Items.Clear();

            DisplayDishes(mains);
        }

        private void ReadLunchDesserts()
        {
            List<Dish> desserts = dishLogic.GetLunchDesserts();
            listviewDesserts.Items.Clear();

            DisplayDishes(desserts);
        }

        private void ReadDinnerMains()
        {
            List<Dish> mains = dishLogic.GetDinnerMains();
            listviewDinnerMains.Items.Clear();

            DisplayDishes(mains);
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
        private void btnAddDinnerMains_Click(object sender, EventArgs e)
        {
            AddDinnerMain();
        }
        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            AddSoftDrink();
        }

        private void btnOrderRemove_Click(object sender, EventArgs e)
        {
            Item item = (Item)listviewOrder.SelectedItems[0].Tag; // Remove the ORDERED STARTER FROM ORDER LIST
            ListViewItem li = listviewOrder.SelectedItems[0];

            if (item is Dish)
            {
                Dish dish = (Dish)listviewOrder.SelectedItems[0].Tag;
                if (dish.ItemName == li.SubItems[0].Text && li.SubItems[0].ForeColor == Color.Green)
                {
                    MessageBox.Show("You cannot edit old items");
                }
                else
                {
                    if(dish.Amount == 1)
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
            }
            else if (item is Drink)
            {
               Drink drink = (Drink)listviewOrder.SelectedItems[0].Tag;
                if (drink.ItemName == li.SubItems[0].Text && li.SubItems[0].ForeColor == Color.Green)
                {
                    MessageBox.Show("You cannot edit old items");
                }
                else
                {
                    if (drink.Amount == 1)
                    {
                        listviewOrder.Items.RemoveAt(listviewOrder.SelectedItems[0].Index);
                        drinkLogic.IncreaseDrinkStock(drink);
                    }
                    else
                    {
                        drink.Amount--;
                        listviewOrder.SelectedItems[0].SubItems[2].Text = drink.Amount.ToString();
                        drinkLogic.IncreaseDrinkStock(drink);
                    }
                }
            }
        }

        private void AddStarter() // Add starters to the orderedlist - if there is already one, just increase the amount
        {
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
                item.Tag = (Item)starter;
                item.ForeColor = Color.Red; // Change color for the new ordered item
                listviewOrder.Items.Add(item);
            }

            dishLogic.DecreaseDishStock(starter); // Decrease the stock
        }

        private void AddMain() // Add starters to the orderedlist - if there is already one, just increase the amount
        {
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
                item.Tag = (Item)main;
                item.ForeColor = Color.Red; // Change color for the new ordered item
                listviewOrder.Items.Add(item);
            }

            dishLogic.DecreaseDishStock(main); // Decrease the stock
        }

        private void AddDessert() // Add starters to the orderedlist - if there is already one, just increase the amount
        {
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
                item.Tag = (Item)dessert;
                item.ForeColor = Color.Red; // Change color for the new ordered item
                listviewOrder.Items.Add(item);
            }

            dishLogic.DecreaseDishStock(dessert); // Decrease the stock
        }

        private void AddDinnerMain() // Add starters to the orderedlist - if there is already one, just increase the amount
        {
            ListViewItem selectedMain = listviewDinnerMains.SelectedItems[0];
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
                item.Tag = (Item)main;
                item.ForeColor = Color.Red; // Change color for the new ordered item
                listviewOrder.Items.Add(item);
            }

            dishLogic.DecreaseDishStock(main); // Decrease the stock
        }

        private void AddSoftDrink() // Add softDrinks to the orderedlist - if there is already one, just increase the amount
        {
            ListViewItem selectedSoftDrink = listviewSoftDrinks.SelectedItems[0];
            Drink softDrink = (Drink)selectedSoftDrink.Tag;
            ListViewItem currentItem = null;

            foreach (ListViewItem item in listviewOrder.Items)
            {
                if (softDrink.ItemName == item.SubItems[0].Text && item.ForeColor != Color.Green)
                {
                    currentItem = item;
                    softDrink.Amount = int.Parse(item.SubItems[2].Text);
                    softDrink.Amount++;
                    item.SubItems[2].Text = softDrink.Amount.ToString();
                }
            }

            if (currentItem == null)
            {
                ListViewItem item = new ListViewItem(softDrink.ItemName);
                item.SubItems.Add(softDrink.ItemPrice.ToString());
                softDrink.Amount = 1;
                item.SubItems.Add(softDrink.Amount.ToString());
                item.Tag = (Item)softDrink;
                item.ForeColor = Color.Red; // Change color for the new ordered item
                listviewOrder.Items.Add(item);
            }

            drinkLogic.DecreaseDrinkStock(softDrink);
        }


        private void WritesContainedDishes() // Getting the ordered list
        {
            List<Dish> orderedDishes = new List<Dish>();
            List<Drink> orderedDrinks = new List<Drink>();

            List<Item> itemsInOrder = new List<Item>();

            orderedDishes = dishLogic.WriteContainedDishes(table, order);
            orderedDrinks = drinkLogic.WriteContainedDrinks(table,order);

            itemsInOrder.AddRange(orderedDishes);
            itemsInOrder.AddRange(orderedDrinks);

            listviewOrder.Items.Clear();

            foreach (Item item in itemsInOrder)
            {
                ListViewItem lvItem = new ListViewItem(item.ItemName.ToString());
                lvItem.SubItems.Add(item.ItemPrice.ToString());
                lvItem.SubItems.Add(item.ItemAmount.ToString());
                lvItem.ForeColor = Color.Green; // Change color from previous orders
                lvItem.Tag = (Item)item;
                listviewOrder.Items.Add(lvItem);
            }
        }

        private void CreateOrder()
        {
            orderLogic.AddOrder(order); // Create new order
        }

        private void btnCancelOrder_Click(object sender, EventArgs e) // Clear the order list
        {

            DialogResult dialogResult = MessageBox.Show("Do you want to cancel new order?", "Cancel Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (ListViewItem lvOrderInProcess in listviewOrder.Items) // Remove the new orders at once
                {
                    Item item = (Item)lvOrderInProcess.Tag;

                    if (lvOrderInProcess.ForeColor == Color.Red)
                    {
                        listviewOrder.Items.Remove(lvOrderInProcess);
                        item.ItemName = lvOrderInProcess.SubItems[0].Text;
                        item.ItemAmount = int.Parse(lvOrderInProcess.SubItems[2].Text);
                        orderLogic.UpdateStock(item);
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
                //Create new order
                CreateOrder();

                // send order - ( and grouping the old items' amount by adding the new items' amount)
                SendOrder();

                //Adding completely new dishes and drinks to Order_Dish and Order_Drink tables
                orderedDishLogic.AddDishes(DishesInOrderProcess, order);

                orderedDrinkLogic.AddDrinks(DrinkInOrderProcess, order);

                WritesContainedDishes();

                //Update KitchenView
                rosMain.UpdateDishes();

                //Update TableView
                rosMain.UpdateTableToOrdered(table.TableNumber);
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
                Item itemInOrderList = (Item)listviewOrder.Items[i].Tag; // Tag all the item as Dish in listview
                ListViewItem lvItemInOrderList = listviewOrder.Items[i];

                if (lvItemInOrderList.ForeColor == Color.Red && itemInOrderList is Dish)
                {
                    Dish dish = (Dish)itemInOrderList;
                    DishesInOrderProcess.Add(dish);
                }
                else if(lvItemInOrderList.ForeColor == Color.Red && itemInOrderList is Drink)
                {
                    Drink drink = (Drink)itemInOrderList;
                    DrinkInOrderProcess.Add(drink);
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
