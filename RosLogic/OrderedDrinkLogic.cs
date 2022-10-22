using System.Collections.Generic;
using RosModel;
using RosDAL;
using System;

////////////////////Mirko Cuccurullo, 691362, GROUP 1, IT1D/////////////////////////////////////////////////////////////////////////////////////////////


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

        public List<OrderedDrink> GetAllOrderedDrinksByTable(Table table)
        {
            return orderedDrinkdb.GetAllOrderedDrinksByTable(table);
        }

        public void UpdateDrinkStatusServe(OrderedDrink drink)
        {
            orderedDrinkdb.UpdateDrinkStatusServe(drink);
        }

        public void UpdateDrinkStatusPickUp(OrderedDrink orderedDrink)
        {
            orderedDrinkdb.UpdateDrinkStatusPickUp(orderedDrink);
        }

        public List<OrderedDrink> GetAllFinishedDrinks()
        {
            return orderedDrinkdb.GetAllFinishedDrinks();
        }

        public void UpdateDrinkToStart(OrderedDrink finishedDrink)
        {
            orderedDrinkdb.UpdateDrinkToStart(finishedDrink);
        }

        public void BringStatusBack(OrderedDrink orderedDrink)
        {
            orderedDrinkdb.BringStatusBack(orderedDrink);
        }

        public void UpdateOrderWithBartenderID(Employee employee, OrderedDrink drink)
        {
            orderedDrinkdb.UpdateOrderWithBartenderID(employee, drink);
        }
    }
}
