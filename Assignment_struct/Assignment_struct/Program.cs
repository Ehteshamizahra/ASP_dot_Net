using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_struct
{
    class Program
    {
        static void Main(string[] args)
        {

            //instanciate a Number and assign a value to it then print it onto the console

            Number number = new Number();
            number.Amount = 5.3M;
            Console.WriteLine(number.Amount);



        }
    }
}
