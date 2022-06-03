using RosModel;
using RosLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

////////////////////Jason Xie, 659045, GROUP 1, IT1D/////////////////////////////////////////////////////////////////////////////////////////////

namespace RosUI
{
    public partial class TableOverview : Form
    {
        private Employee employee;
        private RosMain rosMain;
        private Table table = new Table();
        private TableLogic tableLogic;
        private List<Table> tables;
        private TableControl tableControl;
        private OrderedDishLogic orderedDishLogic;
        private OrderedDrinkLogic orderedDrinkLogic;
        public double TotalMinutes { get; }

        public TableOverview(Employee employee, RosMain rosMain)
        {
            InitializeComponent();
            this.employee = employee;
            this.rosMain = rosMain;
            lblWaiter.Text = "Waiter: " + employee.Name;
            tableLogic = new TableLogic();
            orderedDrinkLogic = new OrderedDrinkLogic();
            orderedDishLogic = new OrderedDishLogic();
            tables = tableLogic.GetAllTables();
            UpdateAllButtons(tables);
            rosMain.AddWaiterView(this);
        }

        //clicking the button opens the table control
        private void btnTableOne_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                // get Table One and opens the TableControl
                table = tables[0];
                new TableControl(employee, rosMain, table).Show();
            }
            catch(Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        private void btnTableTwo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                table = tables[1];
                new TableControl(employee, rosMain, table).Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        private void btnTableThree_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                table = tables[2];
                new TableControl(employee, rosMain, table).Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        private void btnTableFour_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                table = tables[3];
                new TableControl(employee, rosMain, table).Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        private void btnTableFive_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                table = tables[4];
                new TableControl(employee, rosMain, table).Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        private void btnTableSix_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                table = tables[5];
                new TableControl(employee, rosMain, table).Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        private void btnTableSeven_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                table = tables[6];
                new TableControl(employee, rosMain, table).Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        private void btnTableEight_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                table = tables[7];
                new TableControl(employee, rosMain, table).Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        private void btnTableNine_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                table = tables[8];
                new TableControl(employee, rosMain, table).Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        private void btnTableTen_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                table = tables[9];
                new TableControl(employee, rosMain, table).Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }

        //Updates all the table buttons every minute
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            UpdateAllButtons(tables);
        }

        //Changes the button color depending on the status of the table
        public Button UpdateButtonColor(Table table, Button button)
        {
            switch (table.TableStatus)
            {
                case 0:
                    button.BackColor = Color.LightGray;
                    button.Text = "Empty";
                    button.ForeColor = Color.Black;
                    return button;
                case 1:
                    button.BackColor = Color.Red;
                    button.Text = "Occupied";
                    button.ForeColor = Color.White;
                    return button;
                case 2:
                    button.BackColor = Color.LightBlue;
                    button.Text = "Standby";
                    button.ForeColor = Color.Black;
                    CalculateTimeTaken(button, table);
                    return button;
                case 3:
                    button.BackColor = Color.LightGreen;
                    button.Text = "DrinkReady";
                    button.ForeColor = Color.Black;
                    return button;
                case 4:
                    button.BackColor = Color.LightGreen;
                    button.Text = "DishReady";
                    button.ForeColor = Color.Black;
                    return button;
                case 5:
                    button.BackColor = Color.Yellow;
                    button.Text = "Served";
                    button.ForeColor = Color.Black;
                    return button;
            }
            return button;
        }

        //calculates the time taken and displays it on the button
        private Button CalculateTimeTaken(Button button, Table table)
        {
            List<OrderedDish> orderedDishes = orderedDishLogic.GetAllOrderedDish();

            foreach (OrderedDish dish in orderedDishes)
            {
                if (dish.TableNumber == table.TableNumber && dish.Status == 0)
                {
                    TimeSpan timeTaken = DateTime.Now - dish.TimeDishOrdered;

                    button.Text = $"{timeTaken.TotalMinutes.ToString("00")} minutes";

                    if (button.Text == "00 minutes")
                    {
                        button.Text = "01 minute";
                    }
                }
            }
            return button;
        }

        //Updates all the buttons with the newest status
        private void UpdateAllButtons(List<Table> tables)
        {
            UpdateButtonColor(tables[0], btnTableOne);
            UpdateButtonColor(tables[1], btnTableTwo);
            UpdateButtonColor(tables[2], btnTableThree);
            UpdateButtonColor(tables[3], btnTableFour);
            UpdateButtonColor(tables[4], btnTableFive);
            UpdateButtonColor(tables[5], btnTableSix);
            UpdateButtonColor(tables[6], btnTableSeven);
            UpdateButtonColor(tables[7], btnTableEight);
            UpdateButtonColor(tables[8], btnTableNine);
            UpdateButtonColor(tables[9], btnTableTen);
        }

        private void ServeDrinks(List<OrderedDrink> orderedDrinks)
        {
            try
            {
                foreach (OrderedDrink orderedDrink in orderedDrinks)
                {
                    orderedDrinkLogic.UpdateDrinkStatusServe(orderedDrink);                
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        private void ServeDishes(List<OrderedDish> orderedDishes)
        {
            try
            {
                foreach (OrderedDish orderedDish in orderedDishes)
                {
                    orderedDishLogic.UpdateDishStatusServe(orderedDish);
                }            
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        public List<OrderedDrink> GetAllOrderedDrinks(Table table)
        {
            List<OrderedDrink> orderedDrinks = tableLogic.GetOrderedDrinks(table.TableNumber);
            ServeDrinks(orderedDrinks);

            return orderedDrinks;
        }

        public List<OrderedDish> GetAllOrderedDishes(Table table)
        {
            List<OrderedDish> orderedDishes = tableLogic.GetOrderedDishes(table.TableNumber);
            ServeDishes(orderedDishes);

            return orderedDishes;
        }

        //Updates database when the order is received in the kitchen
        public void OrderRecieved(int number)
        {
            //Changing color of buttons when Order is initiated
            switch (number)
            {
                case 1:
                    table.TableNumber = 1;
                    table.TableStatus = 2;
                    tableLogic.Update(table);
                    break;

                case 2:
                    table.TableNumber = 2;
                    table.TableStatus = 2;
                    tableLogic.Update(table);
                    break;

                case 3:
                    table.TableNumber = 3;
                    table.TableStatus = 2;
                    tableLogic.Update(table);
                    break;
                case 4:
                    table.TableNumber = 4;
                    table.TableStatus = 2;
                    tableLogic.Update(table);
                    break;

                case 5:
                    table.TableNumber = 5;
                    table.TableStatus = 2;
                    tableLogic.Update(table);
                    break;

                case 6:
                    table.TableNumber = 6;
                    table.TableStatus = 2;
                    tableLogic.Update(table);
                    break;

                case 7:
                    table.TableNumber = 7;
                    table.TableStatus = 2;
                    tableLogic.Update(table);
                    break;

                case 8:
                    table.TableNumber = 8;
                    table.TableStatus = 2;
                    tableLogic.Update(table);
                    break;

                case 9:
                    table.TableNumber = 9;
                    table.TableStatus = 2;
                    tableLogic.Update(table);
                    break;

                case 10:
                    table.TableNumber = 10;
                    table.TableStatus = 2;
                    tableLogic.Update(table);
                    break;
            }
        }

        //Updates database when the drink is ready in the bar
        public void DrinkReady(int number)
        {
            //changing color of buttons when order is ready for the pick up 
            switch (number)
            {
                case 1:
                    table.TableNumber = 1;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    break;

                case 2:
                    table.TableNumber = 2;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    break;

                case 3:
                    table.TableNumber = 3;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    break;
                case 4:
                    table.TableNumber = 4;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    break;

                case 5:
                    table.TableNumber = 5;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    break;

                case 6:
                    table.TableNumber = 6;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    break;

                case 7:
                    table.TableNumber = 7;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    break;

                case 8:
                    table.TableNumber = 8;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    break;

                case 9:
                    table.TableNumber = 9;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    break;

                case 10:
                    table.TableNumber = 10;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    break;
            }
        }

        //Updates database when the dish is ready in the kitchen
        public void DishReady(int number)
        {
            //changing color of buttons when order is ready for the pick up 
            switch (number)
            {
                case 1:
                    table.TableNumber = 1;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    break;

                case 2:
                    table.TableNumber = 2;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    break;

                case 3:
                    table.TableNumber = 3;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    break;
                case 4:
                    table.TableNumber = 4;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    break;

                case 5:
                    table.TableNumber = 5;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    break;

                case 6:
                    table.TableNumber = 6;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    break;

                case 7:
                    table.TableNumber = 7;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    break;

                case 8:
                    table.TableNumber = 8;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    break;

                case 9:
                    table.TableNumber = 9;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    break;

                case 10:
                    table.TableNumber = 10;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    break;
            }
        }
    }
}
