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
        TableDAO tableDAO = new TableDAO();
        public Table GetTableById(int tableNumber)
        {
            return tableDAO.GetTableById(tableNumber);
        }

        public List<Table> GetAllTables()
        {
            return tableDAO.GetAllTables();
        }
    }
}
