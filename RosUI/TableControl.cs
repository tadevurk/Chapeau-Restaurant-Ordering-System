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

namespace RosUI
{
    public partial class TableControl : Form
    {
        private FormOrder orderForm;
        private Employee employee;
        private Table table;
        private RosMain rosMain;
        private TableLogic tableLogic = new TableLogic();

        public TableControl(Employee employee, RosMain rosMain, Table table)
        {
            InitializeComponent();
            this.employee = employee;
            this.rosMain = rosMain;
            this.table =  table;
            orderForm = new FormOrder(table, employee, rosMain);
            lblTable.Text = "Table: " + table.TableNumber;
            lblWaiter.Text = "Waiter: " + employee.Name;

            if (table.TableStatus == 1)
            {
                btnOccupy.Text = "Occupied";
                btnOccupy.BackColor = Color.Red;
            }
        }

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

        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            table = tableLogic.GetTableById(table.TableNumber);
            orderForm = new FormOrder(table, employee, rosMain);
            orderForm.ShowDialog();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            FormPayment formPayment = new FormPayment(table, employee, orderForm, rosMain);
            formPayment.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new TableOverview(employee, rosMain).Show();
            this.Close();
        }
    }
}
