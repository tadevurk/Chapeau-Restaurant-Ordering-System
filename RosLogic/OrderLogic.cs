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
        OrderDAO orderDAO;

        public OrderLogic()
        {
            orderDAO = new OrderDAO();
        }
        public void AddOrder(Order order)
        {
            orderDAO.AddOrder(order);
        }
        public List<Order> GetAllOrders()
        {
            return orderDAO.GetAllOrders();
        }


    }
}
