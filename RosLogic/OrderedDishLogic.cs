using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosModel;
using RosDAL;

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

        public void IncreaseAmount(List<Dish> dishes, Order o)
        {
            foreach (Dish d in dishes)
            {
                orderedDishdb.IncreaseAmount(d, o);
            }
        }

        public void UpdateDishNote(OrderedDish dish, string message)
        {
            orderedDishdb.UpdateDishNote(dish, message);
        }
        public void AddDishes(List<Dish> dishes, Order order)
        {
            orderedDishdb.AddDishes(dishes, order);
        }
        public void UpdateDishStatusPickUp(OrderedDish dish)
        {
            orderedDishdb.UpdateDishStatusPickUp(dish);
        }
        public List<OrderedDish> GetAllOrderedDish()
        {
            return orderedDishdb.GetAllOrderedDish();
        }

        public void UpdateDeliveryTime(Dish d)
        {
            orderedDishdb.UpdateDeliveredTime(d);
        }

        public OrderedDish GetOrdereDishByKey(Order ord, Dish dish)
        {
            return orderedDishdb.GetOrderedDishByKey(ord, dish);
        }
        public void AddDish(OrderedDish orderedDish)
        {
            orderedDishdb.AddDish(orderedDish);
        }

        public void UpdateDish(OrderedDish orderedDish)
        {
            orderedDishdb.UpdateDish(orderedDish);
        }

        public void RemoveDish(OrderedDish orderedDish)
        {
            orderedDishdb.RemoveDish(orderedDish);
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
    }
}
