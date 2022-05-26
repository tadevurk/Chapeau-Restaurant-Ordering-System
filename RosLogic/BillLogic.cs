using System;
using System.Collections.Generic;
using RosDAL;
using RosModel;

namespace RosLogic
{
    public class BillLogic
    {
        BillDAO billdb;

        public BillLogic()
        {
            billdb = new BillDAO();
        }

        public List<Dish> GetOrderedDishes(Table table)
        {
            return billdb.GetOrderedDishes(table);
        }

        public List<Drink> GetOrderedDrinks(Table table)
        {
            return billdb.GetOrderedDrinks(table);
        }

        public void CreateBill(Bill b)
        {
            billdb.CreateBill(b);
        }

        public void UpdateBill(Bill b)
        {
            billdb.UpdateBill(b);
        }

        public void GetBill(Bill b)
        {
            billdb.GetBill(b);
        }

        public void SetDishPaid(Dish billItem)
        {
            billdb.SetDishPaid(billItem);
        }

        public void SetDrinkPaid(Drink billItem)
        {
            billdb.SetDrinkPaid(billItem);
        }
    }
}
