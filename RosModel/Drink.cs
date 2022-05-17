using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosModel
{
    public class Drink : Item
    {
        public int DrinkID { get; set; }
        public int AmountType { get; set; }
        public string DrinkTypeID { get; set; }
        public string DrinkCategory { get; set; }

        public int Order { get; set; }
        public int Amount { get; set; }
        public string Note { get; set; }

    }
}
