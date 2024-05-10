using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card //Class is made public to make it accessible
    {
        public Suit Suit { get; set; } //the card class has a property data type string called Suit. You can get or set this property.
                                       //BY making this property public, it makes it accessable to other part of the program.  
        public Face Face { get; set; }
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
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
