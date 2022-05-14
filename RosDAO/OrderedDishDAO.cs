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

        private List<OrderedDish> ReadTables(DataTable dataTable)
        {
            List<OrderedDish> dishes = new List<OrderedDish>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderedDish dish = new OrderedDish()
                {
                    TableNumber = (int)dr["tableNumber"],
                    Name = (string)dr["name"],
                    TimeDishOrdered = (DateTime)dr["time"],
                    Course = (string)dr["course"]
                };
                dishes.Add(dish);
            }
            return dishes;
        }

        public List<OrderedDish> GetAllOrderedDish()
        {
            string query = "SELECT O.TableNumber as tableNumber, I.ItemName as name, OD.TimeDishOrdered as [time], D.Course from OrderDish as OD join [Order] as O on OD.OrderID=O.OrderID" +
    " join Item as I on OD.DishID=I.ItemID join Dish as D on OD.DishID=D.DishID where OD.DishStatus = 0 order by OD.TimeDishOrdered; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
