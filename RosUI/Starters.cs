using RosLogic;
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
    public partial class Starters : Form
    {
        DishLogic startersLogic;
        public Starters()
        {
            InitializeComponent();
            startersLogic = new DishLogic();
            DisplayStarters();
        }

        private void btnSandvich_Click(object sender, EventArgs e)
        {
            //
        }


        void DisplayStarters()
        {
            List<Dish> starters = startersLogic.GetAllStarters();

            foreach (Dish starter in starters)
            {
                listBox1.Items.Add(starter);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dish starter = (Dish)listBox1.SelectedItem;
            
            startersLogic.DecrementStarterStock(starter); // Decrement the starter from stock

            // Stockdan eksilt
            // OrderDishe ekle
        }
    }
}
