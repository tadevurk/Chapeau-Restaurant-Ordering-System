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

namespace RosUI
{
    public partial class TableOverview : Form
    {
        private Employee employee;
        private RosMain rosMain;
        private Table table;
        private TableLogic tableLogic = new TableLogic();
        private OrderedDishLogic orderedDishLogic = new OrderedDishLogic();
        private OrderedDrinkLogic orderedDrinkLogic = new OrderedDrinkLogic();
        private List<Table> tables;


        public TableOverview(Employee employee, RosMain rosMain)
        {
            InitializeComponent();
            this.employee = employee;
            this.rosMain = rosMain;
            table = new Table();
            rosMain.AddWaiterView(this);
            lblWaiter.Text = "Waiter: " + employee.Name;
            tables = tableLogic.GetAllTables();
            UpdateAllButtons(tables);
        }

        //clicking the button opens the table control
        private void btnTableOne_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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

        public Button UpdateButtonColor(Table table, Button button)
        {
            switch (table.TableStatus)
            {
                case 0:
                    button.BackColor = Color.LightGray;
                    button.Text = "Empty";
                    return button;
                case 1:
                    button.BackColor = Color.Red;
                    button.Text = "Occupied";
                    return button;
                case 2:
                    button.BackColor = Color.LightBlue;
                    button.Text = "Standby";
                    return button;
                case 3:
                    button.BackColor = Color.LightGreen;
                    button.Text = "DrinkReady";
                    return button;
                case 4:
                    button.BackColor = Color.LightGreen;
                    button.Text = "DishReady";
                    return button;
            }        
            return button;
        }

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
        }

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

        public void ItemServed(int number)
        {
            //changing color of buttons when order is ready for the pick up 
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
    }
}
