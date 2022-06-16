using RosModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RosDAL
{
    /////////////////////////// Vedat Turk 683343 IT1D ////////////////////////////////////////////
    //////// Contributor Mirko Cuccurullo ///////
    public class DrinkDAO : BaseDAO
    {
        public void AddDrinks(List<Drink> drinkInOrderProcess, Order order)// Add drinks to OrderedDrink
        {
            foreach (Drink drink in drinkInOrderProcess)
            {
                SqlParameter noteParameter;

                if (drink.ItemNote == null)
                {
                    noteParameter = new SqlParameter("@Note", DBNull.Value);
                }
                else
                {
                    noteParameter = new SqlParameter("@Note", drink.ItemNote);
                }

                //Adding dish
                string query = "insert into OrderDrink values(@OrderID, @drinkID, 0, @CurrentTime, null, @Amount, @Note);";
                SqlParameter[] sqlParameters = { new SqlParameter("@drinkID", drink.ItemID),
                new SqlParameter("@OrderID", order.OrderID),
                noteParameter,
                new SqlParameter("@CurrentTime", DateTime.Now),
                new SqlParameter("@Amount", drink.ItemAmount)};

                ExecuteEditQuery(query, sqlParameters);
            }
        }

        public List<Drink> ReadContainedDrinks(Table table)
        {
            string query = "select OD.DrinkID as DrinkID, I.ItemName as [Name], I.ItemPrice as [Price], SUM(OD.OrderedDrinkAmount) as [Amount]," +
                " O.TableNumber as [TableNumber] from OrderDrink as OD join [Order] as O on OD.OrderID=O.OrderID" +
                " join Item as I on I.ItemID=OD.DrinkID" +
                " where O.TableNumber=@TableNumber and OD.DrinkStatus<3 " +
                "group by DrinkID, I.ItemName, I.ItemPrice, O.TableNumber";
            SqlParameter sqlParameter = new SqlParameter("@TableNumber", table.TableNumber);
            return ReadTablesOrder(ExecuteSelectQuery(query, sqlParameter));
        }

        private List<Drink> ReadTablesOrder(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {

                Drink drink = new Drink()
                {
                    ItemID = (int)dr["DrinkID"],
                    ItemName = (string)dr["Name"],
                    ItemPrice = (decimal)dr["Price"],
                    ItemAmount = (int)dr["Amount"],
                };
                drinks.Add(drink);
            }
            return drinks;
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
                    ItemStock = (int)dr["ItemStock"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }

        public List<Drink> GetAllDrinks()
        {
            string query = "Select DrinkID, ItemName, ItemPrice, ItemStock " +
                "from Drink " +
                "join Item on DrinkID = ItemID ";
            return ReadDrinks(SelectQueryNonParameter(query));
        }
    }
}
