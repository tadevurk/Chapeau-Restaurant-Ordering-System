﻿using RosModel;
using System;
using RosLogic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RosUI
{
    public partial class RosMain : Form
    {
        Employee employee = new Employee();
        Table table = new Table();
        TableLogic tableLogic = new TableLogic();
        OrderedDishLogic dishLogic = new OrderedDishLogic();
        OrderedDrinkLogic drinkLogic = new OrderedDrinkLogic();
        private List<TableOverview> tableOverview = new List<TableOverview>();

        public List<Dish> Contained { get; set; }
        public RosMain(Employee employee)
        {
            InitializeComponent();
            UpdateDishes();
            UpdateDrinks();
            UpdateTables();
            Contained = new List<Dish>();
            this.employee = employee;

            if (employee.Roles == Roles.Manager)
            {
                lblWelcomeBarDash.Text += $" {employee.Name}!";
                lblWelcomeKitDash.Text += $" {employee.Name}!";
                ShowPanel("KitchenDashboard");
            }

            if (employee.Roles == Roles.Chef)
            {
                barViewToolStripMenuItem.Visible = false;
                tableViewToolStripMenuItem.Visible = false;
                btnUndoKitFin.Enabled = false;
                lblWelcomeKitDash.Text += $" {employee.Name}!";
                ShowPanel("KitchenDashboard");
                
            }
            else if (employee.Roles == Roles.Bartender)
            {
                kitchenViewToolStripMenuItem.Visible = false;
                tableViewToolStripMenuItem.Visible = false;
                btnUndoKitFin.Enabled = false;
                lblWelcomeBarDash.Text += $" {employee.Name}!";
                ShowPanel("BarDashboard");
            }
        }

        private void RosMain_Load(object sender, EventArgs e)
        {
            ShowPanel("Dashboard");
        }

        private void ShowPanel(string panelName)
        {
            switch (panelName)
            {
                case "KitchenView":

                    HideAllPanels();
                    pnlKitchenView.Show();
                    UpdateDishes();

                    break;

                case "KitchenDashboard":

                    HideAllPanels();
                    pnlDashboardKitchen.Show();

                    break;

                case "BarView":

                    HideAllPanels();
                    pnlBarView.Show();

                    UpdateDrinks();

                    break;

                case "BarDashboard":

                    HideAllPanels();
                    pnlDashboardBar.Show();

                    break;
                case "FinishedDrinkView":

                    HideAllPanels();
                    pnlBarViewFinished.Show();
                    UpdateFinishedDrinks();

                    break;

                case "FinishedDishView":

                    HideAllPanels();
                    pnlKitchenViewFinished.Show();
                    UpdateFinishedDishes();

                    break;

            }

        }

        public void UpdateTables()
        {

            foreach (ListViewItem item in lvOrderedDishes.Items)
            {
                OrderedDish d = item.Tag as OrderedDish;

                switch (d.Status)
                {
                    case DishStatus.ToPrepare:
                        UpdateTableToOrdered(d.TableNumber);
                        break;
                    case DishStatus.PickUp:
                        UpdateTableToReadyDish(d);
                        break;
                    case DishStatus.Serve:
                        UpdateTableToServedDish(d);
                        break;
                }

            }



        }

        private void HideAllPanels()
        {
            pnlKitchenView.Hide();
            pnlDashboardKitchen.Hide();
            pnlDashboardBar.Hide();
            pnlBarView.Hide();
            pnlKitchenViewFinished.Hide();
            pnlBarViewFinished.Hide();

        }

        private void kitchenViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("KitchenDashboard");
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (employee.Roles == Roles.Bartender)
            {
                ShowPanel("BarDashboard");

            }
            else
            {
                ShowPanel("KitchenDashboard");
            }
        }

        private void barViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("BarDashboard");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }


        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShowPanel("TableView");

            new TableOverview(employee, this).Show();
        }

        public void UpdateTableToOrdered(int number)
        {
            foreach (TableOverview to in tableOverview)
            {
                to.OrderRecieved(number);
            }
        }
        public void UpdateDrinks()
        {
            List<OrderedDrink> orderedDrinks = drinkLogic.GetAllOrderedDrinks();

            lvOrderedDrinks.Items.Clear();

            foreach (OrderedDrink drink in orderedDrinks)
            {
                ListViewItem li = new ListViewItem(drink.OrderedDrinkAmount.ToString());
                li.SubItems.Add(drink.Name);

                if (drink.DrinkNote == "null")
                {
                    li.SubItems.Add("No");
                }
                else
                {
                    li.SubItems.Add("Yes");
                }

                li.SubItems.Add(drink.TimeDrinkOrdered.ToString("HH.mm"));
                li.SubItems.Add(drink.TableNumber.ToString());

                li.Tag = drink;

                if (drink.DrinkStatus == DrinkStatus.PickUp)
                {
                    li.BackColor = Color.Green;
                }

                lvOrderedDrinks.Items.Add(li);
            }
        }

        public void UpdateFinishedDrinks()
        {
            List<OrderedDrink> finishedDrinks = drinkLogic.GetAllFinishedDrinks();

            lvFinishedDrinks.Items.Clear();

            foreach (OrderedDrink drink in finishedDrinks)
            {
                ListViewItem li = new ListViewItem(drink.OrderedDrinkAmount.ToString());
                li.SubItems.Add(drink.Name);

                if (drink.DrinkNote == "null")
                {
                    li.SubItems.Add("No");
                }
                else
                {
                    li.SubItems.Add("Yes");
                }

                li.SubItems.Add(drink.TimeDrinkOrdered.ToString("HH.mm"));
                li.SubItems.Add(drink.TableNumber.ToString());

                li.Tag = drink;

                if (drink.DrinkStatus == DrinkStatus.PickUp)
                {
                    li.BackColor = Color.Green;
                }

                lvFinishedDrinks.Items.Add(li);
            }
        }


        public void UpdateDishes()
        {

            List<OrderedDish> orderedDishes = dishLogic.GetAllOrderedDish();

            lvOrderedDishes.Items.Clear();


            foreach (OrderedDish dish in orderedDishes)
            {

                ListViewItem li = new ListViewItem(dish.OrderedDishAmount.ToString());
                li.SubItems.Add(dish.Name);
                if (dish.DishNote == "null")
                {
                    li.SubItems.Add("No");
                }
                else
                {
                    li.SubItems.Add("Yes");
                }
                li.SubItems.Add(dish.TimeDishOrdered.ToString("HH:mm"));
                li.SubItems.Add(dish.Course);
                li.SubItems.Add(dish.TableNumber.ToString());

                li.Tag = dish;

                if (dish.Status == DishStatus.PickUp)
                {
                    li.BackColor = Color.Green;
                }

                lvOrderedDishes.Items.Add(li);

            }

        }

        public void UpdateFinishedDishes()
        {
            List<OrderedDish> finishedDishes = dishLogic.GetAllFinishedDish();

            lvOrderedDishes.Items.Clear();


            foreach (OrderedDish dish in finishedDishes)
            {

                ListViewItem li = new ListViewItem(dish.OrderedDishAmount.ToString());
                li.SubItems.Add(dish.Name);

                if (dish.DishNote == "null")
                {
                    li.SubItems.Add("No");
                }
                else
                {
                    li.SubItems.Add("Yes");
                }

                li.SubItems.Add(dish.TimeDishOrdered.ToString("HH:mm"));
                li.SubItems.Add(dish.Course);
                li.SubItems.Add(dish.TableNumber.ToString());

                li.Tag = dish;

                if (dish.Status == DishStatus.PickUp)
                {
                    li.BackColor = Color.Green;
                }

                lvOrderedDishes.Items.Add(li);

            }
        }

        private void btnDrinkReady_Click(object sender, EventArgs e)
        {
            if (lvOrderedDrinks.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }
            for (int i = 0; i < lvOrderedDrinks.SelectedItems.Count; i++)
            {
                OrderedDrink drink = (OrderedDrink)lvOrderedDrinks.SelectedItems[i].Tag;
                UpdateTableToReadyDrink(drink);

                drinkLogic.UpdateDrinkStatusPickUp(drink);
            }

            UpdateDrinks();
        }

        private void btnDishReady_Click(object sender, EventArgs e)
        {
            if (lvOrderedDishes.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            for (int i = 0; i < lvOrderedDishes.SelectedItems.Count; i++)
            {
                OrderedDish dish = (OrderedDish)lvOrderedDishes.SelectedItems[i].Tag;
                UpdateTableToReadyDish(dish);
                dishLogic.UpdateDishStatusPickUp(dish);
            }

            UpdateDishes();
        }

        private void UpdateTableToReadyDish(OrderedDish dish)
        {
            foreach (TableOverview to in tableOverview)
                to.PickUpReady(dish.TableNumber);
        }
        private void UpdateTableToReadyDrink(OrderedDrink drink)
        {
            foreach (TableOverview to in tableOverview)
                to.PickUpReady(drink.TableNumber);
        }

        private void btnViewNote_Click(object sender, EventArgs e)
        {
            if (lvOrderedDishes.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            OrderedDish dish = (OrderedDish)lvOrderedDishes.SelectedItems[0].Tag;

            if (dish.DishNote == "null")
            {
                MessageBox.Show("No note");
            }
            else
            {
                MessageBox.Show(dish.DishNote);
            }
        }

        private void btnServe_Click(object sender, EventArgs e)
        {
            if (lvOrderedDishes.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            for (int i = 0; i < lvOrderedDishes.SelectedItems.Count; i++)
            {
                OrderedDish orderedDish = (OrderedDish)lvOrderedDishes.SelectedItems[i].Tag;

                dishLogic.UpdateDishStatusServe(orderedDish);

                UpdateTableToServedDish(orderedDish);//update all table overview

            }

            UpdateDishes();
        }

        private void btnViewDrinkNote_Click(object sender, EventArgs e)
        {
            if (lvOrderedDrinks.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            OrderedDrink d = (OrderedDrink)lvOrderedDrinks.SelectedItems[0].Tag;

            if (d.DrinkNote == "null")
            {
                MessageBox.Show("No note");
            }
            else
            {
                MessageBox.Show(d.DrinkNote);
            }


        }

        public void AddWaiterView(TableOverview to)
        {
            tableOverview.Add(to);
        }
        private void btnDrinkServed_Click(object sender, EventArgs e)
        {
            if (lvOrderedDrinks.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            for (int i = 0; i < lvOrderedDrinks.SelectedItems.Count; i++)
            {
                OrderedDrink orderedDrink = (OrderedDrink)lvOrderedDrinks.SelectedItems[i].Tag;
                drinkLogic.UpdateDrinkStatusServe(orderedDrink);

                UpdateTableToServedDrink(orderedDrink);//update observer tableOverview form


            }

            UpdateDrinks();
        }

        private void UpdateTableToServedDrink(OrderedDrink orderedDrink)
        {
            foreach (TableOverview to in tableOverview)
            {
                to.ItemServed(orderedDrink.TableNumber);
            }
        }

        private void UpdateTableToServedDish(OrderedDish orderedDish)
        {
            foreach (TableOverview to in tableOverview)
            {
                to.ItemServed(orderedDish.TableNumber);
            }
        }

        //Write error to text file
        public void WriteError(Exception e, string errorMessage)
        {
            StreamWriter writer = File.AppendText("ErrorLog.txt");
            writer.WriteLine($"Error occurred: {errorMessage}");
            writer.WriteLine(e);
            writer.WriteLine(DateTime.Now);
            writer.Close();
        }

        private void runningOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("KitchenView");
        }

        private void btnRunningKitDash_Click(object sender, EventArgs e)
        {
            ShowPanel("KitchenView");
        }

        private void btnRunnningBarDash_Click(object sender, EventArgs e)
        {
            ShowPanel("BarView");
        }

        private void runningOrdersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowPanel("BarView");
        }

        private void finishedOrdersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowPanel("FinishedDrinkView");
        }

        private void finishedOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("FinishedDishView");
        }

        private void btnViewNoteFinDrink_Click(object sender, EventArgs e)
        {
            if (lvFinishedDrinks.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            OrderedDrink d = (OrderedDrink)lvFinishedDrinks.SelectedItems[0].Tag;

            if (d.DrinkNote == "null")
            {
                MessageBox.Show("No note");
            }
            else
            {
                MessageBox.Show(d.DrinkNote);
            }
        }

        private void btnViewNoteFinDish_Click(object sender, EventArgs e)
        {
            if (lvFinishedDishes.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            OrderedDish dish = (OrderedDish)lvFinishedDishes.SelectedItems[0].Tag;

            if (dish.DishNote == "null")
            {
                MessageBox.Show("No note");
            }
            else
            {
                MessageBox.Show(dish.DishNote);
            }
        }

        private void btnUndoKitFin_Click(object sender, EventArgs e)
        {
            if (lvFinishedDishes.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            for (int i = 0; i < lvFinishedDishes.SelectedItems.Count; i++)
            {
                OrderedDish finishedDish = (OrderedDish)lvFinishedDishes.SelectedItems[i].Tag;

                dishLogic.UpdateDishToStart(finishedDish);
            }

            UpdateFinishedDishes();
        }

        private void btnUndoFinDrink_Click(object sender, EventArgs e)
        {
            if (lvFinishedDrinks.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            for (int i = 0; i < lvFinishedDrinks.SelectedItems.Count; i++)
            {
                OrderedDrink finishedDrink = (OrderedDrink)lvFinishedDrinks.SelectedItems[i].Tag;

                drinkLogic.UpdateDrinkToStart(finishedDrink);
            }

            UpdateFinishedDrinks();
        }

        private void btnUndoBarView_Click(object sender, EventArgs e)
        {
            if (lvOrderedDrinks.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            for (int i = 0; i < lvOrderedDrinks.SelectedItems.Count; i++)
            {
                OrderedDrink orderedDrink = (OrderedDrink)lvOrderedDrinks.SelectedItems[i].Tag;

                if (orderedDrink.DrinkStatus == DrinkStatus.ToPrepare)
                {
                    MessageBox.Show("You can not undo this item {0}", orderedDrink.Name);
                    UpdateDrinks();
                    return;
                }

                drinkLogic.BringStatusBack(orderedDrink);
            }

            UpdateDrinks();
        }

        private void btnUndoKitView_Click(object sender, EventArgs e)
        {
            if (lvOrderedDishes.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            for (int i = 0; i < lvOrderedDishes.SelectedItems.Count; i++)
            {
                OrderedDish orderedDish = (OrderedDish)lvOrderedDishes.SelectedItems[i].Tag;

                if (orderedDish.Status == DishStatus.ToPrepare)
                {
                    MessageBox.Show("You can not undo this item {0}", orderedDish.Name);
                    UpdateDishes();
                    return;
                }

                dishLogic.BringStatusBack(orderedDish);
            }

            UpdateDishes();
        }
    }
}
