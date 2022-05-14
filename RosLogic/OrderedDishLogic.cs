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
        public List<OrderedDish> GetAllOrderedDish()
        {
            return orderedDishdb.GetAllOrderedDish();
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
