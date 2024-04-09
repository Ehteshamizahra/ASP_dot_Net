using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_abstarct_class
{
    //inherit from the Person class
    public class Employee: Person, IQuittable
    {
        //Implement the SayName() class by overriding the abstarct method
        public override void SayName()
        {
            Console.WriteLine("Player's Name is " + firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("Player 1 is quitting");
        }

        

    }
}
