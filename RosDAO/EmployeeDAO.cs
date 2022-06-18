using RosModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace RosDAL
{
    public class EmployeeDAO : BaseDAO
    {
        public Employee GetLastEmployeeID()
        {
            string query = "SELECT TOP 1 EmplID, Name, Username, Salt, Digest, SecretAnswer FROM Employee ORDER BY EmplID DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<SecretQuestion> GetAllSecretQuestions()
        {
            string query = "SELECT QuestionID, Question FROM [SecretQuestion]  WHERE QuestionID > 0 ORDER BY [QuestionID]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadQuestions(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Employee> GetAllManagers()
        {
            string query = "SELECT EmplID, Name, Username, Salt, Digest, SecretAnswer FROM [Employee] JOIN Manager ON EmplID = ManagerID ORDER BY [EmplID]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Employee> GetAllWaiters()
        {
            string query = "SELECT EmplID, Name, Username, Salt, Digest, SecretAnswer FROM [Employee] JOIN Waiter ON EmplID = WaiterID ORDER BY [EmplID]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Employee> GetAllChefs()
        {
            string query = "SELECT EmplID, Name, Username, Salt, Digest, SecretAnswer FROM [Employee] JOIN Chef ON EmplID = ChefID ORDER BY [EmplID]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Employee> GetAllBartenders()
        {
            string query = "SELECT EmplID, Name, Username, Salt, Digest, SecretAnswer FROM [Employee] JOIN Bartender ON EmplID = BartenderID ORDER BY [EmplID]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Employee GetEmployeeByUsername(string username)
        {
            string query = $"SELECT EmplID, Name, Username, Salt, Digest, SecretAnswer FROM [Employee] WHERE Username = @Username;";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Username", username)
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdatePassword(Employee employee)
        {
            string query = $"UPDATE Employee SET Salt = @Salt, Digest = @Digest WHERE EmplID = @EmplID;";
            SqlParameter[] sqlParameters = {
            new SqlParameter("@EmplID", employee.EmplID),
            new SqlParameter("@Salt", employee.Salt),
            new SqlParameter("@Digest", employee.Digest)          
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Employee employee = new Employee();
                    {
                        employee.EmplID = (int)dr["EmplID"];
                        employee.Name = (string)dr["Name"].ToString();
                        employee.Username = (string)dr["Username"].ToString();
                        employee.Salt = (string)dr["Salt"].ToString();
                        employee.Digest = (string)dr["Digest"].ToString();
                        employee.SecretAnswer = (string)dr["SecretAnswer"].ToString();
                    };
                    employees.Add(employee);
                }
                return employees;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }          
        }

        private Employee ReadTable(DataTable dataTable)
        {
            Employee employee = new Employee();
            try
            {            
                foreach (DataRow dr in dataTable.Rows)
                {
                    employee.EmplID = (int)dr["EmplID"];
                    employee.Name = (string)dr["Name"].ToString();
                    employee.Username = (string)dr["Username"].ToString();
                    employee.Salt = (string)dr["Salt"].ToString();
                    employee.Digest = (string)dr["Digest"].ToString();
                    employee.SecretAnswer = (string)dr["SecretAnswer"].ToString();
                }               
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return employee;
        }

        private List<SecretQuestion> ReadQuestions(DataTable dataTable)
        {
            List<SecretQuestion> questions = new List<SecretQuestion>();
            try
            {              
                foreach (DataRow dr in dataTable.Rows)
                {
                    SecretQuestion question = new SecretQuestion();
                    question.QuestionID = (int)dr["QuestionID"];
                    question.Question = (string)dr["Question"].ToString();
                    questions.Add(question);
                }

                return questions;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Add(Employee employee)
        {
            try
            {
                string query = "INSERT INTO Employee VALUES(@Name, @Username, @Salt, @Digest, @SecretAnswer);";

                SqlParameter[] sqlParameters = { new SqlParameter("@EmplID", employee.EmplID),
                new SqlParameter("@Name", employee.Name),
                new SqlParameter("@Username", employee.Username),
                new SqlParameter("@Salt", employee.Salt),
                new SqlParameter("@Digest", employee.Digest),
                new SqlParameter("@SecretAnswer", employee.SecretAnswer) };

                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw new Exception("*Failed to register user*" + e.Message);
            }
        }

        public void AddManager(Employee employee)
        {
            try
            {
                string query = "INSERT INTO Manager VALUES(@ManagerID);";

                SqlParameter[] sqlParameters = { new SqlParameter("@ManagerID", employee.EmplID) };

                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw new Exception("*Failed to register user*" + e.Message);
            }
        }

        public void AddWaiter(Employee employee)
        {
            try
            {
                string query = "INSERT INTO Waiter VALUES(@WaiterID);";

                SqlParameter[] sqlParameters = { new SqlParameter("@WaiterID", employee.EmplID) };

                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw new Exception("*Failed to register user*" + e.Message);
            }
        }

        public void AddChef(Employee employee)
        {
            try
            {
                string query = "INSERT INTO Chef VALUES(@ChefID);";

                SqlParameter[] sqlParameters = { new SqlParameter("@ChefID", employee.EmplID) };

                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw new Exception("*Failed to register user*" + e.Message);
            }
        }

        public void AddBartender(Employee employee)
        {
            try
            {
                string query = "INSERT INTO Bartender VALUES(@BartenderID);";

                SqlParameter[] sqlParameters = { new SqlParameter("@BartenderID", employee.EmplID) };

                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw new Exception("*Failed to register user*" + e.Message);
            }
        }
    }
}
