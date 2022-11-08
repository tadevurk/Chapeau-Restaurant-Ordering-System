using RosDAL;
using RosModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosLogic
{
    public class OrderLogic
    {
        OrderDAO orderDAO;

        public OrderLogic()
        {
            orderDAO = new OrderDAO();
        }

        public void WriteOrderedItems(List<Item> itemsInOrderProcess, Order order)
        {
            if(itemsInOrderProcess.Count <= 0)
            {
                throw new Exception("Something went wrong, try again!");
            }
            orderDAO.WriteOrderedItems(itemsInOrderProcess, order);
        }

        public List<Item> ReadRunningOrderItems(Table table)
        {
            // There is no check here since this method, mostly, returns 0 lenght list 
            return orderDAO.ReadRunningOrderItems(table);
        }

        public List<Dish> GetDishes(MenuType menuType)
        {
            List<Dish> dishes =  orderDAO.GetDishes(menuType);

            if (dishes.Count <= 0)
            {
                throw new Exception("Something went wrong, try again!");
            }
            return dishes;
        }

        public List<Drink> GetAllDrinks()
        {
            List<Drink> drinks =  orderDAO.GetAllDrinks();

            if (drinks.Count <= 0)
            {
                throw new Exception("Something went wrong, try again!");
            }
            return drinks;
        }


        public int OpenOrder(Employee employee, Table table)
        {
            if (employee == null && table == null)
            {
                throw new Exception("Something went wrong, try again!");
            }
            return orderDAO.OpenOrder(employee, table);
        }

        public void DecreaseStock(Item item)
        {
            if (item == null)
            {
                throw new Exception("Item is not decreased from stock");
            }
            orderDAO.DecreaseStock(item);
        }

    }
}
