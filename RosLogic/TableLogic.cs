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

        public void Update(Table table)
        {
            tabledb.Update(table);
        }
    }
}
