using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        Console.WriteLine("What is the Package weight?");
        int weight = Convert.ToInt32(Console.ReadLine());

        if (weight > 50)
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        else
            Console.WriteLine("What is the Package width?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the Package height?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the Package length?");
            int length = Convert.ToInt32(Console.ReadLine());
            int dimension_total = width + height + length;
            int price = (width * height * length * weight) / 100;

            if (dimension_total > 50)
                Console.WriteLine("Package too big to be shipped via Package Express.");
            else
                Console.WriteLine("Your estimated total for shipping this package is: $" + price + "\nThank you!");

        Console.ReadLine();


    }
}



