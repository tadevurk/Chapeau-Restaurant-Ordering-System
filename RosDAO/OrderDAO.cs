using RosModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RosDAL
{
    public class OrderDAO : BaseDAO
    {
        // Write order items to drink and dish table
        public void WriteOrderedItems(List<Item> itemsInOrderProcess, Order order) 
        {      
            foreach (Item item in itemsInOrderProcess)
            {
                List<SqlParameter> sqlParameters = new();
                SqlParameter noteParameter;
                string query = "";             

                if (item.ItemNote == null)
                {
                    noteParameter = new SqlParameter("@Note", DBNull.Value);
                }
                else
                {
                    noteParameter = new SqlParameter("@Note", item.ItemNote);
                }


                if (item is Dish)
                {
                    query = "insert into OrderDish values(@OrderID, @dishID, 0, @CurrentTime, null, @Amount, @Note);";
                    sqlParameters.Add(new SqlParameter("@dishID", item.ItemID));
                }
                if (item is Drink)
                {
                    query = "insert into OrderDrink values(@OrderID, @drinkID, 0, @CurrentTime, null, @Amount, @Note);";
                    sqlParameters.Add(new SqlParameter("@drinkID", item.ItemID));
                }

                sqlParameters.Add(noteParameter);
                sqlParameters.Add(new SqlParameter("@CurrentTime", DateTime.Now));
                sqlParameters.Add(new SqlParameter("@Amount", item.ItemAmount));
                sqlParameters.Add(new SqlParameter("@OrderID", order.OrderID));
                ExecuteEditQuery(query, sqlParameters.ToArray());
            }
        }


        public List<Item> ReadRunningOrderItems(Table table)
        {
            List<Item> items;
            string queryDishes = "select I.ItemID as ItemID, I.ItemName as [Name], I.ItemPrice as [Price], SUM(OD.OrderedDishAmount) as [Amount]," +
                " O.TableNumber as [TableNumber], Count(OD.DishNote) as [NoteAmount] " +
                "from OrderDish as OD" +
                " join [Order] as O on OD.OrderID=O.OrderID" +
                " join Item as I on I.ItemID=OD.DishID" +
                " where O.TableNumber=@TableNumber and OD.DishStatus<3" +
                "group by ItemID, I.ItemName, I.ItemPrice, O.TableNumber";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@TableNumber", table.TableNumber),
            };

            items = ReadTablesOrder(ExecuteSelectQuery(queryDishes, sqlParameters));

            string queryDrinks = "select I.ItemID as ItemID, I.ItemName as [Name], I.ItemPrice as [Price], SUM(OD.OrderedDrinkAmount) as [Amount]," +
                " O.TableNumber as [TableNumber], Count(Od.DrinkNote) as [NoteAmount]" +
                " from OrderDrink as OD join [Order] as O on OD.OrderID=O.OrderID" +
                " join Item as I on I.ItemID=OD.DrinkID" +
                " where O.TableNumber=@TableNumber and OD.DrinkStatus<3 " +
                "group by ItemID, I.ItemName, I.ItemPrice, O.TableNumber";
            SqlParameter sqlParameter = new SqlParameter("@TableNumber", table.TableNumber);

            items.AddRange(ReadTablesOrder(ExecuteSelectQuery(queryDrinks, sqlParameter)));

            return items;

        }

        private List<Item> ReadTablesOrder(DataTable table)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in table.Rows)
            {
                Item item = new Dish()
                {
                    ItemID = (int)dr["ItemID"],
                    ItemName = (string)dr["Name"],
                    ItemPrice = (decimal)dr["Price"],
                    ItemAmount = (int)dr["Amount"],
                    NoteAmount = (int)dr["NoteAmount"],
                    IsOrdered = true
                };
                items.Add(item);
            }
            return items;
        }
        public List<Dish> GetDishes(MenuType menuType)
        {
            string query = " Select DishID, ItemName, ItemPrice, ItemStock, Course " +
                "from Dish join Item on DishID = ItemID " +
                "join Menu on Item.MenuTypeID = Menu.MenuTypeID " +
                "where Item.MenuTypeID = @MenuType OR Item.MenuTypeID = 3";
            SqlParameter sqlParameter = new SqlParameter("@MenuType", menuType);
            return ReadDishes(ExecuteSelectQuery(query, sqlParameter));
        }

        public List<Drink> GetAllDrinks()
        {
            string query = "Select DrinkID, ItemName, ItemPrice, ItemStock, DrinkCategory " +
                "from Drink " +
                "join Item on DrinkID = ItemID ";
            return ReadDrinks(ExecuteSelectQuery(query));
        }

        private List<Dish> ReadDishes(DataTable dataTable) // Reading the dishesInOrderProcess
        {
            List<Dish> dishes = new List<Dish>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Dish starter = new Dish()
                {
                    ItemID = (int)dr["DishID"],
                    ItemName = (string)dr["ItemName"],
                    ItemPrice = (decimal)dr["ItemPrice"],
                    ItemStock = (int)dr["ItemStock"],
                    Course = (string)dr["Course"]
                };
                dishes.Add(starter);
            }
            return dishes;
        }

        private List<Drink> ReadDrinks(DataTable dataTable) // Reading the drinks
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    ItemID = (int)dr["DrinkID"],
                    ItemName = (string)dr["ItemName"],
                    ItemPrice = (decimal)dr["ItemPrice"],
                    ItemStock = (int)dr["ItemStock"],
                    DrinkCategory = (string)dr["DrinkCategory"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }

        public int OpenOrder(Employee employee, Table table) // Mirko contributed 
        {
            string query = "insert into [Order] values(@WaiterID, null, @TableNumber, null, null);" +
                "select cast(scope_identity() as int)";
            SqlParameter[] sqlParameters = {
            new SqlParameter("@WaiterID", employee.EmplID),
            new SqlParameter("@TableNumber", table.TableNumber)
            };
            return ExecuteScalarQuery(query, sqlParameters);
        }

        // When order is sent all items will be decreased in stock
        public void DecreaseStock(Item item)
        {
            string query = "Update Item " +
            "SET ItemStock = ItemStock - @amount " +
            "where ItemName = @ItemName; ";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ItemName", item.ItemName),
                new SqlParameter("@amount", item.ItemAmount)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
