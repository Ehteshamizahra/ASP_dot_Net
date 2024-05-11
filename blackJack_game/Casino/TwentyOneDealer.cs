using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne //subsection of casino, using a sub-namespace to organise the large code
{
    public class TwentyOneDealer : Dealer
    {
        public bool Stay { get; set; }
        public bool isBusted { get; set; }

        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
    }
}
