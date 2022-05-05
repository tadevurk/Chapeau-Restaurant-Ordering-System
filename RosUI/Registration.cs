using System;

using System.Windows.Forms;
using RosLogic;
using RosModel;

namespace RosUI
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            EmployeeLogic employeeLogic = new EmployeeLogic();
            Employee employee = new Employee();
            employee = employeeLogic.GetEmployeeByUsername(txtUsername.Text);
            
            RosMain uIMain = new RosMain(employee);
            this.Hide();
            uIMain.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
