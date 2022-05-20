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

        public List<OrderedDish> GetOrderedDishes()
        {
            return billdb.GetOrderedDishes();
        }

        public List<OrderedDrink> GetOrderedDrinks()
        {
            return billdb.GetOrderedDrinks();
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

        public void SetItemsPaid(List<Dish> dishes)
        {
            billdb.SetItemsPaid(dishes);
        }
    }
}
