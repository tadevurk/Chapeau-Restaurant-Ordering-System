﻿using RosModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RosDAL
{
    public class BillDAO : BaseDAO
    {
        public List<OrderedDish> GetOrderedDishes(Table table) // Get a list of the unpaid ordered dishes for a certain table
        {
            string query = "SELECT OD.DishID, OD.OrderID, I.ItemName, I.ItemPrice, SUM(OD.OrderedDishAmount) as OrderedDishAmount, " +
                "D.Vat FROM OrderDish as OD JOIN [Order] as O on OD.OrderID = O.OrderID " +
                "JOIN Item as I on OD.DishID = I.ItemID JOIN Dish as D on OD.DishID = D.DishID " +
                "WHERE O.TableNumber = @TableNumber AND OD.DishStatus < 3 GROUP BY I.ItemName, I.ItemPrice, D.Vat, OD.DishID ,OD.OrderID; ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TableNumber", table.TableNumber);

            return ReadOrderedDishes(ExecuteSelectQuery(query, sqlParameters));
        }


        private List<OrderedDish> ReadOrderedDishes(DataTable dataTable)
        {
            List<OrderedDish> orderedDishes = new List<OrderedDish>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderedDish orderedDish = new OrderedDish()
                {
                    ItemID = (int)dr["DishID"],
                    ItemName = (string)dr["ItemName"],
                    ItemPrice = (decimal)dr["ItemPrice"],
                    ItemAmount = (int)dr["OrderedDishAmount"],
                    ItemVat = (int)dr["Vat"],
                    OrderID = (int)dr["OrderID"]
                };
                orderedDishes.Add(orderedDish);
            }
            return orderedDishes;
        }

        public List<OrderedDrink> GetOrderedDrinks(Table table) // Get a list of the unpaid ordered drinks for a certain table
        {
            string query = "SELECT OD.DrinkID, OD.OrderID, I.ItemName, I.ItemPrice, SUM(OD.OrderedDrinkAmount) as OrderedDrinkAmount, DT.Vat, DT.DrinkTypeID FROM OrderDrink as OD " +
                "JOIN [Order] as O on OD.OrderID = O.OrderID JOIN Item as I on OD.DrinkID = I.ItemID JOIN Drink as D on OD.DrinkID = D.DrinkID" +
                " JOIN DrinkType as DT on D.DrinkTypeID = DT.DrinkTypeID WHERE O.TableNumber = @TableNumber AND OD.DrinkStatus < 3 GROUP BY I.ItemName, I.ItemPrice, DT.Vat, OD.DrinkID, OD.OrderID, DT.DrinkTypeID; ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TableNumber", table.TableNumber);

            return ReadOrderedDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderedDrink> ReadOrderedDrinks(DataTable dataTable)
        {
            List<OrderedDrink> orderedDrinks = new List<OrderedDrink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderedDrink orderedDrink = new OrderedDrink()
                {
                    ItemID = (int)dr["DrinkID"],
                    ItemName = (string)dr["ItemName"],
                    ItemPrice = (decimal)dr["ItemPrice"],
                    ItemAmount = (int)dr["OrderedDrinkAmount"],
                    ItemVat = (int)dr["Vat"],
                    OrderID = (int)dr["OrderID"],
                    DrinkTypeID = (int)dr["DrinkTypeID"]
                };
                orderedDrinks.Add(orderedDrink);
            }
            return orderedDrinks;
        }

        
        public void CreateBill(Bill bill)
        {
            // insert a complete bill into the database bill table
            string query = "INSERT INTO Bill (TotalAmount, TipAmount,  Feedback, TableNumber, PaymentDate, SubTotalAmount, PaymentMethod) " +
                "VALUES (@TotalAmount, @TipAmount,  @Feedback, @TableNumber, GETDATE(), @SubTotalAmount, @PaymentMethod);" +
                "SELECT cast(scope_identity() as int)";
            if (bill.Feedback == null)
            {
                bill.Feedback = "Null";
            }
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@TotalAmount", bill.TotalAmount),
                new SqlParameter("@TipAmount", bill.TipAmount),
                new SqlParameter("@Feedback", bill.Feedback),
                new SqlParameter("@TableNumber", bill.TableNumber),
                new SqlParameter("@SubTotalAmount", bill.SubTotalAmount),
                new SqlParameter("@PaymentMethod", bill.PaymentMethod),
            };

            bill.BillNumber = ExecuteScalarQuery(query, sqlParameters);
        }

        public void SetDishPaid(OrderedDish item)
        {
            // update the ordered dish status to paid status 
            string query = "UPDATE [OrderDish] SET DishStatus = 3 WHERE OrderID = @OrderID and DishID=@DishID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@OrderID", item.OrderID),
                new SqlParameter("@DishID", item.ItemID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void SetDrinkPaid(OrderedDrink item)
        {
            // update the ordered drinks status to paid status 
            string query = "UPDATE [OrderDrink] SET DrinkStatus = 3 WHERE OrderID = @OrderID and DrinkID=@DrinkID";
            SqlParameter[] sqlParameters =
            {
                 new SqlParameter("@OrderID", item.OrderID),
                 new SqlParameter("@DrinkID", item.ItemID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateOrderBillNumber(Bill bill, OrderedDish dish)
        {
            // update BillNumber in Order table according to ordered dishes 
            string query = "UPDATE [Order] SET BillNumber = @BillNumber WHERE OrderID = @OrderID";
            SqlParameter[] sqlParameters =
            {
                 new SqlParameter("@BillNumber", bill.BillNumber),
                 new SqlParameter("@OrderID", dish.OrderID),
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateOrderBillNumber(Bill bill, OrderedDrink drink)
        {
            // update BillNumber in Order table according to ordered drinks
            string query = "UPDATE [Order] SET BillNumber = @BillNumber WHERE OrderID = @OrderID";
            SqlParameter[] sqlParameters =
            {
                 new SqlParameter("@BillNumber", bill.BillNumber),
                 new SqlParameter("@OrderID", drink.OrderID)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
