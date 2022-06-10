using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;
using RosLogic;
using RosModel;

////////////////////Jason Xie, 659045, GROUP 1, IT1D////////////////////////////////////////////////////////////////////////////////////////////////

namespace RosUI
{
    public partial class Registration : Form
    {
        private EmployeeLogic employeeLogic;
        private RosMain rosMain;
        private Employee employee;
        private List<SecretQuestion> questions;

        public Registration(RosMain rosMain)
        {
            InitializeComponent();
            employeeLogic = new EmployeeLogic();
            this.rosMain = rosMain;
            questions = employeeLogic.GetAllSecretQuestions();
            foreach (SecretQuestion question in questions)
            {
                cmbSecret.Items.Add($"{question.Question}");
            }
        }

        //Will register the user and store it into the database
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {                             
                //Make sure all the fields are filled
                if (txtUsername.Text == "" || txtName.Text == "" || txtPinCode.Text == "" || txtSecretAnswer.Text == "" || cmbSecret.SelectedItem == null)
                {
                    MessageBox.Show("make sure to fill in all the fields");
                    return;
                }

                employee = new Employee();

                //stores the informaion about the user
                Employee blank = employeeLogic.GetLastEmployeeID();
                int id = blank.EmplID + 1;
                employee.EmplID = id;
                employee.Username = txtUsername.Text;
                employee.Name = txtName.Text;
                employee.PinCode = txtPinCode.Text;
                employee.SecretAnswer = txtSecretAnswer.Text;

                //Make sure the password and the role is correct
                if (CheckPassword(employee) && CheckRole(txtLicenseKey.Text, employee))
                {
                    MessageBox.Show("Your Registration is Successfull");

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
                MessageBox.Show(exp.Message, "Error");
                rosMain.WriteError(exp, exp.Message);
            }
        }

        //Goes back to the Login Form
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
                MessageBox.Show(exp.Message, "Error");
                rosMain.WriteError(exp, exp.Message);
            }
        }

        //Check for a valid password and Encrypts the password and store it
        private bool CheckPassword(Employee employee)
        {
            //If the password is valid store the salt and digest
            if (IsValidPassword(employee.PinCode))
            {
                HashWithSaltResult hashResultSha256 = EncryptPassword(txtPinCode.Text);
                employee.Salt = hashResultSha256.Salt;
                employee.Digest = hashResultSha256.Digest;
                return true;
            }
            else
            {
                txtPinCode.Text = "";
                MessageBox.Show("Your password must be a 4 digit pincode");
                return false;
            }
        }

        //Check which role this user will be through the license key and adds it to the database
        private bool CheckRole(string licenseKey, Employee employee)
        {
            switch (licenseKey)
            {
                case "0001":
                    employeeLogic.Add(employee);
                    employeeLogic.AddManager(employee);                   
                    return true;

                case "0002":
                    employeeLogic.Add(employee);
                    employeeLogic.AddWaiter(employee);                  
                    return true;

                case "0003":
                    employeeLogic.Add(employee);
                    employeeLogic.AddChef(employee);                    
                    return true;

                case "0004":
                    employeeLogic.Add(employee);
                    employeeLogic.AddBartender(employee);                   
                    return true;
            }
            MessageBox.Show("Please check if you have the correct license key");
            txtLicenseKey.Text = "";
            return false;
        }

        //Encrypts the password
        private HashWithSaltResult EncryptPassword(string password)
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            HashWithSaltResult hashResultSha256 = pwHasher.HashWithSalt(password, 64, SHA256.Create());

            return hashResultSha256;
        }

        //Check if the password the user entered meets the requirement
        private bool IsValidPassword(string pincode)
        {
            if (ContainsNumber(pincode) && pincode.Length == 4)
            {
                return true;
            }
            return false;
        }

        //Check if the password contains numbers
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
