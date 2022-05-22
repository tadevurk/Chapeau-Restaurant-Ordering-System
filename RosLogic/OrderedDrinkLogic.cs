using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosModel;
using RosDAL;

namespace RosLogic
{
    public class OrderedDrinkLogic
    {
        OrderedDrinkDAO orderedDrinkdb;

        public OrderedDrinkLogic()
        {
            orderedDrinkdb = new OrderedDrinkDAO();
        }
        public List<OrderedDrink> GetAllOrderedDrinks()
        {
            return orderedDrinkdb.GetAllOrderedDrinks();
        }

        public void UpdateDrinkStatusServe(OrderedDrink drink)
        {
            orderedDrinkdb.UpdateDrinkStatusServe(drink);
        }

        public void UpdateDeliveryTime(Drink d)
        {
            orderedDrinkdb.UpdateDeliveredTime(d);
        }

        public void UpdateDrinkStatusPickUp(OrderedDrink orderedDrink)
        {
            orderedDrinkdb.UpdateDrinkStatusPickUp(orderedDrink);
        }
        public void AddDrink(OrderedDrink orderedDrink)
        {
            orderedDrinkdb.AddDrink(orderedDrink);
        }

        public void UpdateDrink(OrderedDrink orderedDrink)
        {
            orderedDrinkdb.AddDrink(orderedDrink);
        }

        public void RemoveDrink(OrderedDrink orderedDrink)
        {
            orderedDrinkdb.RemoveDrink(orderedDrink);
        }
    }
}
