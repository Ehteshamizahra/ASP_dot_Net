using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_abstarct_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the Employee class and give it's properties some values
            Employee employee = new Employee();
            
            employee.firstName = "Sample";
            employee.lastName = "Student";

            //Asignment_abstract_class
            //Call the SayName() method
            employee.SayName();

            //Assignment_polymorphism
            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it
            IQuittable quitingPerson = new Employee();
            quitingPerson.Quit();
            Console.ReadLine();

        }
    }
}
