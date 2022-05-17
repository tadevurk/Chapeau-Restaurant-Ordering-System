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
    public class BillDAO : BaseDAO
    {
        public List<OrderedDish> GetOrderedDishes() // Get the list of the ordered dishes
        {
            string query = "SELECT I.ItemName as [name], I.ItemPrice, OD.OrderedDishAmount FROM OrderDish as OD " +
                "JOIN [Order] as O on OD.OrderID = O.OrderID JOIN Item as I on OD.DishID = I.ItemID JOIN Dish as D on OD.DishID = D.DishID " +
                "WHERE O.TableNumber = 1 AND OD.DishStatus>=3; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadOrderedDishes(ExecuteSelectQuery(query, sqlParameters));
        }


        private List<OrderedDish> ReadOrderedDishes(DataTable dataTable)
        {
            List<OrderedDish> orderedDishes = new List<OrderedDish>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderedDish orderedDish = new OrderedDish()
                {
                    Name = (string)dr["ItemName"],
                    Price = (decimal)dr["ItemPrice"],
                    OrderedDishAmount = (int)dr["OrderedDishAmount"]

                };
                orderedDishes.Add(orderedDish);
            }
            return orderedDishes;
        }

        public List<OrderedDrink> GetOrderedDrinks() // Get the list of the ordered drinks
        {
            string query = "SELECT I.ItemName as [name], I.ItemPrice, OD.OrderedDrinkAmount FROM OrderDrink as OD " +
                "JOIN [Order] as O on OD.OrderID = O.OrderID JOIN Item as I on OD.DrinkID = I.ItemID JOIN Dish as D on OD.DrinkID = D.DrinkID " +
                "WHERE O.TableNumber = 1 AND OD.DrinkStatus>=3; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadOrderedDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderedDrink> ReadOrderedDrinks(DataTable dataTable)
        {
            List<OrderedDrink> orderedDrinks = new List<OrderedDrink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderedDrink orderedDrink = new OrderedDrink()
                {
                    Name = (string)dr["ItemName"],
                    Price = (decimal)dr["ItemPrice"],
                    OrderedDrinkAmount = (int)dr["OrderedDrinkAmount"]

                };
                orderedDrinks.Add(orderedDrink);
            }
            return orderedDrinks;
        }


        // store a complete bill for a table in the database
        public void CreateBill(Bill bill)
        {
            string query = "INSERT INTO Bill (BillNumber, BillAmount, BillStatus, TipAmount, Feedback, TableNumber, PaymentDate) " +
                "VALUES (@BillNumber, @BillAmount, @BillStatus, @TipAmount, @Feedback, @TableNumber, @PaymentDate) SELECT SCOPE_IDENTITY()";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@BillNumber", bill.BillNumber),
                new SqlParameter("@BillAmount", bill.BillAmount),
                new SqlParameter("@BillStatus", bill.BillStatus),
                new SqlParameter("@TipAmount", bill.TipAmount),
                new SqlParameter("@Feedback", bill.Feedback),
                new SqlParameter("@TableNumber", bill.TableNumber),
                new SqlParameter("@PaymentDate", bill.PaymentDate)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        // update bill
        public void UpdateBill(Bill bill)
        {
            string query = "UPDATE [Bill] SET BillNumber = @BillNumber, BillAmount = @BillAmount, BillStatus = @BillStatus," +
                " TipAmount = @TipAmount, Feedback = @Feedback, TableNumber = @TableNumber, PaymentDate = @PaymentDate" +
                " WHERE BillNumber = @BillNumber";
            SqlParameter[] sqlParameters =
           {
                new SqlParameter("@BillNumber", bill.BillNumber),
                new SqlParameter("@BillAmount", bill.BillAmount),
                new SqlParameter("@BillStatus", bill.BillStatus),
                new SqlParameter("@TipAmount", bill.TipAmount),
                new SqlParameter("@Feedback", bill.Feedback),
                new SqlParameter("@TableNumber", bill.TableNumber),
                new SqlParameter("@PaymentDate", bill.PaymentDate)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public Bill GetBillById(int drinkId)
        {
            string query = "SELECT * FROM [Drinks] WHERE DrinkId = @DrinkId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DrinkId", drinkId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<Bill> ReadTables(DataTable dataTable)
        {
            List<Bill> bills = new List<Bill>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bill bill = new Bill()
                {
                    BillNumber = (int)dr["BillNumber"],
                    BillAmount = (decimal)dr["BillAmount"],
                    BillStatus = (bool)dr["BillStatus"],
                    TipAmount = (decimal)dr["TipAmount"],
                    Feedback = (string)dr["Feedback"],
                    TableNumber = (int)dr["TableNumber"],
                    PaymentDate = (DateTime)dr["PaymentDate"]
                };
                bills.Add(bill);
            }
            return bills;
        }
    }
}
