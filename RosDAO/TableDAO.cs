using RosModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace RosDAL
{
    public class TableDAO : BaseDAO
    {
        private SqlConnection conn;
        public TableDAO()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
        }
        public Table GetTableById(int tableNumber)
        {
            string query = $"SELECT TableNumber, TableStatus FROM [Table] WHERE TableNumber = {tableNumber} ORDER BY [TableNumber]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Table> GetAllTables()
        {
            string query = "SELECT TableNumber, TableStatus FROM [Table] ORDER BY [TableNumber]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));    
        }

        public List<OrderedDrink> GetOrderedDrinks(int tableNumber)
        {
            string query = "SELECT O.TableNumber as tableNumber, OD.TimeDrinkOrdered as [Time], OD.DrinkStatus as [Status], OD.DrinkID as ID, OD.OrderID as [OrderID], I.ItemName as name, OD.DrinkNote as [Note], " +
                "SUM(OD.OrderedDrinkAmount) as [Amount] from OrderDrink as OD " +
                "join [Order] as O on OD.OrderID = O.OrderID " +
                $"join Item as I on OD.DrinkID = I.ItemID join Drink as D on OD.DrinkID = D.DrinkID where OD.DrinkStatus = 1 and O.TableNumber = { tableNumber} " +
                "group by O.TableNumber, OD.DrinkStatus, OD.DrinkID, I.ItemName, OD.DrinkNote, OD.OrderID, OD.TimeDrinkOrdered " +
                "order by OD.TimeDrinkOrdered; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderedDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderedDish> GetOrderedDishes(int tableNumber)
        {
            string query = "SELECT O.TableNumber as tableNumber, OD.DishStatus as [Status], OD.DishID as ID, OD.OrderID as [OrderID], " +
                 "I.ItemName as name,OD.TimeDishOrdered as [Time], OD.DishNote as [Note], SUM(OD.OrderedDishAmount) as [Amount], D.Course " +
                 "from OrderDish as OD join[Order] as O on OD.OrderID = O.OrderID " +
                 "join Item as I on OD.DishID = I.ItemID join Dish as D on OD.DishID = D.DishID " +
                $"where OD.DishStatus = 1 and cast(OD.TimeDishOrdered as Date) = cast(getdate() as Date) and O.TableNumber = {tableNumber} " +
                "group by O.TableNumber, OD.DishStatus, OD.DishID, I.ItemName, OD.DishNote, D.Course, OD.OrderID, OD.TimeDishOrdered; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderedDishes(ExecuteSelectQuery(query, sqlParameters));
        }

        public void Update(Table table)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("UPDATE [Table] SET TableStatus = @TableStatus WHERE TableNumber = @ID", conn);
                command.Parameters.AddWithValue("@ID", table.TableNumber);
                command.Parameters.AddWithValue("@TableStatus", table.TableStatus);

                int nrOfRowAffected = command.ExecuteNonQuery();
                if (nrOfRowAffected == 0)
                    throw new Exception("Update was succesful");
            }
            catch (Exception e)
            {
                throw new Exception("Update failed! " + e.Message);
            }

            conn.Close();
        }

        public void UpdateTableWaiter(Table table)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("UPDATE [Table] SET TableStatus = @TableStatus, WaiterID = @WaiterID WHERE TableNumber = @TableNumber", conn);
                command.Parameters.AddWithValue("@TableNumber", table.TableNumber);
                command.Parameters.AddWithValue("@TableStatus", table.TableStatus);
                command.Parameters.AddWithValue("@WaiterID", table.WaiterID);

                int nrOfRowAffected = command.ExecuteNonQuery();
                if (nrOfRowAffected == 0)
                    throw new Exception("Update was succesful");
            }
            catch (Exception e)
            {
                throw new Exception("Update failed! " + e.Message);
            }

            conn.Close();
        }


        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table();
                {
                    table.TableNumber = (int)dr["TableNumber"];
                    table.TableStatus = (int)dr["TableStatus"];
                };
                tables.Add(table);
            }
            return tables;
        }

        public List<OrderedDrink> ReadOrderedDrinks(DataTable dataTable)
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

        private List<OrderedDish> ReadOrderedDishes(DataTable dataTable)
        {
            List<OrderedDish> orderedDishes = new List<OrderedDish>();

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
                orderedDishes.Add(dish);
            }
            return orderedDishes;
        }

        private Table ReadTable(DataTable dataTable)
        {
            Table table = new Table();
            foreach (DataRow dr in dataTable.Rows)
            {                  
                table.TableNumber = (int)dr["TableNumber"];
                table.TableStatus = (int)dr["TableStatus"];
            }
            return table;
        }
    }
}
