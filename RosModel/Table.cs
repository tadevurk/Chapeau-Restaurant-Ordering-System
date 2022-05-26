using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosModel
{
    public enum TableStatus {Empty = 0, Occupied, Standby, DrinkReady, DishReady}

    public class Table
    {
        public int TableNumber { get; set; }
        public int TableStatus { get; set; }

        public int WaiterID { get; set; }

        public Table(int number, int tableStatus, int emplID)
        {
            TableNumber = number;
            TableStatus = tableStatus;
            WaiterID = emplID;
        }

        public Table(int number, int emplID)
        {
            TableNumber = number;
            WaiterID = emplID;
        }

        public Table(int number)
        {
            TableNumber = number;
        }
        public Table()
        {

        }
    }
}
