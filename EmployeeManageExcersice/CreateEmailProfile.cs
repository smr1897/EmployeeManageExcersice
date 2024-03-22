using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManageExcersice
{
    public class CreateEmailProfile : IEmailProfile
    {
        static int id = 0;
        public string email { get; }

        public CreateEmailProfile(string email)
        {
            this.email = email;
        }

        public string get_description()
        {
            string description = $"The employee with id {id} was added to the email group";
            return description;
        }
    }
}
