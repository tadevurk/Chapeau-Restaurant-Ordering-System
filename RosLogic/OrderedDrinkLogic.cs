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

        public void AddDrinks(List<Drink> drinkInOrderProcess, Order order)
        {
            orderedDrinkdb.AddDrinks(drinkInOrderProcess, order);
        }
    }
}
