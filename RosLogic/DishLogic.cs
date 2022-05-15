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

        public List<Dish> GetAllStarters()
        {
            return dishDAO.GetAllStarters();
        }

        public List<Dish> GetAllMains()
        {
            return dishDAO.GetAllMains();
        }

        public List<Dish> GetAllDesserts()
        {
            return dishDAO.GetAllDesserts();
        }

        public List<Dish> GetAllEntremets()
        {
            return dishDAO.GetAllEntremets();
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
