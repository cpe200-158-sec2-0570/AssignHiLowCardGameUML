using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highlowgame
{
    class Deck  
    {
        private List<Card> _deck;
        private int _numcard;
        private Random rand;

        public List<Card> deck
        {
            get
            {
                return _deck;
            }
            set
            {
                _deck = new List<Card>(value);
            }
        }
        public int numcard
        {
            get
            {
                return _numcard;
            }
            set
            {
                _numcard = value;
            }
        }
        public Deck()
        {
            deck = new List<Card>();
            rand = new Random();

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 13; j++)
                {
                    deck.Add(new Card(j + 1, i + 1));
                }
            }

        }
        public int Countcard()
        {
            numcard = 0;
            for(int i=0; i < deck.Count(); i++)
            {
                numcard = numcard + 1;
            }
            return numcard;
        }
        public void Shuffled()
        {
            Random rand = new Random();
            for (int i = 0; i < deck.Count();i++)
            {
                var n = rand.Next(i, deck.Count);
                var temp = deck[i];
                deck[i] = deck[n];
                deck[n] = temp;
            }
            Console.WriteLine("Card is suffled");
        }

    }

}