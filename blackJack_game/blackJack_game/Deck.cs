using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackJack_game
{
    public class Deck
    {

        //Creating a constructor
        public Deck () //Constructor - used to set defult value for the class
        {

        //    List<string> faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine","Ten", "Soldier", "Queen", "King", "Ace" };
        //    List<string> suits = new List<string>() { "Dimonds", "Spades", "Hearts", "Clubs" };
            Cards = new List<Card>();//Instantiate the property 'Cards' from the current class Deck as an empty list of cards

            for (int i=0; i<13;i++)
            {
                for (int j=0; j<4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;//Casting an integer to string, Casting to Face j
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }


        //    foreach (string face in faces)
        //    {
        //        //foreach(string suit in suits)
        //        //{
        //        //    Card card = new Card(); //Instantiate  an object frm Card class. We create a card during each loop
        //        //    card.Suit = suit;
        //        //    card.Face = face;
        //        //    Cards.Add(card); //Add the card to the list of Cards
                    
        //        //}
        //    }
        }

        //Creating a property
        public List<Card> Cards { get; set; } //Cards property

        //Creating a method to allow shuffle the deck of cards
        public void Shuffle(int times = 1)   //public: so it's accessible, Void: as we don't return anything. it does it internally.
                                                                                      //Deck: That's the type of data it's returing, Shuffle: the name of the function,
                                                                                      //Deck deck: takes a prameter of types Deck with variable named deck
                                                                                      //out int timeshuffled: 
                                                                                      //int times =1: an optional argument
        {
            for (int i = 0; i < times; i++)
            {
                Random random = new Random();
                List<Card> tempList = new List<Card>();
                while (Cards.Count > 0)
                {
                    int randomInd = random.Next(0, Cards.Count);
                    tempList.Add(Cards[randomInd]);
                    Cards.RemoveAt(randomInd);
                }
                this.Cards = tempList; //this is refering to its own object Cards. 'This' is refering to itself.
            }
        }
    }
}
