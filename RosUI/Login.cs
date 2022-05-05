using RosModel;
using RosLogic;
using System;
using System.Windows.Forms;

namespace RosUI
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
      
        private bool CheckPassword()
        {
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (CheckPassword())
            {
                Employee employee = new Employee();
                EmployeeLogic employeeLogic = new EmployeeLogic();
                employee = employeeLogic.GetEmployeeByUsername(txtUsername.Text);

                RosMain uIMain = new RosMain(employee);
                this.Hide();
                uIMain.Show();
            }
            else { return; }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }
    }
}
