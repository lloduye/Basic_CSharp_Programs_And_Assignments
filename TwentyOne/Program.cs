using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main()
        {
            Console.Readline("Welcome to the Grand Hotel Casino. Let's start by telling me your name.");
            string playerName = Console.Readline();
            Console.ReadLine();
            Console.WriteLine("And How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join the game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower;

            if (answer == "yes" || answer=="yeah" || answer=="y" ||answer=="ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance>0)
                {
                    game.Play();
                }
            }
        }
    }
}