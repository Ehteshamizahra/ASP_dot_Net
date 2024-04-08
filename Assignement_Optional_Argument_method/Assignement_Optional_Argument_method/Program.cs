using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_Optional_Argument_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the bird class
            birds bird = new birds();
            //Aquire a maximum range to generate a random number for the user            
            Console.WriteLine("Enter a max range for random value generation from 0-50:");
            int max=Convert.ToInt32(Console.ReadLine());
            //Aquire an optional count for the number of generated random number
            Console.WriteLine("Pick a count for random number generator --Optional, press enter if no repeate is required");
            string countRan = Console.ReadLine();
            
            //If the user doesn't select a count for the roundom number, call the random number generator without the optional count, and display the value
            if (string.IsNullOrEmpty(countRan))
            {
                List<int> newList = birds.randomNumber(max);
                Console.WriteLine(string.Join(", ", newList));
            }
            //If the user selects a count for the roundom number, call the random number generator and display the list of the generated random numbers
            else
            {
                int countRan1 = Convert.ToInt32(countRan);
                List<int> newList = birds.randomNumber(max, countRan1);
                Console.WriteLine(string.Join(", ", newList) );
            }
            Console.ReadLine();
            
        }

        //Create a random number generator method which requires a maximum value to set the range and an optional count for the number of random values.
        public class birds
        {
            public static List<int> randomNumber(int max, int countRan = 1)

            {
                Random random = new Random();
                List<int> randomList = new List<int> { };

                for (int i = 0; i < countRan; i++)
                {
                    int randomValue = random.Next(0, max);
                    randomList.Add(randomValue);
                }
                return randomList;

            }
        }

    }
}
