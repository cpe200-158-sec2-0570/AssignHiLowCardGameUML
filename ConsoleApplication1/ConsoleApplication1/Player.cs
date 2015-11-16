using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highlowgame
{
    class Player
    {
        private string _name;
        private int _score;
        private Deck _mycard;

        public string name
        { 
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
            }
        }
        public Deck mycard
        {
            get
            {
                return _mycard;
            }
            set
            {
                _mycard = value;
            }
        }
        public Player()
        {
            name = "XXXXXXX";
            score = 0;
            mycard = new Deck();
            mycard.deck.Clear();
            
        }
    }
}
