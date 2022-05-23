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


            if (employee.Roles == Roles.Chef)
            {
                barViewToolStripMenuItem.Visible = false;
                tableViewToolStripMenuItem.Visible = false;
                ShowPanel("KitchenView");
            }
            else if (employee.Roles == Roles.Bartender)
            {
                kitchenViewToolStripMenuItem.Visible = false;
                tableViewToolStripMenuItem.Visible = false;
                ShowPanel("BarView");
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
            //ShowPanel("TableView");

            new TableOverview(employee, this).Show();
        }

        private void btnTableOne_Click(object sender, EventArgs e)
        {
            table = new Table(1);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.Show();
        }

        private void btnTableTwo_Click(object sender, EventArgs e)
        {
            table = new Table(2);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.Show();
        }

        private void btnTableThree_Click(object sender, EventArgs e)
        {
            table = new Table(3);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.Show();
        }

        private void btnTableFour_Click(object sender, EventArgs e)
        {
            table = new Table(4);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.Show();
        }

        private void btnTableFive_Click(object sender, EventArgs e)
        {
            table = new Table(5);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.Show();
        }

        private void btnTableSix_Click(object sender, EventArgs e)
        {
            table = new Table(6);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.Show();
        }

        private void btnTableSeven_Click(object sender, EventArgs e)
        {
            table = new Table(7);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.Show();
        }

        private void btnTableEight_Click(object sender, EventArgs e)
        {
            table = new Table(8);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.Show();
        }

        private void btnTableNine_Click(object sender, EventArgs e)
        {
            table = new Table(9);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.Show();
        }

        private void btnTableTen_Click(object sender, EventArgs e)
        {
            table = new Table(10);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.Show();
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

    }
}
