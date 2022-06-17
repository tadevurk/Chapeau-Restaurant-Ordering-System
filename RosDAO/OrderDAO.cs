using RosModel;
using System.Data.SqlClient;


namespace RosDAL
{
    public class OrderDAO : BaseDAO
    {
        ////////////// Vedat Turk 683343 IT1D //////////////////////////////

        public int AddOrder(Employee employee, Table table) // Mirko contributed 
        {

            string query = "insert into [Order] values(@WaiterID, null, @TableNumber, null, null);" +
                "select cast(scope_identity() as int)";
            SqlParameter[] sqlParameters = {           
            new SqlParameter("@WaiterID", employee.EmplID),
            new SqlParameter("@TableNumber", table.TableNumber)
            };
            return ExecuteScalarQuery(query, sqlParameters);

        }

        public void DecreaseStock(Item item) // When order is sent all items will be decreased in stock
        {
            string query = "Update Item " +
            "SET ItemStock = ItemStock - @amount " +
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
