using System;
class Program
{
    static void Main()
    {
        //Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        //Obtain the package weight
        Console.WriteLine("What is the Package weight?");
        int weight = Convert.ToInt32(Console.ReadLine());
        
        //Check if the package weight is more than 50kg and if yes display an error message and end the inquiry  
        if (weight > 50)
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        else
            //Obtain the package dimensions
            Console.WriteLine("What is the Package width?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the Package height?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the Package length?");
            int length = Convert.ToInt32(Console.ReadLine());

            //Calculate the package total dimension and price
            int dimension_total = width + height + length;
            int price = (width * height * length * weight) / 100;

            //Check if the package total dimension is more than 50cm and if yes display an error message and end the inquiry
            if (dimension_total > 50)
                Console.WriteLine("Package too big to be shipped via Package Express.");
            else
                Console.WriteLine("Your estimated total for shipping this package is: $" + price + "\nThank you!");

        Console.ReadLine();


    }
}



