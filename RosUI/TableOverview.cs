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
        private List<Table> tables;

        public TableOverview(Employee employee, RosMain rosMain)
        {
            InitializeComponent();
            this.employee = employee;
            this.rosMain = rosMain;
            rosMain.AddWaiterView(this);
            lblWaiter.Text = "Waiter: " + employee.Name;
            tables = tableLogic.GetAllTables();

        }

        //clicking the button opens the table control
        //passing the button as parameter to change the color
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
                MessageBox.Show("Error Occurred: " + exp.Message);
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

        public void UpdateTableStatus()
        {

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
    }
}
