using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDirectory
{
    class Payroll
    {
        private List<Employee> employees = new List<Employee>();

        public void Add(string name, int salary)
        {
            Employee employee = new Employee(name, salary);
            employees.Add(employee);
        }
    }
}
