﻿using RosModel;
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
        public List<Dish> WriteContainedDishes(Table t, Order o)
        {
            string query = "select OD.DishID as DishID, I.ItemName as [Name], I.ItemPrice as [Price], OD.OrderedDishAmount as [Amount], OD.OrderID as [Order] from OrderDish as OD" +
                " join [Order] as O on OD.OrderID=O.OrderID" +
                " join Item as I on I.ItemID=OD.DishID" +
                " where O.TableNumber=@TableNumber and OD.DishStatus<3";
            SqlParameter[] sp =
            {
                new SqlParameter("@TableNumber", t.TableNumber),
                new SqlParameter("@OrderID", o.OrderID)
            };

            return ReadTablesOrder(ExecuteSelectQuery(query, sp));
        }

        private List<Dish> ReadTablesOrder(DataTable table)
        {
            List<Dish> dishes = new List<Dish>();

            foreach (DataRow dr in table.Rows)
            {

                Dish dish = new Dish()
                {
                    DishID = (int)dr["DishID"],
                    ItemName = (string)dr["Name"],
                    ItemPrice = (decimal)dr["Price"],
                    OrderedAmount = (int)dr["Amount"],
                    Order = (int)dr["Order"]

                };
                dishes.Add(dish);
            }
            return dishes;
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
