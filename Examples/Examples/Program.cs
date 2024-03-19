using System;



class Program
{
    static void Main(string[] args)
    {

        bool number = 5 > 6;
        Console.WriteLine(number.ToString());
        //Console.ReadLine();

        Console.WriteLine("What's your name?");
        string name = Console.ReadLine();
        if (name != "Zahra")
            Console.WriteLine("It's hard to look like her");
        else
            Console.WriteLine("You must be Zahra then");
        
        string results = 3 > 6 ? "are you crazy?" : "Makes sense";
        Console.WriteLine(results);
        Console.ReadLine();

    }
}
