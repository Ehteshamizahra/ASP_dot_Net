using System;
using System.Collections.Generic;
using System.Threading;




class Program
{
    static void Main(string[] args)



    {

        //////////////Assignment part 1 - Create a string array/////////////////////

        string[] sports = { "basketball-", "horseriding-", "pingpong-", "swimming-", "squash-" };
        //Obtain the user data and append to the string array
        Console.WriteLine("What's your favourit fruit?");
        string favSport = Console.ReadLine().ToLower();
        string newWord;

        //Iterate through each element and concatinate string with the user input
        for (int i = 0; i < sports.Length; i++)
        {
            newWord = sports[i] + favSport;
            sports[i] = newWord;
        }
        //Iterate through each element and print the result one at a time
        for (int i = 0; i < sports.Length; i++)
        {
            Console.WriteLine(sports[i]);
            Thread.Sleep(500);
        }



        //////////////Assignment part 2 - Create an Infinit loop/////////////////////
        //Creating infinit loop by sending true to the while loop condition.The fix is to use a variable as a
        //condition and so we have control over the variable in the while loop. break is lso used. 
        bool boolval = true;
        while (boolval)
        {
            Console.WriteLine("infinit loop!");
            boolval = false;
            break;
        }

        //////////////Assignment part 3 - Iteration using comparison/////////////////////

        // using a '<' to condition the loop iteration
        List<int> number = new List<int> { 1, 4, 8, 12, 16, 20 };
        for (int i = 0; i < number.Count; i++)
        {
            Console.WriteLine(number[i]);
           Thread.Sleep(500);

        }
        // using a '<=' to condition the loop iteration
        List<int> val = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine(val[i]);
            Thread.Sleep(500);

        }

        //////////////Assignment part 4 - String list/////////////////////
        //Create a list with unique string values
        List<string> fav_animals = new List<string> { "horse", "cat", "lion", "tiger" };

        //Ask teh user to input their favourite animal
        Console.WriteLine("What is your faviourite animal?");
        string user_fav = Console.ReadLine().ToLower();

        //Check if the user input matches an item in the list
        for (int i = 0; i < fav_animals.Count; i++)
        {
            if (fav_animals[i] == user_fav)
            {
                Console.WriteLine(i);
                break;
            }
            //If tehre is no match, let the user know
            else if (i == fav_animals.Count - 1)
            {
                Console.WriteLine("Your input doesn't match the list");
            }
        }

        //////////////Assignment part 5 - String list with duplication/////////////////////

        //Create a list with unique string values except a duplication
        List<string> fav_animals_2 = new List<string> { "horse", "fox", "cat", "lion", "tiger", "fox" };

        Console.WriteLine("What is your faviourite animal?");
        string user_fav_2 = Console.ReadLine().ToLower();
        Boolean checkOutput = false;

        //Check if the user input matches an item in the list
        for (int i = 0; i < fav_animals_2.Count; i++)
        {
            if (fav_animals_2[i] == user_fav_2)
            {
                Console.WriteLine(i);
                checkOutput = true;
            }
            //If tehre is no match, let the user know
            else if (i == (fav_animals_2.Count - 1) && checkOutput == false)
            {
                Console.WriteLine("Your input doesn't match the list");
            }
        }

        //////////////Assignment part 6 - Concatinate string/////////////////////
        //Create a list with unique string values except a duplication
        List<string> fav_animals_3 = new List<string> { "horse", "fox", "cat", "lion", "tiger", "fox" };
        //Create a second list to concatinate the animals from teh first list into
        List<string> newList = new List<string> { };
        ////Check if the user input matches an item in the list
        foreach (string animal in fav_animals_3)
        {
            //Check if the second list contains the animal already
            Boolean uniqueItem = newList.Contains(animal);
            //add the animal to the second list
            newList.Add(animal);
            //If the animal string dosn't exist in the second list add the 'is unique' string as suffix and if not add 'is NOT uniquie' as suffix
            if (uniqueItem==false)
            {
                Console.WriteLine(animal + "- this is unique");
            }
            else
            {
                Console.WriteLine(animal + "- this is NOT unique");
            }
        }


        Console.ReadLine();
    }
}

