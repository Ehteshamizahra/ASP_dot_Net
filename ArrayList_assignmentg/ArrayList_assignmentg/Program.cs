using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_assignmentg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a 1D array of string and obtain users choice of index
            string[] farmAnimals = { "horse", "duck", "sheep", "boar", "goat" };
            Console.WriteLine("Pick a number 0-4:");
            int animalIndex = Convert.ToInt32(Console.ReadLine());
            //If the chosen index is in range, display the string from tehe array
            if (animalIndex >= 0 && animalIndex < 5)
            {
                Console.WriteLine(farmAnimals[animalIndex]);
                //Instantiate a 1D array of integer and obtain users choice of index
                int[] logInt = { 10, 100, 1000, 10000 };
                Console.WriteLine("Pick another number 0-3:");
                int logIntIndex = Convert.ToInt32(Console.ReadLine());
                //If the chosen index is in range, display the integer from the array
                if (logIntIndex >= 0 && logIntIndex < 4)
                {
                    Console.WriteLine(logInt[logIntIndex]);
                    //Instantiate a list and obtain users choice of index
                    List<string> strlist = new List<string>() { "Zero","One", "Two", "Three", "Four" };
                    Console.WriteLine("Pick another number 0-4:");
                    int listInd = Convert.ToInt32(Console.ReadLine());
                    //If the chosen index is in range, display the value from the list
                    if (listInd >= 0 && listInd < 5)
                    {
                        Console.WriteLine(strlist[listInd]);
                    }
                    else
                    {
                        //Terminate if the value is out of range
                        Console.WriteLine("the value is out of range");
                        Console.ReadLine();
                    }
                }
                else
                {
                    //Terminate if the value is out of range
                    Console.WriteLine("the value is out of range");
                    Console.ReadLine();
                }
            }
            else
            {
                //Terminate if the value is out of range
                Console.WriteLine("the value is out of range");
                Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}
