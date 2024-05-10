using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player //Or public class Player<T> to create a generic class so this can apply to all games including the onse with no cards

    {
        //Create a constructor, initialise the player
        public Player(string name, int beginingBalance)
        {
            Hand = new List<Card>();
            Balance = beginingBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } } //Or public List<T> Hand { get; set; } for making it to generic class
        public string Name { get; set; }
        public int Balance { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }

        public bool Bet(int amount)
        {
            if (Balance-amount<0)
            {
                Console.WriteLine("You do not have enough amount to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        //overloaded operators
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator-(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
