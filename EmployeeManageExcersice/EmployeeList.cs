using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManageExcersice
{
    public class EmployeeList
    {
        public List<IEmployee> employees = new List<IEmployee>();

        public void addEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }

        public void printDetails()
        {
            foreach(var employee in  employees) 
            {
                Console.WriteLine(employee.get_description());
                Console.WriteLine(employee.calculate_salary());
            }
        }
    }
}
