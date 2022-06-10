using System;

namespace RosModel
{
    public enum DrinkStatus { ToPrepare, PickUp, Serve, Payed }

    public class OrderedDrink :Item
    {
        public int OrderID { get; set; }
        public DrinkStatus DrinkStatus { get; set; }
        public DateTime TimeDrinkOrdered { get; set; }
        public int OrderedDrinkAmount { get; set; }

        public int TableNumber { get; set; }
    }
}
