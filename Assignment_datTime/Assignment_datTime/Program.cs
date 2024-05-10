using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_datTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the current time and date to tthe console
            DateTime TimeNow = DateTime.Now;
            Console.WriteLine(TimeNow);

            //Ask the user to enter an integer number, then convert the answer to hour format
            Console.WriteLine("Please enter an integer number: ");
            TimeSpan answer= TimeSpan.FromHours(Convert.ToInt32(Console.ReadLine()));

            //Use the overloading operators to add the hour to teh current time and print it to the screen
            Console.WriteLine(TimeNow+answer);
            Console.ReadLine();
        }
    }
}
