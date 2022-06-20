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
            HideListViews();
            switch (panelName)
            {
                case "Lunch":
                    listviewLunch.Show();
                    List<Dish> lunchMeals = dishLogic.GetDishes(1);
                    ReadFood(listviewLunch, lunchMeals);                              
                    break;
                case "Dinner":
                    listviewDinner.Show();
                    List<Dish> dinnerMeals = dishLogic.GetDishes(2);
                    ReadFood(listviewDinner, dinnerMeals);
                    break;
                case "Drinks":
                    listviewDrinks.Show();                
                    List<Drink> drinks = drinkLogic.GetAllDrinks();
                    ReadDrinks(listviewDrinks,drinks);                  
                    break;
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            HideListViews();
            ButtonColorReset();
        }

        private void ButtonColorReset()
        {
            btnLunch.BackColor = Color.LightSkyBlue;
            btnDrinks.BackColor = Color.LightSkyBlue;
            btnDinner.BackColor = Color.LightSkyBlue;
        }
        private void SendCancelNoteButtonsVisible()
        {
            btnSendOrder.Visible = true;
            btnCancelOrder.Visible = true;
            btnOrderAddNote.Visible = true;
            txtNote.Visible = true;
        }
        void HideListViews()
        {
            listviewLunch.Hide();
            listviewDinner.Hide();
            listviewDrinks.Hide();
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

                if (listview.Items.IndexOf(li) % 2 == 0)
                {
                    li.BackColor = Color.FromArgb(224, 234, 255);
                }

                if (dish.ItemStock == 0)
                {
                    li.BackColor = Color.DarkGray;
                    li.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Strikeout);
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

                if (listview.Items.IndexOf(li) % 2 == 0)
                {
                    li.BackColor = Color.FromArgb(224, 234, 255);
                }
                if (drink.ItemStock == 0)
                {
                   li.BackColor = Color.DarkGray;
                   li.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Strikeout);
                }
            }
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Lunch");
                ButtonColorReset();
                listviewDinner.SelectedItems.Clear();
                listviewDrinks.SelectedItems.Clear();
                btnLunch.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnDinner_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Dinner");
                ButtonColorReset();
                listviewLunch.SelectedItems.Clear();
                listviewDrinks.SelectedItems.Clear();
                btnDinner.BackColor = Color.LightGreen;
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
                listviewLunch.SelectedItems.Clear();
                listviewDinner.SelectedItems.Clear();
                btnDrinks.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void listviewLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listviewLunch.SelectedItems.Count == 1 && listviewLunch.SelectedItems[0].BackColor == Color.DarkGray)
                {
                    listviewLunch.SelectedItems[0].Selected = false;
                    return;
                }
                if (listviewLunch.SelectedItems.Count == 1)
                {
                    AddFood(listviewLunch);
                    SendCancelNoteButtonsVisible();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void listviewDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listviewDinner.SelectedItems.Count == 1 && listviewDinner.SelectedItems[0].BackColor == Color.DarkGray)
                {
                    listviewDinner.SelectedItems[0].Selected = false;
                    return;
                }
                if (listviewDinner.SelectedItems.Count == 1)
                {
                    AddFood(listviewDinner);
                    SendCancelNoteButtonsVisible();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void listviewDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listviewDrinks.SelectedItems.Count == 1 && listviewDrinks.SelectedItems[0].BackColor == Color.DarkGray)
                {
                    listviewDrinks.SelectedItems[0].Selected = false;
                    return;
                }
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
        private void listviewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listviewDinner.SelectedItems.Clear();
                listviewLunch.SelectedItems.Clear();
                listviewDrinks.SelectedItems.Clear();
                if (listviewOrder.SelectedItems.Count == 1)
                {
                    Item item = (Item)listviewOrder.SelectedItems[0].Tag;
                    ListViewItem lvItem = listviewOrder.SelectedItems[0];
                    if (item is Dish)
                    {
                        RemoveItem(lvItem, (Dish)item); // Remove the dish from the list
                    }
                    else if (item is Drink)
                    {
                        RemoveItem(lvItem, (Drink)item); // Remove the drink from the list
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }
        }

        private void AddFood(ListView listview)
        {
            ListViewItem selectedFood = listview.SelectedItems[0];
            Dish dish = (Dish)selectedFood.Tag;
            CheckCurrentDish(dish);
        }

        private void AddDrinks(ListView listview)
        {
            ListViewItem selectedDrink = listview.SelectedItems[0];
            Drink drink = (Drink)selectedDrink.Tag;
            CheckCurrentDrink(drink);
        }
        private void CheckCurrentDish(Dish dish)
        {
            ListViewItem? currentItem = null;

            if (dish.ItemStock <= 0) // Extra checking for the sold out items, already enabled
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

            if (drink.ItemStock <= 0) // Extra checking for the sold out items, already enabled
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
        private void RemoveItem(ListViewItem lvItem, Item item)
        {

            if (item.ItemName == lvItem.SubItems[0].Text && lvItem.SubItems[0].ForeColor == Color.Green) // Disabling the ordered item to choose and remove
            {
                lvItem.Selected = false;
                return;
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
                    CancelOrder();
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
                CancelOrder();
                this.Close();
                new TableControl(emp, rosMain, table).Show();
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void CancelOrder()
        {
            foreach (ListViewItem lvOrderInProcess in listviewOrder.Items) // Remove the items from order list
            {
                if (lvOrderInProcess.ForeColor == Color.Red)
                {
                    listviewOrder.Items.Remove(lvOrderInProcess);
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
                    DecreaseStock();

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

        private void DecreaseStock()
        {
            foreach (ListViewItem lvOrderInProcess in listviewOrder.Items) // Decrease stock when order is sent
            {
                Item item = (Item)lvOrderInProcess.Tag;
                {
                    if (lvOrderInProcess.ForeColor == Color.Red)
                    {
                        item.ItemName = lvOrderInProcess.SubItems[0].Text;
                        item.ItemAmount = int.Parse(lvOrderInProcess.SubItems[2].Text);
                        orderLogic.DecreaseStock(item);
                    }
                }
            }
        }

        private void btnOrderAddNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewOrder.SelectedItems.Count > 0) // Disabling the ordered items
                {
                    listviewOrder.SelectedItems[0].Selected = false;
                    return;
                }
                AddItemNote(); // Add note according to its list
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
            if (txtNote.Text == "")
            {
                return;
            }

            if (listviewLunch.SelectedItems.Count == 1)
            {
                Dish dish = (Dish)listviewLunch.SelectedItems[0].Tag;
                dish.ItemNote = txtNote.Text;
                listviewLunch.SelectedItems.Clear();
                MessageBox.Show($"{emp.Name}, you have added the note!");
            }
            else if (listviewDinner.SelectedItems.Count == 1)
            {
                Dish dish = (Dish)listviewDinner.SelectedItems[0].Tag;
                dish.ItemNote = txtNote.Text;
                listviewDinner.SelectedItems.Clear();
                MessageBox.Show($"{emp.Name}, you have added the note!");
            }
            else if (listviewDrinks.SelectedItems.Count == 1)
            {
                Drink drink = (Drink)listviewDrinks.SelectedItems[0].Tag;
                drink.ItemNote = txtNote.Text;
                listviewDrinks.SelectedItems.Clear();
                MessageBox.Show($"{emp.Name}, you have added the note!");
            }        
        }
    }
}
