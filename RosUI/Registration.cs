﻿using System;
using System.IO;
using System.Security.Cryptography;
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
            try
            {
                EmployeeLogic employeeLogic = new EmployeeLogic();
                Employee employee = new Employee();
                Employee blank = employeeLogic.GetLastEmployeeID();
                int id = blank.EmplID + 1;

                if (txtUsername.Text == "" || txtName.Text == "" || txtPinCode.Text == "")
                {
                    MessageBox.Show("*Please fill all the fields*");
                    txtPinCode.Text = "";
                    txtName.Text = "";
                    txtUsername.Text = "";
                    return;
                }

                employee.EmplID = id;
                employee.Username = txtUsername.Text;
                employee.Name = txtName.Text;
                employee.PinCode = int.Parse(txtPinCode.Text);

                if (CheckPassword(employee))
                {
                    employeeLogic.Add(employee);
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
                MessageBox.Show("Error Occorred: " + exp);
                WriteError(exp, exp.Message);
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
                MessageBox.Show("Error Occorred: " + exp);
                WriteError(exp, exp.Message);
            }
        }

        //Methods
        //Write error to text file
        private void WriteError(Exception e, string errorMessage)
        {
            StreamWriter writer = File.AppendText("ErrorLog.txt");
            writer.WriteLine($"Error occurred: {errorMessage}");
            writer.WriteLine(e);
            writer.WriteLine(DateTime.Now);
            writer.Close();
        }

        public bool CheckPassword(Employee employee)
        {
            if (IsValidPassword(employee.PinCode.ToString()))
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
