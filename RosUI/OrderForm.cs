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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnStarters_Click(object sender, EventArgs e)
        {
            Starters starters = new Starters();

            starters.Show();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            Drinks drinks = new Drinks();
            drinks.Show();
        }
    }
}
