using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace blackJack_game
{
    class Program
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

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money do you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Hello, {0}, would you like to join a game of 21 righ now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName,bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance> 0)
                {
                    game.Play();
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            
            Console.ReadLine();
        }
    }
}
