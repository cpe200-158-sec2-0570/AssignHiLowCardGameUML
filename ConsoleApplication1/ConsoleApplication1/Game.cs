using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highlowgame
{
    class Game 
    {
        private Player _player1;
        private Player _player2;
        private Deck _dec;
        

        public Deck dec   
        {
            get
            {
                return _dec;
            }
            set
            {
                _dec = value;
            }
        }
        public Player player1
        {
            get
            {
                return _player1;
            }
            set
            {
                _player1 = value;
            }
        }
        public Player player2
        {
            get
            {
                return _player2;
            }
            set
            {
                _player2 = value;
            }
        }

        public Game()
        {
            player1 = new Player();
            player2 = new Player();
            dec = new Deck();
        }
        public void Deal()
        {
            for(int i = 0; i < 26; i++)
            {
                player1.mycard.deck.Add(dec.deck[i]);
                player2.mycard.deck.Add(dec.deck[i + 26]);
            }
            Console.WriteLine("Card is dealed.");
        }
        public void start()
        {
            Console.WriteLine("_______Star!________");
            Console.WriteLine("Input player1's name?");
            player1.name = Console.ReadLine();
            Console.WriteLine("Input player2's name?");
            player2.name = Console.ReadLine();
            dec.Shuffled();
            Deal();
        }
        public int topcard (Player a)
        {
            int i = a.mycard.deck[0].rank;
            Console.WriteLine(a.name + "'s card is" + a.mycard.deck[0].ToString());
            a.mycard.deck.RemoveAt(0);
            return i;
        }
        public void playing()
        {
            Console.WriteLine();
            Console.WriteLine("_____________________");
            int card_player1 = topcard(player1);
            int card_player2 = topcard(player2);
        //check
            if (card_player1 > card_player2)
            {
                player1.score += 2;
                Console.WriteLine(player1.name + "win this turn");
                Console.WriteLine(player1.name + "'s score" + player1.score);
                Console.WriteLine(player2.name + "'s score" + player2.score);

            }
            else if (card_player1 < card_player2)
            {
                player2.score += 2;
                Console.WriteLine(player2.name + "win thid turn");
                Console.WriteLine(player1.name + "'s score" + player1.score);
                Console.WriteLine(player2.name + "'s score" + player2.score);
            }
            else if (card_player1 == card_player2)
            {
                Console.WriteLine("Card's rank of both player is equal");
                Console.WriteLine("then, open new card");
                if (player1.mycard.Countcard() == 0 || player2.mycard.Countcard() == 0)
                {
                    Console.WriteLine("Card run out.");
                }
                else if (card_player1 > player1.mycard.Countcard() || card_player2 > player2.mycard.Countcard())
                {
                    Console.WriteLine("player has cards in their deck less than the card in rank.");
                    player1.mycard.deck.Add(player1.mycard.deck[0]);
                    Console.WriteLine(player1.name + " then, must shuffle cards.");
                    player1.mycard.Shuffled();
                    player2.mycard.deck.Add(player2.mycard.deck[0]);
                    Console.WriteLine(player2.name + " then, must shuffle cards.");
                    player2.mycard.Shuffled();
                }
                else if (player1.mycard.deck[card_player1 - 1] == player2.mycard.deck[card_player2])
                {
                    Console.WriteLine("Card is equal again.");
                    player1.mycard.deck.Add(player1.mycard.deck[0]);
                    Console.WriteLine(player1.name + " then, must shuffle cards.");
                    player1.mycard.Shuffled();
                    player2.mycard.deck.Add(player2.mycard.deck[0]);
                    Console.WriteLine(player2.name + " then, must shuffle cards.");
                    player2.mycard.Shuffled();
                }
                else if (player1.mycard.deck[card_player1 - 1] != player2.mycard.deck[card_player2 - 1])
                {
                    int cardrank = card_player1;
                    int score_temp = 2;
                    for (int i = 0; i < cardrank; i++)
                    {
                        card_player1 = topcard(player1);
                        card_player2 = topcard(player2);
                        score_temp = score_temp + 2;
                   
                    }
                    if (card_player1 < card_player2)
                    {
                        player1.score = player1.score + score_temp;
                        Console.WriteLine(player1.name + "win this turn.");
                        Console.WriteLine(player1.name + "'s score =" + player1.score);
                        Console.WriteLine(player2.name + "'s score =" + player2.score);

                    }
                    else if (card_player1 > card_player2)
                    {
                        player2.score = player2.score + score_temp;
                        Console.WriteLine(player2.name + "win this turn.");
                        Console.WriteLine(player1.name + "'s score =" + player1.score);
                        Console.WriteLine(player2.name + "'s score =" + player2.score);
                    }
                }
            }
        }

        public bool end()
        {
            if (player1.mycard.Countcard() == 0 || player2.mycard.Countcard() == 0)
            {
                Console.WriteLine("_______________The End_______________");
                if (player1.score == player2.score)
                {
                    Console.WriteLine("Draw");
                }
                else if (player1.score > player2.score)
                {
                    Console.WriteLine("Winner is " + player1.name + " .");
                }
                else if (player1.score < player2.score)
                {
                    Console.WriteLine("Winner is " + player2.name + " .");
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
