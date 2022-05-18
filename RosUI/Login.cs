using RosModel;
using RosLogic;
using System;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace RosUI
{
    public partial class Login : Form
    {
        Employee employee = new Employee();
        EmployeeLogic employeeLogic = new EmployeeLogic();
        Roles Roles = new Roles();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
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
                PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
                employee = employeeLogic.GetEmployeeByUsername(txtUsername.Text);
                CheckRole(employee);

          
                if (CheckPassword())
                {
                    RosMain main;
                    switch (employee.Roles)
                    {
                        case Roles.Manager:
                            this.Hide();
                            main = new RosMain(employee);
                            main.Show();
                            break;
                        case Roles.Waiter:
                            main = new RosMain(employee);
                            this.Hide();
                            new TableOverview(employee, main).Show();
                            break;
                        case Roles.Chef:
                            this.Hide();
                            main = new RosMain(employee);
                            main.Show();

                            break;
                        case Roles.Bartender:
                            this.Hide();
                            main = new RosMain(employee);
                            main.Show();

                            break;
                        case Roles.None:
                            this.Hide();
                            main = new RosMain(employee);
                            main.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("*Incorrect username or password*");
                    txtUsername.Text = "";
                    txtPinCode.Text = "";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp);
                WriteError(exp, exp.Message);
            }         
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new Registration().Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Occorred: " + exp);
                WriteError(exp, exp.Message);
            }
        }

        private bool CheckPassword()
        {
            if (employee.Salt == null || employee.Digest == null)
                return false;

                return employee.Digest.ToString() == EncryptPassword(txtPinCode.Text, employee.Salt).Digest;
        }

        private void CheckRole(Employee employee)
        {
            
            if (IsManager(employee))
            {
                employee.Roles = Roles.Manager;
            }
            else if (IsWaiter(employee))
            {
                employee.Roles = Roles.Waiter;
            }
            else if (IsChef(employee))
            {
                employee.Roles = Roles.Chef;
            }
            else if (IsBartender(employee))
            {
                employee.Roles = Roles.Bartender;
            }
            else
            {
                employee.Roles = Roles.None;
            }
        }

        private bool IsManager(Employee manager)
        {
            List<Employee> managers = employeeLogic.GetAllManagers();
            bool isManager = false;
            foreach (Employee m in managers)
            {
                if(manager.EmplID == m.EmplID)
                    isManager = true;
                break;
            }
            return isManager;
        }

        private bool IsWaiter(Employee waiter)
        {
            List<Employee> waiters = employeeLogic.GetAllWaiters();
            bool isWaiter = false;
            foreach (Employee w in waiters)
            {
                if (waiter.EmplID == w.EmplID)
                    isWaiter = true;
            }
            return isWaiter;
        }

        private bool IsChef(Employee chef)
        {
            List<Employee> chefs = employeeLogic.GetAllChefs();
            bool isChef = false;
            foreach (Employee c in chefs)
            {
                if (chef.EmplID == c.EmplID)
                    isChef = true;
            }
            return isChef;
        }

        private bool IsBartender(Employee bartender)
        {
            List<Employee> bartenders = employeeLogic.GetAllBartenders();
            bool isBartender = false;
            foreach (Employee b in bartenders)
            {
                if (bartender.EmplID == b.EmplID)
                    isBartender = true;
            }
            return isBartender;
        }

        //Write error to text file
        private void WriteError(Exception e, string errorMessage)
        {
            StreamWriter writer = File.AppendText("ErrorLog.txt");
            writer.WriteLine($"Error occurred: {errorMessage}");
            writer.WriteLine(e);
            writer.WriteLine(DateTime.Now);
            writer.Close();
        }

        //This method hash the password
        private HashWithSaltResult EncryptPassword(string password, string salt)
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            HashWithSaltResult hashResultSha256 = pwHasher.Hash(password, SHA256.Create(), salt);

            return hashResultSha256;
        }    
    }
}
