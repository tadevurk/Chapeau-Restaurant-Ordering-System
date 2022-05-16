using RosModel;
using RosLogic;
using System;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace RosUI
{
    public partial class Login : Form
    {
        Employee employee = new Employee();
        EmployeeLogic employeeLogic = new EmployeeLogic();

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

          
                if (CheckPassword())
                {
                    RosMain uIMain = new RosMain(employee);
                    this.Hide();
                    uIMain.Show();
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
