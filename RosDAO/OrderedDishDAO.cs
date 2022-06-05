using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RosModel;

////////////////////Mirko Cuccurullo, 691362, GROUP 1, IT1D/////////////////////////////////////////////////////////////////////////////////////////////

namespace RosDAL
{
    public class OrderedDishDAO : BaseDAO
    {
        OrderDAO orderDAO = new OrderDAO();


        public void BringStatusBack(OrderedDish d)
        {
            string query = "UPDATE OrderDish SET DishStatus=DishStatus-1 WHERE DishID=@DishID AND OrderID=@OrderID AND DishStatus=1";
            SqlParameter[] sqlParameters = { new SqlParameter("@DishID", d.ItemID),
            new SqlParameter("@OrderID", d.OrderID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    

        public void UpdateDishToStart(OrderedDish d)
        {
            string query = "UPDATE OrderDish SET DishStatus=0 WHERE DishID=@DishID AND OrderID=@OrderID";
            SqlParameter[] sqlParameters = { new SqlParameter("@DishID", d.ItemID),
            new SqlParameter("@OrderID", d.OrderID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public List<OrderedDish> GetAllFinishedDish()
        {
            string query = "SELECT O.TableNumber as tableNumber, OD.DishStatus as [Status], OD.DishID as ID, OD.OrderID as [OrderID]," +
                " I.ItemName as name,OD.TimeDishOrdered as [Time], OD.DishNote as [Note], SUM(OD.OrderedDishAmount) as [Amount], D.Course" +
                " from OrderDish as OD join [Order] as O on OD.OrderID=O.OrderID" +
                 " join Item as I on OD.DishID=I.ItemID join Dish as D on OD.DishID=D.DishID " +
                 "where OD.DishStatus>=2 and cast(OD.TimeDishOrdered as Date) = cast(getdate() as Date)" +
                 " group by O.TableNumber, OD.DishStatus, OD.DishID, I.ItemName, OD.DishNote, D.Course, OD.OrderID, OD.TimeDishOrdered";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateOrderWithChefID(Employee employee, OrderedDish dish)
        {
            string query = "UPDATE [Order] SET ChefID=@EmplID WHERE OrderID=@OrderID;";
            SqlParameter[] sqlParameters = { new SqlParameter("@EmplID", employee.EmplID),
            new SqlParameter("@OrderID", dish.OrderID) };

            ExecuteEditQuery(query, sqlParameters);
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
                    ItemID = (int)dr["ID"],
                    OrderID = (int)dr["OrderID"],
                    ItemNote = note,
                    OrderedDishAmount = (int)dr["Amount"],
                    ItemName = (string)dr["name"],
                    TimeDishOrdered = (DateTime)dr["Time"],
                    Course = (string)dr["Course"]

                };
                dishes.Add(dish);
            }
            return dishes;
        }

        public List<OrderedDish> GetAllOrderedDish()
        {
            string query = "SELECT O.TableNumber as tableNumber, OD.DishStatus as [Status], OD.DishID as ID, OD.OrderID as [OrderID]," +
                " I.ItemName as name,OD.TimeDishOrdered as [Time], OD.DishNote as [Note], SUM(OD.OrderedDishAmount) as [Amount], D.Course" +
                " from OrderDish as OD join [Order] as O on OD.OrderID=O.OrderID" +
                " join Item as I on OD.DishID=I.ItemID join Dish as D on OD.DishID=D.DishID " +
                "where OD.DishStatus<2 " +
                "group by O.TableNumber, OD.DishStatus, OD.DishID, I.ItemName, OD.DishNote, D.Course, OD.OrderID, OD.TimeDishOrdered " +
                "order by OD.TimeDishOrdered";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateDishStatusPickUp(OrderedDish orderedDish)
        {
            string query = "UPDATE OrderDish SET DishStatus=1 WHERE DishID=@DishID AND OrderID=@OrderID AND DishStatus=0";
            SqlParameter[] sqlParameters = { new SqlParameter("@DishID", orderedDish.ItemID),
            new SqlParameter("@OrderID", orderedDish.OrderID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateDishStatusServe(OrderedDish d)
        {
            string query = "UPDATE OrderDish SET DishStatus=2, TimeDishDelivered=@GetTime WHERE DishID=@DishID AND OrderID=@OrderID";
            SqlParameter[] sqlParameters = { new SqlParameter("@DishID", d.ItemID),
            new SqlParameter("@OrderID", d.OrderID),
            new SqlParameter("@GetTime", DateTime.Now)
            };

            ExecuteEditQuery(query, sqlParameters);
        }


    }
}
