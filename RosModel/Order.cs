
namespace RosModel
{
    public class Order
    {
        public Order(Employee emp, Table tab)
        {
            WaiterID = emp.EmplID;
            TableNumber = tab.TableNumber;

        }
        public int OrderID { get; set; }
        public int WaiterID { get; set; }
        public int TableNumber { get; set; }
     }
}
