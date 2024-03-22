using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManageExcersice
{
    public interface IDatabaseProfile
    {
        int get_employee_id();
        string get_employee_name();

        int get_employee_salary();
        string get_employee_email();
    }
}
