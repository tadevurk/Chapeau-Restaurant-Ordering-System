using RosModel;
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


namespace RosUI
{
    public partial class RosMain : Form
    {
        Employee employee = new Employee();
        OrderedDishLogic dishLogic = new OrderedDishLogic();
        OrderedDrinkLogic drinkLogic = new OrderedDrinkLogic();
        public RosMain(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
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

                case "Dashboard":

                    HideAllPanels();
                    pnlDashboard.Show();

                    break;

                case "BarView":

                    HideAllPanels();
                    pnlBarView.Show();
                    UpdateDrinks();

                    break;

                case "TableView":

                    HideAllPanels();
                    pnlTableView.Show();

                    break;


            }

        }

        private void HideAllPanels()
        {
            pnlKitchenView.Hide();
            pnlDashboard.Hide();
            pnlBarView.Hide();
            pnlTableView.Hide();
        }

        private void kitchenViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("KitchenView");
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("Dashboard");
        }

        private void barViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("BarView");
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
            ShowPanel("TableView");
        }

        private void btnTableOne_Click(object sender, EventArgs e)
        {
            Table table = new Table(1);
            FormOrder orderForm = new FormOrder(table);

            orderForm.ShowDialog();
        }

        private void btnTableTwo_Click(object sender, EventArgs e)
        {
            Table table = new Table(2);
            FormOrder orderForm = new FormOrder(table);

            orderForm.ShowDialog();
        }

        private void btnTableThree_Click(object sender, EventArgs e)
        {
            Table table = new Table(3);
            FormOrder orderForm = new FormOrder(table);

            orderForm.ShowDialog();
        }

        private void btnTableFour_Click(object sender, EventArgs e)
        {
            Table table = new Table(4);
            FormOrder orderForm = new FormOrder(table);

            orderForm.ShowDialog();
        }

        private void btnTableFive_Click(object sender, EventArgs e)
        {
            Table table = new Table(5);
            FormOrder orderForm = new FormOrder(table);

            orderForm.ShowDialog();
        }

        private void btnTableSix_Click(object sender, EventArgs e)
        {
            Table table = new Table(6);
            FormOrder orderForm = new FormOrder(table);

            orderForm.ShowDialog();
        }

        private void btnTableSeven_Click(object sender, EventArgs e)
        {
            Table table = new Table(7);
            FormOrder orderForm = new FormOrder(table);

            orderForm.ShowDialog();
        }

        private void btnTableEight_Click(object sender, EventArgs e)
        {
            Table table = new Table(8);
            FormOrder orderForm = new FormOrder(table);

            orderForm.ShowDialog();
        }

        private void btnTableNine_Click(object sender, EventArgs e)
        {
            Table table = new Table(9);
            FormOrder orderForm = new FormOrder(table);

            orderForm.ShowDialog();
        }

        private void btnTableTen_Click(object sender, EventArgs e)
        {
            Table table = new Table(10);
            FormOrder orderForm = new FormOrder(table);

            orderForm.ShowDialog();
        }
        private void UpdateDrinks()
        {
            List<OrderedDrink> orderedDrinks = drinkLogic.GetAllOrderedDrinks();

            lvOrderedDrinks.Items.Clear();

            foreach (OrderedDrink drink in orderedDrinks)
            {
                ListViewItem li = new ListViewItem(drink.TableNumber.ToString());
                li.SubItems.Add(drink.Name);
                li.SubItems.Add(drink.TimeDrinkOrdered.ToString());
                li.Tag = drink;
                lvOrderedDrinks.Items.Add(li);
            }
        }

        private void UpdateDishes()
        {

            List<OrderedDish> orderedDishes = dishLogic.GetAllOrderedDish();

            lvOrderedDishes.Items.Clear();

            foreach (OrderedDish dish in orderedDishes)
            {
                ListViewItem li = new ListViewItem(dish.TableNumber.ToString());
                li.SubItems.Add(dish.Name);
                li.SubItems.Add(dish.TimeDishOrdered.ToString());
                li.SubItems.Add(dish.Course);
                li.Tag = dish;
                lvOrderedDishes.Items.Add(li);
            }
        }

        private void btnDrinkReady_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvOrderedDrinks.SelectedItems.Count; i++)
            {
                OrderedDrink drink = (OrderedDrink)lvOrderedDrinks.SelectedItems[i].Tag;
                drinkLogic.UpdateDrinkStatus(drink);
            }

            UpdateDrinks();
        }

        private void btnDishReady_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvOrderedDishes.SelectedItems.Count; i++)
            {
                OrderedDish dish = (OrderedDish)lvOrderedDishes.SelectedItems[i].Tag;
                dishLogic.UpdateDishStatus(dish);
            }

            UpdateDishes();
        }
    }
}
