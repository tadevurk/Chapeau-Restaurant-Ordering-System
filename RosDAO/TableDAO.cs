using RosModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace RosDAL
{
    public class TableDAO : BaseDAO
    {
        private SqlConnection conn;
        public TableDAO()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
        }
        public Table GetTableById(int tableNumber)
        {
            string query = $"SELECT TableNumber, TableStatus FROM [Table] WHERE TableNumber = {tableNumber} ORDER BY [TableNumber]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Table> GetAllTables()
        {
            string query = "SELECT TableNumber, TableStatus FROM [Table] ORDER BY [TableNumber]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));    
        }

        public void Update(Table table)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("UPDATE [Table] SET TableStatus = @TableStatus WHERE TableNumber = @ID", conn);
                command.Parameters.AddWithValue("@ID", table.TableNumber);
                command.Parameters.AddWithValue("@TableStatus", table.TableStatus);

                int nrOfRowAffected = command.ExecuteNonQuery();
                if (nrOfRowAffected == 0)
                    throw new Exception("Update was succesful");
            }
            catch (Exception e)
            {
                throw new Exception("Update failed! " + e.Message);
            }

            conn.Close();
        }

        public void UpdateTableWaiter(Table table)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("UPDATE [Table] SET TableStatus = @TableStatus, WaiterID = @WaiterID WHERE TableNumber = @TableNumber", conn);
                command.Parameters.AddWithValue("@TableNumber", table.TableNumber);
                command.Parameters.AddWithValue("@TableStatus", table.TableStatus);
                command.Parameters.AddWithValue("@WaiterID", table.WaiterID);

                int nrOfRowAffected = command.ExecuteNonQuery();
                if (nrOfRowAffected == 0)
                    throw new Exception("Update was succesful");
            }
            catch (Exception e)
            {
                throw new Exception("Update failed! " + e.Message);
            }

            conn.Close();
        }


        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table();
                {
                    table.TableNumber = (int)dr["TableNumber"];
                    table.TableStatus = (int)dr["TableStatus"];
                };
                tables.Add(table);
            }
            return tables;
        }

        private Table ReadTable(DataTable dataTable)
        {
            Table table = new Table();
            foreach (DataRow dr in dataTable.Rows)
            {                  
                table.TableNumber = (int)dr["TableNumber"];
                table.TableStatus = (int)dr["TableStatus"];
            }
            return table;
        }
    }
}
