using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for their age. Exceptions must be handled using “try/catch.”
            bool tryAgain = true;
            while(tryAgain)//Allow the user try again if 'ArgumentException was thrown.
            {
                try
                {
                    //Exceotion handling for an invalid entry
                    bool validAnswer = false;
                    int age = 0;
                    while (!validAnswer)
                    {
                        Console.WriteLine("How old are you?");
                        validAnswer = int.TryParse(Console.ReadLine(), out age);//int.TryParse converts string to int, if it's successful then it throws true
                        if (!validAnswer)
                        {
                            Console.WriteLine("Please enter digits and no decimal");
                        }
                    }
                    //Throw a catch exception if the answer is <=0
                    if (age <= 0)
                    {
                        throw new ArgumentException();
                    }
                    //Display the year the user was born
                    DateTime currentDate = DateTime.Today;
                    int yearBorn = currentDate.Year - age;
                    Console.WriteLine(yearBorn);
                    Console.ReadLine();
                    return;
                }
                //Catch exception if the answer is <=0
                catch (ArgumentException)
                {
                    Console.WriteLine("Your age must be above 0. Try again!");
                    tryAgain = true;
                }
                //Catch exception for any other reasons
                catch (Exception)
                {
                    Console.WriteLine("An error occured in the system. Contact your admin. Goodbye!");
                    tryAgain = false;
                    Console.ReadLine();
                    return;
                }
            }
            
            
            
            




            //Display appropriate error messages if the user enters zero or negative numbers.

            //Display a general message if an exception was caused by anything else.
        }
    }
}
