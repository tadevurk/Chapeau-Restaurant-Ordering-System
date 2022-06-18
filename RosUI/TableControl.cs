using System;
using System.Drawing;
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
            UpdateOccupyButton(table, btnOccupy);
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
            tableOverview.UpdateButtonColor(table, button);
        }
    }
}
