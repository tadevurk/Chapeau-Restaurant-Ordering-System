using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RosModel;
using RosLogic;

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

        public TableControl(Employee employee, RosMain rosMain, Table table)
        {
            InitializeComponent();
            this.employee = employee;
            this.rosMain = rosMain;
            this.table = table;
            tableLogic = new TableLogic();
            orderForm = new FormOrder(table, employee, rosMain);
            tableOverview = new TableOverview(employee, rosMain);
            lblTable.Text = "Table: " + table.TableNumber;
            lblWaiter.Text = "Waiter: " + employee.Name;
            UpdateOccupyButton();
        }

        //When Clicked will Occupy and unOccupy the tables
        private void btnOccupy_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnOccupy.Text == "Occupy")
                {
                    btnOccupy.Text = "Occupied";
                    btnOccupy.BackColor = Color.Red;
                    btnOccupy.ForeColor = Color.White;
                    table.TableStatus = 1;
                    table.WaiterID = employee.EmplID;
                    tableLogic.UpdateTableWaiter(table);
                }
                else if (btnOccupy.Text == "Occupied")
                {
                    btnOccupy.Text = "Occupy";
                    btnOccupy.BackColor = Color.LightGray;
                    btnOccupy.ForeColor = Color.Black;
                    table.TableStatus = 0;
                    tableLogic.Update(table);
                }
                else { return; };
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error", exp.Message);
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
                MessageBox.Show("Error", exp.Message);
            }
        }

        //Will take you to the PaymentForm
        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                FormPayment formPayment = new FormPayment(table, employee, orderForm, rosMain);
                formPayment.Show();
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error", exp.Message);
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
                MessageBox.Show("Error", exp.Message);
            }
        }

        //Serves the dishes oredered by the table and update the kitchen view
        private void btnDishServed_Click(object sender, EventArgs e)
        {
            try
            {
                tableOverview.GetAllOrderedDishes(table);
                tableOverview.CheckOrderedItems(table);
                rosMain.UpdateAllListViews();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error", exp.Message);
            }          
        }

        //Serves the drinks oredered by the table and update the bar view
        private void btnDrinkServed_Click(object sender, EventArgs e)
        {
            try
            {
                tableOverview.GetAllOrderedDrinks(table);
                tableOverview.CheckOrderedItems(table);
                rosMain.UpdateAllListViews();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error", exp.Message);
            }
            
        }

        //updates the occupy button.
        private void UpdateOccupyButton()
        {
            btnOccupy.Enabled = false;

            if (table.TableStatus == 1)
            {
                btnOccupy.Text = "Occupied";
                btnOccupy.BackColor = Color.Red;
                btnOccupy.ForeColor = Color.White;
                btnOccupy.Enabled = true;
            }
            else if (table.TableStatus == 2)
            {
                btnOccupy.Text = "Occupied";
                btnOccupy.BackColor = Color.Red;
                btnOccupy.ForeColor = Color.White;
            }
            else if (table.TableStatus == 3)
            {
                btnOccupy.Text = "Drink Ready";
                btnOccupy.BackColor = Color.LightGreen;
                btnOccupy.ForeColor = Color.Black;
            }
            else if (table.TableStatus == 4)
            {
                btnOccupy.Text = "Dish Ready";
                btnOccupy.BackColor = Color.LightGreen;
                btnOccupy.ForeColor = Color.Black;
            }
            else if (table.TableStatus == 5)
            {
                btnOccupy.Text = "Served";
                btnOccupy.BackColor = Color.Yellow;
                btnOccupy.ForeColor = Color.Black;
            }
            else
            {
                btnOccupy.Text = "Occupy";
                btnOccupy.BackColor = Color.LightGray;
                btnOccupy.ForeColor = Color.Black;
                btnOccupy.Enabled = true;
            }
        }
    }
}
