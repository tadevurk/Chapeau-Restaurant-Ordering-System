using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosModel
{
    public class Dish : Item
    {
        public int DishID { get; set; }
        public string MenuType { get; set; }
        public string Course { get; set; }
        public string Note { get; set; }
        public int Vat { get; set; }
        public decimal SubPrice { get; set; }

        public int Amount { get; set; }

        public int Order { get; set; } // OrderID

        public int OrderedAmount { get; set; }

        public override string ToString()
        {
            return $"{ItemName}";
        }

    }
}
