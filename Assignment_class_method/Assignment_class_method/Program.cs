using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_class_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the mathsOp class
            mathsOp operation1 = new mathsOp();
            //Aquire a number from teh user and assign the answer to "input"
            Console.WriteLine("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            //Call the method on the input and display the result on the screen
            mathsOp.maths(input, out output);
            Console.WriteLine(output);

            //Call the cals method on the defined triangle sides and display the area on the screen
            double sinAngle = 0;
            double cosAngle = 0;
            double tanAngle = 0;
            double area = cals(5, 10, 8, out sinAngle, out cosAngle, out tanAngle);
            Console.WriteLine("The area of the triangle with Opposit=5, Adjacent=10 and Hypotenuse=8 is: " + area);
            Console.WriteLine("And the sinAngle, cosAngle, and tanAngle of this triangle are :  " + sinAngle  +", "+ cosAngle + ", and " + tanAngle);
            Console.WriteLine("5 degrees in radien is "+ cals(5));

            Console.ReadLine();
        }

        //Create a method with output parameters
        public static double cals(double opposite, double hypotenuse, double adjacent, out double sinAngle, out double cosAngle, out double tanAngle)
        {
            sinAngle = opposite / hypotenuse;
            cosAngle = adjacent / hypotenuse;
            tanAngle = opposite / adjacent;

            double area = 0.5 * opposite * adjacent;
            return area;
        }
        //Overloading a method
        public static int cals(int angle)
        {
            int toRad = angle * (int)Math.PI / 180;
            return toRad;
        }

    }
}
