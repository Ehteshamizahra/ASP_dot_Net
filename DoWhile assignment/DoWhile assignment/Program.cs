using System;



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
                        answer = true;
                    else
                        answer = false;
                    Console.WriteLine("Which month of year sprint starts?");
                    month = Console.ReadLine().ToLower();
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
                        answer = true;
                    else
                        answer = false;
                    Console.WriteLine("Which month of year sprint starts?");
                    month = Console.ReadLine().ToLower();
                    break;
                //Define cases with NOT a month answer
                default:
                    Console.WriteLine("The entry is not a month");
                    Console.WriteLine("Do you want to have another go? answer with yes or no");
                    anotherGO = Console.ReadLine().ToLower();
                    if (anotherGO == "yes")
                        answer = true;
                    else
                        answer = false;
                    Console.WriteLine("Which month of year sprint starts?");
                    month = Console.ReadLine().ToLower();
                    break;
            }

        }
        while (answer);


        Console.ReadLine();

    }
}

