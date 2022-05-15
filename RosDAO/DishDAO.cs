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
    public class DishDAO : BaseDAO
    {
        //Getting all Starters
        public List<Dish> GetAllStarters() 
        {
            string query = "Select DishID, ItemName, ItemPrice, ItemStock " +
                "from Dish " +
                "join Item on DishID = ItemID " +
                "where Dish.Course = 'Starter';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDishes(ExecuteSelectQuery(query, sqlParameters));
        }
        
        //Getting all Mains
        public List<Dish> GetAllMains()
        {
            string query = "Select DishID, ItemName, ItemPrice, ItemStock " +
                "from Dish " +
                "join Item on DishID = ItemID " +
                "where Dish.Course = 'Main';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDishes(ExecuteSelectQuery(query, sqlParameters));
        }

        //Getting all Desserts
        public List<Dish> GetAllDesserts()
        {
            string query = "Select DishID, ItemName, ItemPrice, ItemStock " +
                "from Dish " +
                "join Item on DishID = ItemID " +
                "where Dish.Course = 'Dessert';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDishes(ExecuteSelectQuery(query, sqlParameters));
        }

        //Getting all Entremets
        public List<Dish> GetAllEntremets()
        {
            string query = "Select DishID, ItemName, ItemPrice, ItemStock " +
                "from Dish " +
                "join Item on DishID = ItemID " +
                "where Dish.Course = 'Entremes';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDishes(ExecuteSelectQuery(query, sqlParameters));
        }

        // Decrease the dish from stock
        public void DecreaseDishStock(Dish dish)
        {
            string query = "Update Item " +
                "SET ItemStock = ItemStock - 1 " +
                "where ItemID = @ItemID; ";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ItemID", dish.DishID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        // Increase the dish from stock
        public void IncreaseDishStock(Dish dish)
        {
            string query = "Update Item " +
                "SET ItemStock = ItemStock + 1  " +
                "where ItemID = @ItemID; ";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ItemID", dish.DishID)
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
                    DishID = (int)dr["DishID"],
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
