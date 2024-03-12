using System;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Anonymous Income Comparison Program");
        
        //Obtain the salary details from person 1 and 2
        Console.WriteLine("Person 1");
        Console.WriteLine("What is your Hourly Rate?");
        string person1_rate = Console.ReadLine();
        Console.WriteLine("What is your Hours worked per week?");
        string person1_hours = Console.ReadLine();

        Console.WriteLine("Person 2");
        Console.WriteLine("What is your Hourly Rate?");
        string person2_rate = Console.ReadLine();
        Console.WriteLine("What is your Hours worked per week?");
        string person2_hours = Console.ReadLine();

        //Calculate the annual income for person 1 and 2
        double person1_salery = Convert.ToDouble(person1_rate) * Convert.ToDouble(person1_hours) * 52;
        Console.WriteLine("Annual salary of Person 1:\n" + person1_salery);
        
        double person2_salery = Convert.ToDouble(person2_rate) * Convert.ToDouble(person2_hours) * 52;
        Console.WriteLine("Annual salary of Person 2:\n" + person2_salery);

        //Compare teh results and display it
        Boolean sal_comparison = person1_salery > person2_salery;
        Console.WriteLine("Does Person 1 make more money than Person 2?\n" + sal_comparison);

        Console.ReadLine();
    }
}

