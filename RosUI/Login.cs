using RosModel;
using RosLogic;
using System;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;

////////////////////Jason Xie, 659045, GROUP 1, IT1D////////////////////////////////////////////////////////////////////////////////////////////////

namespace RosUI
{
    public partial class Login : Form
    {
        private RosMain main;
        private Employee employee = new Employee();
        private EmployeeLogic employeeLogic;


        public Login()
        {
            InitializeComponent();
            employeeLogic = new EmployeeLogic();
        }

        //Will login the user in
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //check to see if all fields are filled
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
                        return;
                    }
                    if (txtPinCode.Text == "")
                    {
                        MessageBox.Show("*Please fill your password*");
                        return;
                    }
                }

                employee = employeeLogic.GetEmployeeByUsername(txtUsername.Text);
                //retrieve the role from the database
                CheckRole(employee);         

                //Checks the login password
                if (CheckPassword())
                {
                    //Checks which role the users has and opens the corrisponding form
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
                    txtPinCode.Text = "";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error");
                WriteError(exp, exp.Message);
            }         
        }

        //opens forgot password form
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            new ForgotPassword().Show();
        }

        //Opens the registration form
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new Registration(main).Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error");
                WriteError(exp, exp.Message);
            }
        }

        //Encrypts the password from the login and checks it with the one in the database
        private bool CheckPassword()
        {
            if (employee.Salt == null || employee.Digest == null)
                return false;

                return employee.Digest.ToString() == EncryptPassword(txtPinCode.Text, employee.Salt).Digest;
        }

        //Checks which role this user has
        private void CheckRole(Employee employee)
        {
            
            if (IsManager(employee))
            {
                employee.Roles = Roles.Manager;
                return;
            }
            else if (IsWaiter(employee))
            {
                employee.Roles = Roles.Waiter;
                return;
            }
            else if (IsChef(employee))
            {
                employee.Roles = Roles.Chef;
                return;
            }
            else if (IsBartender(employee))
            {
                employee.Roles = Roles.Bartender;
                return;
            }
            else
            {
                employee.Roles = Roles.None;
                return;
            }
        }

        //Checks in the database if the user is a manager
        private bool IsManager(Employee manager)
        {
            List<Employee> managers = employeeLogic.GetAllManagers();
            bool isManager = false;
            foreach (Employee m in managers)
            {
                if(manager.EmplID == m.EmplID)
                    isManager = true;
            }
            return isManager;
        }

        //Checks in the database if the user is a waiter
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

        //Checks in the database if the user is a chef
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

        //Checks in the database if the user is a bartender
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

        //This method encrypts the password
        private HashWithSaltResult EncryptPassword(string password, string salt)
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            HashWithSaltResult hashResultSha256 = pwHasher.Hash(password, SHA256.Create(), salt);

            return hashResultSha256;
        }
    }
}
