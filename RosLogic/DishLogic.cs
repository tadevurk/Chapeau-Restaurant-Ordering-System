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

        public List<Dish> GetAllDish()
        {
            return dishDAO.GetAllDish();
        }

        public Dish GetDishByCourse(string course)
        {
            return dishDAO.GetDishByCourse(course);
        }
    }
}
