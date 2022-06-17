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

        public void IncreaseStock(Item item)
        {
            orderDAO.IncreaseStock(item);
        }

        public void DecreaseStock(Item item)
        {
            orderDAO.DecreaseStock(item);
        }
    }
}
