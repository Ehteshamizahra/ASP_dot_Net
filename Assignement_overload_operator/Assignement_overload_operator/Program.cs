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

            //for Assignment 1, page 315

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
            Console.WriteLine(employee1 == employee2);

            Console.ReadLine();

            ////For assignment 2, page 319

            ////Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things
            //Employee<string> professions = new Employee<string>();
            //professions.thing = new List<string>() { "Engineer", "Accountance", "Lawyer", "Admin", "Managers" };

            ////Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.
            //Employee<int> levels = new Employee<int>();
            //levels.thing = new List<int>() { 1,2,3,4,5 };

            ////Create a loop that prints all of the Things to the Console.
            //foreach (string profession in professions.thing)
            //{
            //    Console.WriteLine(profession);
            //}
            //foreach (int level in levels.thing)
            //{
            //    Console.WriteLine(level);
            //}
            Console.ReadLine();



        }
    }
}
