using System;



class Program
{
    static void Main()
    {   //Write heading title on teh console
        Console.WriteLine("The Tech Academy.\nStudent Daily Report.");

        //Write questions on the console and save the answers as strings. Then convert the responses into the correct data type for future use
        Console.WriteLine("What is your name?");
        string student_name = Console.ReadLine();
        Console.WriteLine("What course are you on?");
        string course_name = Console.ReadLine();
        Console.WriteLine("What page number?");
        string course_page = Console.ReadLine();
        int course_page_int = Convert.ToInt32(course_page);
        Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
        string help_required = Console.ReadLine();
        bool help_required_bool = Convert.ToBoolean(help_required);
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string positive_experience = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        string hours_studied = Console.ReadLine();
        float hours_studied_float = (float)Convert.ToDouble(hours_studied);

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");

        Console.ReadLine();



    }
}

