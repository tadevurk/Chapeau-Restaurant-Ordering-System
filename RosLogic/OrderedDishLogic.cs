using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosModel;
using RosDAL;

namespace RosLogic
{
    public class OrderedDish
    {
        OrderedDishDAO dishDAO = new OrderedDishDAO();

        public List<Dish> GetOrderedDishByTable(Table table)
        {
            return dishDAO.GetOrderedDishByTable(table);
        }

        public List<Dish> GetOrderedDishByOrder(Order order)
        {
            return dishDAO.GetOrderedDishByOrder(order);
        }
    }
}
