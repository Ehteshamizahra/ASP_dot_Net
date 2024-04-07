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
            Deck deckOne = new Deck();
            deckOne = Shuffle(deckOne); // call method shuffle

            foreach (Card card in deckOne.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);

            }
            Console.WriteLine(deckOne.Cards.Count);
            Console.ReadLine();
        }


        //Creating a method to allow shuffle the deck of cards
        public static Deck Shuffle(Deck deck)   //public: so it's accassable, static: We don't have to create an object program before calling this,Deck: That's the type of data it's returing, Shuffle: the name of the function, Deck deck: takes a prameter of types Deck with variable named deck
        {
            Random random = new Random();
            List<Card> tempList = new List<Card>();

            while (deck.Cards.Count > 0)
            {
                int randomInd = random.Next(0, deck.Cards.Count);
                tempList.Add(deck.Cards[randomInd]);
                deck.Cards.RemoveAt(randomInd);
            }
            deck.Cards = tempList;
            return deck;
        
        }
        
    }
}
