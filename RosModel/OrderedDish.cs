using System;

namespace RosModel
{
    public enum DishStatus { ToPrepare, PickUp, Serve, Payed }

    public class OrderedDish : Item
    {
        public int OrderID { get; set; }

        public DishStatus Status { get; set; }
        public DateTime TimeDishOrdered { get; set; }

        public int TableNumber { get; set; }

        public string Course { get; set; }

        public int OrderedDishAmount { get; set; }
    }
}
