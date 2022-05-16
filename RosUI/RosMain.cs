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
        Table table = new Table();
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
            table = new Table(1);
            FormOrder orderForm = new FormOrder(table,employee, this);

            orderForm.ShowDialog();
        }

        private void btnTableTwo_Click(object sender, EventArgs e)
        {
            table = new Table(2);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.ShowDialog();
        }

        private void btnTableThree_Click(object sender, EventArgs e)
        {
            table = new Table(3);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.ShowDialog();
        }

        private void btnTableFour_Click(object sender, EventArgs e)
        {
            table = new Table(4);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.ShowDialog();
        }

        private void btnTableFive_Click(object sender, EventArgs e)
        {
            table = new Table(5);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.ShowDialog();
        }

        private void btnTableSix_Click(object sender, EventArgs e)
        {
            table = new Table(6);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.ShowDialog();
        }

        private void btnTableSeven_Click(object sender, EventArgs e)
        {
            table = new Table(7);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.ShowDialog();
        }

        private void btnTableEight_Click(object sender, EventArgs e)
        {
            table = new Table(8);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.ShowDialog();
        }

        private void btnTableNine_Click(object sender, EventArgs e)
        {
            table = new Table(9);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.ShowDialog();
        }

        private void btnTableTen_Click(object sender, EventArgs e)
        {
            table = new Table(10);
            FormOrder orderForm = new FormOrder(table, employee, this);

            orderForm.ShowDialog();
        }
        public void OrderRecieved(int number)
        {
            //Changing color of buttons when Order is initiated
            switch (number)
            {
                case 1:
                    btnTableOne.BackColor = SystemColors.ButtonFace;
                    break;

                case 2:
                    btnTableTwo.BackColor = SystemColors.ButtonFace;

                    break;
                case 3:
                    btnTableThree.BackColor = SystemColors.ButtonFace;

                    break;
                case 4:
                    btnTableFour.BackColor = SystemColors.ButtonFace;

                    break;
                case 5:
                    btnTableFive.BackColor = SystemColors.ButtonFace;

                    break;
                case 6:
                    btnTableSix.BackColor = SystemColors.ButtonFace;

                    break;
                case 7:
                    btnTableSeven.BackColor = SystemColors.ButtonFace;

                    break;
                case 8:
                    btnTableEight.BackColor = SystemColors.ButtonFace;

                    break;
                case 9:
                    btnTableNine.BackColor = SystemColors.ButtonFace;

                    break;
                case 10:
                    btnTableTen.BackColor = SystemColors.ButtonFace;

                    break;
            }
        }

 
        public void PickUpReady(int number)
        {
            //changing color of buttons when order is ready for the pick up 
            switch (number)
            {
                case 1:
                    btnTableOne.BackColor = SystemColors.Window;
                    break;

                case 2:
                    btnTableTwo.BackColor = SystemColors.Window;

                    break;
                case 3:
                    btnTableThree.BackColor = SystemColors.Window;

                    break;
                case 4:
                    btnTableFour.BackColor = SystemColors.Window;

                    break;
                case 5:
                    btnTableFive.BackColor = SystemColors.Window;

                    break;
                case 6:
                    btnTableSix.BackColor = SystemColors.Window;

                    break;
                case 7:
                    btnTableSeven.BackColor = SystemColors.Window;

                    break;
                case 8:
                    btnTableEight.BackColor = SystemColors.Window;

                    break;
                case 9:
                    btnTableNine.BackColor = SystemColors.Window;

                    break;
                case 10:
                    btnTableTen.BackColor = SystemColors.Window;

                    break;
            }
        }
        public void UpdateDrinks()
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

        public void UpdateDishes()
        {

            List<OrderedDish> orderedDishes = dishLogic.GetAllOrderedDish();

            lvOrderedDishes.Items.Clear();

            foreach (OrderedDish dish in orderedDishes)
            {
                ListViewItem li = new ListViewItem(dish.TableNumber.ToString());
                li.SubItems.Add(dish.Name);
                li.SubItems.Add(dish.OrderedDishAmount.ToString());
                li.SubItems.Add(dish.TimeDishOrdered.ToString());
                li.SubItems.Add(dish.Course);

                if (dish.DishNote == "null")
                {
                    li.SubItems.Add("No");
                }
                else
                {
                    li.SubItems.Add("Yes");
                }

                
                li.Tag = dish;
                lvOrderedDishes.Items.Add(li);
            }

        }

        private void btnDrinkReady_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvOrderedDrinks.SelectedItems.Count; i++)
            {
                OrderedDrink drink = (OrderedDrink)lvOrderedDrinks.SelectedItems[i].Tag;
                int tableNumber = drink.TableNumber;
                PickUpReady(tableNumber);
                drinkLogic.UpdateDrinkStatusPickUp(drink);
            }

            UpdateDrinks();
        }

        private void btnDishReady_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvOrderedDishes.SelectedItems.Count; i++)
            {
                OrderedDish dish = (OrderedDish)lvOrderedDishes.SelectedItems[i].Tag;
                int tableNumber = dish.TableNumber;
                PickUpReady(tableNumber);
                dishLogic.UpdateDishStatusPickUp(dish);
            }

            UpdateDishes();
        }

        private void btnViewNote_Click(object sender, EventArgs e)
        {
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
            OrderedDish orderedDish = (OrderedDish)lvOrderedDishes.SelectedItems[0].Tag;
            dishLogic.UpdateDishStatusServe(orderedDish);
        }
    }
}
