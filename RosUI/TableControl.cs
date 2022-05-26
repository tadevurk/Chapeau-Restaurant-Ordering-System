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

namespace RosUI
{
    public partial class TableControl : Form
    {
        private TableStatus tableStatus;
        private FormOrder orderForm;
        private Employee employee;
        private Table table;
        private RosMain rosMain;

        public TableControl(Employee employee, RosMain rosMain, Table table)
        {
            InitializeComponent();
            this.employee = employee;
            this.rosMain = rosMain;
            this.table =  table;
            lblTable.Text = "Table: " + table.TableNumber;
            lblWaiter.Text = "Waiter: " + employee.Name;
        }

        private void btnOccupy_Click(object sender, EventArgs e)
        {
            tableStatus = TableStatus.Occupied;
        }

        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            table = new Table(table.TableNumber, employee);
            orderForm = new FormOrder(table, employee, rosMain);

            orderForm.ShowDialog();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            tableStatus = TableStatus.Empty;
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
