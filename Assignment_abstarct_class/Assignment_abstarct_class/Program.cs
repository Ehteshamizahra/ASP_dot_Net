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

            //Call the SayName() method
            employee.SayName();

        }
    }
}
