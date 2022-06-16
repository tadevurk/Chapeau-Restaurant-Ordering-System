using System.Collections.Generic;
using RosModel;
using RosDAL;
using System;

namespace RosLogic
{
    public class DishLogic
    {
        DishDAO dishDAO = new DishDAO();

        public void AddDishes(List<Dish> dishes, Order order)
        {
            dishDAO.AddDishes(dishes, order);
        }
        public List<Dish> ReadContainedDishes(Table table)
        {
            return dishDAO.ReadContainedDishes(table);
        }

        public List<Dish> GetDishes(int menuType)
        {
            return dishDAO.GetDishes(menuType);
        }
    }
}
