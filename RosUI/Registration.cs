using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using RosLogic;
using RosModel;

namespace RosUI
{
    public partial class Registration : Form
    {
        EmployeeLogic employeeLogic;
        RosMain rosMain;
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                employeeLogic = new EmployeeLogic();
                Employee employee = new Employee();
                Employee blank = employeeLogic.GetLastEmployeeID();
                int id = blank.EmplID + 1;

                if (txtUsername.Text == "" || txtName.Text == "" || txtPinCode.Text == "")
                {
                    MessageBox.Show("*Please fill all the fields*");
                    txtPinCode.Text = "";
                    txtName.Text = "";
                    txtUsername.Text = "";
                    txtLicenseKey.Text = "";
                    return;
                }

                employee.EmplID = id;
                employee.Username = txtUsername.Text;
                employee.Name = txtName.Text;
                employee.PinCode = txtPinCode.Text;

                if (CheckPassword(employee) && CheckRole(txtLicenseKey.Text, employee))
                {
                    MessageBox.Show("Registration Successfull");

                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    return;
                }            
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp.Message);
                rosMain.WriteError(exp, exp.Message);
            }
        }

        private bool CheckPassword(Employee employee)
        {
            if (IsValidPassword(employee.PinCode))
            {
                HashWithSaltResult hashResultSha256 = EncryptPassword(txtPinCode.Text);
                employee.Salt = hashResultSha256.Salt;
                employee.Digest = hashResultSha256.Digest;
                return true;
            }
            else
            {
                MessageBox.Show("*Your password must be a 4 digit pincode*");
                return false;
            }
        }

        private bool CheckRole(string licenseKey, Employee employee)
        {
            switch (licenseKey)
            {
                case "0001":
                    employeeLogic.AddManager(employee);
                    employeeLogic.Add(employee);
                    return true;

                case "0002":
                    employeeLogic.AddWaiter(employee);
                    employeeLogic.Add(employee);
                    return true;

                case "0003":
                    employeeLogic.AddChef(employee);
                    employeeLogic.Add(employee);
                    return true;

                case "0004":
                    employeeLogic.AddBartender(employee);
                    employeeLogic.Add(employee);
                    return true;
            }
            MessageBox.Show("*Please check if you have the correct license key*");
            return false;
        }

        private HashWithSaltResult EncryptPassword(string password)
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            HashWithSaltResult hashResultSha256 = pwHasher.HashWithSalt(password, 64, SHA256.Create());

            return hashResultSha256;
        }

        private bool IsValidPassword(string pincode)
        {
            if (ContainsNumber(pincode) && pincode.Length == 4)
            {
                return true;
            }
            return false;
        }

        private bool ContainsNumber(string pincode)
        {
            foreach (char c in pincode)
            {
                if (c >= '0' && c <= '9')
                {
                    return true;
                }
            }
            return false;
        }     
    }
}
