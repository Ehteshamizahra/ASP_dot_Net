using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackJack_game
{

    //A base class/Abstract class. We will never have an object called game
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        public List<Player> Players { get { return _players; } set { _players=value; } }//this is an emty list rather than a null
        public string Name { get; set; }
        //public string Dealer { get; set; }

        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public Dictionary<Player,int> Bets { get { return _bets; } set { _bets = value; } }

        //Abstract method
        public abstract void Play();
        
        //Creating a method
        public virtual void ListPlayers()
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player);
            }
        }




    }
}
