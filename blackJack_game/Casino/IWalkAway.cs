using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interfaces //using a sub-namespace to organise the large code
{
    interface IWalkAway
    {
        //Create a method
        void walkAway(Player player); //No need for public as everything is public in interfaces
    }
}
