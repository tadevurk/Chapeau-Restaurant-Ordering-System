using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosModel
{
    public class Table
    {

        public int TableNumber { get; set; }
        public string TabStatus { get; set; }

        Bill Bill { get; set; }

        Order Order { get; set; }
        Employee Employee { get; set; }

        void ReserveTable(Table table)
        {

        }

        void AddOrder(Order order)
        {

        }

    }
}
