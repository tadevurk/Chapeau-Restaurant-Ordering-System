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

        public void AddOrder(Order order)
        {
            order.OrderID = MaxCount() + 1;
            string query = "insert into [Order] values(@count, @WaiterID, null, @TableNumber, null, null);";
            SqlParameter[] pr = {
            new SqlParameter("@count", order.OrderID),
            new SqlParameter("@WaiterID", order.WaiterID),
            new SqlParameter("@TableNumber", order.TableNumber)
            };
            ExecuteEditQuery(query, pr);

        }

        public int MaxCount()
        {
            string query = "select count(*) as count from [Order]";
            SqlParameter[] sp = new SqlParameter[0];
            
            return ReadCount(ExecuteSelectQuery(query, sp));
        }

        private int ReadCount(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            return (int)row["count"];
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
