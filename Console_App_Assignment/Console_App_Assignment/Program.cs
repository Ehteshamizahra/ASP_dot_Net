using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)



    {   
        
        //Assignment part 1 - Create a string array
        string[] sports = { "basketball-", "horseriding-", "pingpong-", "swimming-", "squash-" };
        //Obtain the user data and append to the string array
        Console.WriteLine("What's your favourit fruit?");
        string favSport = Console.ReadLine().ToLower();
        List<string> newList = new List<string>();
        string newWord;

        //Iterate through each element and concatinate with the user input
        for (int i = 0; i<sports.Length;i++)
        {
            newWord=sports[i]+ favSport;
            newList.Add(newWord);
        }

        //Iterate through each element and cprint the result
        foreach (string element in newList)
        {
            Console.WriteLine(element);
        }


        Console.ReadLine();





    }
}

