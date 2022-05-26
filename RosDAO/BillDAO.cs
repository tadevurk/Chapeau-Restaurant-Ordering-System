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
        public List<BillItem> GetOrderedDishes(Table table) // Get the list of the unpaid ordered dishes for a certain table
        {
            string query = "SELECT I.ItemName, I.ItemPrice, OD.OrderedDishAmount, D.Vat FROM OrderDish as OD " +
                "JOIN [Order] as O on OD.OrderID = O.OrderID JOIN Item as I on OD.DishID = I.ItemID JOIN Dish as D on OD.DishID = D.DishID " +
                "WHERE O.TableNumber = @TableNumber AND OD.DishStatus < 3; ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TableNumber", table.TableNumber);


            return ReadOrderedDishes(ExecuteSelectQuery(query, sqlParameters));
        }


        private List<BillItem> ReadOrderedDishes(DataTable dataTable)
        {

            List<BillItem> orderedDishes = new List<BillItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                BillItem orderedDish = new BillItem()
                {
                    Name = (string)dr["ItemName"],
                    ItemPrice = (decimal)dr["ItemPrice"],
                    Amount = (int)dr["OrderedDishAmount"],
                    Vat = (int)dr["Vat"]
                };
                orderedDishes.Add(orderedDish);
            }
            return orderedDishes;
        }

        public List<BillItem> GetOrderedDrinks(Table table) // Get the list of the unpaid ordered drinks for a certain table
        {
            string query = "SELECT I.ItemName, I.ItemPrice, OD.OrderedDrinkAmount, DT.Vat FROM OrderDrink as OD " +
                "JOIN [Order] as O on OD.OrderID = O.OrderID JOIN Item as I on OD.DrinkID = I.ItemID JOIN Drink as D on OD.DrinkID = D.DrinkID " +
                "JOIN DrinkType as DT on D.DrinkTypeID = DT.DrinkTypeID WHERE O.TableNumber = @TableNumber AND OD.DrinkStatus < 3; ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TableNumber", table.TableNumber);


            return ReadOrderedDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<BillItem> ReadOrderedDrinks(DataTable dataTable)
        {
            List<BillItem> orderedDrinks = new List<BillItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                BillItem orderedDrink = new BillItem()
                {
                    Name = (string)dr["ItemName"],
                    ItemPrice = (decimal)dr["ItemPrice"],
                    Amount = (int)dr["OrderedDrinkAmount"],
                    Vat = (int)dr["Vat"]

                };
                orderedDrinks.Add(orderedDrink);
            }
            return orderedDrinks;
        }



        // store a complete table bill in the database
        public void CreateBill(Bill bill)
        {
            //bill.BillNumber = LastBillNumberPK() + 1;
            string query = "INSERT INTO Bill (TotalAmount, TipAmount,  Feedback, TableNumber, PaymentDate, SubTotalAmount, PaymentMethod) " +
                "VALUES (@TotalAmount, @TipAmount,  @Feedback, @TableNumber, GETDATE(), @SubTotalAmount, @PaymentMethod)";

            if (bill.Feedback == null)
            {
                bill.Feedback = "Null";
            }
            SqlParameter[] sqlParameters =
            {
                //new SqlParameter("@BillNumber", bill.BillNumber),
                new SqlParameter("@TotalAmount", bill.TotalAmount),
                new SqlParameter("@TipAmount", bill.TipAmount),
                new SqlParameter("@Feedback", bill.Feedback),
                new SqlParameter("@TableNumber", bill.TableNumber),
                new SqlParameter("@SubTotalAmount", bill.SubTotalAmount),
                new SqlParameter("@PaymentMethod", bill.PaymentMethod),
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        // temporary solution until we change billNumber to autoincrement 
        public int LastBillNumberPK()
        {
            string query = "select count(*) as count from Bill";
            SqlParameter[] sp = new SqlParameter[0];
            return ReadCount(ExecuteSelectQuery(query, sp));
        }

        private int ReadCount(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            return (int)row["count"];
        }

        public void SetDishPaid(BillItem billItem)
        {
            // update the ordered dish status to paid status 
            string query = "UPDATE [OrderedDish] SET @DishStatus = 3";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@DishStatus", billItem.DishStatus)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void SetDrinkPaid(BillItem billItem)
        {
            // update the ordered drinks status to paid status 
            string query = "UPDATE [OrderedDrink] SET @DrinkStatus = 3";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@DishStatus", billItem.DrinkStatus)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        // update a bill in the database
        public void UpdateBill(Bill bill)
        {
            string query = "UPDATE [Bill] SET BillNumber = @BillNumber, BillAmount = @BillAmount, SubTotalAmount = @SubTotalAmount," +
                " TipAmount = @TipAmount, Feedback = @Feedback, TableNumber = @TableNumber, PaymentDate = GETDATE()" +
                " WHERE BillNumber = @BillNumber";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@BillNumber", bill.BillNumber),
                new SqlParameter("@BillAmount", bill.TotalAmount),
                new SqlParameter("@SubTotalAmount", bill.SubTotalAmount),
                new SqlParameter("@TipAmount", bill.TipAmount),
                new SqlParameter("@Feedback", bill.Feedback),
                new SqlParameter("@TableNumber", bill.TableNumber),
            };
            ExecuteEditQuery(query, sqlParameters);
        }


        // retrieve a bill from database
        public Bill GetBill(Bill bill)
        {
            string query = "SELECT BillNumber = @BillNumber, BillAmount = @BillAmount, SubTotalAmount = @SubTotalAmount," +
                " TipAmount = @TipAmount, Feedback = @Feedback, TableNumber = @TableNumber, PaymentDate = @GETDATE()" +
                " WHERE BillNumber = @BillNumber";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BillNumber", bill.BillNumber);
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
                    TotalAmount = (decimal)dr["TotalAmount"],
                    SubTotalAmount = (decimal)dr["SubTotalAmount"],
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
