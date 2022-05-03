using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosModel;
using RosDAL;

namespace RosLogic
{
    public class OrderedDrink
    {
        OrderedDrinkDAO drinkDAO = new OrderedDrinkDAO();

        public List<Drink> GetOrderedDrinksByTable(Table table)
        { return null; }

        public List<Drink> GetOrderedDrinksByOrder(Order order)
        { return null; }
    }
}
