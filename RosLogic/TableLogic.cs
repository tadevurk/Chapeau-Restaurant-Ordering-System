using System;
using RosModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<OrderedDrink> GetOrderedDrinksReady(int tableNumber)
        {
            return tabledb.GetOrderedDrinksReady(tableNumber);
        }

        public List<OrderedDish> GetOrderedDishesReady(int tableNumber)
        {
            return tabledb.GetOrderedDishesReady(tableNumber);
        }

        public List<OrderedDrink> GetOrderedDrinksToPrepare(int tableNumber)
        {
            return tabledb.GetOrderedDrinksToPrepare(tableNumber);
        }

        public List<OrderedDish> GetOrderedDishesToPrepare(int tableNumber)
        {
            return tabledb.GetOrderedDishesToPrepare(tableNumber);
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
