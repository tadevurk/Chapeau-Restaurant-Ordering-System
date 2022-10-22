using RosModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RosDAL
{
    /////////////////////////// Vedat Turk 683343 IT1D ////////////////////////////////////////////
    public class DishDAO : BaseDAO
    {
        public void AddOrderedDishes(List<Dish> dishes, Order order) // Add dishes to OrderedDish
        {
            foreach (Dish dish in dishes)
            {
                SqlParameter noteParameter;

                if (dish.ItemNote == null)
                {
                    noteParameter = new SqlParameter("@Note", DBNull.Value);
                }
                else
                {
                    noteParameter = new SqlParameter("@Note", dish.ItemNote);
                }
                string query = "insert into OrderDish values(@OrderID, @dishID, 0, @CurrentTime, null, @Amount, @Note);";
                SqlParameter[] sqlParameters = { new SqlParameter("@dishID", dish.ItemID),
                new SqlParameter("@OrderID", order.OrderID),
                noteParameter,
                new SqlParameter("@CurrentTime", DateTime.Now),
                new SqlParameter("@Amount", dish.ItemAmount)};

                ExecuteEditQuery(query, sqlParameters);
            }
        }

        public List<Dish> ReadContainedDishes(Table table)
        {
            string query = "select OD.DishID as DishID, I.ItemName as [Name], I.ItemPrice as [Price], SUM(OD.OrderedDishAmount) as [Amount]," +
                " O.TableNumber as [TableNumber], Count(OD.DishNote) as [NoteAmount] " +
                "from OrderDish as OD" +
                " join [Order] as O on OD.OrderID=O.OrderID" +
                " join Item as I on I.ItemID=OD.DishID" +
                " where O.TableNumber=@TableNumber and OD.DishStatus<3" +
                "group by DishID, I.ItemName, I.ItemPrice, O.TableNumber";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@TableNumber", table.TableNumber),
            };

            return ReadTablesOrder(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Dish> GetDishes(int menuType)
        {
            string query = " Select DishID, ItemName, ItemPrice, ItemStock, Course " +
                "from Dish join Item on DishID = ItemID " +
                "join Menu on Item.MenuTypeID = Menu.MenuTypeID " +
                "where Item.MenuTypeID = @MenuType OR Item.MenuTypeID = 3";
            SqlParameter sqlParameter = new SqlParameter("@MenuType", menuType);
            return ReadDishes(ExecuteSelectQuery(query, sqlParameter));
        }
        private List<Dish> ReadTablesOrder(DataTable table)
        {
            List<Dish> dishes = new List<Dish>();

            foreach (DataRow dr in table.Rows)
            {

                Dish dish = new Dish()
                {
                    ItemID = (int)dr["DishID"],
                    ItemName = (string)dr["Name"],
                    ItemPrice = (decimal)dr["Price"],
                    ItemAmount = (int)dr["Amount"],
                    NoteAmount = (int)dr["NoteAmount"]
                };
                dishes.Add(dish);
            }
            return dishes;
        }
        private List<Dish> ReadDishes(DataTable dataTable) // Reading the dishes
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
    }
}
