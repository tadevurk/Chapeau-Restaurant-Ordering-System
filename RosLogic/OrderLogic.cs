using RosModel;
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
        public int AddOrder(Employee employee, Table table)
        {
           return orderDAO.AddOrder(employee, table);
        }

        public void UpdateStock(Item item)
        {
            orderDAO.UpdateStock(item);
        }
    }
}
