using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManageExcersice
{
    public interface IEmployee
    {
        string get_description();
        int calculate_salary();
        //void add_to_database();
    }
}
