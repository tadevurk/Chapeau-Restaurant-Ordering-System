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
                MessageBox.Show("Error", exp.Message);
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
                MessageBox.Show("Error", exp.Message);
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
                MessageBox.Show("Error", exp.Message);
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
                MessageBox.Show("Error", exp.Message);
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
                MessageBox.Show("Error", exp.Message);
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
                MessageBox.Show("Error", exp.Message);
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
                MessageBox.Show("Error", exp.Message);
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
                MessageBox.Show("Error", exp.Message);
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
                MessageBox.Show("Error", exp.Message);
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
                MessageBox.Show("Error", exp.Message);
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
                    CalculateDishTimeTaken(button, table);
                    CalculateDrinkTimeTaken(button, table);
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
        private Button CalculateDrinkTimeTaken(Button button, Table table)
        {
            List<OrderedDrink> orderedDrinks = orderedDrinkLogic.GetAllOrderedDrinks();

            foreach (OrderedDrink orderedDrink in orderedDrinks)
            {
                if (orderedDrink.TableNumber == table.TableNumber && orderedDrink.DrinkStatus == 0)
                {
                    TimeSpan timeTaken = DateTime.Now - orderedDrink.TimeDrinkOrdered;

                    button.Text = $"{timeTaken.TotalMinutes.ToString("00")} minutes";

                    if (button.Text == "00 minutes")
                    {
                        button.Text = "01 minute";
                    }
                }

            }
            return button;
        }

        //calculates the time taken and displays it on the button
        private Button CalculateDishTimeTaken(Button button, Table table)
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
        public void UpdateAllButtons(List<Table> tables)
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
            foreach (Table table in tables)
            {
                CheckForOrderedItemsOnTable(table);
            }
        }

        //get all the ordered drinks by table
        public List<OrderedDrink> GetAllOrderedDrinks(Table table)
        {
            List<OrderedDrink> orderedDrinks = tableLogic.GetOrderedDrinksReady(table.TableNumber);
            if(orderedDrinks.Count == 0)
            {
                throw new Exception("there is currently no drinks to serve");
            }
            ServeDrinks(orderedDrinks);

            return orderedDrinks;      
        }

        //gets all the ordered dishes by table
        public List<OrderedDish> GetAllOrderedDishes(Table table)
        {
            List<OrderedDish> orderedDishes = tableLogic.GetOrderedDishesReady(table.TableNumber);
            if (orderedDishes.Count == 0)
            {
                throw new Exception("there is currently no dishes to serve");
            }
            ServeDishes(orderedDishes);
            
            return orderedDishes;
        }

        //changes the status of the drink to served
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
                MessageBox.Show("Error", exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        //changes the status of the dish to served
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
                MessageBox.Show("Error", exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        //checks for empty list to make the order of the table served
        public void CheckOrderedItems(Table table)
        {
            List<OrderedDish> orderedDishes = tableLogic.GetOrderedDishesToPrepare(table.TableNumber);
            List<OrderedDrink> orderedDrinks = tableLogic.GetOrderedDrinksToPrepare(table.TableNumber);

            if (orderedDishes.Count == 0 && orderedDrinks.Count == 0)
            {
                table.TableStatus = 5;
                tableLogic.Update(table);
            }
            else
            {
                table.TableStatus = 2;
                tableLogic.Update(table);
            }
        }

        //checks what the ordered item a specific table has and displays the icon
        public void CheckForOrderedItemsOnTable(Table table)
        {
            List<OrderedDish> orderedDishes = tableLogic.GetOrderedDishesToPrepare(table.TableNumber);
            List<OrderedDrink> orderedDrinks = tableLogic.GetOrderedDrinksToPrepare(table.TableNumber);

            if (orderedDishes.Count > 0 && orderedDrinks.Count == 0)
            {
                ShowRunningDishIcon(table.TableNumber);
            }
            else if (orderedDrinks.Count > 0 && orderedDishes.Count == 0)
            {
                ShowRunningDrinkIcon(table.TableNumber);
            }
            else if (orderedDrinks.Count > 0 && orderedDishes.Count > 0)
            {
                ShowRunningDishAndDrinkIcon(table.TableNumber);
            }
            else
            {
                return;
            }
        }

        //Displays the dish icon when a order with dishes are being prepared
        public void ShowRunningDishIcon(int number)
        {
            switch (number)
            {    
                case 1:
                    t1DishIcon.Visible = true;
                    break;

                case 2:
                    t2DishIcon.Visible = true;
                    break;

                case 3:
                    t3DishIcon.Visible = true;
                    break;
                case 4:
                    t4DishIcon.Visible = true;
                    break;

                case 5:
                    t5DishIcon.Visible = true;
                    break;

                case 6:
                    t6DishIcon.Visible = true;
                    break;

                case 7:
                    t7DishIcon.Visible = true;
                    break;

                case 8:
                    t8DishIcon.Visible = true;
                    break;

                case 9:
                    t9DishIcon.Visible = true;
                    break;

                case 10:
                    t10DishIcon.Visible = true;
                    break;
            }
        }

        //displays only the drink icon 
        public void ShowRunningDrinkIcon(int number)
        {
            //changes the state of the Icon and the position.
            switch (number)
            {
                case 1:
                    t1DrinkIcon.Visible = true;
                    t1DrinkIcon.Location = new Point(47, 109);
                    break;

                case 2:
                    t2DrinkIcon.Visible = true;
                    t2DrinkIcon.Location = new Point(398, 109);
                    break;

                case 3:
                    t3DrinkIcon.Visible = true;
                    t3DrinkIcon.Location = new Point(47, 199);
                    break;
                case 4:
                    t4DrinkIcon.Visible = true;
                    t4DrinkIcon.Location = new Point(398, 199);
                    break;

                case 5:
                    t5DrinkIcon.Visible = true;
                    t5DrinkIcon.Location = new Point(47, 289);
                    break;

                case 6:
                    t6DrinkIcon.Visible = true;
                    t6DrinkIcon.Location = new Point(398, 289);
                    break;

                case 7:
                    t7DrinkIcon.Visible = true;
                    t7DrinkIcon.Location = new Point(47, 380);
                    break;

                case 8:
                    t8DrinkIcon.Visible = true;
                    t8DrinkIcon.Location = new Point(398, 380);
                    break;

                case 9:
                    t9DrinkIcon.Visible = true;
                    t9DrinkIcon.Location = new Point(47, 470);
                    break;

                case 10:
                    t10DrinkIcon.Visible = true;
                    t10DrinkIcon.Location = new Point(398, 470);
                    break;
            }
        }

        //displays both the drink and dish icon
        public void ShowRunningDishAndDrinkIcon(int number)
        {
            switch (number)
            {
                case 1:
                    ShowRunningIcons(t1DishIcon, t1DrinkIcon);
                    break;

                case 2:
                    t2DishIcon.Visible = true;
                    t2DrinkIcon.Visible = true;
                    break;

                case 3:
                    t3DishIcon.Visible = true;
                    t3DrinkIcon.Visible = true;
                    break;
                case 4:
                    t4DishIcon.Visible = true;
                    t4DrinkIcon.Visible = true;
                    break;

                case 5:
                    t5DishIcon.Visible = true;
                    t5DrinkIcon.Visible = true;
                    break;

                case 6:
                    t6DishIcon.Visible = true;
                    t6DrinkIcon.Visible = true;
                    break;

                case 7:
                    t7DishIcon.Visible = true;
                    t7DrinkIcon.Visible = true;
                    break;

                case 8:
                    t8DishIcon.Visible = true;
                    t8DrinkIcon.Visible = true;
                    break;

                case 9:
                    t9DishIcon.Visible = true;
                    t9DrinkIcon.Visible = true;
                    break;

                case 10:
                    t10DishIcon.Visible = true;
                    t10DrinkIcon.Visible = true;
                    break;
            }
        }

        private void ShowRunningIcons(PictureBox pbDish, PictureBox pbDrink)
        {
            pbDish.Visible = true;
            pbDrink.Visible = true;
        }

        //Updates database when the order is received in the kitchen
        public void OrderRecieved(int number)
        {
            //Changing color of buttons when Order is initiated
            switch (number)
            {
                case 1:
                    DisplayingOrderRecieved(table, number);
                    UpdateButtonColor(table, btnTableOne);
                    break;
                case 2:
                    DisplayingOrderRecieved(table, number);
                    UpdateButtonColor(table, btnTableTwo);
                    break;
                case 3:
                    DisplayingOrderRecieved(table, number);
                    UpdateButtonColor(table, btnTableThree);
                    break;
                case 4:
                    DisplayingOrderRecieved(table, number);
                    UpdateButtonColor(table, btnTableFour);
                    break;
                case 5:
                    DisplayingOrderRecieved(table, number);
                    UpdateButtonColor(table, btnTableFive);
                    break;
                case 6:
                    DisplayingOrderRecieved(table, number);
                    UpdateButtonColor(table, btnTableSix);
                    break;
                case 7:
                    DisplayingOrderRecieved(table, number);
                    UpdateButtonColor(table, btnTableSeven);
                    break;
                case 8:
                    DisplayingOrderRecieved(table, number);
                    UpdateButtonColor(table, btnTableEight);
                    break;
                case 9:
                    DisplayingOrderRecieved(table, number);
                    UpdateButtonColor(table, btnTableNine);
                    break;
                case 10:
                    DisplayingOrderRecieved(table, number);
                    UpdateButtonColor(table, btnTableTen);
                    break;
            }
        }

        private void DisplayingOrderRecieved(Table table, int number)
        {
            table.TableNumber = number;
            table.TableStatus = 2;
            tableLogic.Update(table);
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
                    UpdateButtonColor(table, btnTableOne);
                    break;

                case 2:
                    table.TableNumber = 2;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableTwo);
                    break;

                case 3:
                    table.TableNumber = 3;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableThree);
                    break;
                case 4:
                    table.TableNumber = 4;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableFour);
                    break;

                case 5:
                    table.TableNumber = 5;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableFive);
                    break;

                case 6:
                    table.TableNumber = 6;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableSix);
                    break;

                case 7:
                    table.TableNumber = 7;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableSeven);
                    break;

                case 8:
                    table.TableNumber = 8;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableEight);
                    break;

                case 9:
                    table.TableNumber = 9;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableNine);
                    break;

                case 10:
                    table.TableNumber = 10;
                    table.TableStatus = 3;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableTen);
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
                    UpdateButtonColor(table, btnTableOne);
                    break;

                case 2:
                    table.TableNumber = 2;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableTwo);
                    break;

                case 3:
                    table.TableNumber = 3;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableThree);
                    break;
                case 4:
                    table.TableNumber = 4;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableFour);
                    break;

                case 5:
                    table.TableNumber = 5;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableFive);
                    break;

                case 6:
                    table.TableNumber = 6;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableSix);
                    break;

                case 7:
                    table.TableNumber = 7;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableSeven);
                    break;

                case 8:
                    table.TableNumber = 8;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableEight);
                    break;

                case 9:
                    table.TableNumber = 9;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableNine);
                    break;

                case 10:
                    table.TableNumber = 10;
                    table.TableStatus = 4;
                    tableLogic.Update(table);
                    UpdateButtonColor(table, btnTableTen);
                    break;
            }
        }
    }
}
