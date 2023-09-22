using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Hutton_Riley
{
    class Card
    {
        //Two strings with automatic getters
        public string Number { get; }

        public string Suit { get; }

        //a constructor that has two parameters, number and suit.
        public Card(string numParam, string suitParam)
        {
            Number = numParam;
            Suit = suitParam;
        }

    }
}
