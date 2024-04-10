using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackJack_game
{
    interface IWalkAway
    {
        //Create a method
        void walkAway(Player player); //No need for public as everything is public in interfaces
    }
}
