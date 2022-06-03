using System;
using System.Collections.Generic;
using RosModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosDAL;

namespace RosLogic
{
    public class DishLogic
    {
        DishDAO dishDAO = new DishDAO();

        public void AddDishes(List<Dish> dishes, Order order)
        {
            dishDAO.AddDishes(dishes, order);
        }
        public List<Dish> GetLunchStarters()
        {
            return dishDAO.GetLunchStarters();
        }
        public List<Dish> WriteContainedDishes(Table table)
        {
            return dishDAO.WriteContainedDishes(table);
        }

        public List<Dish> GetLunchMains()
        {
            return dishDAO.GetLunchMains();
        }

        public List<Dish> GetLunchDesserts()
        {
            return dishDAO.GetLunchDesserts();
        }
        public List<Dish> GetDinnerStarters()
        {
            return dishDAO.GetDinnerStarters();
        }
        public List<Dish> GetDinnerMains()
        {
            return dishDAO.GetDinnerMains();
        }
        public List<Dish> GetDinnerDesserts()
        {
            return dishDAO.GetDinnerDesserts();
        }
        public void IncreaseDishStock(Dish dish)
        {
            dishDAO.IncreaseDishStock(dish);
        }

        public void DecreaseDishStock(Dish dish)
        {
            dishDAO.DecreaseDishStock(dish);
        }
    }
}
