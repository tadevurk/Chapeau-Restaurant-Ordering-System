using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosModel;
using RosDAL;

namespace RosLogic
{
    public class EmployeeLogic
    {
        EmployeeDAO employeedb = new EmployeeDAO();


        public void UpdatePassword(Employee employee)
        {
            employeedb.UpdatePassword(employee);
        }

        public Employee GetLastEmployeeID()
        {
            return employeedb.GetLastEmployeeID();
        }

        public List<SecretQuestion> GetAllSecretQuestions()
        {
            return employeedb.GetAllSecretQuestions();
        }

        public List<Employee> GetAllManagers()
        {
            return employeedb.GetAllManagers();
        }

        public List<Employee> GetAllWaiters()
        {
            return employeedb.GetAllWaiters();
        }

        public List<Employee> GetAllChefs()
        {
            return employeedb.GetAllChefs();
        }

        public List<Employee> GetAllBartenders()
        {
            return employeedb.GetAllBartenders();
        }

        public Employee GetEmployeeByUsername(string username)
        {
            return employeedb.GetEmployeeByUsername(username);
        }

        public void Add(Employee employee)
        {
            employeedb.Add(employee);
        }

        public void AddManager(Employee employee)
        {
            employeedb.AddManager(employee);
        }

        public void AddWaiter(Employee employee)
        {
            employeedb.AddWaiter(employee);
        }

        public void AddChef(Employee employee)
        {
            employeedb.AddChef(employee);
        }

        public void AddBartender(Employee employee)
        {
            employeedb.AddBartender(employee);
        }
    }
}
