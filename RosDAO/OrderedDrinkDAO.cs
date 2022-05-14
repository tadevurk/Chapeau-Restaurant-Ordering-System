using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosModel;

namespace RosDAL
{
    public class OrderedDrinkDAO : BaseDAO
    {
        public void AddDrink(OrderedDrink orderedDrink) // Add dish to ordered dish table (The question is DishID or OrderID??)
        {
            string query = "INSERT INTO OrderDrink " +
                "(OrderID, DrinkID, " +
                "DrinkStatus, TimeDrinkOrdered, TimeDrinkDelivered), " +
                "OrderedDrinkAmount, DrinkNote " +
                "VALUES (@OrderID, @DrinkID, " +
                "@DrinkStatus, @TimeDrinkOrdered, @TimeDrinkDelivered), " +
                "@OrderedDrinkAmount, @DrinkNote " +
                "SELECT SCOPE_IDENTITY()";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@OrderID", orderedDrink.OrderID),
                new SqlParameter("@DrinkID", orderedDrink.DrinkID),
                new SqlParameter("@DrinkStatus", orderedDrink.DrinkStatus),
                new SqlParameter("@TimeDrinkOrdered", orderedDrink.TimeDrinkOrdered),
                new SqlParameter("@TimeDishDelivered", orderedDrink.TimeDrinkDelivered),
                new SqlParameter("@TimeDrinkDelivered", orderedDrink.OrderedDrinkAmount),
                new SqlParameter("@DrinkNote", orderedDrink.DrinkNote)
            };
            ExecuteEditQuery(query, sqlParameters);
        }


        public void UpdateDrink(OrderedDrink orderedDrink) // Change the amount of the drink etc. (The question is DrinkID or OrderID??)
        {
            string query = "UPDATE [OrderDrink] SET TimeDrinkOrdered = @TimeDrinkOrdered, TimeDrinkDelivered = @TimeDrinkDelivered, " +
                "OrderedDrinkAmount = @OrderedDrinkAmount, DrinkNote = @DrinkNote " +
                "WHERE DrinkID = @DrinkID";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@DrinkID", orderedDrink.DrinkID),
                new SqlParameter("@TimeDrinkOrdered", orderedDrink.TimeDrinkOrdered),
                new SqlParameter("@TimeDrinkDelivered", orderedDrink.TimeDrinkDelivered),
                new SqlParameter("@OrderedDrinkAmount", orderedDrink.OrderedDrinkAmount),
                new SqlParameter("@DrinkNote", orderedDrink.DrinkNote)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveDrink(OrderedDrink orderedDrink) // Remove drink from ordered drink table (The question is DrinkID or OrderID??)
        {
            string query = "DELETE FROM OrderDrink WHERE DrinkID = @DrinkID";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinkID", orderedDrink.DrinkID) };

            ExecuteEditQuery(query, sqlParameters);
        }
        public List<OrderedDrink> GetAllOrderedDrinks()
        {
            string query = "SELECT O.TableNumber as tableNumber, I.ItemName as name, OD.TimeDrinkOrdered as [time] from OrderDrink as OD join [Order] as O on OD.OrderID=O.OrderID" +
                " join Item as I on OD.DrinkID=I.ItemID where OD.DrinkStatus = 0 order by OD.TimeDrinkOrdered; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderedDrink> ReadTables(DataTable dataTable)
        {
            List<OrderedDrink> drinks = new List<OrderedDrink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderedDrink drink = new OrderedDrink()
                {
                    TableNumber = (int)dr["tableNumber"],
                    Name = (string)dr["name"],
                    TimeDrinkOrdered = (DateTime)dr["time"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
