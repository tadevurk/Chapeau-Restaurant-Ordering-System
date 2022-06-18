using RosModel;
using System;
using System.Windows.Forms;

namespace RosUI
{
    public partial class TableGuide : Form
    {
        private Employee employee;
        private RosMain rosMain;

        public TableGuide(Employee employee, RosMain rosMain)
        {
            InitializeComponent();
            this.employee = employee;
            this.rosMain = rosMain;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new TableOverview(employee, rosMain).Show();
        }
    }
}
