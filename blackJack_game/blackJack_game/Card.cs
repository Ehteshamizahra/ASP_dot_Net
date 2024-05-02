using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackJack_game
{
    public class Card //Class is made public to make it accessible
    {
        public Suit Suit { get; set; } //the card class has a property data type string called Suit. You can get or set this property.
                                       //BY making this property public, it makes it accessable to other part of the program.  
        public Face Face { get; set; }
    }
    public enum Suit    //Enum data type
    {
            Clubs,
            Diamonds,
            Hearts,
            Spades
    }
    public enum Face
    {
            Two, 
            Three, 
            Four, 
            Five, 
            Six, 
            Seven, 
            Eight, 
            Nine,
            Ten, 
            Soldier, 
            Queen, 
            King, 
            Ace 
    }
    
    
}
