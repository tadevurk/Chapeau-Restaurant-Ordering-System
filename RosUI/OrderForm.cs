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

            WriteContainedItems();
        }


        private void showPanel(string panelName)
        {
            HidePanels();
            switch (panelName)
            {
                case "Lunch":
                    pnlLunch.Show();
                    pnlLunch.Visible = true;
                    txtNote.Visible = false;
                    break;

                case "Starters":
                    pnlStarters.Show();
                    pnlStarters.Visible = true;
                    pnlLunch.Visible = true;
                    txtNote.Visible = true;
                    ReadStarters();
                    break;

                case "Mains":
                    pnlMains.Show();
                    pnlMains.Visible = true;
                    pnlLunch.Visible = true;
                    txtNote.Visible = true;
                    ReadLunchMains();
                    break;

                case "Desserts":
                    pnlDesserts.Show();
                    pnlDesserts.Visible = true;
                    pnlLunch.Visible = true;
                    txtNote.Visible = true;
                    ReadLunchDesserts();
                    break;

                case "Dinner":
                    pnlDinner.Show();
                    pnlDinner.Visible = true;
                    txtNote.Visible = false;
                    break;

                case "DinnerStarters":
                    pnlDinnerStarters.Show();
                    pnlDinnerStarters.Visible = true;
                    pnlDinner.Visible = true;
                    txtNote.Visible = true;
                    ReadDinnerStarters();
                    break;

                case "DinnerMains":
                    pnlDinnerMains.Show();
                    pnlDinnerMains.Visible = true;
                    pnlDinner.Visible = true;
                    txtNote.Visible = true;
                    ReadDinnerMains();
                    break;

                case "DinnerDesserts":
                    pnlDinnerDesserts.Show();
                    pnlDinnerDesserts.Visible = true;
                    pnlDinner.Visible = true;
                    txtNote.Visible = true;
                    ReadDinnerDesserts();
                    break;

                case "Drinks":
                    pnlDrinkCategories.Show();
                    pnlDrinkCategories.Visible = true;
                    txtNote.Visible = false;
                    break;

                case "SoftDrinks":
                    pnlSoftDrinks.Show();
                    pnlSoftDrinks.Visible = true;
                    pnlDrinkCategories.Visible = true;
                    txtNote.Visible = true;
                    ReadSoftDrinks();
                    break;

                case "Beers":
                    pnlBeers.Show();
                    pnlBeers.Visible = true;
                    pnlDrinkCategories.Visible = true;
                    txtNote.Visible = true;
                    ReadBeers();
                    break;

                case "Wines":
                    pnlWines.Show();
                    pnlBeers.Visible = true;
                    pnlDrinkCategories.Visible = true;
                    txtNote.Visible = true;
                    ReadWines();
                    break;

                case "Spirits":
                    pnlSpirits.Show();
                    pnlSpirits.Visible = true;
                    pnlDrinkCategories.Visible = true;
                    txtNote.Visible = true;
                    ReadSpirits();
                    break;

                case "HotDrinks":
                    pnlHotDrinks.Show();
                    pnlHotDrinks.Visible = true;
                    pnlDrinkCategories.Visible = true;
                    txtNote.Visible = true;
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
            btnLunch.BackColor = Color.LightSkyBlue;
            btnStarters.BackColor = Color.LightSkyBlue;
            btnMains.BackColor = Color.LightSkyBlue;
            btnDesserts.BackColor = Color.LightSkyBlue;
            btnDinner.BackColor = Color.LightSkyBlue;
            btnStartersDinner.BackColor = Color.LightSkyBlue;
            btnMainsDinners.BackColor = Color.LightSkyBlue;
            btnDessertsDinner.BackColor = Color.LightSkyBlue;
            btnDrinks.BackColor = Color.LightSkyBlue;
            btnSoftDrink.BackColor = Color.LightSkyBlue;
            btnBeers.BackColor = Color.LightSkyBlue;
            btnWine.BackColor = Color.LightSkyBlue;
            btnSpirits.BackColor = Color.LightSkyBlue;
            btnHotDrinks.BackColor = Color.LightSkyBlue;
        }
        private void btnLunch_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Lunch");
                ButtonColorReset();
                btnLunch.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnStarters_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Starters");
                ButtonColorReset();
                btnStarters.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnMains_Click_1(object sender, EventArgs e)
        {
            try
            {
                showPanel("Mains");
                ButtonColorReset();
                btnMains.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnDesserts_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Desserts");
                ButtonColorReset();
                btnDesserts.BackColor = Color.LightGreen;
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
                btnDinner.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnStartersDinner_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("DinnerStarters");
                ButtonColorReset();
                btnStartersDinner.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnMainsDinners_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("DinnerMains");
                ButtonColorReset();
                btnMainsDinners.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnDessertsDinner_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("DinnerDesserts");
                ButtonColorReset();
                btnDessertsDinner.BackColor = Color.LightGreen;
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

        private void btnSoftDrink_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("SoftDrinks");
                ButtonColorReset();
                btnSoftDrink.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnBeers_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Beers");
                ButtonColorReset();
                btnBeers.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnWine_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Wines");
                ButtonColorReset();
                btnWine.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnSpirits_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Spirits");
                ButtonColorReset();
                btnSpirits.BackColor = Color.LightGreen;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnHotDrinks_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("HotDrinks");
                ButtonColorReset();
                btnHotDrinks.BackColor = Color.LightGreen;           
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void SendCancelNoteButtonsVisible()
        {
            btnSendOrder.Visible = true;
            btnCancelOrder.Visible = true;
            btnOrderAddNote.Visible = true;
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
                    throw new Exception($"Oops {emp.Name}, please select an item");
                }

                AddLunchStarter();
                SendCancelNoteButtonsVisible();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void btnAddMains_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewMains.SelectedItems.Count == 0)
                {
                    throw new Exception($"Oops {emp.Name}, please select an item");
                }

                AddLunchMain();
                SendCancelNoteButtonsVisible();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void btnAddDessert_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewDesserts.SelectedItems.Count == 0)
                {
                    throw new Exception($"Oops {emp.Name}, please select an item");
                }

                AddLunchDessert();
                SendCancelNoteButtonsVisible();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void btnAddDinnerMains_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewDinnerMains.SelectedItems.Count == 0)
                {
                    throw new Exception($"Oops {emp.Name}, please select an item");
                }

                AddDinnerMain();
                SendCancelNoteButtonsVisible();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void btnAddDinnerStarter_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewDinnerStarters.SelectedItems.Count == 0)
                {
                    throw new Exception($"Oops {emp.Name}, please select an item");
                }

                AddDinnerStarter();
                SendCancelNoteButtonsVisible();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void btnAddDinnerDesserts_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDinnerDesserts.SelectedItems.Count == 0)
                {
                    throw new Exception($"Oops {emp.Name}, please select an item");
                }

                AddDinnerDessert();
                SendCancelNoteButtonsVisible();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void btnAddDrink_Click(object sender, EventArgs e) // Soft Drink
        {
            try
            {
                if (listviewSoftDrinks.SelectedItems.Count == 0)
                {
                    throw new Exception($"Oops {emp.Name}, please select an item");
                }

                AddSoftDrink();
                SendCancelNoteButtonsVisible();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }
        private void btnAddBeers_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewBeers.SelectedItems.Count == 0)
                {
                    throw new Exception($"Oops {emp.Name}, please select an item");
                }

                AddBeer();
                SendCancelNoteButtonsVisible();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }

        private void btnAddWines_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewWines.SelectedItems.Count == 0)
                {
                    throw new Exception($"Oops {emp.Name}, please select an item");
                }

                AddWine();
                SendCancelNoteButtonsVisible();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }

        private void btnAddSpirits_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSpirits.SelectedItems.Count == 0)
                {
                    throw new Exception($"Oops {emp.Name}, please select an item");
                }

                AddSpirit();
                SendCancelNoteButtonsVisible();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }

        private void btnAddHotDrinks_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewHotDrinks.SelectedItems.Count == 0)
                {
                    throw new Exception($"Oops {emp.Name}, please select an item");
                }

                AddHotDrink();
                SendCancelNoteButtonsVisible();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
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
                    Dish dish = (Dish)item;
                    CheckDishToRemove(lvItem, dish);
                }
                else if (item is Drink)
                {
                    Drink drink = (Drink)item;
                    CheckDrinkToRemove(lvItem, drink);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "ERROR");
            }
        }

        private void CheckDishToRemove(ListViewItem lvItem, Dish dish)
        {
            if (dish.ItemName == lvItem.SubItems[0].Text && lvItem.SubItems[0].ForeColor == Color.Green)
            {
                throw new Exception($"{emp.Name}, you cannot edit an old item");
            }
            else
            {
                if (dish.ItemAmount == 1)
                {
                    listviewOrder.Items.RemoveAt(listviewOrder.SelectedItems[0].Index);
                    dishLogic.IncreaseDishStock(dish);
                }
                else
                {
                    dish.ItemAmount--;
                    listviewOrder.SelectedItems[0].SubItems[2].Text = dish.ItemAmount.ToString();
                    dishLogic.IncreaseDishStock(dish);
                }
            }
        }

        private void CheckDrinkToRemove(ListViewItem lvItem, Drink drink)
        {
            if (drink.ItemName == lvItem.SubItems[0].Text && lvItem.SubItems[0].ForeColor == Color.Green)
            {
                throw new Exception($"{emp.Name}, you cannot edit an old item");
            }

            if (drink.ItemAmount == 1)
            {
                listviewOrder.Items.RemoveAt(listviewOrder.SelectedItems[0].Index);
                drinkLogic.IncreaseDrinkStock(drink);
            }
            else
            {
                drink.ItemAmount--;
                listviewOrder.SelectedItems[0].SubItems[2].Text = drink.ItemAmount.ToString();
                drinkLogic.IncreaseDrinkStock(drink);
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
                throw new Exception($"{dish.ItemName} is sold out");
            }

            foreach (ListViewItem item in listviewOrder.Items)
            {
                if (dish.ItemName == item.SubItems[0].Text && item.ForeColor != Color.Green)
                {
                    currentItem = item;
                    dish.ItemAmount = int.Parse(item.SubItems[2].Text);
                    dish.ItemAmount++;
                    item.SubItems[2].Text = dish.ItemAmount.ToString();
                }
            }

            if (currentItem == null)
            {
                ListViewItem item = new ListViewItem(dish.ItemName);
                item.SubItems.Add(dish.ItemPrice.ToString());
                dish.ItemAmount = 1;
                item.SubItems.Add(dish.ItemAmount.ToString());
                item.Tag = dish;
                item.ForeColor = Color.Red; // Change color for the new ordered item
                listviewOrder.Items.Add(item);
            }
            dishLogic.DecreaseDishStock(dish);

            AddItemNote();
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
            drinkLogic.DecreaseDrinkStock(drink);

            AddItemNote();
        }

        private void WriteContainedItems() // Getting the ordered list
        {
            try
            {
                List<Item> itemsInOrder = new List<Item>();

                List<Dish> orderedDishes = dishLogic.WriteContainedDishes(table); // Read all ordered Dishes 
                List<Drink> orderedDrinks = drinkLogic.WriteContainedDrinks(table); // Read all ordered Drinks

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

                    // adding the items in the listviewOrder to dish and drink list
                    SendOrder();

                    
                    dishLogic.AddDishes(DishesInOrderProcess, order); // DishesInOrderProcess(comes from SendOrder) is the new ordered dishes 
                    drinkLogic.AddDrinks(DrinkInOrderProcess, order);// DrinkInOrderProcess(comes from SendOrder) is the new ordered drinks

                    table.TableStatus = TableStatus.Standby; // Jason
                    tableLogic.Update(table); // Jason

                    //Update KitchenView and Barview
                    rosMain.UpdateAllListViews();

                    //Update TableView
                    rosMain.UpdateTableToOrdered(table.TableNumber);

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
                    return;
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

            try
            {
                if (listviewOrder.Items.Count == 0)
                {
                    throw new Exception($"Oops {emp.Name}, please select an item");
                }

                if (listviewOrder.SelectedItems.Count > 0 && listviewOrder.SelectedItems[0].ForeColor == Color.Red)
                {
                    item = (Item)listviewOrder.SelectedItems[0].Tag;
                    if (item is Dish)
                    {
                        Dish dish = (Dish)item;
                        AddDishNote(dish);
                    }
                    else if (item is Drink)
                    {
                        Drink drink = (Drink)item;
                        AddDrinkNote(drink);
                    }
                }
                else
                {
                    item = (Item)listviewOrder.Items[listviewOrder.Items.Count - 1].Tag;
                    if (item is Dish)
                    {
                        Dish dish = (Dish)item;
                        AddDishNote(dish);
                    }
                    else if (item is Drink)
                    {
                        Drink drink = (Drink)item;
                        AddDrinkNote(drink);
                    }
                }

                txtNote.Clear();
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        void AddDrinkNote(Drink drink)
        {
            if (txtNote.Text == "")
            {
                return;
            }

            drink.ItemNote = txtNote.Text;
            MessageBox.Show($"{emp.Name}, You've added the note!");
        }

        private void AddDishNote(Dish dish)
        {
            if (txtNote.Text == "")
            {
                return;
            }

            dish.ItemNote = txtNote.Text;
            MessageBox.Show($"{emp.Name}, You've added the note!");
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
            foreach (ListViewItem lvOrderInProcess in listviewOrder.Items) // Update stock when back is clicked
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
    }
}
