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
        OrderDAO orderDAO = new OrderDAO();

        public void UpdateDishNote(OrderedDish dish, string message)
        {
            string query = "UPDATE OrderDish SET DishNote=@message  WHERE DishID=@DishID AND OrderID=@OrderID";

            SqlParameter[] sp =
            {
                new SqlParameter("@DishID", dish.DishID),
                new SqlParameter("@message", message),
                new SqlParameter("@OrderID", dish.OrderID)
            };
            ExecuteEditQuery(query, sp);
        }

        public OrderedDish GetOrderedDishByKey(Order ord, Dish dish)
        {
            string query = "select * from OrderDish where OrderID=@OrderID AND DishID=@DishID ";
            SqlParameter[] sp =
            {
                new SqlParameter("@OrderID", dish.Order),
                new SqlParameter("@DishID", dish.DishID)
            };

            return ReatSingleTable(ExecuteSelectQuery(query, sp));
        }
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
                new SqlParameter("@DishStatus", orderedDish.Status),
                new SqlParameter("@TimeDishOrdered", orderedDish.TimeDishOrdered),
                new SqlParameter("@TimeDishDelivered", orderedDish.TimeDishDelivered),
                new SqlParameter("@OrderedDishAmount", orderedDish.OrderedDishAmount),
                new SqlParameter("@DishNote", orderedDish.DishNote)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void BringStatusBack(OrderedDish d)
        {
            string query = "UPDATE OrderDish SET DishStatus=DishStatus-1 WHERE DishID=@DishID AND OrderID=@OrderID AND DishStatus=1";
            SqlParameter[] sqlParameters = { new SqlParameter("@DishID", d.DishID),
            new SqlParameter("@OrderID", d.OrderID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    

        public void UpdateDishToStart(OrderedDish d)
        {
            string query = "UPDATE OrderDish SET DishStatus=0 WHERE DishID=@DishID AND OrderID=@OrderID AND DishStatus=1";
            SqlParameter[] sqlParameters = { new SqlParameter("@DishID", d.DishID),
            new SqlParameter("@OrderID", d.OrderID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public List<OrderedDish> GetAllFinishedDish()
        {
            string query = "SELECT O.TableNumber as tableNumber, OD.DishStatus as [Status], OD.DishID as ID, OD.OrderID as [OrderID], I.ItemName as name,OD.TimeDishOrdered as [Time], OD.DishNote as [Note], SUM(OD.OrderedDishAmount) as [Amount], D.Course" +
    " from OrderDish as OD join [Order] as O on OD.OrderID=O.OrderID" +
    " join Item as I on OD.DishID=I.ItemID join Dish as D on OD.DishID=D.DishID " +
    "where OD.DishStatus>=2 group by O.TableNumber, OD.DishStatus, OD.DishID, I.ItemName, OD.DishNote, D.Course, OD.OrderID, OD.TimeDishOrdered";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddDishes(List<Dish> dishes, Order order)
        {
            foreach (Dish dish in dishes)
            {
                if (dish.Note == null)
                {
                    dish.Note = "null";
                }

                //Adding dish
                string query = "insert into OrderDish values(@OrderID, @dishID, 0, getdate(), null, @Amount, @Note);";
                SqlParameter[] sp = { new SqlParameter("@dishID", dish.DishID),
                new SqlParameter("@OrderID", order.OrderID),
                new SqlParameter("@Note", dish.Note),
                new SqlParameter("@Amount", dish.Amount)};

                ExecuteEditQuery(query, sp);
            }
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
        private OrderedDish ReatSingleTable(DataTable dataTable)
        {
            List<OrderedDish> dishes = new List<OrderedDish>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderedDish dish = new OrderedDish()
                {
                    TableNumber = (int)dr["tableNumber"],
                    OrderID = (int)dr["order"],
                    DishID = (int)dr["ID"],
                    Name = (string)dr["name"],
                    TimeDishOrdered = (DateTime)dr["time"],
                    Course = (string)dr["course"]
                };
                dishes.Add(dish);
            }
            return dishes[0];
        }

        public void IncreaseAmount(Dish dish, Order order)
        {
            string query = "update OrderDish set OrderedDishAmount=@Amount, DishStatus = 0 where DishID=@DishID and OrderID=@OrderID";
            SqlParameter[] sp = {
                new SqlParameter("@Amount",dish.Amount),
                new SqlParameter("@DishID", dish.DishID),
                new SqlParameter("@OrderID", order.OrderID),
            };

            ExecuteEditQuery(query, sp);
        }
        private List<OrderedDish> ReadTables(DataTable dataTable)
        {
            List<OrderedDish> dishes = new List<OrderedDish>();

            foreach (DataRow dr in dataTable.Rows)
            {
                string note = "";
                if (dr["Note"].Equals(DBNull.Value))
                {
                    note = "null";
                }
                else
                {
                    note = (string)dr["Note"];
                }



                OrderedDish dish = new OrderedDish()
                {
                    TableNumber = (int)dr["tableNumber"],
                    Status = (DishStatus)dr["Status"],
                    DishID = (int)dr["ID"],
                    OrderID = (int)dr["OrderID"],
                    DishNote = note,
                    OrderedDishAmount = (int)dr["Amount"],
                    Name = (string)dr["name"],
                    TimeDishOrdered = (DateTime)dr["Time"],
                    Course = (string)dr["Course"]

                };
                dishes.Add(dish);
            }
            return dishes;
        }

        public void UpdateDeliveredTime(Dish d)
        {
            string query = "update OrderDish set TimeDishDelivered=Getdate() where DrinkID=@DishID and OrderID=@OrderID";
            SqlParameter[] sp = {
                new SqlParameter("@DishID", d.DishID),
                new SqlParameter("@OrderID", d.Order)
            };
        }

        public List<OrderedDish> GetAllOrderedDish()
        {
            string query = "SELECT O.TableNumber as tableNumber, OD.DishStatus as [Status], OD.DishID as ID, OD.OrderID as [OrderID], I.ItemName as name,OD.TimeDishOrdered as [Time], OD.DishNote as [Note], SUM(OD.OrderedDishAmount) as [Amount], D.Course" +
                " from OrderDish as OD join [Order] as O on OD.OrderID=O.OrderID" +
                " join Item as I on OD.DishID=I.ItemID join Dish as D on OD.DishID=D.DishID " +
                "where OD.DishStatus<2 group by O.TableNumber, OD.DishStatus, OD.DishID, I.ItemName, OD.DishNote, D.Course, OD.OrderID, OD.TimeDishOrdered";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateDishStatusPickUp(OrderedDish orderedDish)
        {
            string query = "UPDATE OrderDish SET DishStatus=1 WHERE DishID=@DishID AND OrderID=@OrderID AND DishStatus=0";
            SqlParameter[] sqlParameters = { new SqlParameter("@DishID", orderedDish.DishID),
            new SqlParameter("@OrderID", orderedDish.OrderID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateDishStatusServe(OrderedDish d)
        {
            string query = "UPDATE OrderDish SET DishStatus=2, TimeDishDelivered=GetTime() WHERE DishID=@DishID AND OrderID=@OrderID AND DishStatus=1";
            SqlParameter[] sqlParameters = { new SqlParameter("@DishID", d.DishID),
            new SqlParameter("@OrderID", d.OrderID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }


    }
}
