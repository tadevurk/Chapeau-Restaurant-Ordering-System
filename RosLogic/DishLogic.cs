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

        public List<Dish> GetLunchStarters()
        {
            return dishDAO.GetLunchStarters();
        }
        public List<Dish> WriteContainedDishes(Table t, Order o)
        {
            return dishDAO.WriteContainedDishes(t, o);
        }

        public List<Dish> GetLunchMains()
        {
            return dishDAO.GetLunchMains();
        }

        public List<Dish> GetLunchDesserts()
        {
            return dishDAO.GetLunchDesserts();
        }
        public List<Dish> GetDinnerMains()
        {
            return dishDAO.GetDinnerMains();
        }
        public void IncreaseDishStock(Dish dish)
        {
            dishDAO.IncreaseDishStock(dish);
        }

        public void DecreaseDishStock(Dish dish)
        {
            dishDAO.DecreaseDishStock(dish);
        }
        public int RetrieveVatByID(int id)
        {
            return dishDAO.RetrieveVatByID(id);
        }
    }
}
