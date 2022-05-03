using RosModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosDAL
{
    public class OrderDAO : BaseDAO
    {
        public Order GetOrderById(int id)
        {
            return new Order();
        }

        public List<Order> GetAllOrders()
        {
            return new List<Order>();
        }

        public Order GetOrderByTable(Table table)
        {
            return new Order();
        }
    }
}
