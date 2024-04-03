using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        try
        {
            List<int> myList = new List<int> { 1, 2, 3, 5, 7, 9 };

            Console.WriteLine("Pick a number for my devision function");
            int newNumber = Convert.ToInt32(Console.ReadLine());

            foreach (int number in myList)
            {
                int division = number / newNumber;
                Console.WriteLine(division);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Make sure you select an integer");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Zero is not accepted for this division");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }
        finally
        {
            Console.WriteLine("The program has emerged from a try/catch block");
            Console.ReadLine();
        }




    }
}

