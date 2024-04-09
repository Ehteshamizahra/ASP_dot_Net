using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackJack_game
{
    //INheritance from a base class and an interface
    class TwentyOneGame : Game, IWalkAway  //Inheretance is one of the three pillars of object oriented programing.
    {
        //override method to the abstract MethodAccessException in Game  class
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 players: ");
            base.ListPlayers();
        }

        //Implementing interface walkAway method
        public void walkAway(Player player)
        {
            throw new NotImplementedException();
        }


    }
}
