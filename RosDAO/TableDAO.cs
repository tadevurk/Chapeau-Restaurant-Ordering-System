using RosModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosDAL
{
    public class TableDAO : BaseDAO
    {
        public Table GetTableById(int tableNumber)
        {
            return new Table();
        }

        public List<Table> GetAllTables()
        {
            return new List<Table>();
        }
    }
}
