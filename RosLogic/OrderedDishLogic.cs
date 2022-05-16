﻿using System;
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
        public void UpdateDishNote(OrderedDish dish, string message)
        {
            orderedDishdb.UpdateDishNote(dish, message);
        }
        public void AddDishes(List<Dish> dishes, Order order)
        {
            orderedDishdb.AddDishes(dishes, order);
        }
        public void UpdateDishStatus(OrderedDish dish)
        {
            orderedDishdb.UpdateDishStatus(dish);
        }
        public List<OrderedDish> GetAllOrderedDish()
        {
            return orderedDishdb.GetAllOrderedDish();
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
    }
}
