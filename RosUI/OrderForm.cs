using System;
using System.Collections.Generic;
using System.Drawing;
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
        TableLogic tableLogic;
        List<Dish> DishesInOrderProcess = new List<Dish>(); // For the orders that are in process (between order- will be ordered)
        List<Drink> DrinkInOrderProcess = new List<Drink>();
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
            tableLogic = new TableLogic();
            lblTableNumber.Text = $"{lblTableNumber.Text} {table.TableNumber.ToString()}";

            ReadContainedItems();
        }


        private void showPanel(string panelName)
        {
            HidePanels();
            switch (panelName)
            {
                case "Starter":
                    if (DateTime.Now.Hour < 16)
                    {
                        pnlLunchStarters.Visible = true;
                        List<Dish> lunchStarters = dishLogic.GetStarters("Starter", 1);
                        ReadFood(listviewLunchFood, lunchStarters);
                    }
                    else if (DateTime.Now.Hour >= 16)
                    {
                        pnlDinnerStarter.Visible = true;
                        List<Dish> dinnerStarters = dishLogic.GetStarters("Starter", 2);
                        ReadFood(listviewDinnerStarter, dinnerStarters);
                    }                               
                    break;

                case "Dessert":
                    if (DateTime.Now.Hour < 16)
                    {
                        pnlDessert.Visible = true;
                        List<Dish> lunchDesserts = dishLogic.GetDishes("Dessert", 1);
                        ReadFood(listviewDessert, lunchDesserts);
                    }
                    else if (DateTime.Now.Hour >= 16)
                    {
                        pnlDinnerDessert.Visible = true;
                        List<Dish> dinnerDesserts = dishLogic.GetDishes("Dessert", 2);
                        ReadFood(listviewDinnerDessert, dinnerDesserts);
                    }
                    break;

                case "Main":
                    if (DateTime.Now.Hour < 16)
                    {
                        pnlMain.Visible = true;
                        List<Dish> lunchMains = dishLogic.GetDishes("Main", 1);
                        ReadFood(listivewLunchMain, lunchMains);
                    }
                    else if (DateTime.Now.Hour >= 16)
                    {
                        pnlDinnerMain.Visible = true;
                        List<Dish> dinnerMains = dishLogic.GetDishes("Main", 2);
                        ReadFood(listviewDinnerMain, dinnerMains);
                    }
                    break;

                case "Drinks":
                    pnlDrinks.Visible = true;                 
                    List<Drink> drinks = drinkLogic.GetAllDrinks();
                    ReadDrinks(listviewDrinks,drinks);                  
                    break;
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            HidePanels();
            ButtonColorReset();
        }

        private void ButtonColorReset()
        {
            btnStarter.BackColor = Color.LightSkyBlue;
            btnDrinks.BackColor = Color.LightSkyBlue;
            btnMain.BackColor = Color.LightSkyBlue;
            btnDessert.BackColor = Color.LightSkyBlue;
        }
        private void SendCancelNoteButtonsVisible()
        {
            btnSendOrder.Visible = true;
            btnCancelOrder.Visible = true;
            btnOrderAddNote.Visible = true;
            txtNote.Visible = true;
            btnOrderRemove.Visible = true;
        }
        void HidePanels()
        {
            pnlLunchStarters.Hide();
            pnlDessert.Hide();
            pnlDinnerStarter.Hide();
            pnlDrinks.Hide();
            pnlMain.Hide();
            pnlDinnerMain.Hide();
            pnlDinnerDessert.Hide();
        }
        private void ReadContainedItems() // Getting the ordered list
        {
            try
            {
                List<Dish> orderedDishes = dishLogic.ReadContainedDishes(table); // Read all ordered Dishes 
                List<Drink> orderedDrinks = drinkLogic.ReadContainedDrinks(table); // Read all ordered Drinks
                List<Item> itemsInOrder = new List<Item>();
                itemsInOrder.AddRange(orderedDishes); // Add Dishes to item list
                itemsInOrder.AddRange(orderedDrinks);// Add Drinks to item list
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
            catch
            {
                MessageBox.Show("Something went wrong!");
            }
        }
        private void ReadFood(ListView listview, List<Dish> dishes)
        {
            listview.Items.Clear();

            foreach (Dish dish in dishes)
            {
                ListViewItem li = new ListViewItem(dish.ItemName.ToString());
                li.SubItems.Add(dish.ItemPrice.ToString());
                li.Tag = dish;
                listview.Items.Add(li);
                if (dish.ItemStock == 0)
                {
                    li.ForeColor = Color.DarkGray;
                }

            }
        }
        private void ReadDrinks(ListView listview, List<Drink> drinks)
        {
            listview.Items.Clear();

            foreach (Drink drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.ItemName.ToString());
                li.SubItems.Add(drink.ItemPrice.ToString());
                li.Tag = drink;
                listview.Items.Add(li);
                if (drink.ItemStock == 0)
                {
                    li.ForeColor = Color.DarkGray;
                }
            }
        }
        private void btnStarter_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Starter");
                ButtonColorReset();
                btnStarter.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Dessert");
                ButtonColorReset();
                btnDessert.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Main");
                ButtonColorReset();
                btnMain.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Drinks");
                ButtonColorReset();
                btnDrinks.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void listviewLunchFood_SelectedIndexChanged(object sender, EventArgs e) // For resit
        {
            try
            {
                if (listviewLunchFood.SelectedItems.Count == 1)
                {
                    AddFood(listviewLunchFood);
                    SendCancelNoteButtonsVisible();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }

        private void listviewFoodDinner_SelectedIndexChanged(object sender, EventArgs e) // For resit
        {
            try
            {
                if (listviewDinnerStarter.SelectedItems.Count == 1)
                {
                    AddFood(listviewDinnerStarter);
                    SendCancelNoteButtonsVisible();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void listviewDrinks_SelectedIndexChanged(object sender, EventArgs e) // For resit
        {
            try
            {
                if (listviewDrinks.SelectedItems.Count == 1)
                {
                    AddDrinks(listviewDrinks);
                    SendCancelNoteButtonsVisible();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void listviewDessert_SelectedIndexChanged(object sender, EventArgs e) // For resit
        {
            try
            {
                if (listviewDessert.SelectedItems.Count == 1)
                {
                    AddFood(listviewDessert);
                    SendCancelNoteButtonsVisible();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void listivewLunchMain_SelectedIndexChanged(object sender, EventArgs e) // For resit
        {
            try
            {
                if (listivewLunchMain.SelectedItems.Count == 1)
                {
                    AddFood(listivewLunchMain);
                    SendCancelNoteButtonsVisible();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void listviewDinnerMain_SelectedIndexChanged(object sender, EventArgs e) // For resit
        {
            try
            {
                if (listviewDinnerMain.SelectedItems.Count == 1)
                {
                    AddFood(listviewDinnerMain);
                    SendCancelNoteButtonsVisible();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void listviewDinnerDessert_SelectedIndexChanged(object sender, EventArgs e) // For resit
        {
            try
            {
                if (listviewDinnerDessert.SelectedItems.Count == 1)
                {
                    AddFood(listviewDinnerDessert);
                    SendCancelNoteButtonsVisible();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void AddFood(ListView listview)
        {
            ListViewItem selectedFood = listview.SelectedItems[0];
            Dish dish = (Dish)selectedFood.Tag;
            CheckCurrentDish(dish);
            orderLogic.DecreaseStock(dish.ItemID);
        }

        private void AddDrinks(ListView listview)
        {
            ListViewItem selectedDrink = listview.SelectedItems[0];
            Drink drink = (Drink)selectedDrink.Tag;
            CheckCurrentDrink(drink);
            orderLogic.DecreaseStock(drink.ItemID);
        }
        private void CheckCurrentDish(Dish dish)
        {
            ListViewItem? currentItem = null;

            if (dish.ItemStock <= 0)
            {
                throw new Exception($"{dish.ItemName} is sold out");
            }

            foreach (ListViewItem lvItem in listviewOrder.Items)
            {
                if (dish.ItemName == lvItem.SubItems[0].Text && lvItem.ForeColor != Color.Green)
                {
                    currentItem = lvItem;
                    dish.ItemAmount = int.Parse(lvItem.SubItems[2].Text);
                    dish.ItemAmount++;
                    lvItem.SubItems[2].Text = dish.ItemAmount.ToString();
                }
            }

            if (currentItem == null)
            {
                ListViewItem lvItem = new ListViewItem(dish.ItemName);
                lvItem.SubItems.Add(dish.ItemPrice.ToString());
                dish.ItemAmount = 1;
                lvItem.SubItems.Add(dish.ItemAmount.ToString());
                lvItem.Tag = dish;
                lvItem.ForeColor = Color.Red; // Change color for the new ordered item
                listviewOrder.Items.Add(lvItem);
            }
        }
        private void CheckCurrentDrink(Drink drink)
        {
            ListViewItem? currentItem = null;

            if (drink.ItemStock <= 0)
            {
                throw new Exception($"{drink.ItemName} is sold out");
            }

            foreach (ListViewItem item in listviewOrder.Items)
            {
                if (drink.ItemName == item.SubItems[0].Text && item.ForeColor != Color.Green)
                {
                    currentItem = item;
                    drink.ItemAmount = int.Parse(item.SubItems[2].Text);
                    drink.ItemAmount++;
                    item.SubItems[2].Text = drink.ItemAmount.ToString();
                }
            }

            if (currentItem == null)
            {
                ListViewItem item = new ListViewItem(drink.ItemName);
                item.SubItems.Add(drink.ItemPrice.ToString());
                drink.ItemAmount = 1;
                item.SubItems.Add(drink.ItemAmount.ToString());
                item.Tag = drink;
                item.ForeColor = Color.Red; // Change color for the new ordered item
                listviewOrder.Items.Add(item);
            }          
        }
        private void btnOrderRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewOrder.SelectedItems.Count == 0)
                {
                    throw new Exception($"Oops {emp.Name}, please select an item");
                }

                Item item = (Item)listviewOrder.SelectedItems[0].Tag; // Remove the ORDERED STARTER FROM ORDER LIST
                ListViewItem lvItem = listviewOrder.SelectedItems[0];
                if (item is Dish)
                {
                    RemoveItem(lvItem, (Dish)item);
                }
                else if (item is Drink)
                {
                    RemoveItem(lvItem, (Drink)item);
                }
                orderLogic.IncreaseStock(item.ItemID);
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }
        }
        private void RemoveItem(ListViewItem lvItem, Item item)
        {
            if (item.ItemName == lvItem.SubItems[0].Text && lvItem.SubItems[0].ForeColor == Color.Green)
            {
                throw new Exception($"{emp.Name}, you cannot edit an old item");
            }

            if (item.ItemAmount == 1)
            {
                listviewOrder.Items.RemoveAt(listviewOrder.SelectedItems[0].Index);
            }
            else
            {
                item.ItemAmount--;
                listviewOrder.SelectedItems[0].SubItems[2].Text = item.ItemAmount.ToString();
            }
        }
        private void btnCancelOrder_Click(object sender, EventArgs e) // Clear the order list
        {
            try
            {
                if (listviewOrder.Items.Count == 0)
                {
                    throw new Exception($"{emp.Name}, you did not order anything!");
                }

                DialogResult dialogResult = MessageBox.Show("Do you want to cancel new order?", "Cancel Order", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    UpdateCanceledStock();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateCanceledStock();
                this.Close();
                new TableControl(emp, rosMain, table).Show();
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void UpdateCanceledStock()
        {
            foreach (ListViewItem lvOrderInProcess in listviewOrder.Items) // Update stock when back and cancel is clicked
            {
                Item item = (Item)lvOrderInProcess.Tag;
                {
                    if (lvOrderInProcess.ForeColor == Color.Red)
                    {
                        listviewOrder.Items.Remove(lvOrderInProcess);
                        item.ItemName = lvOrderInProcess.SubItems[0].Text;
                        item.ItemAmount = int.Parse(lvOrderInProcess.SubItems[2].Text);
                        orderLogic.UpdateStock(item);
                    }
                }
            }
        }
        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewOrder.Items.Count == 0) // Extra checking
                {
                    throw new Exception($"Sorry {emp.Name}, there is nothing to send");
                }
                DialogResult dialogResult = MessageBox.Show("Do you want to send this order?", "Send Order", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    order.OrderID = orderLogic.AddOrder(emp, table); // Create new order with waiterId and tableNumber                
                    SendOrder(); // adding the items in the listviewOrder to dish and drink list              
                    dishLogic.AddDishes(DishesInOrderProcess, order); // DishesInOrderProcess(comes from SendOrder) is the new ordered dishes 
                    drinkLogic.AddDrinks(DrinkInOrderProcess, order);// DrinkInOrderProcess(comes from SendOrder) is the new ordered drinks

                    table.TableStatus = TableStatus.Standby; // Jason
                    tableLogic.Update(table); // Jason                    
                    rosMain.UpdateAllListViews(); //Update KitchenView and Barview
                    rosMain.UpdateTableToOrdered(table.TableNumber); //Update TableView

                    this.Close();
                    new TableOverview(emp, rosMain).Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Send Order");
            }
        }
        private void SendOrder()
        {
            for (int i = 0; i < listviewOrder.Items.Count; i++)
            {
                Item itemInOrderList = (Item)listviewOrder.Items[i].Tag; // Tag all the item as item in listview
                ListViewItem lvItemInOrderList = listviewOrder.Items[i];

                if (lvItemInOrderList.ForeColor == Color.Red && itemInOrderList is Dish)
                {
                    Dish dish = (Dish)itemInOrderList;
                    DishesInOrderProcess.Add(dish);
                }
                else if (lvItemInOrderList.ForeColor == Color.Red && itemInOrderList is Drink)
                {
                    Drink drink = (Drink)itemInOrderList;
                    DrinkInOrderProcess.Add(drink);
                }
            }
        }
        private void btnOrderAddNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewOrder.SelectedItems.Count == 0)
                {
                    throw new Exception($"{emp.Name}, please select an item");
                }

                if (listviewOrder.SelectedItems[0].ForeColor != Color.Green)
                {
                    AddItemNote();
                }
                else
                {
                    throw new Exception($"Oops {emp.Name}, you cannot add note to ordered item");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                txtNote.Clear();
            }
        }
        private void AddItemNote()
        {
            Item item;

            if (listviewOrder.SelectedItems.Count > 0 && listviewOrder.SelectedItems[0].ForeColor == Color.Red)
            {
                if (txtNote.Text == "")
                {
                    return;
                }
                item = (Item)listviewOrder.SelectedItems[0].Tag;
                if (item is Dish)
                {
                    Dish dish = (Dish)item;
                    dish.ItemNote = txtNote.Text;
                }
                else if (item is Drink)
                {
                    Drink drink = (Drink)item;
                    drink.ItemNote = txtNote.Text;
                }
                MessageBox.Show($"{emp.Name}, you have added the note!");
            }
        }
    }
}
