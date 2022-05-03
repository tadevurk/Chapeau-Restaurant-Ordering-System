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
        EmployeeDAO employeeDAO = new EmployeeDAO();    
        public Employee GetEmployeeById(int id)
        {
            return employeeDAO.GetEmployeeById(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDAO.GetAllEmployees();
        }

        public Employee GetEmployeeByUsername(string username)
        {
            return employeeDAO.GetEmployeeByUsername(username);
        }
    }
}
