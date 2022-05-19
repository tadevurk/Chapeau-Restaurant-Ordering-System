using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosModel
{
    public enum TableStatus { Unreserved, Reserved}

    public class Table
    {
        public int TableNumber { get; set; }
        public TableStatus TableStatus { get; set; }

        public Table(int number)
        {
            TableNumber = number;
        }

        public Table()
        {

        }

        Bill Bill { get; set; }

        Order Order { get; set; }
        Employee Employee { get; set; }
    }
}
