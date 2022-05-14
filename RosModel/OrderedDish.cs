using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosModel
{
    public class OrderedDish
    {
        public int OrderID { get; set; }
        public int DishID { get; set; }
        public bool DishStatus { get; set; }
        public DateTime TimeDishOrdered { get; set; }
        public DateTime TimeDishDelivered { get; set; }

        public int TableNumber { get; set; }

        public string Course { get; set; }

        public string Name { get; set; }
        public int OrderedDishAmount { get; set; }
        public string DishNote { get; set; }
    }
}
