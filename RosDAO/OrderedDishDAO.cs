using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosModel;

namespace RosDAL
{
    public class OrderedDishDAO : BaseDAO
    {
        public void AddDish(OrderedDish orderedDish) // Add dish to ordered dish table (The question is DishID or OrderID??)
        {
            string query = "INSERT INTO OrderDish " +
                "(OrderID, DishID, " +
                "DishStatus, TimeDishOrdered, TimeDishDelivered), " +
                "OrderedDishAmount, DishNote " +
                "VALUES (@OrderID, @DishID, " +
                "@DishStatus, @TimeDishOrdered, @TimeDishDelivered), " +
                "@OrderedDishAmount, @DishNote " +
                "SELECT SCOPE_IDENTITY()";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@OrderID", orderedDish.OrderID),
                new SqlParameter("@DishID", orderedDish.DishID),
                new SqlParameter("@DishStatus", orderedDish.DishStatus),
                new SqlParameter("@TimeDishOrdered", orderedDish.TimeDishOrdered),
                new SqlParameter("@TimeDishDelivered", orderedDish.TimeDishDelivered),
                new SqlParameter("@OrderedDishAmount", orderedDish.OrderedDishAmount),
                new SqlParameter("@DishNote", orderedDish.DishNote)
            };
            ExecuteEditQuery(query, sqlParameters);
        }


        public void UpdateDish(OrderedDish orderedDish) // Change the amount of the dish (The question is DishID or OrderID??)
        {
            string query = "UPDATE [OrderDish] SET TimeDishOrdered = @TimeDishOrdered, TimeDishDelivered = @TimeDishDelivered, " +
                "OrderedDishAmount = @OrderedDishAmount, DishNote = @DishNote " +
                "WHERE DishID = @DishID";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@DishID", orderedDish.DishID),
                new SqlParameter("@TimeDishOrdered", orderedDish.TimeDishOrdered),
                new SqlParameter("@TimeDishDelivered", orderedDish.TimeDishDelivered),
                new SqlParameter("@OrderedDishAmount", orderedDish.OrderedDishAmount),
                new SqlParameter("@DishNote", orderedDish.DishNote)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveDish(OrderedDish orderedDish) // Remove dish from ordered dish table (The question is DishID or OrderID??)
        {
            string query = "DELETE FROM OrderDish WHERE DishID = @DishID";
            SqlParameter[] sqlParameters = { new SqlParameter("@DishID", orderedDish.DishID) };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
