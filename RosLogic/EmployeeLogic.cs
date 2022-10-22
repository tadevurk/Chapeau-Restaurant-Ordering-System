﻿using System.Collections.Generic;
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

        public List<SecretQuestion> GetAllSecretQuestions()
        {
            return employeedb.GetAllSecretQuestions();
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
