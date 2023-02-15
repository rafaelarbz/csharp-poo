using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RacingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean win = false;
            String playAgain = "y";
            int selectedPlayer = 0;
            int winnerNumber = 0;
            String winnerName = "";

            while (playAgain == "y")
            {
                Track track = new Track(100, new Player("P"));
                Track trackTwo = new Track(100, new Player("M"));
                Track trackThree = new Track(100, new Player("R"));

                Console.Clear();
                Console.WriteLine("---- Crazy Race ----");
                Console.WriteLine("<<< Players : 1 - Penelope , 2 - Muttley, 3 - Rock Slag >>> ");
                Console.Write("Choose your player (1, 2 or 3): ");

                selectedPlayer = Convert.ToInt32(Console.ReadLine());
                winnerNumber = 0;
                winnerName = "";
                win = false;

                while (win == false)
                {
                    Console.Clear();

                    if (track.UpdateRacing() == true)
                    {
                        win = true;
                        winnerNumber = 1;
                        winnerName = "Penelope";
                    }
                    if (trackTwo.UpdateRacing() == true)
                    {
                        win = true;
                        winnerNumber = 2;
                        winnerName = "Muttley";
                    }
                    if (trackThree.UpdateRacing() == true)
                    {
                        win = true;
                        winnerNumber = 3;
                        winnerName = "Rock Slag";
                    }

                    track.ShowRacing();
                    trackTwo.ShowRacing();
                    trackThree.ShowRacing();

                    //Console.ReadKey();
                    Thread.Sleep(1000);
                }
                Console.Clear();
                Console.WriteLine("---- Crazy Race ----");
                Console.WriteLine($"Player {winnerNumber} - {winnerName} won.");

                if (winnerNumber == selectedPlayer)
                {
                    Console.WriteLine("Yeah, your player won!");
                }
                else
                {
                    Console.WriteLine("Your player lost!");
                }

                Console.Write("Play again Y or N: ");
                playAgain = Console.ReadLine().ToLower();
            }
        }
    }
}
