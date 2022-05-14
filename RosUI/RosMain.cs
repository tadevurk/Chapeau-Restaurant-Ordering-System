﻿using RosModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RosLogic;

namespace RosUI
{
    public partial class RosMain : Form
    {
        Employee employee = new Employee();
        public RosMain(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;         
        }

        private void RosMain_Load(object sender, EventArgs e)
        {
            ShowPanel("Dashboard");
        }

        private void ShowPanel(string panelName)
        {
            switch (panelName)
            {
                case "KitchenView":

                    HideAllPanels();
                    pnlKitchenView.Show();
                    UpdateDishes();

                    break;

                case "Dashboard":

                    HideAllPanels();
                    pnlDashboard.Show();

                    break;

                case "BarView":

                    HideAllPanels();
                    pnlBarView.Show();
                    UpdateDrinks();

                    break;

                case "TableView":

                    HideAllPanels();
                    pnlTableView.Show();

                    break;


            }
                
        }

        private void HideAllPanels()
        {
            pnlKitchenView.Hide();
            pnlDashboard.Hide();
            pnlBarView.Hide();
            pnlTableView.Hide();
        }

        private void kitchenViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("KitchenView");
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("Dashboard");
        }

        private void barViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("BarView");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }


        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("TableView");
        }

        private void btnTableOne_Click(object sender, EventArgs e)
        {
            Table table = new Table(1);
            OrderForm orderForm = new OrderForm(table);

            orderForm.ShowDialog();
        }

        private void UpdateDrinks()
        {
            OrderedDrinkLogic logic = new OrderedDrinkLogic();
            List<OrderedDrink> orderedDrinks = logic.GetAllOrderedDrinks();

            lvOrderedDrinks.Items.Clear();

            foreach (OrderedDrink drink in orderedDrinks)
            {
                ListViewItem li = new ListViewItem(drink.TableNumber.ToString());
                li.SubItems.Add(drink.Name);
                li.SubItems.Add(drink.TimeDrinkOrdered.ToString());
                lvOrderedDrinks.Items.Add(li);
            }
        }

        private void UpdateDishes()
        {
            OrderedDishLogic logic = new OrderedDishLogic();
            List<OrderedDish> orderedDrinks = logic.GetAllOrderedDish();

            lvOrderedDishes.Items.Clear();

            foreach (OrderedDish dish in orderedDrinks)
            {
                ListViewItem li = new ListViewItem(dish.TableNumber.ToString());
                li.SubItems.Add(dish.Name);
                li.SubItems.Add(dish.TimeDishOrdered.ToString());
                li.SubItems.Add(dish.Course);
                lvOrderedDishes.Items.Add(li);
            }
        }


    }
}
