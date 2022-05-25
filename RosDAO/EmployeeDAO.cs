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

        public List<Employee> GetAllManagers()
        {
            string query = "SELECT EmplID, Name, Username, Salt, Digest FROM [Employee] JOIN Manager ON EmplID = ManagerID ORDER BY [EmplID]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Employee> GetAllWaiters()
        {
            string query = "SELECT EmplID, Name, Username, Salt, Digest FROM [Employee] JOIN Waiter ON EmplID = WaiterID ORDER BY [EmplID]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Employee> GetAllChefs()
        {
            string query = "SELECT EmplID, Name, Username, Salt, Digest FROM [Employee] JOIN Chef ON EmplID = ChefID ORDER BY [EmplID]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Employee> GetAllBartenders()
        {
            string query = "SELECT EmplID, Name, Username, Salt, Digest FROM [Employee] JOIN Bartender ON EmplID = BartenderID ORDER BY [EmplID]";
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
                SqlCommand command = new SqlCommand("INSERT INTO Employee VALUES(@Name, @Username, @Salt, @Digest);", conn);

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

        public void AddManager(Employee employee)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Manager VALUES(@ManagerID);", conn);

                command.Parameters.AddWithValue("@ManagerID", employee.EmplID);

                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("*Failed to register user*" + e.Message);
            }
            conn.Close();
        }

        public void AddWaiter(Employee employee)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Waiter VALUES(@WaiterID);", conn);

                command.Parameters.AddWithValue("@WaiterID", employee.EmplID);

                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("*Failed to register user*" + e.Message);
            }
            conn.Close();
        }

        public void AddChef(Employee employee)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Chef VALUES(@ChefID);", conn);

                command.Parameters.AddWithValue("@ChefID", employee.EmplID);

                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("*Failed to register user*" + e.Message);
            }
            conn.Close();
        }

        public void AddBartender(Employee employee)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Bartender VALUES(@BartenderID);", conn);

                command.Parameters.AddWithValue("@BartenderID", employee.EmplID);

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
