using RosModel;
using RosLogic;
using System;
using System.Windows.Forms;

namespace RosUI
{
    public partial class Login : Form
    {
        Employee employee;
        EmployeeLogic employeeLogic = new EmployeeLogic();


        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "test")
            {
                RosMain uIMain = new RosMain(employee);
                this.Hide();
                uIMain.Show();
            }
            if (txtUsername.Text == "" && txtPinCode.Text == "")
            {
                MessageBox.Show("*Please your username and password*");
                return;
            }
            else
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("*Please fill your username*");
                    txtPinCode.Text = "";
                    return;
                }
                if (txtPinCode.Text == "")
                {
                    MessageBox.Show("*Please fill your password*");
                    txtUsername.Text = "";
                    return;
                }
            }

            employee = employeeLogic.GetEmployeeByUsername(txtUsername.Text);

            if (CheckPassword(employee))
            {
                RosMain uIMain = new RosMain(employee);
                this.Hide();
                uIMain.Show();
            }
            else { return; }
        }

        private bool CheckPassword(Employee empl)
        {

            if (txtPinCode.Text == empl.PinCode.ToString())
            {
                return true;
            }

            return false;         
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }
    }
}
