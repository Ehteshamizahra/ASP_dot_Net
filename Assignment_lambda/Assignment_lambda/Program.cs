using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //create a list of at least 10 employees. At least two employees should have the first name “Joe”.
            List<Employee> employees = new List<Employee>
            {                 
                new Employee{ Id = 1, firstName = "Joe", lastName = "Wicks" },
                new Employee{ Id = 2, firstName = "Jamie", lastName = "Chandler" },
                new Employee{ Id = 3, firstName = "Zahra", lastName = "Ehteshami" },
                new Employee{ Id = 4, firstName = "James", lastName = "Trotter" },
                new Employee{ Id = 5, firstName = "Chris", lastName = "Hunt" },
                new Employee{ Id = 6, firstName = "Joe", lastName = "Henry" },
                new Employee{ Id = 7, firstName = "Stephen", lastName = "Fry" },
                new Employee{ Id = 8, firstName = "Brittany", lastName = "Marshall" },
                new Employee{ Id = 9, firstName = "Luke", lastName = "Aram" },
                new Employee{ Id = 10, firstName = "Jackson", lastName = "Heavener" },
            };
            //Using a foreach loop, create a new list of all employees with the first name “Joe”

            List<Employee> employees1 = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.firstName=="Joe")
                {
                    employees1.Add(employee);
                    Console.WriteLine(employee.lastName);
                }              
            }
            //Perform the above action again, but this time with a lambda expression.
            List<Employee> employees3 = employees.Where(x => x.firstName == "Joe").ToList();
            //Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> employees4 = employees.Where(x => x.Id >= 5).ToList();
            

            Console.ReadLine();


        }
    }
}
