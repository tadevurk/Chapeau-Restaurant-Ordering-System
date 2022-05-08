using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosModel
{
    public class OrderedDrink
    {
        public int OrderID { get; set; }
        public int DrinkID { get; set; }
        public bool DrinkStatus { get; set; }
        public DateTime TimeDrinkOrdered { get; set; }
        public DateTime TimeDrinkDelivered { get; set; }
        public int OrderedDrinkAmount { get; set; }
        public string DrinkNote { get; set; }
    }
}
