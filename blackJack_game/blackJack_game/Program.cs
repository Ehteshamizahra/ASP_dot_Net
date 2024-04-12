using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackJack_game
{
    class Program
    {
        static void Main(string[] args)
        {
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


            //overloaded opeator example
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";
            game = game + player; //or game +=player
            game = game - player; //or game -=player




            Deck deckOne = new Deck();
            deckOne.Shuffle(3);

            //Shuffle method is moved to the Deck class
            //int timesShuffled = 0;
            //deckOne = Shuffle(deckOne, out timesShuffled,2) ; // call method shuffle
            ////deckOne = Shuffle(deck: deckOne, times: 3); // Named parameter

            foreach (Card card in deckOne.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);

            }
            Console.WriteLine(deckOne.Cards.Count);
            Console.ReadLine();
        }

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

    }
}
