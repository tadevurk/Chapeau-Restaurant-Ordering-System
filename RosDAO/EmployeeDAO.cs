using RosModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace RosDAL
{
    public class EmployeeDAO : BaseDAO
    {
        private SqlConnection conn;
        public EmployeeDAO()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
        }

        public Employee GetEmployeeById(int emplID)
        {
            string query = $"SELECT EmplID, Name, Username, Salt, Digest FROM [Employee] WHERE EmplID = {emplID} ORDER BY [EmplID]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public Employee GetLastEmployeeID()
        {
            string query = "SELECT TOP 1 EmplID, Name, Username, Salt, Digest FROM Employee ORDER BY EmplID DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Employee> GetAllEmployees()
        {
            string query = "SELECT EmplID, Name, Username, Salt, Digest FROM [Employee] ORDER BY [EmplID]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Employee GetEmployeeByUsername(string username)
        {
            string query = $"SELECT EmplID, Name, Username, Salt, Digest FROM [Employee] WHERE Username = '{username}';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee();
                {
                    employee.EmplID = (int)dr["EmplID"];
                    employee.Name = (string)dr["Name"].ToString();
                    employee.Username = (string)dr["Username"].ToString();
                    employee.Salt = (string)dr["Salt"].ToString();
                    employee.Digest = (string)dr["Digest"].ToString();
                };
                employees.Add(employee);
            }
            return employees;
        }

        private Employee ReadTable(DataTable dataTable)
        {
            Employee employee = new Employee();

            foreach (DataRow dr in dataTable.Rows)
            {               
                employee.EmplID = (int)dr["EmplID"];
                employee.Name = (string)dr["Name"].ToString();
                employee.Username = (string)dr["Username"].ToString();
                employee.Salt = (string)dr["Salt"].ToString();
                employee.Digest = (string)dr["Digest"].ToString();
            }
            return employee;
        }

        public void Add(Employee employee)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Employee VALUES(@EmplID, @Name, @Username, @Salt, @Digest);", conn);

                command.Parameters.AddWithValue("@EmplID", employee.EmplID);
                command.Parameters.AddWithValue("@Name", employee.Name);
                command.Parameters.AddWithValue("@Username", employee.Username);
                command.Parameters.AddWithValue("@Salt", employee.Salt);
                command.Parameters.AddWithValue("@Digest", employee.Digest);

                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("*Failed to register user*" + e.Message);
            }
            conn.Close();
        }        
    }
}
