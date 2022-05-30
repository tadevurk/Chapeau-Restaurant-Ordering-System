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

        public List<OrderedDish> GetOrderedDishes(Table table)
        {
            return billdb.GetOrderedDishes(table);
        }

        public List<OrderedDrink> GetOrderedDrinks(Table table)
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

        public void SetDishPaid(OrderedDish item)
        {
            billdb.SetDishPaid(item);
        }

        public void SetDrinkPaid(OrderedDrink item)
        {
            billdb.SetDrinkPaid(item);
        }
    }
}
