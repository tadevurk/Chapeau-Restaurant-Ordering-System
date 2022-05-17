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
    public partial class Payment : Form
    {
        Order order = new Order();

        public Payment(Table table)
        {
            InitializeComponent();
            lblTableNumber.Text = $"{lblTableNumber.Text} {table.TableNumber.ToString()}";

        }

        private void listViewPayment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
