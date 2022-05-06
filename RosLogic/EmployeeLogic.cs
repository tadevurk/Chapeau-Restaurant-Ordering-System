using RosDAL;
using RosModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosLogic
{
    public class EmployeeLogic
    {
        EmployeeDAO employeedb = new EmployeeDAO();    
        public Employee GetEmployeeById(int id)
        {
            return employeedb.GetEmployeeById(id);
        }

        public Employee GetLastEmployeeID()
        {
            return employeedb.GetLastEmployeeID();
        }

        public List<Employee> GetAllEmployees()
        {
            return employeedb.GetAllEmployees();
        }

        public Employee GetEmployeeByUsername(string username)
        {
            return employeedb.GetEmployeeByUsername(username);
        }

        public void Add(Employee employee)
        {
            employeedb.Add(employee);
        }
    }
}
