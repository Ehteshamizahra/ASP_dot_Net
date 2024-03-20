using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        //Obtain an answer from the user and set the correct answer
        string anotherGO;
        Console.WriteLine("Which month of year sprint starts?");
        String month = Console.ReadLine().ToLower();
        bool answer = month == "march";

        do
        {
            switch (month)
            {
                //Define the case for the correct answer
                case "march":
                    Console.WriteLine("That's correct!");
                    answer = false;
                    break;
                //Define the close guesses
                case "april":
                case "february":
                    Console.WriteLine("You are very close!");
                    Console.WriteLine("Do you want to have another go? answer with yes or no");
                    anotherGO = Console.ReadLine().ToLower();
                    if (anotherGO == "yes")
                    {
                        answer = true;
                        Console.WriteLine("Which month of year sprint starts?");
                        month = Console.ReadLine().ToLower();
                    }
                    else
                    {
                        answer = false;
                        break;
                    }

                    break;
                //Define the cases with wrong answer
                case "june":
                case "july":
                case "auhust":
                case "september":
                case "october":
                case "november":
                case "december":
                case "january":
                case "may":
                    Console.WriteLine("Not quite!");
                    Console.WriteLine("Do you want to have another go? answer with yes or no");
                    anotherGO = Console.ReadLine().ToLower();
                    if (anotherGO == "yes")
                    {
                        answer = true;
                        Console.WriteLine("Which month of year sprint starts?");
                        month = Console.ReadLine().ToLower();
                    }
                    else
                    {
                        answer = false;
                        break;
                    }
                    break;
                //Define cases with NOT a month answer
                default:
                    Console.WriteLine("The entry is not a month");
                    Console.WriteLine("Do you want to have another go? answer with yes or no");
                    anotherGO = Console.ReadLine().ToLower();
                    if (anotherGO == "yes")
                    {
                        answer = true;
                        Console.WriteLine("Which month of year sprint starts?");
                        month = Console.ReadLine().ToLower();
                    }
                    else
                    {
                        answer = false;
                        break;
                    }
                    break;
            }

        }
        while (answer);


        //The while loop boolean comparison part of teh assignment


        Console.WriteLine("What is the smallest prime number under 10?");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPrime = number != 2;
        while (isPrime)
        {
            switch (number)
            {
                case (2):
                    Console.WriteLine("That's correct!");
                    isPrime = false;
                    break;
                default:
                    Console.WriteLine("Not quite! Try again");
                    Console.WriteLine("Name one prime number under 10?");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
            }

        }
        Console.ReadLine();

    }
}

