using System;
using System.Drawing;
using System.Windows.Forms;
using RosModel;
using RosLogic;
using System.Collections.Generic;

////////////////////Jason Xie, 659045, GROUP 1, IT1D/////////////////////////////////////////////////////////////////////////////////////////////

namespace RosUI
{
    public partial class TableControl : Form
    {
        private FormOrder orderForm;
        private Employee employee;
        private Table table;
        private RosMain rosMain;
        private TableLogic tableLogic;
        private TableOverview tableOverview;
        private OrderedDishLogic dishLogic;
        private OrderedDrinkLogic drinkLogic;
        private List<OrderedDish> dishes;
        private List<OrderedDrink> drinks;

        public TableControl(Employee employee, RosMain rosMain, Table table)
        {
            InitializeComponent();
            this.employee = employee;
            this.rosMain = rosMain;
            this.table = table;
            tableLogic = new TableLogic();
            dishLogic = new OrderedDishLogic();
            drinkLogic = new OrderedDrinkLogic();
            dishes = dishLogic.GetAllOrderedDishByTable(table);
            drinks = drinkLogic.GetAllOrderedDrinksByTable(table);
            ShowAllDishes(dishes);
            ShowAllDrinks(drinks);
            orderForm = new FormOrder(table, employee, rosMain);
            tableOverview = new TableOverview(employee, rosMain);
            lblTable.Text = "Table: " + table.TableNumber;
            lblWaiter.Text = "Waiter: " + employee.Name;
            FillComboBox();
            cmbStatus.SelectedIndex = 0;
            UpdateOccupyButton(table, btnOccupy);
        }

        //fills in the combobox
        private void FillComboBox()
        {
            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Running Dish");
            cmbStatus.Items.Add("Running Drink");
            cmbStatus.Items.Add("Dish Ready");
            cmbStatus.Items.Add("Drink Ready");
            cmbStatus.Items.Add("Served");
        }

        //sorts the items according to the type that is selected
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortItems(dishes, drinks);
        }

        //displays the items according to the combobox
        private void SortItems(List<OrderedDish> dishes, List<OrderedDrink> drinks)
        {
            lvOrders.Items.Clear();
            switch (cmbStatus.Text)
            {
                case "All":
                    ShowAllDishes(dishes);
                    ShowAllDrinks(drinks);
                    break;
                case "Running Dish":
                    ShowPreparingDishes(dishes);
                    break;
                case "Running Drink":
                    ShowPreparingDrinks(drinks);
                    break;
                case "Dish Ready":
                    ShowDishReady(dishes);
                    break;
                case "Drink Ready":
                    ShowDrinkReady(drinks);
                    break;
                case "Served":
                    ShowServedItems(dishes, drinks);
                    break;
            }
        }
        
        //show all the dishes in the list view
        private void ShowAllDishes(List<OrderedDish> dishes)
        {
            foreach (OrderedDish dish in dishes)
            {
                ListViewItem lvItem = new ListViewItem(dish.ItemName.ToString());
                lvItem.SubItems.Add(dish.TimeDishOrdered.ToShortTimeString());
                if (dish.Status == DishStatus.ToPrepare)
                {
                    lvItem.SubItems.Add("Preparing...");
                    lvItem.BackColor = Color.LightBlue;
                }
                else if (dish.Status == DishStatus.PickUp)
                {
                    lvItem.SubItems.Add("Dish Ready");
                    lvItem.BackColor = Color.LightGreen;
                }
                else if (dish.Status == DishStatus.Serve)
                {
                    lvItem.SubItems.Add("Served");
                    lvItem.BackColor = Color.Yellow;
                }
                else
                    return;
                lvItem.SubItems.Add(dish.OrderedDishAmount.ToString());                

                lvOrders.Items.Add(lvItem);
            }
        }

        //show all the drinks in the list view
        private void ShowAllDrinks(List<OrderedDrink> drinks)
        {
            foreach (OrderedDrink drink in drinks)
            {
                ListViewItem lvItem = new ListViewItem(drink.ItemName.ToString());
                lvItem.SubItems.Add(drink.TimeDrinkOrdered.ToShortTimeString());
                if (drink.DrinkStatus == DrinkStatus.ToPrepare)
                {
                    lvItem.SubItems.Add("Preparing...");
                    lvItem.BackColor = Color.LightBlue;
                }
                else if (drink.DrinkStatus == DrinkStatus.PickUp)
                {
                    lvItem.SubItems.Add("Drink Ready");
                    lvItem.BackColor = Color.LightGreen;
                }
                else if (drink.DrinkStatus == DrinkStatus.Serve)
                {
                    lvItem.SubItems.Add("Served");
                    lvItem.BackColor = Color.Yellow;
                }
                else
                    return;
                lvItem.SubItems.Add(drink.OrderedDrinkAmount.ToString());

                lvOrders.Items.Add(lvItem);
            }
        }

        //show all the preparing dishes in the list view
        private void ShowPreparingDishes(List<OrderedDish> dishes)
        {
            foreach (OrderedDish dish in dishes)
            {
                if (dish.Status == DishStatus.ToPrepare)
                {
                    ListViewItem lvItem = new ListViewItem(dish.ItemName.ToString());
                    lvItem.SubItems.Add(dish.TimeDishOrdered.ToShortTimeString());
                    lvItem.SubItems.Add("Preparing...");
                    lvItem.BackColor = Color.LightBlue;
                    lvItem.SubItems.Add(dish.OrderedDishAmount.ToString());
                    lvOrders.Items.Add(lvItem);
                }
            }                  
        }

        //show all the preparing drinks in the list view
        private void ShowPreparingDrinks(List<OrderedDrink> drinks)
        {
            foreach (OrderedDrink drink in drinks)
            {
                if (drink.DrinkStatus == DrinkStatus.ToPrepare)
                {
                    ListViewItem lvItem = new ListViewItem(drink.ItemName.ToString());
                    lvItem.SubItems.Add(drink.TimeDrinkOrdered.ToShortTimeString());
                    lvItem.SubItems.Add("Preparing...");
                    lvItem.BackColor = Color.LightBlue;
                    lvItem.SubItems.Add(drink.OrderedDrinkAmount.ToString());
                    lvOrders.Items.Add(lvItem);
                }
            }
        }

        //show all the dishes that are ready in the list view
        private void ShowDishReady(List<OrderedDish> dishes)
        {
            foreach (OrderedDish dish in dishes)
            {
                if (dish.Status == DishStatus.PickUp)
                {
                    ListViewItem lvItem = new ListViewItem(dish.ItemName.ToString());
                    lvItem.SubItems.Add(dish.TimeDishOrdered.ToShortTimeString());
                    lvItem.SubItems.Add("Dish Ready");
                    lvItem.BackColor = Color.LightGreen;
                    lvItem.SubItems.Add(dish.OrderedDishAmount.ToString());
                    lvOrders.Items.Add(lvItem);
                }
            }
        }

        //show all the drinks that are ready in the list view
        private void ShowDrinkReady(List<OrderedDrink> drinks)
        {
            foreach (OrderedDrink drink in drinks)
            {
                if (drink.DrinkStatus == DrinkStatus.PickUp)
                {
                    ListViewItem lvItem = new ListViewItem(drink.ItemName.ToString());
                    lvItem.SubItems.Add(drink.TimeDrinkOrdered.ToShortTimeString());
                    lvItem.SubItems.Add("Drink Ready");
                    lvItem.BackColor = Color.LightGreen;
                    lvItem.SubItems.Add(drink.OrderedDrinkAmount.ToString());
                    lvOrders.Items.Add(lvItem);
                }
            }
        }

        //show all the items that are served in the list view
        private void ShowServedItems(List<OrderedDish> dishes, List<OrderedDrink> drinks)
        {
            foreach (OrderedDish dish in dishes)
            {
                if (dish.Status == DishStatus.Serve)
                {
                    ListViewItem lvItem = new ListViewItem(dish.ItemName.ToString());
                    lvItem.SubItems.Add(dish.TimeDishOrdered.ToShortTimeString());
                    lvItem.SubItems.Add("Served");
                    lvItem.BackColor = Color.Yellow;
                    lvItem.SubItems.Add(dish.OrderedDishAmount.ToString());
                    lvOrders.Items.Add(lvItem);
                }               
            }

            foreach (OrderedDrink drink in drinks)
            {
                if (drink.DrinkStatus == DrinkStatus.Serve)
                {
                    ListViewItem lvItem = new ListViewItem(drink.ItemName.ToString());
                    lvItem.SubItems.Add(drink.TimeDrinkOrdered.ToShortTimeString());
                    lvItem.SubItems.Add("Served");
                    lvItem.BackColor = Color.Yellow;
                    lvItem.SubItems.Add(drink.OrderedDrinkAmount.ToString());
                    lvOrders.Items.Add(lvItem);
                }
            }
        }

        //When Clicked will Occupy and unOccupy the tables
        private void btnOccupy_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnOccupy.Text == "Empty")
                {
                    btnOccupy.Text = "Occupied";
                    btnOccupy.BackColor = Color.Red;
                    btnOccupy.ForeColor = Color.White;
                    table.TableStatus = TableStatus.Occupied;
                    table.WaiterID = employee.EmplID;
                    tableLogic.UpdateTableWaiter(table);
                }
                else if (btnOccupy.Text == "Occupied")
                {
                    btnOccupy.Text = "Empty";
                    btnOccupy.BackColor = Color.LightGray;
                    btnOccupy.ForeColor = Color.Black;
                    table.TableStatus = TableStatus.Empty;
                    tableLogic.Update(table);
                }
                else
                {
                    return;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error");
            }                     
        }

        //Will take you to the OrderFrom
        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                table = tableLogic.GetTableById(table.TableNumber);
                orderForm = new FormOrder(table, employee, rosMain);
                this.Close();
                orderForm.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error");
            }
        }

        //Will take you to the PaymentForm
        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                FormPayment formPayment = new FormPayment(table, employee, rosMain);
                formPayment.Show();
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error");
            }
        }

        //Goes back to the TableOverview
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                new TableOverview(employee, rosMain).Show();
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error");
            }
        }

        //Serves the dishes oredered by the table and update the kitchen view
        private void btnDishServed_Click(object sender, EventArgs e)
        {
            try
            {                
                tableOverview.GetAllOrderedDishes(table);
                tableOverview.CheckOrderedItems(table);
                UpdateOccupyButton(table, btnOccupy);
                rosMain.UpdateAllListViews();             
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }          
        }

        //Serves the drinks oredered by the table and update the bar view
        private void btnDrinkServed_Click(object sender, EventArgs e)
        {
            try
            {        
                tableOverview.GetAllOrderedDrinks(table);                
                tableOverview.CheckOrderedItems(table);
                UpdateOccupyButton(table, btnOccupy);
                rosMain.UpdateAllListViews();              
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

        //updates the occupy button.
        private void UpdateOccupyButton(Table table, Button button)
        {
            Label l = new Label();
            PictureBox pb = new PictureBox();
            PictureBox pb2 = new PictureBox();
            button.Enabled = false;
            tableOverview.UpdateButtonColor(table, button, l, pb, pb2);
            if (button.Text == "Empty" || button.Text == "Occupied")
            {
                button.Enabled = true;
            }               
        }

        //updates the list view and the button occupy
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            lvOrders.Items.Clear();
            dishes = dishLogic.GetAllOrderedDishByTable(table);
            drinks = drinkLogic.GetAllOrderedDrinksByTable(table);
            
            SortItems(dishes, drinks);
            UpdateOccupyButton(table, btnOccupy);
            return;
        }


    }
}
