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
                        OrderRecieved(d.TableNumber);
                        break;
                    case DishStatus.PickUp:
                        PickUpReady(d.TableNumber);
                        break;
                    case DishStatus.Serve:
                        ItemServed(d.TableNumber);
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
            ShowPanel("TableView");
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
        public void OrderRecieved(int number)
        {
            //Changing color of buttons when Order is initiated
            switch (number)
            {
                case 1:
                    btnTableOne.BackColor = Color.Blue;
                    break;

                case 2:
                    btnTableTwo.BackColor = Color.Blue;

                    break;
                case 3:
                    btnTableThree.BackColor = Color.Blue;

                    break;
                case 4:
                    btnTableFour.BackColor = Color.Blue;

                    break;
                case 5:
                    btnTableFive.BackColor = Color.Blue;

                    break;
                case 6:
                    btnTableSix.BackColor = Color.Blue;

                    break;
                case 7:
                    btnTableSeven.BackColor = Color.Blue;

                    break;
                case 8:
                    btnTableEight.BackColor = Color.Blue;

                    break;
                case 9:
                    btnTableNine.BackColor = Color.Blue;

                    break;
                case 10:
                    btnTableTen.BackColor = Color.Blue;

                    break;
            }
        }


        public void PickUpReady(int number)
        {
            //changing color of buttons when order is ready for the pick up 
            switch (number)
            {
                case 1:
                    btnTableOne.BackColor = Color.Green;
                    break;

                case 2:
                    btnTableTwo.BackColor = Color.Green;

                    break;
                case 3:
                    btnTableThree.BackColor = Color.Green;

                    break;
                case 4:
                    btnTableFour.BackColor = Color.Green;

                    break;
                case 5:
                    btnTableFive.BackColor = Color.Green;

                    break;
                case 6:
                    btnTableSix.BackColor = Color.Green;

                    break;
                case 7:
                    btnTableSeven.BackColor = Color.Green;

                    break;
                case 8:
                    btnTableEight.BackColor = Color.Green;

                    break;
                case 9:
                    btnTableNine.BackColor = Color.Green;

                    break;
                case 10:
                    btnTableTen.BackColor = Color.Green;

                    break;
            }
        }
        public void ItemServed(int number)
        {
            //changing color of buttons when order is ready for the pick up 
            switch (number)
            {
                case 1:
                    btnTableOne.BackColor = Color.Yellow;
                    break;

                case 2:
                    btnTableTwo.BackColor = Color.Yellow;

                    break;
                case 3:
                    btnTableThree.BackColor = Color.Yellow;

                    break;
                case 4:
                    btnTableFour.BackColor = Color.Yellow;

                    break;
                case 5:
                    btnTableFive.BackColor = Color.Yellow;

                    break;
                case 6:
                    btnTableSix.BackColor = Color.Yellow;

                    break;
                case 7:
                    btnTableSeven.BackColor = Color.Yellow;

                    break;
                case 8:
                    btnTableEight.BackColor = Color.Yellow;

                    break;
                case 9:
                    btnTableNine.BackColor = Color.Yellow;

                    break;
                case 10:
                    btnTableTen.BackColor = Color.Yellow;

                    break;
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
                PickUpReady(drink.TableNumber);
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
                PickUpReady(dish.TableNumber);
                dishLogic.UpdateDishStatusPickUp(dish);
            }

            UpdateDishes();
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
                ItemServed(orderedDish.TableNumber);
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
                ItemServed(orderedDrink.TableNumber);
            }

            UpdateDrinks();
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
