using RosModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosUI
{
    public partial class Login : Form
    {
        RosMain uIMain;
        Employee employee;
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
                uIMain = new RosMain(employee);
                this.Hide();
                uIMain.Show();
            }
            else { return; }

        }
    }
}
