using RosModel;
using System.Collections.Generic;
using RosDAL;

namespace RosLogic
{
    public class TableLogic
    {
        TableDAO tabledb;

        public TableLogic()
        {
            tabledb = new TableDAO();
        }

        public Table GetTableById(int tableNumber)
        {
            return tabledb.GetTableById(tableNumber);
        }

        public List<Table> GetAllTables()
        {
            return tabledb.GetAllTables();
        }

        public int GetAmountOfTables()
        {
            return tabledb.GetAmountOfTables();
        }

        public List<OrderedDrink> GetOrderedDrinks(int tableNumber, int status)
        {
            return tabledb.GetOrderedDrinks(tableNumber, status);
        }

        public List<OrderedDish> GetOrderedDishes(int tableNumber, int status)
        {
            return tabledb.GetOrderedDishes(tableNumber, status);
        }

        public void Update(Table table)
        {
            tabledb.Update(table);
        }

        public void UpdateTableWaiter(Table table)
        {
            tabledb.UpdateTableWaiter(table);
        }
    }
}
