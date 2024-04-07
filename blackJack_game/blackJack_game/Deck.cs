using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackJack_game
{
    public class Deck
    {
        public Deck () //Constructor - used to set defult value for the class
        {

            List<string> faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine","Ten", "Soldier", "Queen", "King", "Ace" };
            List<string> suits = new List<string>() { "Dimonds", "Spades", "Hearts", "Clubs" };
            Cards = new List<Card>();//Instantiate the property 'Cards' from the current class Deck as an empty list of cards

            foreach (string face in faces)
            {
                foreach(string suit in suits)
                {
                    Card card = new Card(); //Instantiate  an object frm Card class. We create a card during each loop
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card); //Add the card to the list of Cards
                    
                }
            }
        }


        public List<Card> Cards { get; set; }
    }
}
