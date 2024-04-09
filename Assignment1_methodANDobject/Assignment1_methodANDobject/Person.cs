using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_methodANDobject
{
    public class Person
    {

        //Create some properties for the class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Create a method to write name on the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
