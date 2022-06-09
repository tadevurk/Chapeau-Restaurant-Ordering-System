using RosLogic;
using RosModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosUI
{
    public partial class ForgotPassword : Form
    {
        private Employee employee;
        private List<SecretQuestion> questions;
        private EmployeeLogic employeeLogic;
        public ForgotPassword()
        {
            InitializeComponent();
            employeeLogic = new EmployeeLogic();
            employee = new Employee();
            questions = employeeLogic.GetAllSecretQuestions();
            foreach (SecretQuestion question in questions)
            {
                cmbSecret.Items.Add($"{question.Question}");
            }
        }

        //checks all the fields and stores the stores the new password
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtSecretAnswer.Text == "" || txtNewPassword.Text == "" || txtReEnterpassword.Text == "" || cmbSecret.SelectedItem == null)
                {
                    throw new Exception("please make sure you filled in all fields");                   
                }

                employee.Username = txtUsername.Text;
                employee = employeeLogic.GetEmployeeByUsername(employee.Username);               

                if (employee.SecretAnswer == txtSecretAnswer.Text && txtNewPassword.Text == txtReEnterpassword.Text)
                {
                    employee.PinCode = txtNewPassword.Text;
                    StoreNewPassword();
                }
                else
                {
                    throw new Exception("your secret answer is incorrect");
                }            
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //encrypts the new password and updates it to database
        private void StoreNewPassword()
        {
            if (IsValidPassword(employee.PinCode))
            {
                HashWithSaltResult hashResultSha256 = EncryptPassword(txtNewPassword.Text);
                employee.Salt = hashResultSha256.Salt;
                employee.Digest = hashResultSha256.Digest;
                employeeLogic.UpdatePassword(employee);
                MessageBox.Show("succesfully updated new password");
                this.Close();
                new Login().Show();
            }
            else
            {
                throw new Exception("make sure your pincode is 4 digits long");
            }
            
        }

        //encrypts the password
        private HashWithSaltResult EncryptPassword(string password)
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            HashWithSaltResult hashResultSha256 = pwHasher.HashWithSalt(password, 64, SHA256.Create());

            return hashResultSha256;
        }

        //check if the password is valid
        private bool IsValidPassword(string pincode)
        {
            if (ContainsNumber(pincode) && pincode.Length == 4 && txtNewPassword.Text == txtReEnterpassword.Text)
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
