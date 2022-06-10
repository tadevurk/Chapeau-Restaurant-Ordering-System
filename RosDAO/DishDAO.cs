using RosModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosDAL
{
    /////////////////////////// Vedat Turk 683343 IT1D ////////////////////////////////////////////
    /////////// Contributor Mirko Cuccurullo ///////
    public class DishDAO : BaseDAO
    {
        public void AddDishes(List<Dish> dishes, Order order) // Add dishes to OrderedDish
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

                //Adding dish
                string query = "insert into OrderDish values(@OrderID, @dishID, 0, @CurrentTime, null, @Amount, @Note);";
                SqlParameter[] sqlParameters = { new SqlParameter("@dishID", dish.ItemID),
                new SqlParameter("@OrderID", order.OrderID),
                noteParameter,
                new SqlParameter("@CurrentTime", DateTime.Now),
                new SqlParameter("@Amount", dish.ItemAmount)};

                ExecuteEditQuery(query, sqlParameters);
            }
        }

        public List<Dish> WriteContainedDishes(Table t)
        {
            string query = "select OD.DishID as DishID, I.ItemName as [Name], I.ItemPrice as [Price], SUM(OD.OrderedDishAmount) as [Amount], O.TableNumber as [TableNumber] from OrderDish as OD" +
                " join [Order] as O on OD.OrderID=O.OrderID" +
                " join Item as I on I.ItemID=OD.DishID" +
                " where O.TableNumber=@TableNumber and OD.DishStatus<3" +
                "group by DishID, I.ItemName, I.ItemPrice, O.TableNumber";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@TableNumber", t.TableNumber),
            };

            return ReadTablesOrder(ExecuteSelectQuery(query, sqlParameters));
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
                };
                dishes.Add(dish);
            }
            return dishes;
        }
        public List<Dish> GetLunchStarters() // Getting all starters
        {
            string query = "Select DishID, ItemName, ItemPrice, ItemStock " +
                "from Dish " +
                "join Item on DishID = ItemID " +
                "join Menu on Item.MenuTypeID = Menu.MenuTypeID " +
                "where Dish.Course = 'Starter' AND Item.MenuTypeID = 1 OR Item.MenuTypeID=3";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDishes(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Dish> GetLunchMains() //Getting all Mains
        {
            string query = "Select DishID, ItemName, ItemPrice, ItemStock " +
                "from Dish " +
                "join Item on DishID = ItemID " +
                "where Dish.Course = 'Main' AND Item.MenuTypeID = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDishes(ExecuteSelectQuery(query, sqlParameters));
        }


        public List<Dish> GetLunchDesserts() //Getting all Desserts
        {
            string query = "Select DishID, ItemName, ItemPrice, ItemStock " +
                "from Dish " +
                "join Item on DishID = ItemID " +
                "where Dish.Course = 'Dessert' AND Item.MenuTypeID = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDishes(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Dish> GetDinnerStarters() // Dinner Starter contains menu type 3 as well.
        {
            string query = "Select DishID, ItemName, ItemPrice, ItemStock " +
                "from Dish " +
                "join Item on DishID = ItemID " +
                "join Menu on Item.MenuTypeID = Menu.MenuTypeID " +
                "where Dish.Course = 'Starter' AND Item.MenuTypeID = 2 OR Item.MenuTypeID=3";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDishes(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Dish> GetDinnerMains()
        {
            string query = "Select DishID, ItemName, ItemPrice, ItemStock " +
                "from Dish " +
                "join Item on DishID = ItemID " +
                "where Dish.Course = 'Main' AND Item.MenuTypeID = 2";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDishes(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Dish> GetDinnerDesserts() //Getting all Desserts
        {
            string query = "Select DishID, ItemName, ItemPrice, ItemStock " +
                "from Dish " +
                "join Item on DishID = ItemID " +
                "where Dish.Course = 'Dessert' AND Item.MenuTypeID = 2";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDishes(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DecreaseDishStock(Dish dish) // Decrease the dish from stock (Add buttons)
        {
            string query = "Update Item " +
                "SET ItemStock = ItemStock - 1 " +
                "where ItemID = @ItemID; ";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ItemID", dish.ItemID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }


        public void IncreaseDishStock(Dish dish) // Increase the dish from stock (Remove button)
        {
            string query = "Update Item " +
                "SET ItemStock = ItemStock + 1  " +
                "where ItemID = @ItemID; ";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ItemID", dish.ItemID)
            };

            ExecuteEditQuery(query, sqlParameters);
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
                    ItemStock = (int)dr["ItemStock"]
                };
                dishes.Add(starter);
            }
            return dishes;
        }
    }
}
