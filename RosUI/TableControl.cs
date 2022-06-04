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
            UpdateButtonAccessibilty();
        }

        //When Clicked will Occupy and unOccupy the tables
        private void btnOccupy_Click(object sender, EventArgs e)
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
                btnOccupy.BackColor = Color.LightGray;
                btnOccupy.ForeColor = Color.Black;
                table.TableStatus = 0;
                tableLogic.Update(table);
            }              
        }

        //Will take you to the OrderFrom
        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            table = tableLogic.GetTableById(table.TableNumber);
            orderForm = new FormOrder(table, employee, rosMain);
            this.Close();
            orderForm.Show();
        }

        //Will take you to the PaymentForm
        private void btnPay_Click(object sender, EventArgs e)
        {
            FormPayment formPayment = new FormPayment(table, employee, orderForm, rosMain);
            formPayment.Show();
            this.Close();
        }

        //Goes back to the TableOverview
        private void btnBack_Click(object sender, EventArgs e)
        {
            new TableOverview(employee, rosMain).Show();
            this.Close();
        }

        private void btnDishServed_Click(object sender, EventArgs e)
        {
            tableOverview.GetAllOrderedDishes(table);
            btnOccupy.Text = "Served";
            btnOccupy.BackColor = Color.Yellow;
            btnOccupy.ForeColor = Color.Black;
            tableOverview.CheckOrderedItems(table);
            btnPay.Enabled = true;
            rosMain.UpdateAllListViews();
        }

        private void btnDrinkServed_Click(object sender, EventArgs e)
        {
            tableOverview.GetAllOrderedDrinks(table);
            btnOccupy.Text = "Served";
            btnOccupy.BackColor = Color.Yellow;
            btnOccupy.ForeColor = Color.Black;
            tableOverview.CheckOrderedItems(table);
            btnPay.Enabled = true;
            rosMain.UpdateAllListViews();
        }

        private void UpdateButtonAccessibilty()
        {
            btnPay.Enabled = false;
            btnDishServed.Enabled = false;
            btnDrinkServed.Enabled = false;
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
                btnDrinkServed.Enabled = true;
            }
            else if (table.TableStatus == 4)
            {
                btnOccupy.Text = "Dish Ready";
                btnOccupy.BackColor = Color.LightGreen;
                btnOccupy.ForeColor = Color.Black;
                btnDishServed.Enabled = true;
            }
            else if (table.TableStatus == 5)
            {
                btnOccupy.Text = "Served";
                btnOccupy.BackColor = Color.Yellow;
                btnOccupy.ForeColor = Color.Black;
                btnPay.Enabled = true;
            }
            else
            {
                btnOccupy.Text = "Occupy";
                btnOccupy.BackColor = Color.LightGray;
                btnOccupy.ForeColor = Color.Black;
                btnOccupy.Enabled = true;
            }

            //if (employee.Name == "supusr")
            //{
            //    btnPay.Enabled = true;
            //    btnDishServed.Enabled = true;
            //    btnDrinkServed.Enabled = true;
            //}
        }
    }
}
