using System;

class Program
{
    static void Main(string[] args)
    {
        //Obtain the applicant's details
        Console.WriteLine("What is your age?");
        string age = Console.ReadLine();

        Console.WriteLine("Have you ever had a DUI? Reply with true or false please");
        string DUI = Console.ReadLine();

        Console.WriteLine("How many speeding tickets do you have?");
        string ticket = Console.ReadLine();

        //Run the logic to assess if the applicant is qualifid
        string reply = "no";
        Boolean qualified = Convert.ToInt32(age) > 15 && Convert.ToBoolean(DUI)== false && Convert.ToInt32(ticket) <= 3;
        Console.WriteLine("Qualified?\n" + qualified);

        Console.ReadLine();


    }
}

