using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_exampleProject
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //Ask teh user to enter a day of teh week then parse that valaue to the dayOfWeek enum to check if the value exist in that list
                Console.WriteLine("What is the current day of the week");
                string userEntry = (Console.ReadLine()).ToLower();//Convert user input to lower case string
                Console.WriteLine(Enum.Parse(typeof(dayOfWeek), userEntry));

            }
            //Throw an exception of the user entry doesnt exist in the defined enum
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.ReadLine();

            }              

        }
        //Define the day of teh week enum
        public enum dayOfWeek
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }

    }
}
