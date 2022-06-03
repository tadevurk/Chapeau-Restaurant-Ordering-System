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

        public List<OrderedDrink> GetAllFinishedDrinks()
        {
            string query = "SELECT O.TableNumber as tableNumber, OD.TimeDrinkOrdered as [Time], OD.DrinkStatus as [Status], OD.DrinkID as ID, OD.OrderID as [OrderID], I.ItemName as name, OD.DrinkNote as [Note]," +
    " SUM(OD.OrderedDrinkAmount) as [Amount] from OrderDrink as OD join [Order] as O on OD.OrderID=O.OrderID " +
    "join Item as I on OD.DrinkID=I.ItemID join Drink as D on OD.DrinkID=D.DrinkID" +
    " where OD.DrinkStatus>=2 and cast(OD.TimeDrinkOrdered as Date) = cast(getdate() as Date)" +
    " group by O.TableNumber," +
    " OD.DrinkStatus, OD.DrinkID, I.ItemName, OD.DrinkNote, OD.OrderID, OD.TimeDrinkOrdered";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void BringStatusBack(OrderedDrink orderedDrink)
        {
            string query = "UPDATE OrderDrink SET DrinkStatus=DrinkStatus-1 WHERE DrinkID=@DrinkID AND OrderID=@OrderID";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinkID", orderedDrink.ItemID),
            new SqlParameter("@OrderID", orderedDrink.OrderID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateDrinkToStart(OrderedDrink d)
        {
            string query = "UPDATE OrderDrink SET DrinkStatus=0 WHERE DrinkID=@DrinkID AND OrderID=@OrderID";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinkID", d.ItemID),
            new SqlParameter("@OrderID", d.OrderID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public List<OrderedDrink> GetAllOrderedDrinks()
        {
            string query = "SELECT O.TableNumber as tableNumber, OD.TimeDrinkOrdered as [Time], OD.DrinkStatus as [Status], OD.DrinkID as ID, OD.OrderID as [OrderID], I.ItemName as name, OD.DrinkNote as [Note]," +
                " SUM(OD.OrderedDrinkAmount) as [Amount] from OrderDrink as OD join [Order] as O on OD.OrderID=O.OrderID " +
                "join Item as I on OD.DrinkID=I.ItemID join Drink as D on OD.DrinkID=D.DrinkID where OD.DrinkStatus<2 group by O.TableNumber," +
                " OD.DrinkStatus, OD.DrinkID, I.ItemName, OD.DrinkNote, OD.OrderID, OD.TimeDrinkOrdered " +
                "order by OD.TimeDrinkOrdered";

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
                    ItemID = (int)dr["ID"],
                    ItemNote = note,
                    OrderedDrinkAmount = (int)dr["Amount"],
                    ItemName = (string)dr["name"],
                    TimeDrinkOrdered = (DateTime)dr["Time"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }

        public void UpdateDrinkStatusPickUp(OrderedDrink orderedDrink)
        {
            string query = "UPDATE OrderDrink SET DrinkStatus=1 WHERE DrinkID=@DrinkID AND OrderID=@OrderID";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinkID", orderedDrink.ItemID),
            new SqlParameter("@OrderID", orderedDrink.OrderID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }



        public void UpdateDrinkStatusServe(OrderedDrink d)
        {
            string query = "UPDATE OrderDrink SET DrinkStatus=2, TimeDrinkDelivered=@GetTime WHERE DrinkID=@DrinkID AND OrderID=@OrderID";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinkID", d.ItemID),
            new SqlParameter("@OrderID", d.OrderID),
            new SqlParameter("@GetTime", DateTime.Now)

            };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
