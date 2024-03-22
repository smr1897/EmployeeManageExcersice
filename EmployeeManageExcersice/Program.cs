namespace EmployeeManageExcersice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to add an employee ? [Y/N] ");
            string addEmployee = Console.ReadLine();

            if (addEmployee == "y")
            {
                Console.WriteLine("Enter the name of the employee : ");
                string employeeName = Console.ReadLine();
                Console.WriteLine("Enter the email of the employee : ");
                string employeeEmail = Console.ReadLine();

                AddEmployee employee = new AddEmployee();
                IEmployee newEmployee = employee.create_employee(employeeName, employeeEmail);

                EmployeeList employeeList = new EmployeeList();
                employeeList.addEmployee(newEmployee);

                employeeList.printDetails();
            }
        }
    }
}
