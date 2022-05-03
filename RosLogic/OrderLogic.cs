using RosModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosDAL;

namespace RosLogic
{
    public class OrderLogic
    {
        OrderDAO orderDAO = new OrderDAO();
        public Order GetOrderById(int id)
        {
            return orderDAO.GetOrderById(id);
        }

        public List<Order> GetAllOrders()
        {
            return orderDAO.GetAllOrders();
        }

        public Order GetOrderByTable(Table table)
        {
            return orderDAO.GetOrderByTable(table);
        }
    }
}
