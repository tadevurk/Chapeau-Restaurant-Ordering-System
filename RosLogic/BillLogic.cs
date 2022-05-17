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

        public void CreateBills()
        {
            return billDAO.GetAllBills();
        }
    }
}
