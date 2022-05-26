using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosModel
{
    public class BillItem : Item
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public int Vat { get; set; }
        public int DishStatus { get; set; }
        public int DrinkStatus { get; set; }

        //public decimal SubPrice { get; set; }
        //public decimal ItemPrice { get; set; }


    }
}
