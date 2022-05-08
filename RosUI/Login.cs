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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPinCode.Text == "")
            {
                MessageBox.Show("*Please your username and password*");
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

            if (CheckPassword())
            {
                Employee employee = new Employee();
                EmployeeLogic employeeLogic = new EmployeeLogic();
                employee = employeeLogic.GetEmployeeByUsername(txtUsername.Text);

                //if(employee.PinCode = txtPinCode.Text)
                //{
                    
                //}

                RosMain uIMain = new RosMain(employee);
                this.Hide();
                uIMain.Show();
            }
            else { return; }
        }

        private bool CheckPassword()
        {
            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }
    }
}
