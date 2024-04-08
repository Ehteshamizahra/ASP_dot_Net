using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_maths_methods
{
    class birds
    {
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
