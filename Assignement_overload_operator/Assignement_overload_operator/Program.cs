using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_overload_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate class to create two objects and asign values to their propertires 
            Employee employee1 = new Employee();
            employee1.Id = 123;
            employee1.FirstName = "Bob";
            employee1.LastName = "Johnson";
            Employee employee2 = new Employee();
            employee2.Id = 234;
            employee2.FirstName = "James";
            employee2.LastName = "Johnson";


            //Use overload operator to compare the employee Ids and display the result on the console
            Console.WriteLine("Do our two employees have the same Id? \n"+ (employee1.Id==employee2.Id));

            Console.ReadLine();



        }
    }
}
