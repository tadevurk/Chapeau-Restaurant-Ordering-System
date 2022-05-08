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
        public Dish GetDishById(int id)
        {
            return new Dish();
        }

        public List<Dish> GetAllStarters()
        {
            string query = "Select DishID, ItemName, ItemPrice, ItemStock " +
                "from Dish " +
                "join Item on DishID = ItemID " +
                "where Dish.Course = 'Starter';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadStarters(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DecrementStarterStock(Dish starter) // Change the amount of the dish (The question is DishID or OrderID??)
        {
            string query = "Update Item " +
                "SET ItemStock = ItemStock - 1 " +
                "where ItemID = @ItemID; ";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ItemID", starter.DishID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Dish> ReadStarters(DataTable dataTable)
        {
            List<Dish> starters = new List<Dish>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Dish starter = new Dish()
                {
                    DishID = (int)dr["DishID"],
                    ItemName = (string)dr["ItemName"],
                    ItemPrice = (decimal)dr["ItemPrice"],
                    ItemStock = (int)dr["ItemStock"]
                };
                starters.Add(starter);
            }
            return starters;
        }

        public Dish GetDishByCourse(string course)
        {
            return new Dish();
        }
    }
}
