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
    public class DrinkDAO : BaseDAO
    {
        // Getting all soft drinks
        public List<Drink> GetAllSoftDrinks()
        {
            string query = "Select DrinkID, ItemName, ItemPrice, ItemStock " +
                "from Drink " +
                "join Item on DrinkID = ItemID " +
                "where Dish.Course = 'SoftDrink';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        // Getting all beers
        public List<Drink> GetAllBeers()
        {
            string query = "Select DrinkID, ItemName, ItemPrice, ItemStock " +
                "from Drink " +
                "join Item on DrinkID = ItemID " +
                "where Dish.Course = 'Beers';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        // Getting all wines
        public List<Drink> GetAllWines()
        {
            string query = "Select DrinkID, ItemName, ItemPrice, ItemStock " +
                "from Drink " +
                "join Item on DrinkID = ItemID " +
                "where Dish.Course = 'Wine';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        // Getting all spirits
        public List<Drink> GetAllSpirits()
        {
            string query = "Select DrinkID, ItemName, ItemPrice, ItemStock " +
                "from Drink " +
                "join Item on DrinkID = ItemID " +
                "where Dish.Course = 'Spirits';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        // Getting all hot-drinks
        public List<Drink> GetAllHotDrinks()
        {
            string query = "Select DrinkID, ItemName, ItemPrice, ItemStock " +
                "from Drink " +
                "join Item on DrinkID = ItemID " +
                "where Dish.Course = 'HotDrinks';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        // Increase the drink from stock
        public void IncreaseDrinkStock(Drink drink)
        {
            string query = "Update Item " +
                "SET ItemStock = ItemStock + 1  " +
                "where ItemID = @ItemID; ";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ItemID", drink.DrinkID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        // Decrease the drink from stock
        public void DecreaseDrinkStock(Drink drink)
        {
            string query = "Update Item " +
                "SET ItemStock = ItemStock - 1  " +
                "where ItemID = @ItemID; ";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ItemID", drink.DrinkID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Drink> ReadDrinks(DataTable dataTable) // Reading the drinks
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    DrinkID = (int)dr["DrinkID"],
                    ItemName = (string)dr["ItemName"],
                    ItemPrice = (decimal)dr["ItemPrice"],
                    ItemStock = (int)dr["ItemStock"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
