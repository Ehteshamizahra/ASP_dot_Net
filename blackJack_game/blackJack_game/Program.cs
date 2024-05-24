using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace blackJack_game
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////example of writing to a file
            //string text = "my first file";
            //File.WriteAllText(@"C:\Users\zehtesha\OneDrive - JNJ\Desktop\log.txt", text);

            ////polymorphism example
            //List<Game> games = new List<Game>();
            //Game game = new TwentyOneGame();
            //games.Add(game);

            ////Inherentance Example 
            //TwentyOneGame game = new TwentyOneGame(); 
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" }; //When instantiating a list, new List<string>() has to be included
            //game.Name = "TwentyOne";
            //game.ListPlayers();//Calling superclass method: When calling a method from a class inhereting from it's calling a superclass method 
            //Console.ReadLine();

            ////Abstract and virtual methods
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "bob", "joe", "sarah" };
            //game.ListPlayers();
            //Console.ReadLine();


            ////overloaded opeator example
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game = game + player; //or game +=player
            //game = game - player; //or game -=player

            ////Generic class with <T> example
            //Player<Card> player = new Player<Card>();
            //player.Hand = new List<Card>();

            ////Example of Enum
            //Card card = new Card();
            //card.suit = Card.Suit.Clubs;
            //int underlyingValue = Convert.ToInt32(Card.Suit.Diamonds);
            //Console.WriteLine(underlyingValue);
            //Console.ReadLine();


            //Deck deckOne = new Deck();
            //deckOne.Shuffle(3);

            ////Shuffle method is moved to the Deck class
            ////int timesShuffled = 0;
            ////deckOne = Shuffle(deckOne, out timesShuffled,2) ; // call method shuffle
            //////deckOne = Shuffle(deck: deckOne, times: 3); // Named parameter

            //foreach (Card card in deckOne.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);

            //}
            //Console.WriteLine(deckOne.Cards.Count);
            //Console.ReadLine();

            ////Lamda example
            ////1 lets see we want to count number of aces in the cards. One way is to use 
            ////foreach loop
            //Deck deck = new Deck();

            //int counter = 0;
            //foreach (Card card in deck.Cards)
            //{
            //    if(card.Face==Face.Ace)
            //    {
            //        counter++;
            //    }
            //}

            ////OR use lambda
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);//x represents eaxh element in the list, => means map every element to the == function

            ////OR use another lambda function
            //List<Card> newList = deck.Cards.where(x => x.Face ==Face.King).ToList();
            ////Another example of lambda function
            //List<int> numberList = new List<int>(){1,2,34,51};
            //int sum = numberList.Sum(x => x + 5);
            //int sum=numberList.where(x=>x>20).Sum();

            //}



            ////This is now moved into the Deck class
            ////Creating a method to allow shuffle the deck of cards
            //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)   //public: so it's accassable, static: We don't have to create an object program before calling this,
            //                                                                             //Deck: That's the type of data it's returing, Shuffle: the name of the function,
            //                                                                             //Deck deck: takes a prameter of types Deck with variable named deck
            //                                                                             //out int timeshuffled: 
            //                                                                             //int times =1: an optional argument
            //{

            //    timesShuffled = 0;
            //    for (int i = 0; i < times; i++)
            //    {
            //        Random random = new Random();
            //        List<Card> tempList = new List<Card>();
            //        timesShuffled++;
            //        while (deck.Cards.Count > 0)
            //        {

            //            int randomInd = random.Next(0, deck.Cards.Count);
            //            tempList.Add(deck.Cards[randomInd]);
            //            deck.Cards.RemoveAt(randomInd);
            //        }
            //        deck.Cards = tempList;
            //    }
            //    return deck;


            //}
            const string casinoName = "Grand Hotel and Casino";


            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.",casinoName);
            string playerName = Console.ReadLine();

            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadOnlyExceptions();
                foreach(var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.ReadLine();
                return;
            }

            //exception handling method
            bool validAnswer = false;
            int bank = 0;
            while(!validAnswer) //while the validAnswer is false
            {
                Console.WriteLine("And how much money do you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank); //int.TryParse converts string to int, if it's successful then it throws true
                if (!validAnswer)
                {
                    Console.WriteLine("Please enter digits only, no decimals");
                }
            }

           
            Console.WriteLine("Hello, {0}, would you like to join a game of 21 righ now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName,bank);

                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\zehtesha\OneDrive - JNJ\Desktop\log.txt", true))
                {
                    file.WriteLine(player.Id);

                }

                
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance> 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message); //The message in TwentyOneGame thrown by the exception
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return; //return in a void method (void method returns nothing) it ends the method right there
                    }
                    catch (Exception ex) //all specific exceptions inhirite from 'Exception'. this is an example of plymorphisem
                    {
                        Console.WriteLine("An erro occured, please contact your system adminstrator");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return; //return in a void method (void method returns nothing) it ends the method right there
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            
            Console.ReadLine();
        }

        private static void UpdateDbWithException(Exception ex) //private: so it's only accessable inside of this class
                                                    //static: so we don't have to create a new instance of program, so it'll be similar to main 
        {

            //ADO.NET, example of openning and adding to a database

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=
                                        TwentyOneGame;Integrated Security=True;Connect Timeout=30;
                                        Encrypt=False;TrustServerCertificate=False;ApplicationIntent=
                                        ReadWrite;MultiSubnetFailover=False";//Connection string: A long string which contains information about the database instance we are trying to connect to 

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp) ";//SQL query string

            using (SqlConnection connection = new SqlConnection(connectionString))//using-Managing and controlling memmory when dealing with external resources. Here we close the resource when we exit the curley braces 
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery(); //insert query
                connection.Close();

            }        
        }

        //ReadException Method. Example of reading from a database
        private static List<ExceptionEntity> ReadOnlyExceptions()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=
                                        TwentyOneGame;Integrated Security=True;Connect Timeout=30;
                                        Encrypt=False;TrustServerCertificate=False;ApplicationIntent=
                                        ReadWrite;MultiSubnetFailover=False";//Connection string: A long string which contains information about the database instance we are trying to connect to 

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";//SQL query string
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))//using-Managing and controlling memmory when dealing with external resources. Here we close the resource when we exit the curley braces 
            {
                //What's happening while the connection to database is open
                SqlCommand command = new SqlCommand(queryString, connection); //New sql command object
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                //loop through each read we get back and for each record we create a new exception entity object 
                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);

                }
                connection.Close();
            }
            return Exceptions; //return a list of ExceptionEntity
        }
    }
}
