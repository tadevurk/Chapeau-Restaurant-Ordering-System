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
        public List<Order> GetAllOrders() // Get the list of the all orders
        {
            string query = "SELECT [OrderID], [WaiterID], [drinkId], [ChefID], [TableNumber], [BartenderID], [BillNumber] FROM [Order]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        //HOW TO REMOVE THE WHOLE ORDER AT ONCE (OrderID is a foreign key in OrderedDish and OrderedDrink) ...

        private List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderID = (int)dr["OrderID"],
                    WaiterID = (int)dr["WaiterID"],
                    ChefID = (int)dr["ChefID"],
                    TableNumber = (int)dr["TableNumber"],
                    BartenderID = (int)dr["BartenderID"],
                    BillNumber = (int)dr["BillNumber"]
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
