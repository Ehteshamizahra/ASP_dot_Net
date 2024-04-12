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
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

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
