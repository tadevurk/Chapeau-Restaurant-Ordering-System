using RosModel;
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
    public partial class RosMain : Form
    {
        Employee employee = new Employee();
        public RosMain(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;         
        }

        private void RosMain_Load(object sender, EventArgs e)
        {
            ShowPanel("Dashboard");
        }

        private void ShowPanel(string panelName)
        {
            switch (panelName)
            {
                case "KitchenView":

                    HideAllPanels();
                    pnlKitchenView.Show();

                    break;

                case "Dashboard":

                    HideAllPanels();
                    pnlDashboard.Show();

                    break;

                case "BarView":

                    HideAllPanels();
                    pnlBarView.Show();

                    break;

                case "TableView":

                    HideAllPanels();
                    pnlTableView.Show();

                    break;


            }
                
        }

        private void HideAllPanels()
        {
            pnlKitchenView.Hide();
            pnlDashboard.Hide();
            pnlBarView.Hide();
            pnlTableView.Hide();
        }

        private void kitchenViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("KitchenView");
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("Dashboard");
        }

        private void barViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("BarView");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }


        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("TableView");
        }

        private void btnTableOne_Click(object sender, EventArgs e)
        {
            Table table = new Table(1);
            OrderForm orderForm = new OrderForm(table);

            orderForm.ShowDialog();
        }

        private void btnTableTwo_Click(object sender, EventArgs e)
        {
            Table table = new Table(2);
            OrderForm orderForm = new OrderForm(table);

            orderForm.ShowDialog();
        }

        private void btnTableThree_Click(object sender, EventArgs e)
        {
            Table table = new Table(3);
            OrderForm orderForm = new OrderForm(table);

            orderForm.ShowDialog();
        }

        private void btnTableFour_Click(object sender, EventArgs e)
        {
            Table table = new Table(4);
            OrderForm orderForm = new OrderForm(table);

            orderForm.ShowDialog();
        }

        private void btnTableFive_Click(object sender, EventArgs e)
        {
            Table table = new Table(5);
            OrderForm orderForm = new OrderForm(table);

            orderForm.ShowDialog();
        }

        private void btnTableSix_Click(object sender, EventArgs e)
        {
            Table table = new Table(6);
            OrderForm orderForm = new OrderForm(table);

            orderForm.ShowDialog();
        }

        private void btnTableSeven_Click(object sender, EventArgs e)
        {
            Table table = new Table(7);
            OrderForm orderForm = new OrderForm(table);

            orderForm.ShowDialog();
        }

        private void btnTableEight_Click(object sender, EventArgs e)
        {
            Table table = new Table(8);
            OrderForm orderForm = new OrderForm(table);

            orderForm.ShowDialog();
        }

        private void btnTableNine_Click(object sender, EventArgs e)
        {
            Table table = new Table(9);
            OrderForm orderForm = new OrderForm(table);

            orderForm.ShowDialog();
        }

        private void btnTableTen_Click(object sender, EventArgs e)
        {
            Table table = new Table(10);
            OrderForm orderForm = new OrderForm(table);

            orderForm.ShowDialog();
        }
    }
}
