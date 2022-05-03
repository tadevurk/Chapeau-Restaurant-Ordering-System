using RosModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosDAL
{
    public class DishDAO : BaseDAO
    {
        public Dish GetDishById(int id)
        {
            return new Dish();
        }

        public List<Dish> GetAllDish()
        {
            return new List<Dish>();
        }

        public Dish GetDishByCourse(string course)
        {
            return new Dish();
        }
    }
}
