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

        public TableControl(Employee employee, RosMain rosMain, Table table)
        {
            InitializeComponent();
            this.employee = employee;
            this.rosMain = rosMain;
            this.table =  table;
            tableLogic = new TableLogic();
            orderForm = new FormOrder(table, employee, rosMain);
            lblTable.Text = "Table: " + table.TableNumber;
            lblWaiter.Text = "Waiter: " + employee.Name;

            if (table.TableStatus == 2 || table.TableStatus == 3 || table.TableStatus == 4)
            {
                btnOccupy.Text = "Occupied";
                btnOccupy.BackColor = Color.Red;
                btnOccupy.Enabled = false;
            }
            else if (table.TableStatus == 1)
            {
                btnOccupy.Text = "Occupied";
                btnOccupy.BackColor = Color.Red;
            }
        }

        //When Clicked will Occupy and unOccupy the tables
        private void btnOccupy_Click(object sender, EventArgs e)
        {
            
            if (btnOccupy.Text == "Occupy")
            {
                btnOccupy.Text = "Occupied";
                btnOccupy.BackColor = Color.Red;
                table.TableStatus = 1;
                table.WaiterID = employee.EmplID;
                tableLogic.UpdateTableWaiter(table);
            }
            else
            {
                btnOccupy.Text = "Occupy";
                btnOccupy.BackColor = Color.LightGray;
                table.TableStatus = 0;
                tableLogic.Update(table);
            }              
        }

        //Will take you to the OrderFrom
        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            table = tableLogic.GetTableById(table.TableNumber);
            orderForm = new FormOrder(table, employee, rosMain);
            orderForm.ShowDialog();
        }

        //Will take you to the PaymentForm
        private void btnPay_Click(object sender, EventArgs e)
        {
            FormPayment formPayment = new FormPayment(table, employee, orderForm, rosMain);
            formPayment.Show();
            this.Close();
        }

        //Logs the user out and opens the LoginForm
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();         
        }

        //Goes back to the TableOverview
        private void btnBack_Click(object sender, EventArgs e)
        {
            new TableOverview(employee, rosMain).Show();
            this.Close();
        }
    }
}
