using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManageExcersice
{
    public class Employee : IEmployee
    {
        public string name { get; }
        public string email { get; }
        
        public Employee(string name,string email) 
        { 
            this.name = name;
            this.email = email;
        }
        public string get_description()
        {
            CreateEmailProfile newEmail = new CreateEmailProfile(email);
            string add_to_mailing_group = newEmail.get_description();
            return add_to_mailing_group;
        }

        public int calculate_salary()
        {
            return 200000;
        }

        public void add_to_database()
        {

        }
    }
}
