using RosModel;
using RosLogic;
using System;
using System.Collections.Generic;
using System.Drawing;
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
                OpenTableControl(0);
            }
            catch (Exception exp)
            {
                DisplayError(exp);
            }
        }



        private void btnTableTwo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenTableControl(1);
            }
            catch (Exception exp)
            {
                DisplayError(exp);
            }
        }

        private void btnTableThree_Click(object sender, EventArgs e)
        {
            try
            {
                OpenTableControl(2);
            }
            catch (Exception exp)
            {
                DisplayError(exp);
            }
        }

        private void btnTableFour_Click(object sender, EventArgs e)
        {
            try
            {
                OpenTableControl(3);
            }
            catch (Exception exp)
            {
                DisplayError(exp);
            }
        }

        private void btnTableFive_Click(object sender, EventArgs e)
        {
            try
            {
                OpenTableControl(4);
            }
            catch (Exception exp)
            {
                DisplayError(exp);
            }
        }

        private void btnTableSix_Click(object sender, EventArgs e)
        {
            try
            {
                OpenTableControl(5);
            }
            catch (Exception exp)
            {
                DisplayError(exp);
            }
        }

        private void btnTableSeven_Click(object sender, EventArgs e)
        {
            try
            {
                OpenTableControl(6);
            }
            catch (Exception exp)
            {
                DisplayError(exp);
            }
        }

        private void btnTableEight_Click(object sender, EventArgs e)
        {
            try
            {
                OpenTableControl(7);
            }
            catch (Exception exp)
            {
                DisplayError(exp);
            }
        }

        private void btnTableNine_Click(object sender, EventArgs e)
        {
            try
            {
                OpenTableControl(8);
            }
            catch (Exception exp)
            {
                DisplayError(exp);
            }
        }

        private void btnTableTen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenTableControl(9);
            }
            catch (Exception exp)
            {
                DisplayError(exp);
            }
        }

        //Opens the table control of a specific table
        private void OpenTableControl(int index)
        {
            this.Close();
            table = tables[index];
            new TableControl(employee, rosMain, table).Show();
        }

        //Displays error and write it to log file
        private void DisplayError(Exception exp)
        {
            MessageBox.Show(exp.Message, "Error");
            rosMain.WriteError(exp, exp.Message);
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
                case TableStatus.Empty:
                    return UpdateButtonToEmpty(button);
                case TableStatus.Occupied:
                    return UpdateButtonToOccupied(button);
                case TableStatus.Standby:
                    return UpdateButtonToStandby(table, button);
                case TableStatus.DrinkReady:
                    return UpdateButtonToDrinkReady(button);
                case TableStatus.DishReady:
                    return UpdateButtonToDishReady(button);
                case TableStatus.Served:
                    return UpdateButtonToServed(button);
            }
            return button;
        }

        private static Button UpdateButtonToServed(Button button)
        {
            button.BackColor = Color.Yellow;
            button.Text = "Served";
            button.ForeColor = Color.Black;
            return button;
        }

        private static Button UpdateButtonToDishReady(Button button)
        {
            button.BackColor = Color.LightGreen;
            button.Text = "DishReady";
            button.ForeColor = Color.Black;
            return button;
        }

        private static Button UpdateButtonToDrinkReady(Button button)
        {
            button.BackColor = Color.LightGreen;
            button.Text = "DrinkReady";
            button.ForeColor = Color.Black;
            return button;
        }

        private Button UpdateButtonToStandby(Table table, Button button)
        {
            button.BackColor = Color.LightBlue;
            button.Text = "Standby";
            button.ForeColor = Color.Black;
            CalculateDishTimeTaken(button, table);
            CalculateDrinkTimeTaken(button, table);
            return button;
        }

        private static Button UpdateButtonToOccupied(Button button)
        {
            button.BackColor = Color.Red;
            button.Text = "Occupied";
            button.ForeColor = Color.White;
            return button;
        }

        private static Button UpdateButtonToEmpty(Button button)
        {
            button.BackColor = Color.LightGray;
            button.Text = "Empty";
            button.ForeColor = Color.Black;
            return button;
        }

        //calculates the time taken and displays it on the button
        public Button CalculateDrinkTimeTaken(Button button, Table table)
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
        public Button CalculateDishTimeTaken(Button button, Table table)
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
                throw new Exception("you currently have no drinks to serve");
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
                throw new Exception("you currently have no dishes to serve");
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
                table.TableStatus = TableStatus.Served;
                tableLogic.Update(table);
            }
            else
            {
                table.TableStatus = TableStatus.Standby;
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
        public void ShowRunningDishIcon(int tableNumber)
        {
            switch (tableNumber)
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
        public void ShowRunningDrinkIcon(int tableNumber)
        {
            //changes the state of the Icon and the position.
            switch (tableNumber)
            {
                case 1:
                    MoveRunningDrinkIcon(t1DrinkIcon, 47, 109);
                    break;

                case 2:
                    MoveRunningDrinkIcon(t2DrinkIcon, 398, 109);
                    break;

                case 3:
                    MoveRunningDrinkIcon(t3DrinkIcon, 47, 199);
                    break;

                case 4:
                    MoveRunningDrinkIcon(t4DrinkIcon, 398, 199);
                    break;

                case 5:
                    MoveRunningDrinkIcon(t5DrinkIcon, 47, 289);
                    break;

                case 6:
                    MoveRunningDrinkIcon(t6DrinkIcon, 398, 289);
                    break;

                case 7:
                    MoveRunningDrinkIcon(t7DrinkIcon, 47, 380);
                    break;

                case 8:
                    MoveRunningDrinkIcon(t8DrinkIcon, 398, 380);
                    break;

                case 9:
                    MoveRunningDrinkIcon(t9DrinkIcon, 47, 470);
                    break;

                case 10:
                    MoveRunningDrinkIcon(t10DrinkIcon, 398, 470);
                    break;
            }
        }

        //move the icon to the desired position and displays it
        private void MoveRunningDrinkIcon(PictureBox pbDrink, int x, int y)
        {        
            pbDrink.Location = new Point(x, y);
            pbDrink.Visible = true;
        }

        //displays both the drink and dish icon
        public void ShowRunningDishAndDrinkIcon(int tableNumber)
        {
            switch (tableNumber)
            {
                case 1:
                    ShowBothRunningIcons(t1DishIcon, t1DrinkIcon);
                    break;

                case 2:
                    ShowBothRunningIcons(t2DishIcon, t2DrinkIcon);
                    break;

                case 3:
                    ShowBothRunningIcons(t3DishIcon, t3DrinkIcon);
                    break;
                case 4:
                    ShowBothRunningIcons(t4DishIcon, t4DrinkIcon);
                    break;

                case 5:
                    ShowBothRunningIcons(t5DishIcon, t5DrinkIcon);
                    break;

                case 6:
                    ShowBothRunningIcons(t6DishIcon, t6DrinkIcon);
                    break;

                case 7:
                    ShowBothRunningIcons(t7DishIcon, t7DrinkIcon);
                    break;

                case 8:
                    ShowBothRunningIcons(t8DishIcon, t8DrinkIcon);
                    break;

                case 9:
                    ShowBothRunningIcons(t9DishIcon, t9DrinkIcon);
                    break;

                case 10:
                    ShowBothRunningIcons(t10DishIcon, t10DrinkIcon);
                    break;
            }
        }

        //displays both dish icon and drink icon
        private void ShowBothRunningIcons(PictureBox pbDish, PictureBox pbDrink)
        {
            pbDish.Visible = true;
            pbDrink.Visible = true;
        }

        //Updates database when the order is received in the kitchen
        public void OrderRecieved(int tableNumber)
        {
            //Changing color of buttons when Order is initiated
            switch (tableNumber)
            {
                case 1:
                    UpdateTableToStandbystatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableOne);
                    break;
                case 2:
                    UpdateTableToStandbystatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableTwo);
                    break;
                case 3:
                    UpdateTableToStandbystatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableThree);
                    break;
                case 4:
                    UpdateTableToStandbystatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableFour);
                    break;
                case 5:
                    UpdateTableToStandbystatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableFive);
                    break;
                case 6:
                    UpdateTableToStandbystatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableSix);
                    break;
                case 7:
                    UpdateTableToStandbystatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableSeven);
                    break;
                case 8:
                    UpdateTableToStandbystatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableEight);
                    break;
                case 9:
                    UpdateTableToStandbystatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableNine);
                    break;
                case 10:
                    UpdateTableToStandbystatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableTen);
                    break;
            }
        }

        //Updates database when the drink is ready in the bar
        public void DrinkReady(int tableNumber)
        {
            //changing color of buttons when order is ready for the pick up 
            switch (tableNumber)
            {
                case 1:
                    UpdateTableToDrinkReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableOne);
                    break;

                case 2:
                    UpdateTableToDrinkReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableTwo);
                    break;

                case 3:
                    UpdateTableToDrinkReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableThree);
                    break;
                case 4:
                    UpdateTableToDrinkReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableFour);
                    break;

                case 5:
                    UpdateTableToDrinkReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableFive);
                    break;

                case 6:
                    UpdateTableToDrinkReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableSix);
                    break;

                case 7:
                    UpdateTableToDrinkReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableSeven);
                    break;

                case 8:
                    UpdateTableToDrinkReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableEight);
                    break;

                case 9:
                    UpdateTableToDrinkReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableNine);
                    break;

                case 10:
                    UpdateTableToDrinkReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableTen);
                    break;
            }
        }

        //Updates database when the dish is ready in the kitchen
        public void DishReady(int tableNumber)
        {
            //changing color of buttons when order is ready for the pick up 
            switch (tableNumber)
            {
                case 1:
                    UpdateTableToDishReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableOne);
                    break;

                case 2:
                    UpdateTableToDishReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableTwo);
                    break;

                case 3:
                    UpdateTableToDishReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableThree);
                    break;
                case 4:
                    UpdateTableToDishReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableFour);
                    break;

                case 5:
                    UpdateTableToDishReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableFive);
                    break;

                case 6:
                    UpdateTableToDishReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableSix);
                    break;

                case 7:
                    UpdateTableToDishReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableSeven);
                    break;

                case 8:
                    UpdateTableToDishReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableEight);
                    break;

                case 9:
                    UpdateTableToDishReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableNine);
                    break;

                case 10:
                    UpdateTableToDishReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, btnTableTen);
                    break;
            }
        }

        //set the table status to occupied and stores it on the database
        private void UpdateTableToStandbystatus(Table table, int tableNumber)
        {
            table.TableNumber = tableNumber;
            table.TableStatus = TableStatus.Standby;
            tableLogic.Update(table);
        }

        //set the table status to drinkready and stores it on the database
        private void UpdateTableToDrinkReadyStatus(Table table, int tableNumber)
        {
            table.TableNumber = tableNumber;
            table.TableStatus = TableStatus.DrinkReady;
            tableLogic.Update(table);
        }

        //set the table status to dishready and stores it on the database
        private void UpdateTableToDishReadyStatus(Table table, int tableNumber)
        {
            table.TableNumber = tableNumber;
            table.TableStatus = TableStatus.DishReady;
            tableLogic.Update(table);
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            this.Close();
            new TableGuide(employee, rosMain).Show();
        }
    }
}
