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
            //Request for an input from the user and then convert the input into integer
            Console.WriteLine("Select an integer value:"); 
            int input = Convert.ToInt32(Console.ReadLine());
            //Call the three classes and dicplay the values
            Console.WriteLine(input + " multiply by itself is " + class1(input));
            Console.WriteLine(input + " addition by itself is " + class2(input));
            Console.WriteLine(input + " to the power of 2 is " + class3(input));

            Console.ReadLine();

        }
        //Create the three classes and return the output in int
        public static int class1(int input)
        {
            int output1 = input * input;
            return output1;
        }

        public static int class2(int input)
        {
            int output2 = input + input;
            return output2;
        }

        public static int class3(int input)
        {
            int output3 = (int)Math.Pow(input, 2);
            return output3;
        }
    }
}
