﻿using RosModel;
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

        public List<Drink> WriteContainedDrinks(Table table)
        {
            string query = "select OD.DrinkID as DrinkID, I.ItemName as [Name], I.ItemPrice as [Price], SUM(OD.OrderedDrinkAmount) as [Amount]," +
                " O.TableNumber as [TableNumber] from OrderDrink as OD join [Order] as O on OD.OrderID=O.OrderID" +
                " join Item as I on I.ItemID=OD.DrinkID" +
                " where O.TableNumber=@TableNumber and OD.DrinkStatus<3 " +
                "group by DrinkID, I.ItemName, I.ItemPrice, O.TableNumber";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@TableNumber", table.TableNumber),
            };

            return ReadTablesOrder(ExecuteSelectQuery(query, sqlParameters));
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
        // Getting all soft drinks
        public List<Drink> GetAllSoftDrinks()
        {
            string query = "Select DrinkID, ItemName, ItemPrice, ItemStock " +
                "from Drink " +
                "join Item on DrinkID = ItemID " +
                "where DrinkCategory = 'SoftDrink' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Drink> GetAllBeers()
        {
            string query = "Select DrinkID, ItemName, ItemPrice, ItemStock " +
                "from Drink " +
                "join Item on DrinkID = ItemID " +
                "where DrinkCategory = 'Beer';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        }
        // Getting all wines
        public List<Drink> GetAllWines()
        {
            string query = "Select DrinkID, ItemName, ItemPrice, ItemStock " +
                "from Drink " +
                "join Item on DrinkID = ItemID " +
                "where DrinkCategory = 'Wine';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        // Getting all spirits
        public List<Drink> GetAllSpirits()
        {
            string query = "Select DrinkID, ItemName, ItemPrice, ItemStock " +
                "from Drink " +
                "join Item on DrinkID = ItemID " +
                "where DrinkCategory = 'Spirit';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        // Getting all hot-drinks
        public List<Drink> GetAllHotDrinks()
        {
            string query = "Select DrinkID, ItemName, ItemPrice, ItemStock " +
                "from Drink " +
                "join Item on DrinkID = ItemID " +
                "where DrinkCategory = 'HotDrink';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        //Getting all Drinks
        public List<Drink> GetAllDrinks()
        {
            string query = "Select DrinkID, ItemName, ItemPrice, ItemStock " +
                "from Drink " +
                "join Item on DrinkID = ItemID ";
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
                new SqlParameter("@ItemID", drink.ItemID)
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
                new SqlParameter("@ItemID", drink.ItemID)
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
                    ItemID = (int)dr["DrinkID"],
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
