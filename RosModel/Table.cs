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

        public Employee Employee { get; set; }

        public Table(int number, Employee employee)
        {
            TableNumber = number;
            Employee = employee;
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
