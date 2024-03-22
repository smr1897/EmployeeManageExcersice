using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManageExcersice
{
    public class AddEmployee
    {
        public IEmployee create_employee(string name,string email)
        {
            return new Employee(name,email);
        }
    }
}
