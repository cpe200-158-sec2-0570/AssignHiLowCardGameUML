using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highlowgame 
{
    class Card   
    {
        private int _rank;
        private int _suit;
        public string[] rk = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        public string[] st = { "Hearts", "Clubs", "Diamonds", "Spades" };

        public int rank
        {
            get
            {
                return _rank;
            }
            set
            {
                if(value>0 && value <= 13)
                {
                    _rank = value;
                }
                else
                {
                    _rank = 0;
                }
            }
        }

        public int suits
        {
            get
            {
                return _suit;
            }
            set
            {
                if(value<=0&& value > 4)
                {
                    _suit = 0;
                }
                else
                {
                    _suit = value;
                }
            }

        }

        public Card(int a, int b)
        {
            _suit = b;
            _rank = a;
        }

        public override string ToString()
        {
            
            return rk[rank - 1] + " of " + st[suits - 1];
        }
    }

    
}
