using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosModel
{
    public enum TableStatus {Empty = 0, Occupied, Standby, DrinkReady, DishReady, Served}

    public class Table
    {
        public int TableNumber { get; set; }
        public TableStatus TableStatus { get; set; }

        public int WaiterID { get; set; }

        public Table()
        {

        }
    }
}
