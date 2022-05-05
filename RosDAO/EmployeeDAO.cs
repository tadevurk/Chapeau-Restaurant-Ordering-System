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
            string query = $"SELECT EmplID, Name, Username, PinCode FROM [Employee] WHERE EmplID = {emplID} ORDER BY [EmplID]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Employee> GetAllEmployees()
        {
            string query = "SELECT EmplID, Name, Username, PinCode FROM [Employee] ORDER BY [EmplID]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Employee GetEmployeeByUsername(string username)
        {
            string query = $"SELECT EmplID, Name, Username, PinCode FROM [Employee] WHERE Username = {username} ORDER BY [EmplID]";
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
                    employee.EmpID = (int)dr["EmplID"];
                    employee.Name = (string)dr["Name"].ToString();
                    employee.Username = (string)dr["Username"].ToString();
                    employee.PinCode = (int)dr["PinCode"];
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
                employee.EmpID = (int)dr["EmplID"];
                employee.Name = (string)dr["Name"].ToString();
                employee.Username = (string)dr["Username"].ToString();
                employee.PinCode = (int)dr["PinCode"];
            }
            return employee;
        }
    }
}
