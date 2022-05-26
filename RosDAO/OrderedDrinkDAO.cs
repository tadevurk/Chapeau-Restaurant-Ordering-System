using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosModel;

////////////////////Mirko Cuccurullo, 691362, GROUP 1, IT1D/////////////////////////////////////////////////////////////////////////////////////////////

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

        public List<OrderedDrink> GetAllFinishedDrinks()
        {
            string query = "SELECT O.TableNumber as tableNumber, OD.TimeDrinkOrdered as [Time], OD.DrinkStatus as [Status], OD.DrinkID as ID, OD.OrderID as [OrderID], I.ItemName as name, OD.DrinkNote as [Note]," +
    " SUM(OD.OrderedDrinkAmount) as [Amount] from OrderDrink as OD join [Order] as O on OD.OrderID=O.OrderID " +
    "join Item as I on OD.DrinkID=I.ItemID join Drink as D on OD.DrinkID=D.DrinkID where OD.DrinkStatus>=2 group by O.TableNumber," +
    " OD.DrinkStatus, OD.DrinkID, I.ItemName, OD.DrinkNote, OD.OrderID, OD.TimeDrinkOrdered";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddDrinks(List<Drink> drinkInOrderProcess, Order order)
        {
            foreach (Drink drink in drinkInOrderProcess)
            {
                if (drink.Note == null)
                {
                    drink.Note = "null";
                }

                //Adding dish
                string query = "insert into OrderDrink values(@OrderID, @drinkID, 0, getdate(), null, @Amount, @Note);";
                SqlParameter[] sp = { new SqlParameter("@drinkID", drink.DrinkID),
                new SqlParameter("@OrderID", order.OrderID),
                new SqlParameter("@Note", drink.Note),
                new SqlParameter("@Amount", drink.Amount)};

                ExecuteEditQuery(query, sp);
            }
        }

        public void BringStatusBack(OrderedDrink orderedDrink)
        {
            string query = "UPDATE OrderDrink SET DrinkStatus=DrinkStatus-1 WHERE DrinkID=@DrinkID AND OrderID=@OrderID";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinkID", orderedDrink.DrinkID),
            new SqlParameter("@OrderID", orderedDrink.OrderID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateDrinkToStart(OrderedDrink d)
        {
            string query = "UPDATE OrderDrink SET DrinkStatus=0 WHERE DrinkID=@DrinkID AND OrderID=@OrderID";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinkID", d.DrinkID),
            new SqlParameter("@OrderID", d.OrderID)
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
            string query = "SELECT O.TableNumber as tableNumber, OD.TimeDrinkOrdered as [Time], OD.DrinkStatus as [Status], OD.DrinkID as ID, OD.OrderID as [OrderID], I.ItemName as name, OD.DrinkNote as [Note]," +
                " SUM(OD.OrderedDrinkAmount) as [Amount] from OrderDrink as OD join [Order] as O on OD.OrderID=O.OrderID " +
                "join Item as I on OD.DrinkID=I.ItemID join Drink as D on OD.DrinkID=D.DrinkID where OD.DrinkStatus<2 group by O.TableNumber," +
                " OD.DrinkStatus, OD.DrinkID, I.ItemName, OD.DrinkNote, OD.OrderID, OD.TimeDrinkOrdered";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderedDrink> ReadTables(DataTable dataTable)
        {

            List<OrderedDrink> drinks = new List<OrderedDrink>();

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

                OrderedDrink drink = new OrderedDrink()
                {
                    TableNumber = (int)dr["tableNumber"],
                    DrinkStatus = (DrinkStatus)dr["Status"],
                    OrderID = (int)dr["OrderID"],
                    DrinkID = (int)dr["ID"],
                    DrinkNote = note,
                    OrderedDrinkAmount = (int)dr["Amount"],
                    Name = (string)dr["name"],
                    TimeDrinkOrdered = (DateTime)dr["Time"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }

        public void UpdateDrinkStatusPickUp(OrderedDrink orderedDrink)
        {
            string query = "UPDATE OrderDrink SET DrinkStatus=1 WHERE DrinkID=@DrinkID AND OrderID=@OrderID";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinkID", orderedDrink.DrinkID),
            new SqlParameter("@OrderID", orderedDrink.OrderID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }



        public void UpdateDrinkStatusServe(OrderedDrink d)
        {
            string query = "UPDATE OrderDrink SET DrinkStatus=2, TimeDrinkDelivered=GetDate() WHERE DrinkID=@DrinkID AND OrderID=@OrderID";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinkID", d.DrinkID),
            new SqlParameter("@OrderID", d.OrderID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
        public void IncreaseAmount(Drink d, Order o)
        {
            string query = "update OrderDrink set OrderedDrinkAmount=@Amount where DrinkID=@DrinkID and OrderID=@OrderID";
            SqlParameter[] sp = {
                new SqlParameter("@Amount",d.Amount),
                new SqlParameter("@DrinkID", d.DrinkID),
                new SqlParameter("@OrderID", d.Order)
            };

            ExecuteEditQuery(query, sp);
        }

        public void UpdateDeliveredTime(Drink d)
        {
            string query = "update OrderDrink set TimeDrinkDelivered=Getdate() where DrinkID=@DrinkID and OrderID=@OrderID";
            SqlParameter[] sp = {
                new SqlParameter("@DrinkID", d.DrinkID),
                new SqlParameter("@OrderID", d.Order)
            };
        }
        public void AddDrink(List<Drink> drink, Order order)
        {
            foreach (Drink d in drink)
            {
                if (d.Note == null)
                {
                    d.Note = "null";
                }


                //Adding dish
                string query = "insert into OrderDish values(@OrderID, @dishID, 0, getdate(), null, @Amount, @Note);";
                SqlParameter[] sp = { new SqlParameter("@dishID", d.DrinkID),
                new SqlParameter("@OrderID", order.OrderID),
                new SqlParameter("@Note", d.Note),
                new SqlParameter("@Amount", d.Amount)};

                ExecuteEditQuery(query, sp);
            }
        }
    }
}
