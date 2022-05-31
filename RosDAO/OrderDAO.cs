using RosModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosDAL
{
    public class OrderDAO : BaseDAO
    {

        public int AddOrder(Employee emp, Table t) // Mirko contributed 
        {

            string query = "insert into [Order] values(@WaiterID, null, @TableNumber, null, null);" +
                "select cast(scope_identity() as int)";
            SqlParameter[] pr = {
            
            new SqlParameter("@WaiterID", emp.EmplID),
            new SqlParameter("@TableNumber", t.TableNumber)
            };
            return ExecuteScalarQuery(query, pr);

        }

        public void UpdateStock(Item item)
        {
            string query = "Update Item " +
            "SET ItemStock = ItemStock + @amount " +
            "where ItemName = @ItemName; ";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ItemName", item.ItemName),
                new SqlParameter("@amount", item.ItemAmount)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
