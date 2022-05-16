using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosModel
{
    public class Order
    {
        public Order(Employee emp, Table tab)
        {
            WaiterID = emp.EmplID;
            TableNumber = tab.TableNumber;

        }

        public Order()
        {

        }
        public int OrderID { get; set; }
        public int WaiterID { get; set; }
        public int ChefID { get; set; }
        public int TableNumber { get; set; }
        public int BartenderID { get; set; }
        public int BillNumber { get; set; }
    }
}
