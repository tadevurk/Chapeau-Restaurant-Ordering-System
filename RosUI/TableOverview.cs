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
        private int numberOfTables;
        private List<Button> buttons;
        private List<Label> labels;
        private List<PictureBox> dishIcons;
        private List<PictureBox> drinkIcons;
        private bool moveUp = false;
        private bool moveDown = false;

        public TableOverview(Employee employee, RosMain rosMain)
        {
            InitializeComponent();
            this.employee = employee;
            this.rosMain = rosMain;
            userToolStripMenuItem.Text = employee.Name;
            tableLogic = new TableLogic();
            orderedDrinkLogic = new OrderedDrinkLogic();
            orderedDishLogic = new OrderedDishLogic();
            buttons = new List<Button>();
            labels = new List<Label>();
            dishIcons = new List<PictureBox>();
            drinkIcons = new List<PictureBox>();
            
            numberOfTables = tableLogic.GetAmountOfTables();             
            rosMain.AddWaiterView(this);          
            GenerateTableOverview();
            UpdateAllButtons();
        }

        //Generates all necessary components into the table view
        private void GenerateTableOverview()
        {
            try
            {
                GenerateLabels();
                GenerateDrinkIcon();
                GenerateDishIcon();
                GenerateButtons();
                MoveComponents(-60);
            }
            catch (Exception exp)
            {
                DisplayError(exp);
            }           
        }

        //generates the buttons dynamically
        private List<Button> GenerateButtons()
        {
            int i = 1;
            Point point = new Point(19, 164);
            for (int row = 0; row < numberOfTables / 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Button button = new Button();

                    button.Text = "Empty";
                    button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
                    button.BackColor = SystemColors.ControlLight;
                    button.Cursor = Cursors.Hand;
                    button.Location = new Point(point.X, point.Y);
                    button.Name = $"btnTable{i}";
                    button.Size = new Size(180, 100);
                    button.UseVisualStyleBackColor = false;
                    button.Click += new EventHandler(button_Click);                    
                    this.Controls.Add(button);                     
                    
                    buttons.Add(button);
                    point.X += 265;
                    i++;
                }
                point.Y += 106;
                point.X = 19;
            }
            return buttons;
        }

        //A method that checks with button was clicked and opens the corresponding table control
        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int i = 0;
            foreach (Button b in buttons)
            {
                if (button == buttons[i])
                {
                    OpenTableControl(i);
                }
                i++;
            }        
        }

        //generates the drinkicons dynamically
        private List<PictureBox> GenerateDrinkIcon()
        {
            int i = 1;
            Point point = new Point(131, 232);
            for (int row = 0; row < numberOfTables / 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    PictureBox pictureBox = new PictureBox();

                    pictureBox.BackColor = SystemColors.ControlLight;
                    pictureBox.Image = Properties.Resources.icons8_martini_glass_32;
                    pictureBox.Visible = false;
                    pictureBox.Location = new Point(point.X, point.Y);
                    pictureBox.Name = $"pbDrinkIcon{i}";
                    pictureBox.Size = new Size(32, 28);
                    this.Controls.Add(pictureBox);                
                    
                    drinkIcons.Add(pictureBox);
                    point.X += 265;
                    i++;
                }
                point.Y += 106;
                point.X = 131;
            }
            return drinkIcons;
        }

        //generates the dishicons dynamically
        private List<PictureBox> GenerateDishIcon()
        {
            int i = 1;
            Point point = new Point(163, 228);
            for (int row = 0; row < numberOfTables / 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    PictureBox pictureBox = new PictureBox();

                    pictureBox.BackColor = SystemColors.ControlLight;
                    pictureBox.Image = Properties.Resources.icons8_dinner_32;
                    pictureBox.Visible = false;
                    pictureBox.Location = new Point(point.X, point.Y);
                    pictureBox.Name = $"pbDishIcon{i}";
                    pictureBox.Size = new Size(32, 32);
                    this.Controls.Add(pictureBox);                    
                    
                    dishIcons.Add(pictureBox);
                    point.X += 265;
                    i++;
                }
                point.Y += 106;
                point.X = 163;
            }
            return dishIcons;
        }

        //generates the labals dynamically
        private List<Label> GenerateLabels()
        {
            int i = 1;
            Point point = new Point(97, 168);
            for (int row = 0; row < numberOfTables / 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Label label = new Label();

                    label.Text = i++.ToString();
                    label.BackColor = SystemColors.ControlLight;
                    label.Size = new Size(32, 32);
                    label.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
                    label.Location = new Point(point.X, point.Y);
                    label.Name = $"lbl{i}";
                    this.Controls.Add(label);                
                    
                    labels.Add(label);
                    point.X += 265;
                }
                point.Y += 106;
                point.X = 97;
            }
            return labels;
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

        //Updates all the table buttons every minute
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            UpdateAllButtons();
        }

        //Changes the button color depending on the status of the table
        public Button UpdateButtonColor(Table table, Button button, Label label, PictureBox drinkIcon, PictureBox dishIcon)
        {
            switch (table.TableStatus)
            {
                case TableStatus.Empty:
                    return UpdateButtonToEmpty(button, label, drinkIcon, dishIcon);
                case TableStatus.Occupied:
                    return UpdateButtonToOccupied(button, label, drinkIcon, dishIcon);
                case TableStatus.Standby:
                    return UpdateButtonToStandby(table, button, label, drinkIcon, dishIcon);
                case TableStatus.DrinkReady:
                    return UpdateButtonToDrinkReady(button, label, drinkIcon, dishIcon);
                case TableStatus.DishReady:
                    return UpdateButtonToDishReady(button, label, drinkIcon, dishIcon);
                case TableStatus.Served:
                    return UpdateButtonToServed(button, label, drinkIcon, dishIcon);
            }
            return button;
        }

        //update the button to served
        private static Button UpdateButtonToServed(Button button, Label label, PictureBox drinkIcon, PictureBox dishIcon)
        {
            button.BackColor = Color.Yellow;
            label.BackColor = Color.Yellow;
            drinkIcon.BackColor = Color.Yellow;
            dishIcon.BackColor = Color.Yellow;
            button.Text = "Served";
            button.ForeColor = Color.Black;
            return button;
        }

        //Update the button to dish ready
        private static Button UpdateButtonToDishReady(Button button, Label label, PictureBox drinkIcon, PictureBox dishIcon)
        {
            button.BackColor = Color.LightGreen;
            label.BackColor = Color.LightGreen;
            drinkIcon.BackColor = Color.LightGreen;
            dishIcon.BackColor = Color.LightGreen;
            button.Text = "DishReady";
            button.ForeColor = Color.Black;
            return button;
        }

        //Update the button to drink ready
        private static Button UpdateButtonToDrinkReady(Button button, Label label, PictureBox drinkIcon, PictureBox dishIcon)
        {
            button.BackColor = Color.LightGreen;
            label.BackColor = Color.LightGreen;
            drinkIcon.BackColor = Color.LightGreen;
            dishIcon.BackColor = Color.LightGreen;
            button.Text = "DrinkReady";
            button.ForeColor = Color.Black;
            return button;
        }

        //update the button to standby
        private Button UpdateButtonToStandby(Table table, Button button, Label label, PictureBox drinkIcon, PictureBox dishIcon)
        {
            button.BackColor = Color.LightBlue;
            label.BackColor = Color.LightBlue;
            drinkIcon.BackColor = Color.LightBlue;
            dishIcon.BackColor = Color.LightBlue;
            button.Text = "Standby";
            button.ForeColor = Color.Black;
            CalculateDishTimeTaken(button, table);
            CalculateDrinkTimeTaken(button, table);
            return button;
        }

        //Update the button to occupied
        private static Button UpdateButtonToOccupied(Button button, Label label, PictureBox drinkIcon, PictureBox dishIcon)
        {
            button.BackColor = Color.Red;
            label.BackColor = Color.Red;
            drinkIcon.BackColor = Color.Red;
            dishIcon.BackColor = Color.Red;
            button.Text = "Occupied";
            button.ForeColor = Color.White;
            label.ForeColor = Color.White;
            return button;
        }

        //Update the button to empty
        private static Button UpdateButtonToEmpty(Button button, Label label, PictureBox drinkIcon, PictureBox dishIcon)
        {
            button.BackColor = SystemColors.ControlLight;
            label.BackColor = SystemColors.ControlLight;
            drinkIcon.BackColor = SystemColors.ControlLight;
            dishIcon.BackColor = SystemColors.ControlLight;
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
        public void UpdateAllButtons()
        {
            tables = tableLogic.GetAllTables();
            int i = 0;
            foreach (Table table in tables)
            {
                UpdateButtonColor(table, buttons[i], labels[i], drinkIcons[i], dishIcons[i]);
                CheckForOrderedItemsOnTable(table);
                i++;
            }
        }

        //get all the ordered drinks by table
        public List<OrderedDrink> GetAllOrderedDrinks(Table table)
        {
            List<OrderedDrink> orderedDrinks = tableLogic.GetOrderedDrinks(table.TableNumber, 1);
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
            List<OrderedDish> orderedDishes = tableLogic.GetOrderedDishes(table.TableNumber, 1);
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
            List<OrderedDish> orderedDishes = tableLogic.GetOrderedDishes(table.TableNumber, 0);
            List<OrderedDrink> orderedDrinks = tableLogic.GetOrderedDrinks(table.TableNumber, 0);

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
            List<OrderedDish> orderedDishes = tableLogic.GetOrderedDishes(table.TableNumber, 0);
            List<OrderedDrink> orderedDrinks = tableLogic.GetOrderedDrinks(table.TableNumber, 0);

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
            dishIcons[tableNumber - 1].Visible = true;
        }

        //displays only the drink icon 
        public void ShowRunningDrinkIcon(int tableNumber)
        {
            //changes the state of the Icon and the position.
            Point point = drinkIcons[tableNumber - 1].Location;
            if (point.X == 131 || point.X == 396)
            {
                point.X += 32;
            }
            drinkIcons[tableNumber - 1].Location = point;
            drinkIcons[tableNumber - 1].Visible = true;
        }

        //displays both the drink and dish icon
        public void ShowRunningDishAndDrinkIcon(int tableNumber)
        {
            dishIcons[tableNumber - 1].Visible = true;
            drinkIcons[tableNumber - 1].Visible = true;
        }

        //Updates database when the order is received in the kitchen
        public void OrderRecieved(int tableNumber)
        {
            //Changing color of buttons when Order is initiated
            foreach (Table table in tables)
            {
                if (tableNumber == table.TableNumber)
                {
                    UpdateTableToStandbystatus(table, tableNumber);
                    UpdateButtonColor(table, buttons[tableNumber-1], labels[tableNumber-1], drinkIcons[tableNumber-1], dishIcons[tableNumber-1]);
                }
            }           
        }

        //Updates database when the drink is ready in the bar
        public void DrinkReady(int tableNumber)
        {
            //changing color of buttons when order is ready for the pick up            
            foreach (Table table in tables)
            {
                if (tableNumber == table.TableNumber)
                {
                    UpdateTableToDrinkReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, buttons[tableNumber - 1], labels[tableNumber - 1], drinkIcons[tableNumber - 1], dishIcons[tableNumber - 1]);
                }
            }
        }

        //Updates database when the dish is ready in the kitchen
        public void DishReady(int tableNumber)
        {
            //changing color of buttons when order is ready for the pick up 
            foreach (Table table in tables)
            {
                if (tableNumber == table.TableNumber)
                {
                    UpdateTableToDishReadyStatus(table, tableNumber);
                    UpdateButtonColor(table, buttons[tableNumber - 1], labels[tableNumber - 1], drinkIcons[tableNumber - 1], dishIcons[tableNumber - 1]);
                }
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

        //Opens the table guide
        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                new TableGuide(employee, rosMain).Show();
            }
            catch (Exception exp)
            {
                DisplayError(exp);
            }    
        }

        //Is used for the logout
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                new Login().Show();
            }
            catch (Exception exp)
            {
                DisplayError(exp);
            }

        }

        //Show/Hide the legenda
        private void lblShowInfo_Click(object sender, EventArgs e)
        {
            
            if (pbDishOrder.Visible == false)
            {
                ShowInfo();
                moveDown = MoveComponents(60);
                lblShowInfo.Text = "Hide Info";             
            }
            else
            {
                HideInfo();
                moveDown = MoveComponents(-60);
                lblShowInfo.Text = "Show Info";              
            }            
        }

        //Move all the components 
        private bool MoveComponents(int pixels)
        {
            foreach (Button button in buttons)
            {
                button.Location = new Point(button.Location.X, button.Location.Y + pixels);               
            }

            foreach (Label label in labels)
            {
                label.Location = new Point(label.Location.X, label.Location.Y + pixels);
            }

            foreach (PictureBox dishIcon in dishIcons)
            {
                dishIcon.Location = new Point(dishIcon.Location.X, dishIcon.Location.Y + pixels);
            }

            foreach (PictureBox drinkIcon in drinkIcons)
            {
                drinkIcon.Location = new Point(drinkIcon.Location.X, drinkIcon.Location.Y + pixels);
            }
            return true;
        }

        //Hide the legenda
        private void HideInfo()
        {
            pbDishOrder.Visible = false;
            pbDrinkIcon.Visible = false;
            lblDishOrder.Visible = false;
            lblDrinkOrder.Visible = false;
            pbEmpty.Visible = false;
            lblTableFree.Visible = false;
            pbOccupied.Visible = false;
            lblTableOccupied.Visible = false;
            pbRunningOrder.Visible = false;
            lblRunningOrder.Visible = false;
            pbOrderReady.Visible = false;
            lblOrderReady.Visible = false;
            pbOrderServed.Visible = false;
        }

        //Show the legenda
        private void ShowInfo()
        {
            pbDishOrder.Visible = true;
            pbDrinkIcon.Visible = true;
            lblDishOrder.Visible = true;
            lblDrinkOrder.Visible = true;
            pbEmpty.Visible = true;
            lblTableFree.Visible = true;
            pbOccupied.Visible = true;
            lblTableOccupied.Visible = true;
            pbRunningOrder.Visible = true;
            lblRunningOrder.Visible = true;
            pbOrderReady.Visible = true;
            lblOrderReady.Visible = true;
            pbOrderServed.Visible = true;
        }
    }
}
