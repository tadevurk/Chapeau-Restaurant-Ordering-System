
namespace RosModel
{
    public enum TableStatus {Empty = 0, Occupied, Standby, DrinkReady, DishReady, Served}

    public class Table
    {
        public int TableNumber { get; set; }
        public TableStatus TableStatus { get; set; }

        public int WaiterID { get; set; }

    }
}
