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
        TableLogic tableLogic;
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
            tableLogic = new TableLogic();
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

                case "DinnerStarters":
                    pnlDinnerStarters.Show();
                    pnlDinnerStarters.Visible = true;
                    pnlDinner.Visible = true;
                    ReadDinnerStarters();
                    break;

                case "DinnerMains":
                    pnlDinnerMains.Show();
                    pnlDinnerMains.Visible = true;
                    pnlDinner.Visible = true;
                    ReadDinnerMains();
                    break;

                case "DinnerDesserts":
                    pnlDinnerDesserts.Show();
                    pnlDinnerDesserts.Visible = true;
                    pnlDinner.Visible = true;
                    ReadDinnerDesserts();
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

                case "Beers":
                    pnlBeers.Show();
                    pnlBeers.Visible = true;
                    pnlDrinkCategories.Visible = true;
                    ReadBeers();
                    break;

                case "Wines":
                    pnlWines.Show();
                    pnlBeers.Visible = true;
                    pnlDrinkCategories.Visible = true;
                    ReadWines();
                    break;

                case "Spirits":
                    pnlSpirits.Show();
                    pnlSpirits.Visible = true;
                    pnlDrinkCategories.Visible = true;
                    ReadSpirits();
                    break;

                case "HotDrinks":
                    pnlHotDrinks.Show();
                    pnlHotDrinks.Visible = true;
                    pnlDrinkCategories.Visible = true;
                    ReadHotDrinks();
                    break;
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            HidePanels();
            btnSendOrder.Visible = false;
            btnCancelOrder.Visible = false;
            ButtonColorReset();
        }

        private void ButtonColorReset()
        {
            btnLunch.BackColor = default(Color);
            btnStarters.BackColor = default(Color);
            btnMains.BackColor = default(Color);
            btnDesserts.BackColor = default(Color);
            btnDinner.BackColor = default(Color);
            btnStartersDinner.BackColor = default(Color);
            btnMainsDinners.BackColor = default(Color);
            btnDessertsDinner.BackColor = default(Color);
            btnDrinks.BackColor = default(Color);
            btnSoftDrink.BackColor = default(Color);
            btnBeers.BackColor = default(Color);
            btnWine.BackColor = default(Color);
            btnSpirits.BackColor = default(Color);
            btnHotDrinks.BackColor = default(Color);
        }
        private void btnLunch_Click(object sender, EventArgs e)
        {
            showPanel("Lunch");
            ButtonColorReset();
            btnLunch.BackColor = Color.LightGreen;
            SendCancelButtonsVisible();
        }
        private void btnStarters_Click(object sender, EventArgs e)
        {
            showPanel("Starters");
            ButtonColorReset();
            btnStarters.BackColor = Color.LightGreen;
            SendCancelButtonsVisible();
        }
        private void btnMains_Click_1(object sender, EventArgs e)
        {
            showPanel("Mains");
            ButtonColorReset();
            btnMains.BackColor = Color.LightGreen;
            SendCancelButtonsVisible();
        }
        private void btnDesserts_Click(object sender, EventArgs e)
        {
            showPanel("Desserts");
            ButtonColorReset();
            btnDesserts.BackColor = Color.LightGreen;
            SendCancelButtonsVisible();
        }
        private void btnDinner_Click(object sender, EventArgs e)
        {
            showPanel("Dinner");
            ButtonColorReset();
            btnDinner.BackColor = Color.LightGreen;
            SendCancelButtonsVisible();
        }
        private void btnStartersDinner_Click(object sender, EventArgs e)
        {
            showPanel("DinnerStarters");
            ButtonColorReset();
            btnStartersDinner.BackColor = Color.LightGreen;
            SendCancelButtonsVisible();
        }
        private void btnMainsDinners_Click(object sender, EventArgs e)
        {
            showPanel("DinnerMains");
            ButtonColorReset();
            btnMainsDinners.BackColor = Color.LightGreen;
            SendCancelButtonsVisible();
        }
        private void btnDessertsDinner_Click(object sender, EventArgs e)
        {
            showPanel("DinnerDesserts");
            ButtonColorReset();
            btnDessertsDinner.BackColor = Color.LightGreen;
            SendCancelButtonsVisible();
        }
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            showPanel("Drinks");
            ButtonColorReset();
            btnDrinks.BackColor = Color.LightGreen;
            SendCancelButtonsVisible();
        }

        private void btnSoftDrink_Click(object sender, EventArgs e)
        {
            showPanel("SoftDrinks");
            ButtonColorReset();
            btnSoftDrink.BackColor = Color.LightGreen;
            SendCancelButtonsVisible();
        }
        private void btnBeers_Click(object sender, EventArgs e)
        {
            showPanel("Beers");
            ButtonColorReset();
            btnBeers.BackColor = Color.LightGreen;
            SendCancelButtonsVisible();
        }
        private void btnWine_Click(object sender, EventArgs e)
        {
            showPanel("Wines");
            ButtonColorReset();
            btnWine.BackColor = Color.LightGreen;
            SendCancelButtonsVisible();
        }

        private void btnSpirits_Click(object sender, EventArgs e)
        {
            showPanel("Spirits");
            ButtonColorReset();
            btnSpirits.BackColor = Color.LightGreen;
            SendCancelButtonsVisible();
        }

        private void btnHotDrinks_Click(object sender, EventArgs e)
        {
            showPanel("HotDrinks");
            ButtonColorReset();
            btnHotDrinks.BackColor = Color.LightGreen;
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
            pnlDrinkCategories.Hide();

            pnlStarters.Hide();
            pnlMains.Hide();
            pnlDesserts.Hide();

            pnlDinnerStarters.Hide();
            pnlDinnerMains.Hide();
            pnlDinnerDesserts.Hide();

            pnlSoftDrinks.Hide();
            pnlBeers.Hide();
            pnlWines.Hide();
            pnlSpirits.Hide();
            pnlHotDrinks.Hide();

        }

        private void ReadStarters()
        {
            List<Dish> starters = dishLogic.GetLunchStarters();
            listviewStarters.Items.Clear();

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

            foreach (Dish main in mains)
            {
                ListViewItem li = new ListViewItem(main.ItemName.ToString());
                li.SubItems.Add(main.ItemPrice.ToString());
                li.Tag = main; // Tagging the object
                listviewMains.Items.Add(li);
            }
        }

        private void ReadLunchDesserts()
        {
            List<Dish> desserts = dishLogic.GetLunchDesserts();
            listviewDesserts.Items.Clear();

            foreach (Dish dessert in desserts)
            {
                ListViewItem li = new ListViewItem(dessert.ItemName.ToString());
                li.SubItems.Add(dessert.ItemPrice.ToString());
                li.Tag = dessert; // Tagging the object
                listviewDesserts.Items.Add(li);
            }
        }

        private void ReadDinnerStarters()
        {
            List<Dish> starters = dishLogic.GetDinnerStarters();
            listviewDinnerStarters.Items.Clear();

            foreach (Dish starter in starters)
            {
                ListViewItem li = new ListViewItem(starter.ItemName.ToString());
                li.SubItems.Add(starter.ItemPrice.ToString());
                li.Tag = starter; // Tagging the object
                listviewDinnerStarters.Items.Add(li);
            }
        }

        private void ReadDinnerMains()
        {
            List<Dish> mains = dishLogic.GetDinnerMains();
            listviewDinnerMains.Items.Clear();

            foreach (Dish main in mains)
            {
                ListViewItem li = new ListViewItem(main.ItemName.ToString());
                li.SubItems.Add(main.ItemPrice.ToString());
                li.Tag = main; // Tagging the object
                listviewDinnerMains.Items.Add(li);
            }
        }

        private void ReadDinnerDesserts()
        {
            List<Dish> desserts = dishLogic.GetDinnerDesserts();
            listViewDinnerDesserts.Items.Clear();

            foreach (Dish dessert in desserts)
            {
                ListViewItem li = new ListViewItem(dessert.ItemName.ToString());
                li.SubItems.Add(dessert.ItemPrice.ToString());
                li.Tag = dessert; // Tagging the object
                listViewDinnerDesserts.Items.Add(li);
            }
        }

        private void ReadSoftDrinks()
        {
            List<Drink> softDrinks = drinkLogic.GetAllSoftDrinks();

            listviewSoftDrinks.Items.Clear();
            foreach (Drink softDrink in softDrinks)
            {
                ListViewItem li = new ListViewItem(softDrink.ItemName.ToString());
                li.SubItems.Add(softDrink.ItemPrice.ToString());
                li.Tag = softDrink; // Tagging the object
                listviewSoftDrinks.Items.Add(li);
            }
        }
        private void ReadBeers()
        {
            List<Drink> beers = drinkLogic.GetAllBeers();
            listviewBeers.Items.Clear();

            foreach (Drink beer in beers)
            {
                ListViewItem li = new ListViewItem(beer.ItemName.ToString());
                li.SubItems.Add(beer.ItemPrice.ToString());
                li.Tag = beer; // Tagging the object
                listviewBeers.Items.Add(li);
            }
        }

        private void ReadWines()
        {
            List<Drink> wines = drinkLogic.GetAllWines();
            listviewWines.Items.Clear();

            foreach (Drink wine in wines)
            {
                ListViewItem li = new ListViewItem(wine.ItemName.ToString());
                li.SubItems.Add(wine.ItemPrice.ToString());
                li.Tag = wine; // Tagging the object
                listviewWines.Items.Add(li);
            }
        }

        private void ReadSpirits()
        {
            List<Drink> spirits = drinkLogic.GetAllSpirits();
            listViewSpirits.Items.Clear();


            foreach (Drink spirit in spirits)
            {
                ListViewItem li = new ListViewItem(spirit.ItemName.ToString());
                li.SubItems.Add(spirit.ItemPrice.ToString());
                li.Tag = spirit; // Tagging the object
                listViewSpirits.Items.Add(li);
            }
        }
        private void ReadHotDrinks()
        {
            List<Drink> hotDrinks = drinkLogic.GetAllHotDrinks();

            listViewHotDrinks.Items.Clear();
            foreach (Drink hotDrink in hotDrinks)
            {
                ListViewItem li = new ListViewItem(hotDrink.ItemName.ToString());
                li.SubItems.Add(hotDrink.ItemPrice.ToString());
                li.Tag = hotDrink; // Tagging the object
                listViewHotDrinks.Items.Add(li);
            }
        }

        private void btnAddStarter_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewStarters.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an item");
                }
                else
                {
                    AddLunchStarter();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }
        }
        private void btnAddMains_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewMains.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an item");
                }
                else
                {
                    AddLunchMain();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }
        }
        private void btnAddDessert_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewDesserts.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an item");
                }
                else
                {
                    AddLunchDessert();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }
        }
        private void btnAddDinnerMains_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewDinnerMains.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an item");
                }
                else
                {
                    AddDinnerMain();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }
        }
        private void btnAddDinnerStarter_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewDinnerStarters.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an item");
                }
                else
                {
                    AddDinnerStarter();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }
        }
        private void btnAddDinnerDesserts_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDinnerDesserts.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an item");
                }
                else
                {
                    AddDinnerDessert();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }
        }
        private void btnAddDrink_Click(object sender, EventArgs e) // Soft Drink
        {
            try
            {
                if (listviewSoftDrinks.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an item");
                }
                else
                {
                    AddSoftDrink();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }
        }
        private void btnAddBeers_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewBeers.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an item");
                }
                else
                {
                    AddBeer();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }
        }

        private void btnAddWines_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewWines.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an item");
                }
                else
                {
                    AddWine();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }
        }

        private void btnAddSpirits_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSpirits.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an item");
                }
                else
                {
                    AddSpirit();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }
        }

        private void btnAddHotDrinks_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewHotDrinks.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an item");
                }
                else
                {
                    AddHotDrink();
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }
        }

        private void btnOrderRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = (Item)listviewOrder.SelectedItems[0].Tag; // Remove the ORDERED STARTER FROM ORDER LIST
                ListViewItem li = listviewOrder.SelectedItems[0];

                if (listviewOrder.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an item");
                }
                else
                {
                    if (item is Dish)
                    {
                        Dish dish = (Dish)listviewOrder.SelectedItems[0].Tag;
                        if (dish.ItemName == li.SubItems[0].Text && li.SubItems[0].ForeColor == Color.Green)
                        {
                            throw new Exception("You cannot edit an old item");
                        }
                        else
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
                    }
                    else if (item is Drink)
                    {
                        Drink drink = (Drink)listviewOrder.SelectedItems[0].Tag;
                        if (drink.ItemName == li.SubItems[0].Text && li.SubItems[0].ForeColor == Color.Green)
                        {
                            throw new Exception("You cannot edit an old item");
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
            }
            catch(Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }       
        }

        private void AddLunchStarter()
        {
            ListViewItem selectedStarter = listviewStarters.SelectedItems[0];
            Dish starter = (Dish)selectedStarter.Tag;
            CheckCurrentDish(starter);
        }

        private void AddLunchMain()
        {
            ListViewItem selectedMain = listviewMains.SelectedItems[0];
            Dish main = (Dish)selectedMain.Tag;
            CheckCurrentDish(main);
        }

        private void AddLunchDessert()
        {
            ListViewItem selectedDessert = listviewDesserts.SelectedItems[0];
            Dish dessert = (Dish)selectedDessert.Tag;
            CheckCurrentDish(dessert);
        }
        private void AddDinnerStarter()
        {
            ListViewItem selectedStarter = listviewDinnerStarters.SelectedItems[0];
            Dish starter = (Dish)selectedStarter.Tag;
            CheckCurrentDish(starter);
        }

        private void AddDinnerMain()
        {
            ListViewItem selectedMain = listviewDinnerMains.SelectedItems[0];
            Dish main = (Dish)selectedMain.Tag;
            CheckCurrentDish(main);
        }
        private void AddDinnerDessert()
        {
            ListViewItem selectedDessert = listViewDinnerDesserts.SelectedItems[0];
            Dish dessert = (Dish)selectedDessert.Tag;
            CheckCurrentDish(dessert);
        }

        private void AddSoftDrink()
        {
            ListViewItem selectedSoftDrink = listviewSoftDrinks.SelectedItems[0];
            Drink softDrink = (Drink)selectedSoftDrink.Tag;
            CheckCurrentDrink(softDrink);
        }

        private void AddBeer()
        {
            ListViewItem selectedBeer = listviewBeers.SelectedItems[0];
            Drink beer = (Drink)selectedBeer.Tag;
            CheckCurrentDrink(beer);
        }

        private void AddWine()
        {
            ListViewItem selectedWine = listviewWines.SelectedItems[0];
            Drink wine = (Drink)selectedWine.Tag;
            CheckCurrentDrink(wine);
        }

        private void AddSpirit()
        {
            ListViewItem selectedSpirit = listViewSpirits.SelectedItems[0];
            Drink spirit = (Drink)selectedSpirit.Tag;
            CheckCurrentDrink(spirit);
        }

        private void AddHotDrink()
        {
            ListViewItem selectedHotDrink = listViewHotDrinks.SelectedItems[0];
            Drink hotDrink = (Drink)selectedHotDrink.Tag;
            CheckCurrentDrink(hotDrink);          
        }
        private void CheckCurrentDish(Dish dish)
        {
            ListViewItem? currentItem = null;

            if (dish.ItemStock <= 0)
            {
                MessageBox.Show($"{dish.ItemName} is sold out", "Sorry");
            }
            else
            {
                foreach (ListViewItem item in listviewOrder.Items)
                {
                    if (dish.ItemName == item.SubItems[0].Text && item.ForeColor != Color.Green)
                    {
                        currentItem = item;
                        dish.Amount = int.Parse(item.SubItems[2].Text);
                        dish.Amount++;
                        item.SubItems[2].Text = dish.Amount.ToString();
                    }
                }

                if (currentItem == null)
                {
                    ListViewItem item = new ListViewItem(dish.ItemName);
                    item.SubItems.Add(dish.ItemPrice.ToString());
                    dish.Amount = 1;
                    item.SubItems.Add(dish.Amount.ToString());
                    item.Tag = (Item)dish;
                    item.ForeColor = Color.Red; // Change color for the new ordered item
                    listviewOrder.Items.Add(item);
                }
                dishLogic.DecreaseDishStock(dish);
            }
        }

        private void CheckCurrentDrink(Drink drink)
        {
            ListViewItem? currentItem = null;

            if(drink.ItemStock <= 0)
            {
                MessageBox.Show($"{drink.ItemName} is sold out", "Sorry");
            }
            else
            {
                foreach (ListViewItem item in listviewOrder.Items)
                {
                    if (drink.ItemName == item.SubItems[0].Text && item.ForeColor != Color.Green)
                    {
                        currentItem = item;
                        drink.Amount = int.Parse(item.SubItems[2].Text);
                        drink.Amount++;
                        item.SubItems[2].Text = drink.Amount.ToString();
                    }
                }

                if (currentItem == null)
                {
                    ListViewItem item = new ListViewItem(drink.ItemName);
                    item.SubItems.Add(drink.ItemPrice.ToString());
                    drink.Amount = 1;
                    item.SubItems.Add(drink.Amount.ToString());
                    item.Tag = (Item)drink;
                    item.ForeColor = Color.Red; // Change color for the new ordered item
                    listviewOrder.Items.Add(item);
                }
                drinkLogic.DecreaseDrinkStock(drink);
            }
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

        private void btnCancelOrder_Click(object sender, EventArgs e) // Clear the order list
        {
            try
            {
                if (listviewOrder.Items.Count == 0)
                {
                    throw new Exception("You did not order anything!");
                }
                else
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
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }


        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to send this order?", "Send Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                orderLogic.AddOrder(order); // Create new order

                // send order - ( and grouping the old items' amount by adding the new items' amount)
                SendOrder();

                //Adding completely new dishes and drinks to Order_Dish and Order_Drink tables
                orderedDishLogic.AddDishes(DishesInOrderProcess, order);
                orderedDrinkLogic.AddDrinks(DrinkInOrderProcess, order);

                table.TableStatus = 2;
                tableLogic.Update(table);

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
            try
            {
                if (listviewOrder.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an item");
                }
                else
                {
                    Item item = (Item)listviewOrder.SelectedItems[0].Tag;

                    if (item is Dish)
                    {
                        Dish dish = (Dish)listviewOrder.SelectedItems[0].Tag;
                        if (txtNote.Text == "")
                        {
                            throw new Exception("There is no note");
                        }
                        else
                        {
                            dish.Note = txtNote.Text;
                            MessageBox.Show("Note has been added!");
                        }
                    }
                    else if (item is Drink)
                    {
                        Drink drink = (Drink)listviewOrder.SelectedItems[0].Tag;
                        if (txtNote.Text == "")
                        {
                            throw new Exception("There is no note");
                        }
                        else
                        {
                            drink.Note = txtNote.Text;
                            MessageBox.Show("Note has been added!");
                        }
                    }

                    txtNote.Clear();
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
