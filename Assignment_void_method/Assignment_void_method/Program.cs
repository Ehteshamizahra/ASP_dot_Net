using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_void_method
{
    class Program
    {
        static void Main(string[] args)
        {

            //instantiate class birds
            birds bird = new birds();

            //Define two variables and pass them as arguments to the mathsOp class
            int input1 = 1;
            int input2 = 2;
            birds.mathsOp(input1:input1, input2:input2);

            Console.ReadLine();
        }
        //Create a class called birds
        public class birds

        {
            //CReate a void method with two inputs
            public static void mathsOp(int input1, int input2)
            {
                int result = (int)Math.Log10(input1);
                Console.WriteLine(input2);
            }
        }

    }
}
