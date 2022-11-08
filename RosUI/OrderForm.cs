using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RosLogic;
using RosModel;

namespace RosUI
{
    ////// Vedat Türk --- 683343 --- GROUP1- IT1D - ///////////////////////
    public partial class FormOrder : Form
    {
        private Table table;
        private RosMain rosMainForm;
        private Employee employee;
        private OrderLogic orderLogic;
        private TableLogic tableLogic;

        public FormOrder(Table table, Employee employee, RosMain rosMainForm)
        {
            InitializeComponent();
            this.rosMainForm = rosMainForm;
            this.employee = employee;
            this.table = table;
            orderLogic = new OrderLogic();
            tableLogic = new TableLogic();
            lblTableNumber.Text = $"{lblTableNumber.Text} {table.TableNumber.ToString()}";
            DisplayRunningOrder();
        }

        private void showPanel(string panelName)
        {
            HideListViews();
            switch (panelName)
            {
                case "Lunch":
                    listviewLunch.Show();
                    List<Dish> lunchMeals = orderLogic.GetDishes(MenuType.Lunch);
                    DisplayItems<Dish>(listviewLunch, lunchMeals);
                    break;
                case "Dinner":
                    listviewDinner.Show();
                    List<Dish> dinnerMeals = orderLogic.GetDishes(MenuType.Dinner);
                    DisplayItems<Dish>(listviewDinner, dinnerMeals);
                    break;
                case "Drinks":
                    listviewDrinks.Show();
                    List<Drink> drinks = orderLogic.GetAllDrinks();
                    DisplayItems<Drink>(listviewDrinks, drinks);
                    break;
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            HideListViews();
            ButtonColorReset();
        }

        #region DESIGN OF THE ORDER FORM
        private void ButtonColorReset()
        {
            btnLunch.BackColor = Color.LightSkyBlue;
            btnDrinks.BackColor = Color.LightSkyBlue;
            btnDinner.BackColor = Color.LightSkyBlue;
        }

        // If an item is selected, make visible some buttons
        private void SendCancelNoteButtonsVisible()
        {
            btnSendOrder.Visible = true;
            btnCancelOrder.Visible = true;
            btnOrderAddNote.Visible = true;
            txtNote.Visible = true;
        }
        void HideListViews()
        {
            listviewLunch.Hide();
            listviewDinner.Hide();
            listviewDrinks.Hide();
        }
        private static void ChangeColorOfItems(ListView listview, Item item, ListViewItem lvItem)
        {
            if (listview.Items.IndexOf(lvItem) % 2 == 0)
            {
                lvItem.BackColor = Color.FromArgb(224, 234, 255);
            }

            if (item.ItemStock == 0)
            {
                lvItem.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Strikeout);
            }

        }

        // Clean selected items by passing the listview array since each time different list(s) view is cleaned
        private static void CleanSelectedItems(ListView[] lists)
        {
            foreach (ListView list in lists)
            {
                list.SelectedItems.Clear();
            }
        }
        private void CleanOrderWindow(Button button)
        {
            ButtonColorReset();
            btnOrderAddNote.Enabled = false;
            txtNote.Clear();
            button.BackColor = Color.LightGreen;
        }
        #endregion

        #region DISPLAY ORDERED ITEMS AND MENU ITEMS 
        // Display all (already) ordered items from the table
        private void DisplayRunningOrder()
        {
            try
            {
                List<Item> itemsInOrder = orderLogic.ReadRunningOrderItems(table);
                listviewOrder.Items.Clear();

                foreach (Item item in itemsInOrder)
                {
                    ListViewItem lvItem = new(item.ItemName.ToString());
                    lvItem.SubItems.Add($"€ {item.ItemPrice}");
                    lvItem.SubItems.Add(item.ItemAmount.ToString());
                    if (item.NoteAmount >= 1)
                    {
                        lvItem.SubItems.Add("✓");
                    }
                    else
                    {
                        lvItem.SubItems.Add("");
                    }
                    lvItem.ForeColor = Color.Green;
                    lvItem.Tag = (Item)item;
                    listviewOrder.Items.Add(lvItem);
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        // Passing generic type of list, and calling it according to list type
        private void DisplayItems<T>(ListView listview, List<T> items)
        {
            listview.Items.Clear();

            foreach (T item in items)
            {
                ListViewItem lvItem;
                if (item is Dish dish)
                {
                    lvItem = new ListViewItem(dish.ItemName.ToString());
                    lvItem.SubItems.Add($"€ {dish.ItemPrice}");
                    lvItem.SubItems.Add(dish.Course);
                    lvItem.Tag = dish;
                    listview.Items.Add(lvItem);
                    ChangeColorOfItems(listview, dish, lvItem);
                }
                if (item is Drink drink)
                {
                    lvItem = new ListViewItem(drink.ItemName.ToString());
                    lvItem.SubItems.Add($"€ {drink.ItemPrice}");
                    lvItem.SubItems.Add(drink.DrinkCategory);
                    lvItem.Tag = drink;
                    listview.Items.Add(lvItem);
                    ChangeColorOfItems(listview, drink, lvItem);
                }
            }
        }
        #endregion
        private void btnLunch_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Lunch");
                CleanSelectedItems(new ListView[] { listviewDinner, listviewDrinks });
                CleanOrderWindow(btnLunch);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnDinner_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Dinner");
                CleanSelectedItems(new ListView[] { listviewLunch, listviewDrinks });
                CleanOrderWindow(btnDinner);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            try
            {
                showPanel("Drinks");
                CleanSelectedItems(new ListView[] { listviewLunch, listviewDinner });
                CleanOrderWindow(btnDrinks);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void listviewLunch_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Item selectedDish = (Item)listviewLunch.SelectedItems[0].Tag;
                AddItemAndCleanUI(selectedDish, listviewLunch);
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }

        private void listviewDinner_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Item selectedDish = (Item)listviewDinner.SelectedItems[0].Tag;
                AddItemAndCleanUI(selectedDish, listviewDinner);
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }

        private void listviewDrinks_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Item selectedDrink = (Item)listviewDrinks.SelectedItems[0].Tag;
                AddItemAndCleanUI(selectedDrink, listviewDrinks);
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Sorry");
            }
        }

        private void AddItemAndCleanUI(Item selectedItem, ListView listView)
        {
            CleanSelectedItems(new ListView[] { listviewOrder });
            if (selectedItem.ItemStock == 0)
            {
                listView.SelectedItems[0].Selected = false;
                throw new Exception("This item is sold out!");
            }
            btnOrderAddNote.Enabled = true;
            AddItem(selectedItem);
            SendCancelNoteButtonsVisible();
            txtNote.Clear();
        }

        #region ADD ITEM / CHECK EXISTING ITEM TO listiewOrder
        private void AddItem(Item selectedItem)
        {
            ListViewItem? checkItem = null;

            foreach(ListViewItem lvItem in listviewOrder.Items)
            {
                CheckExistingItem(selectedItem, ref checkItem, lvItem);
            }
            
            if (checkItem == null)
            {
                CreateItem(selectedItem);
            }
        }

        private static void CheckExistingItem(Item selectedItem, ref ListViewItem? checkItem, ListViewItem lvItem)
        {
            Item item = (Item)lvItem.Tag;
            if (selectedItem.ItemID == item.ItemID && !item.IsOrdered)
            {
                checkItem = lvItem; //Not null anymore
                item.ItemAmount = int.Parse(lvItem.SubItems[2].Text);
                item.ItemAmount++; // Increase the amount of the existing item in the listviewOrder
                lvItem.SubItems[2].Text = item.ItemAmount.ToString();
            }
        }

        private void CreateItem(Item selectedItem)
        {
            ListViewItem lvItem = new ListViewItem(selectedItem.ItemName);
            lvItem.SubItems.Add($"€ {selectedItem.ItemPrice}");
            selectedItem.ItemAmount = 1;
            lvItem.SubItems.Add(selectedItem.ItemAmount.ToString());
            lvItem.SubItems.Add(""); // Note column
            lvItem.Tag = selectedItem;  
            lvItem.ForeColor = Color.Red; // Change color for the new ordered item
            listviewOrder.Items.Add(lvItem);
            listviewOrder.Items[listviewOrder.Items.Count - 1].EnsureVisible(); // To see the last item for scrollbar
        }
        #endregion

        #region CANCEL (WHOLE ORDER) OR REMOVE (ONE BY ONE)
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (listviewOrder.Items.Count == 0)
                {
                    throw new Exception($"{employee.Name}, you did not order anything!");
                }

                DialogResult dialogResult = MessageBox.Show("Do you want to cancel complete order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.Yes)
                {
                    CancelOrder();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                CancelOrder();
                Close();
                new TableControl(employee, rosMainForm, table).Show();
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        // Cancel the complete order
        private void CancelOrder()
        {
            foreach (ListViewItem lvOrderInProcess in listviewOrder.Items)
            {
                Item item = (Item)lvOrderInProcess.Tag;

                if (!item.IsOrdered)
                {
                    listviewOrder.Items.Remove(lvOrderInProcess);
                }
            }
        }
        private void listviewOrder_MouseClick(object sender, MouseEventArgs e) // Removing the item from ordered list
        {
            try
            {
                CleanSelectedItems(new ListView[] { listviewDinner, listviewLunch, listviewDrinks });
                btnOrderAddNote.Enabled = false;

                Item item = (Item)listviewOrder.SelectedItems[0].Tag;

                if (item.IsOrdered)
                {
                    listviewOrder.SelectedItems[0].Selected = false;
                    throw new Exception("This item is already ordered!");
                }
                if (listviewOrder.SelectedItems.Count == 1)
                {
                    RemoveItem(item);
                }

                txtNote.Clear();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        // Remove the items one by one
        private void RemoveItem(Item item)
        {
            if (item.ItemAmount == 1)
            {
                listviewOrder.Items.RemoveAt(listviewOrder.SelectedItems[0].Index);
            }
            else
            {
                item.ItemAmount--;
                listviewOrder.SelectedItems[0].SubItems[2].Text = item.ItemAmount.ToString();
            }
        }
        #endregion

        #region ADD ITEM NOTE (EVENT AND METHOD)
        private void btnOrderAddNote_Click(object sender, EventArgs e)
        {
            try
            {
                Item selectedItem;
                if (txtNote.Text == "")
                {
                    throw new Exception("Text box is empty!");
                }
                if (listviewLunch.SelectedItems.Count == 1)
                {
                    selectedItem = (Item)listviewLunch.SelectedItems[0].Tag;
                    AddItemNote(listviewLunch, selectedItem);
                }
                else if (listviewDinner.SelectedItems.Count == 1)
                {
                    selectedItem = (Item)listviewDinner.SelectedItems[0].Tag;
                    AddItemNote(listviewDinner, selectedItem);
                }
                else if (listviewDrinks.SelectedItems.Count == 1)
                {
                    selectedItem = (Item)listviewDrinks.SelectedItems[0].Tag;
                    AddItemNote(listviewDrinks, selectedItem);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                txtNote.Clear();
            }
        }

        private void AddItemNote(ListView menuListView, Item selectedItem)
        {
            foreach (ListViewItem lvItem in listviewOrder.Items)
            {
                Item item = (Item)lvItem.Tag;
                if (item.ItemID == selectedItem.ItemID && !item.IsOrdered)
                    {
                        item.ItemNote = txtNote.Text;
                        lvItem.SubItems[3].Text = "✓";
                    }        
            }
            CleanSelectedItems(new ListView[] { menuListView });
            MessageBox.Show("Note has been added!");
        }
        #endregion

        #region WRITE ITEM, DECREASE STOCK AND UPDATE THE OTHER COMPONENT
        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // If the last item is not ordered yet or the list is empty
                bool hasItemToOrder = listviewOrder.Items.Count > 0 && ((Item)listviewOrder.Items[listviewOrder.Items.Count -1].Tag).IsOrdered;
                if (listviewOrder.Items.Count == 0 || hasItemToOrder)
                {
                    throw new Exception($"Sorry {employee.Name}, there is nothing to send");
                }

                DialogResult dialogResult = MessageBox.Show("Do you want to send this order?", "Send Order", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    WriteItemAndDecreaseStock();            
                    UpdateOtherComponents();
                    Close();
                    new TableControl(employee, rosMainForm, table).Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Send Order");
            }
        }

        private void WriteItemAndDecreaseStock()
        {
            // Create new order with waiterId and tableNumber
            Order order = new(employee, table)
            {
                OrderID = orderLogic.OpenOrder(employee, table)
            };
            List<Item> itemListInOrderProcess = new();
            foreach (ListViewItem lvItem in listviewOrder.Items)
            {
                Item item = (Item)lvItem.Tag;
                if (!item.IsOrdered)
                {
                    itemListInOrderProcess.Add(item);
                    orderLogic.DecreaseStock(item);
                }
            }
            orderLogic.WriteOrderedItems(itemListInOrderProcess, order);
        }
        private void UpdateOtherComponents()
        {
            table.TableStatus = TableStatus.Standby; // Jason
            tableLogic.Update(table); // Jason                    
            rosMainForm.UpdateAllListViews(); //Update KitchenView and Barview
            rosMainForm.UpdateTableToOrdered(table.TableNumber); //Update TableView
        }
        #endregion
    }
}
