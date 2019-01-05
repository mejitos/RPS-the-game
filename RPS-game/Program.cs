using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_game
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.Title = "ROCK PAPER SCISSORS - THE GAME";
            
            // Start screen, make it simple "GAME NAME" "START GAME"
            // Ask player name -> Move on to game itself
            Console.WriteLine("**************************************");
            Console.WriteLine("*** ROCK PAPER SCISSORS - THE GAME ***");
            Console.WriteLine("**************************************");
            Console.WriteLine();

            // Ask for player name and save it for a variable
            Console.Write("Player name: ");
            string player = Console.ReadLine();
            Console.WriteLine();

            // Ask for the number of points for the win -> best of 3, 5 or 7
            Console.Write("Number of wins for the belt: ");
            int rounds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            // Start the game
            Console.Write("Start the game by pressing ENTER");
            Console.ReadLine();
            Console.Clear();

            int score_player = 0;
            int score_cpu = 0;

            //Game loop
            while (score_player < rounds || score_cpu < rounds)
            {                                
                // Show Score                              
                Console.WriteLine("******************************************");
                Console.WriteLine("******************************************");
                Console.WriteLine("***   PLAYER SCORE   ***   CPU SCORE   ***");
                Console.WriteLine("***        " + score_player + "         ***       " + score_cpu + "       ***");
                Console.WriteLine("******************************************");
                Console.WriteLine("******************************************");
                Console.WriteLine("");
                Console.WriteLine("");

                // Check score
                if (score_player == rounds || score_cpu == rounds)
                {
                    break;
                }

                // Get players choice
                Console.WriteLine("Chooce ROCK [1], PAPER [2] or SCISSORS [3]\n");
                Console.Write(player + "s choice: ");
                string player_choice = Console.ReadLine().ToUpper();

                // Get CPUs choice
                Random rndm = new Random();
                int get_cpu_choice = rndm.Next(1, 4);
                string cpu_choice = get_cpu_choice.ToString();

                // Compare users and CPU's choices and declare the result           
                if ((player_choice == "1" || player_choice == "ROCK") && cpu_choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine(player + "s choice: ROCK");
                    Console.WriteLine("CPU's choice: ROCK");
                    Console.WriteLine("It's a DRAW!");
                }
                else if ((player_choice == "1" || player_choice == "ROCK") && cpu_choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine(player + "s choice: ROCK");
                    Console.WriteLine("CPU's choice: PAPER");
                    Console.WriteLine("CPU WINS!");
                    ++score_cpu;
                }
                else if ((player_choice == "1" || player_choice == "ROCK") && cpu_choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine(player + "s choice: ROCK");
                    Console.WriteLine("CPU's choice: SCISSORS");
                    Console.WriteLine(player + " WINS!");
                    ++score_player;
                }
                else if ((player_choice == "2" || player_choice == "PAPER") && cpu_choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine(player + "s choice: PAPER");
                    Console.WriteLine("CPU's choice: ROCK");
                    Console.WriteLine(player + " WINS!");
                    ++score_player;
                }
                else if ((player_choice == "2" || player_choice == "PAPER") && cpu_choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine(player + "s choice: PAPER");
                    Console.WriteLine("CPU's choice: PAPER");
                    Console.WriteLine("It's a DRAW!");
                }
                else if ((player_choice == "2" || player_choice == "PAPER") && cpu_choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine(player + "s choice: PAPER");
                    Console.WriteLine("CPU's choice: SCISSORS");
                    Console.WriteLine("CPU WINS!");
                    ++score_cpu;
                }
                else if ((player_choice == "3" || player_choice == "SCISSORS") && cpu_choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine(player + "s choice: SCISSORS");
                    Console.WriteLine("CPU's choice: ROCK");
                    Console.WriteLine("CPU WINS!");
                    ++score_cpu;
                }
                else if ((player_choice == "3" || player_choice == "SCISSORS") && cpu_choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine(player + "s choice: SCISSORS");
                    Console.WriteLine("CPU's choice: PAPER");
                    Console.WriteLine(player + " WINS!");
                    ++score_player;
                }
                else if ((player_choice == "3" || player_choice == "SCISSORS") && cpu_choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine(player + "s choice: SCISSORS");
                    Console.WriteLine("CPU's choice: SCISSORS");
                    Console.WriteLine("It's a DRAW!");
                }

                // Play again
                Console.WriteLine();
                Console.Write("Play again by pressing ENTER");
                Console.ReadLine();
                Console.Clear();
            }

            // Declare winner
            if (score_player == rounds)
            {
                Console.WriteLine("Gongratulations " + player + "! You WON!");
            }
            else if (score_cpu == rounds)
            {
                Console.WriteLine("CPU WON! Better luck next time!");
                Console.WriteLine("");
            }

        }
        // Loop till one gets score of three 
        // In future player could decide this at the start of the game???

        // Integrate coinflip? Players can choose to flip coin when draw occurs???

    }
}
