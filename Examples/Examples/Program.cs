using System;



class Program
{
    static void Main(string[] args)
    {

        //bool number = 5 > 6;
        //Console.WriteLine(number.ToString());
        ////Console.ReadLine();

        //Console.WriteLine("What's your name?");
        //string name = Console.ReadLine();
        //if (name != "Zahra")
        //    Console.WriteLine("It's hard to look like her");
        //else
        //    Console.WriteLine("You must be Zahra then");

        //string results = 3 > 6 ? "are you crazy?" : "Makes sense";
        //Console.WriteLine(results);
        //Console.ReadLine();

        string anotherGO;
        Console.WriteLine("Which month of year sprint starts?");
        String month = Console.ReadLine().ToLower();
        bool answer = month ==  "march" ;
        
        do
        {
            switch (month)
            {
                case "march":
                    Console.WriteLine("That's correct!");
                    answer = false;
                    break;
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
