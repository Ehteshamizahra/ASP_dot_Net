using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_methodANDobject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate employee object
            Employee employee = new Employee();

            //Initialise teh object with some values
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //Call the superclass method SayName
            employee.SayName();
            Console.ReadLine();
            

        }
    }
}
