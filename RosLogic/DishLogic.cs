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
        public Dish GetDishById(int id)
        {
            return dishDAO.GetDishById(id);
        }

        public List<Dish> GetAllStarters()
        {
            return dishDAO.GetAllStarters();
        }

        public void DecrementStarterStock(Dish starter)
        {
            dishDAO.DecrementStarterStock(starter);
        }
        public Dish GetDishByCourse(string course)
        {
            return dishDAO.GetDishByCourse(course);
        }
    }
}
