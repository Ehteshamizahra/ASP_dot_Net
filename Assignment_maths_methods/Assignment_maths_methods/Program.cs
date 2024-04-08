using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_maths_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the birds class
            birds bird = new birds();
            //Request for an input from the user and then convert the input into integer
            Console.WriteLine("Select an integer value:"); 
            int input = Convert.ToInt32(Console.ReadLine());
            //Call the three classes and dicplay the values
            Console.WriteLine(input + " multiply by itself is " + birds.class1(input));
            Console.WriteLine(input + " addition by itself is " + birds.class2(input));
            Console.WriteLine(input + " to the power of 2 is " + birds.class3(input));

            Console.ReadLine();

        }
    }
}
