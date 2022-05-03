using RosModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosDAL
{
    public class EmployeeDAO : BaseDAO
    {
        public Employee GetEmployeeById(int id)
        {
            return new Employee();
        }

        public List<Employee> GetAllEmployees()
        {
            return new List<Employee>();
        }

        public Employee GetEmployeeByUsername(string username)
        {
            return new Employee();
        }
    }
}
