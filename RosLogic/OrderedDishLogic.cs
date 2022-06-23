using System.Collections.Generic;
using RosModel;
using RosDAL;
using System;

////////////////////Mirko Cuccurullo, 691362, GROUP 1, IT1D/////////////////////////////////////////////////////////////////////////////////////////////

namespace RosLogic
{
    public class OrderedDishLogic
    {
        OrderedDishDAO orderedDishdb;

        public OrderedDishLogic()
        {
            orderedDishdb = new OrderedDishDAO();
        }

        public void UpdateDishStatusServe(OrderedDish d)
        {
            orderedDishdb.UpdateDishStatusServe(d);
        }

        public void UpdateDishStatusPickUp(OrderedDish dish)
        {
            orderedDishdb.UpdateDishStatusPickUp(dish);
        }

        public List<OrderedDish> GetAllOrderedDish()
        {
            return orderedDishdb.GetAllOrderedDish();
        }

        public List<OrderedDish> GetAllOrderedDishByTable(Table table)
        {
            return orderedDishdb.GetAllOrderedDishByTable(table);
        }

        public List<OrderedDish> GetAllFinishedDish()
        {
            return orderedDishdb.GetAllFinishedDish();
        }

        public void UpdateDishToStart(OrderedDish orderedDish)
        {
            orderedDishdb.UpdateDishToStart(orderedDish);
        }

        public void BringStatusBack(OrderedDish orderedDish)
        {
            orderedDishdb.BringStatusBack(orderedDish);
        }

        public void UpdateOrderWithChefID(Employee employee, OrderedDish dish)
        {
            orderedDishdb.UpdateOrderWithChefID(employee, dish);
        }
    }
}
