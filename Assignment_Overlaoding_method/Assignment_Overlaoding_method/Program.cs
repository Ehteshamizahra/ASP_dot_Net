//Assignment on overloading methods

using System;


namespace Assignment_Overlaoding_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the class birds
            birds bird = new birds();
            //Define an integer variable and instantiate the integer maths operation
            int deg = 10;
            Console.WriteLine(birds.mathOp(deg));
            //Define a decimal variable and instantiate the decimal maths operation
            decimal rad =10.10m;
            Console.WriteLine(birds.mathOp(rad));
            //Define a string variable and instantiate the string maths operation
            string stringAngle = "20";
            Console.WriteLine(birds.mathOp(stringAngle));
            Console.ReadLine();
        }

        //Create a class birds
        public class birds
        {
            //Create the first maths operation method that takes an integer as an input and return an integer
            public static int mathOp(int deg)
            {
                int result = deg * (((int)Math.PI) / 180);
                return result;
            }
            //Create the first maths operation method that takes a decimal as an input and return an integer
            public static int mathOp(Decimal rad)
            {
                int result = Convert.ToInt32(rad * 180 / (decimal)Math.PI);
                return result;
            }
            //Create the first maths operation method that takes a string as an input and return an integer
            public static int mathOp(string rad)
            {
                int result = Convert.ToInt32(rad) * 180 / (int)Math.PI;
                return result;
            }
        }
  

    }
}
