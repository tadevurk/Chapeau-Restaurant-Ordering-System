using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RosModel;

namespace RosUI
{
    public partial class OrderForm : Form
    {
        Table table;
        public OrderForm(Table table)
        {
            InitializeComponent();
            this.table = table;
            lblTableNumber.Text =$"{lblTableNumber.Text} {table.TableNumber.ToString()}" ;
        }

        private void btnStarters_Click(object sender, EventArgs e)
        {
            Starters starters = new Starters();

            starters.ShowDialog();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            Drinks drinks = new Drinks();
            drinks.ShowDialog();
        }
    }
}
