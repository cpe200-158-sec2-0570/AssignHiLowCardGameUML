
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highlowgame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game highlowgames;
            highlowgames = new Game();
            highlowgames.start();
            while (!highlowgames.end())
            {
                highlowgames.playing();
                Console.WriteLine(">>>> Please enter for next turn <<<<");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}